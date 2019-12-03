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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aw_enable = new System.Windows.Forms.Button();
            this.spg_enable = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.af_enable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rText_console = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Walk (Hotkey: CTRL+ALT+F2)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dely until start";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "How long to press \"W\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Solo public generator(Hotkey: CTRL+ALT+L)";
            // 
            // aw_enable
            // 
            this.aw_enable.Location = new System.Drawing.Point(232, 85);
            this.aw_enable.Name = "aw_enable";
            this.aw_enable.Size = new System.Drawing.Size(75, 20);
            this.aw_enable.TabIndex = 6;
            this.aw_enable.Text = "Enable";
            this.aw_enable.UseVisualStyleBackColor = true;
            this.aw_enable.Click += new System.EventHandler(this.aw_enable_Click);
            // 
            // spg_enable
            // 
            this.spg_enable.Location = new System.Drawing.Point(17, 45);
            this.spg_enable.Name = "spg_enable";
            this.spg_enable.Size = new System.Drawing.Size(75, 23);
            this.spg_enable.TabIndex = 7;
            this.spg_enable.Text = "Enable";
            this.spg_enable.UseVisualStyleBackColor = true;
            this.spg_enable.Click += new System.EventHandler(this.spg_enable_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Anti AFK (Hotkey: CTRL+ALT+F1)";
            // 
            // af_enable
            // 
            this.af_enable.Location = new System.Drawing.Point(17, 139);
            this.af_enable.Name = "af_enable";
            this.af_enable.Size = new System.Drawing.Size(75, 23);
            this.af_enable.TabIndex = 9;
            this.af_enable.Text = "Enable";
            this.af_enable.UseVisualStyleBackColor = true;
            this.af_enable.Click += new System.EventHandler(this.af_enable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.aw_enable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 130);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Under Development";
            // 
            // rText_console
            // 
            this.rText_console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rText_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rText_console.ForeColor = System.Drawing.Color.ForestGreen;
            this.rText_console.Location = new System.Drawing.Point(406, 9);
            this.rText_console.Name = "rText_console";
            this.rText_console.ReadOnly = true;
            this.rText_console.Size = new System.Drawing.Size(382, 429);
            this.rText_console.TabIndex = 11;
            this.rText_console.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GTA will freeze for 10 seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "This will move your cursor in one direction";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rText_console);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.af_enable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spg_enable);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainWindow";
            this.Text = "GTA Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button aw_enable;
        private System.Windows.Forms.Button spg_enable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button af_enable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rText_console;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

