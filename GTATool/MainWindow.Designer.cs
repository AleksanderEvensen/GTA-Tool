namespace GTATool {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.formSkin1 = new SimpleCodeUIBeta.FormSkin();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new SimpleCodeUIBeta.FlatGroupBox();
            this.aw_enable = new SimpleCodeUIBeta.SimpleButton();
            this.simpleLabel7 = new SimpleCodeUIBeta.SimpleLabel();
            this.simpleLabel6 = new SimpleCodeUIBeta.SimpleLabel();
            this.simpleLabel5 = new SimpleCodeUIBeta.SimpleLabel();
            this.textBox2 = new SimpleCodeUIBeta.SimpleTextBox();
            this.textBox1 = new SimpleCodeUIBeta.SimpleTextBox();
            this.af_enable = new SimpleCodeUIBeta.SimpleButton();
            this.simpleLabel4 = new SimpleCodeUIBeta.SimpleLabel();
            this.simpleLabel3 = new SimpleCodeUIBeta.SimpleLabel();
            this.spg_enable = new SimpleCodeUIBeta.SimpleButton();
            this.simpleLabel2 = new SimpleCodeUIBeta.SimpleLabel();
            this.simpleLabel1 = new SimpleCodeUIBeta.SimpleLabel();
            this.rText_console = new System.Windows.Forms.RichTextBox();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.btnMin);
            this.formSkin1.Controls.Add(this.btnExit);
            this.formSkin1.Controls.Add(this.groupBox1);
            this.formSkin1.Controls.Add(this.af_enable);
            this.formSkin1.Controls.Add(this.simpleLabel4);
            this.formSkin1.Controls.Add(this.simpleLabel3);
            this.formSkin1.Controls.Add(this.spg_enable);
            this.formSkin1.Controls.Add(this.simpleLabel2);
            this.formSkin1.Controls.Add(this.simpleLabel1);
            this.formSkin1.Controls.Add(this.rText_console);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(646, 395);
            this.formSkin1.TabIndex = 14;
            this.formSkin1.Text = "formSkin1";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImage = global::GTATool.Properties.Resources.x;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMin.Image = global::GTATool.Properties.Resources._;
            this.btnMin.Location = new System.Drawing.Point(577, 15);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 27;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::GTATool.Properties.Resources.x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Image = global::GTATool.Properties.Resources.x;
            this.btnExit.Location = new System.Drawing.Point(608, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 26;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.aw_enable);
            this.groupBox1.Controls.Add(this.simpleLabel7);
            this.groupBox1.Controls.Add(this.simpleLabel6);
            this.groupBox1.Controls.Add(this.simpleLabel5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.ShowText = true;
            this.groupBox1.Size = new System.Drawing.Size(388, 137);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.Text = "Under Development";
            // 
            // aw_enable
            // 
            this.aw_enable.BackColor = System.Drawing.Color.Transparent;
            this.aw_enable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.aw_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aw_enable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.aw_enable.Location = new System.Drawing.Point(277, 90);
            this.aw_enable.Name = "aw_enable";
            this.aw_enable.Rounded = true;
            this.aw_enable.Size = new System.Drawing.Size(74, 29);
            this.aw_enable.TabIndex = 25;
            this.aw_enable.Text = "Enable";
            this.aw_enable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.aw_enable.Click += new System.EventHandler(this.aw_enable_Click);
            // 
            // simpleLabel7
            // 
            this.simpleLabel7.AutoSize = true;
            this.simpleLabel7.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel7.ForeColor = System.Drawing.Color.White;
            this.simpleLabel7.Location = new System.Drawing.Point(149, 66);
            this.simpleLabel7.Name = "simpleLabel7";
            this.simpleLabel7.Size = new System.Drawing.Size(167, 21);
            this.simpleLabel7.TabIndex = 24;
            this.simpleLabel7.Text = "How long to press \"W\"";
            // 
            // simpleLabel6
            // 
            this.simpleLabel6.AutoSize = true;
            this.simpleLabel6.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel6.ForeColor = System.Drawing.Color.White;
            this.simpleLabel6.Location = new System.Drawing.Point(24, 66);
            this.simpleLabel6.Name = "simpleLabel6";
            this.simpleLabel6.Size = new System.Drawing.Size(111, 21);
            this.simpleLabel6.TabIndex = 23;
            this.simpleLabel6.Text = "Dely until start";
            // 
            // simpleLabel5
            // 
            this.simpleLabel5.AutoSize = true;
            this.simpleLabel5.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel5.ForeColor = System.Drawing.Color.White;
            this.simpleLabel5.Location = new System.Drawing.Point(24, 36);
            this.simpleLabel5.Name = "simpleLabel5";
            this.simpleLabel5.Size = new System.Drawing.Size(215, 21);
            this.simpleLabel5.TabIndex = 22;
            this.simpleLabel5.Text = "Auto Walk (Hotkey: CTRL+F2)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.FocusOnHover = false;
            this.textBox2.Location = new System.Drawing.Point(153, 90);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = false;
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.FocusOnHover = false;
            this.textBox1.Location = new System.Drawing.Point(28, 90);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = false;
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // af_enable
            // 
            this.af_enable.BackColor = System.Drawing.Color.Transparent;
            this.af_enable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.af_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.af_enable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.af_enable.Location = new System.Drawing.Point(16, 213);
            this.af_enable.Name = "af_enable";
            this.af_enable.Rounded = true;
            this.af_enable.Size = new System.Drawing.Size(74, 32);
            this.af_enable.TabIndex = 20;
            this.af_enable.Text = "Enable";
            this.af_enable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.af_enable.Click += new System.EventHandler(this.af_enable_Click);
            // 
            // simpleLabel4
            // 
            this.simpleLabel4.AutoSize = true;
            this.simpleLabel4.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel4.ForeColor = System.Drawing.Color.White;
            this.simpleLabel4.Location = new System.Drawing.Point(12, 180);
            this.simpleLabel4.Name = "simpleLabel4";
            this.simpleLabel4.Size = new System.Drawing.Size(305, 21);
            this.simpleLabel4.TabIndex = 19;
            this.simpleLabel4.Text = "This will move your cursor in one direction";
            // 
            // simpleLabel3
            // 
            this.simpleLabel3.AutoSize = true;
            this.simpleLabel3.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel3.ForeColor = System.Drawing.Color.White;
            this.simpleLabel3.Location = new System.Drawing.Point(12, 159);
            this.simpleLabel3.Name = "simpleLabel3";
            this.simpleLabel3.Size = new System.Drawing.Size(203, 21);
            this.simpleLabel3.TabIndex = 18;
            this.simpleLabel3.Text = "Anti AFK (Hotkey: CTRL+F1)";
            // 
            // spg_enable
            // 
            this.spg_enable.BackColor = System.Drawing.Color.Transparent;
            this.spg_enable.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.spg_enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spg_enable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.spg_enable.Location = new System.Drawing.Point(16, 110);
            this.spg_enable.Name = "spg_enable";
            this.spg_enable.Rounded = true;
            this.spg_enable.Size = new System.Drawing.Size(71, 32);
            this.spg_enable.TabIndex = 17;
            this.spg_enable.Text = "Enable";
            this.spg_enable.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.spg_enable.Click += new System.EventHandler(this.spg_enable_Click);
            // 
            // simpleLabel2
            // 
            this.simpleLabel2.AutoSize = true;
            this.simpleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel2.ForeColor = System.Drawing.Color.White;
            this.simpleLabel2.Location = new System.Drawing.Point(12, 75);
            this.simpleLabel2.Name = "simpleLabel2";
            this.simpleLabel2.Size = new System.Drawing.Size(218, 21);
            this.simpleLabel2.TabIndex = 16;
            this.simpleLabel2.Text = "GTA will freeze for 10 seconds";
            // 
            // simpleLabel1
            // 
            this.simpleLabel1.AutoSize = true;
            this.simpleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.simpleLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.simpleLabel1.ForeColor = System.Drawing.Color.White;
            this.simpleLabel1.Location = new System.Drawing.Point(12, 54);
            this.simpleLabel1.Name = "simpleLabel1";
            this.simpleLabel1.Size = new System.Drawing.Size(280, 21);
            this.simpleLabel1.TabIndex = 15;
            this.simpleLabel1.Text = "Solo public generator(Hotkey: CTRL+L)";
            // 
            // rText_console
            // 
            this.rText_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rText_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rText_console.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rText_console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(131)))));
            this.rText_console.Location = new System.Drawing.Point(417, 54);
            this.rText_console.Name = "rText_console";
            this.rText_console.ReadOnly = true;
            this.rText_console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rText_console.Size = new System.Drawing.Size(226, 338);
            this.rText_console.TabIndex = 14;
            this.rText_console.Text = "";
            this.rText_console.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 395);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTA Tool";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SimpleCodeUIBeta.FormSkin formSkin1;
        private SimpleCodeUIBeta.SimpleButton af_enable;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel4;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel3;
        private SimpleCodeUIBeta.SimpleButton spg_enable;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel2;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel1;
        private System.Windows.Forms.RichTextBox rText_console;
        private SimpleCodeUIBeta.FlatGroupBox groupBox1;
        private SimpleCodeUIBeta.SimpleTextBox textBox2;
        private SimpleCodeUIBeta.SimpleTextBox textBox1;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel5;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel6;
        private SimpleCodeUIBeta.SimpleButton aw_enable;
        private SimpleCodeUIBeta.SimpleLabel simpleLabel7;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnExit;
    }
}

