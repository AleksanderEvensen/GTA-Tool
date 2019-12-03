using GlobalHotKey;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace GTATool {
    public partial class MainWindow : Form {

        #region Form Buttons

        //Reacts when mouse enters the button/picture box
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            //Changes the picture in the box
            btnExit.Image = global::GTATool.Properties.Resources.xx;
        }

        //Reacts when mouse leaves the button/picture box
        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            //Changes the picture in the box
            btnExit.Image = global::GTATool.Properties.Resources.x;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        //Reacts when mouse enters the button/picture box
        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            //Changes the picture in the box
            btnMin.Image = global::GTATool.Properties.Resources.__;
        }

        //Reacts when mouse leaves the button/picture box
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            //Changes the picture in the box
            btnMin.Image = global::GTATool.Properties.Resources._;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        // This is the hotkey manager this will store all the hotkeys that is used in the program
        HotKeyManager hkManager;


        // this defines all the different hotkeys
        HotKey /*autoWalkKey,*/ soloPublicKey, afkKey;


        // These are control variables when activating different parts of the program
        bool awEnabled = false, spgEnabled = false, afEnabled = false;
        
        // Solo public control variable
        bool isStartingSoloPublic = false;

        // Anti-AFK control variable
        bool isAntiAFKRunning = false;
        // mouse thread
        Thread MouseThread;

        

        public MainWindow() {
            InitializeComponent();


            // Initialize the hotkey manager
            hkManager = new HotKeyManager();


            // set the solo public hotkey to CTRL + ALT + L
            soloPublicKey = hkManager.Register(Key.L, System.Windows.Input.ModifierKeys.Control 
                                                    | System.Windows.Input.ModifierKeys.Alt);
            // set the ANTI-AFK hotkey to CTRL + ALT + F1
            afkKey = hkManager.Register(Key.F1, System.Windows.Input.ModifierKeys.Control
                                              | System.Windows.Input.ModifierKeys.Alt);


            // Adding the medthod to call when the hotkeys are pressed.
            hkManager.KeyPressed += HkManager_KeyPressed;


            // This initialize a thread that is moving to mouse cursor(Used in ANTI-AFK)
            MouseThread = new Thread(new ThreadStart(MouseThreadFunction));
        }


        // This medthod is called when you press a hotkey.
        // it is also responsible for checking what hotkey was pressed and what to do when the correct hot key is pressed
        private void HkManager_KeyPressed(object sender, KeyPressedEventArgs e) {

            // Solo Public
            if(e.HotKey.Key == Key.L) {
                if(spgEnabled || isStartingSoloPublic == false) {
                    StartSoloPublic();
                } else {
                    WriteLine("Solo public hotkey isn't enabled");
                }

            // Anti-AFK
            } else if(e.HotKey.Key == Key.F1) {
                if(afEnabled) {
                    ToggleAfk();
                } else {
                    WriteLine("Anti-AFK hotkey isn't enabled");
                }
            }
        }

        
        //This method is called when the program closes to dispose and unregister the hotkeys
        private void MainWindow_FormClosed(object sender,FormClosedEventArgs e) {
            hkManager.Unregister(soloPublicKey);
            hkManager.Unregister(afkKey);

            hkManager.Dispose();
        }


        // These three methods is called when the enable buttons is pressed
        private void aw_enable_Click(object sender, EventArgs e) {
            //awEnabled = !awEnabled;
            if(awEnabled) {
                aw_enable.Text = "Disable";
                //awHK = AutoWalkHK.Register(System.Windows.Input.Key.F5,System.Windows.Input.ModifierKeys.Control & System.Windows.Input.ModifierKeys.Alt)
            } else {
                aw_enable.Text = "Enable";
                //AutoWalkHK.Unregister(awHK);
            }
        }

        private void spg_enable_Click(object sender,EventArgs e) {
            spgEnabled = !spgEnabled;
            if(spgEnabled) {
                spg_enable.Text = "Disable";
            } else {
                spg_enable.Text = "Enable";
            }
        }

        private void af_enable_Click(object sender,EventArgs e) {
            afEnabled = !afEnabled;
            if(afEnabled) {
                af_enable.Text = "Disable";
            } else {
                af_enable.Text = "Enable";
            }
            
        }


        #region Solo Public Starter


        // This region is just used for suspending and unsuspending of processes
        #region process suspension
        [Flags]
        public enum ThreadAccess : int {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);


        private void SuspendProcess(Process process) {


            foreach(ProcessThread pT in process.Threads) {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if(pOpenThread == IntPtr.Zero) {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }

        public void ResumeProcess(Process process) {


            foreach(ProcessThread pT in process.Threads) {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if(pOpenThread == IntPtr.Zero) {
                    continue;
                }

                var suspendCount = 0;
                do {
                    suspendCount = ResumeThread(pOpenThread);
                } while(suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }

        #endregion


        // This method will generate a solo public session
        public void StartSoloPublic() {

            // Get the gta process
            Process GTAProcess = GetProcessStatus();


            // if process is found do the code in between the blocks
            if(GTAProcess != null) {
                isStartingSoloPublic = true;

                WriteLine("Creating Solo Public Session. This takes 10.5 seconds");
                
                // Suspend the gta process
                SuspendProcess(GTAProcess);

                // Wait for 10,5 seconds
                Thread.Sleep(10500);

                // Resume the process
                ResumeProcess(GTAProcess);
                // Write a sucess message to console
                WriteLine("Solo Public created");

                isStartingSoloPublic = false;
            
            // if process isn't found write it to the custom console
            } else {
                WriteLine("GTA proccess could not be found");
            }
        }


        // this method is used to check if gta is running and if it is then return it
        // otherwise Write error to console
        private Process GetProcessStatus() {
            try {
                Process[] myProcesses = Process.GetProcessesByName("Grand Theft Auto V");

                if(myProcesses.Length > 0) {
                    WriteLine("GTA Process is running.");
                    return myProcesses[0];
                } else {
                    WriteLine("GTA Process isn't running.");
                    return null;
                }
            } catch(Exception ex) {
                WriteLine("An Exception Occoured: " + ex.Message);
                return null;
            }
        }
        #endregion


        #region Anit-AFK

        // this method turns on and off the Anti-AFK Thread
        public void ToggleAfk() {
            if(isAntiAFKRunning) {
                isAntiAFKRunning = false;
                WriteLine("Afk Thread is stopping..");
                // stop mouse thread
                MouseThread.Join();

                // Re-initialize the mouse thread.
                MouseThread = new Thread(new ThreadStart(MouseThreadFunction));
                
            } else {
                isAntiAFKRunning = true;
                WriteLine("Afk Thread is starting..");
                // start the mouse thread
                MouseThread.Start();
            }
        }

        // this method is the loop for the Anti-AFK program
        // it will only move the cursor to the right
        public void MouseThreadFunction() {
            while(isAntiAFKRunning) {
                // sleep for 5ms
                Thread.Sleep(5);

                // move cursor by 1 px to the right
                Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
            }
        }


        #endregion


        #region Console Writing
        // Writes a line to the console
        private void WriteLine(string line) {
            rText_console.Text += "  <GTATool> "+line + Environment.NewLine;
        }

        //Automatically scrolls down to the last line in console
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            rText_console.SelectionStart = rText_console.Text.Length;
            // scroll it automatically
            rText_console.ScrollToCaret();
        }

        #endregion
    }
}
