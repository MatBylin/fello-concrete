namespace FelloConcrete
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ButtonShear = new System.Windows.Forms.Button();
            this.ButtonBending = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shearControl1 = new FelloConcrete.ShearControl();
            this.circleButton1 = new FelloConcrete.CircleButton();
            this.bendingControl1 = new FelloConcrete.BendingControl();
            this.label13 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Panel1.Controls.Add(this.label13);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.circleButton1);
            this.Panel1.Controls.Add(this.SidePanel);
            this.Panel1.Controls.Add(this.ButtonShear);
            this.Panel1.Controls.Add(this.ButtonBending);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(210, 560);
            this.Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(21, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "www.kalkulatoryEC.pl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "matbylin@gmail.com";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 187);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 65);
            this.SidePanel.TabIndex = 3;
            // 
            // ButtonShear
            // 
            this.ButtonShear.FlatAppearance.BorderSize = 0;
            this.ButtonShear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonShear.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonShear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonShear.Image")));
            this.ButtonShear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonShear.Location = new System.Drawing.Point(12, 253);
            this.ButtonShear.Name = "ButtonShear";
            this.ButtonShear.Size = new System.Drawing.Size(198, 65);
            this.ButtonShear.TabIndex = 1;
            this.ButtonShear.Text = "     Ścinanie EC2";
            this.ButtonShear.UseVisualStyleBackColor = true;
            this.ButtonShear.Click += new System.EventHandler(this.ButtonScinanie_Click);
            // 
            // ButtonBending
            // 
            this.ButtonBending.FlatAppearance.BorderSize = 0;
            this.ButtonBending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBending.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBending.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonBending.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBending.Image")));
            this.ButtonBending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBending.Location = new System.Drawing.Point(12, 187);
            this.ButtonBending.Name = "ButtonBending";
            this.ButtonBending.Size = new System.Drawing.Size(198, 65);
            this.ButtonBending.TabIndex = 0;
            this.ButtonBending.Text = "     Zginanie EC2";
            this.ButtonBending.UseVisualStyleBackColor = true;
            this.ButtonBending.Click += new System.EventHandler(this.ButtonZginanie_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(86)))), ((int)(((byte)(136)))));
            this.Panel2.Controls.Add(this.ButtonMinimize);
            this.Panel2.Controls.Add(this.ButtonAbout);
            this.Panel2.Controls.Add(this.ButtonQuit);
            this.Panel2.Controls.Add(this.pictureBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(210, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(615, 35);
            this.Panel2.TabIndex = 1;
            this.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonMinimize.Location = new System.Drawing.Point(504, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(35, 35);
            this.ButtonMinimize.TabIndex = 2;
            this.ButtonMinimize.Text = "_";
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.FlatAppearance.BorderSize = 0;
            this.ButtonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAbout.Font = new System.Drawing.Font("SansSerif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonAbout.Location = new System.Drawing.Point(541, 1);
            this.ButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(35, 35);
            this.ButtonAbout.TabIndex = 3;
            this.ButtonAbout.Text = "?";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.FlatAppearance.BorderSize = 0;
            this.ButtonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonQuit.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonQuit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonQuit.Image")));
            this.ButtonQuit.Location = new System.Drawing.Point(579, 1);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(35, 35);
            this.ButtonQuit.TabIndex = 4;
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // shearControl1
            // 
            this.shearControl1.Location = new System.Drawing.Point(210, 37);
            this.shearControl1.Name = "shearControl1";
            this.shearControl1.Size = new System.Drawing.Size(615, 500);
            this.shearControl1.TabIndex = 3;
            // 
            // circleButton1
            // 
            this.circleButton1.FlatAppearance.BorderSize = 0;
            this.circleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton1.Image = ((System.Drawing.Image)(resources.GetObject("circleButton1.Image")));
            this.circleButton1.Location = new System.Drawing.Point(37, 12);
            this.circleButton1.Name = "circleButton1";
            this.circleButton1.Size = new System.Drawing.Size(130, 130);
            this.circleButton1.TabIndex = 0;
            this.circleButton1.UseVisualStyleBackColor = true;
            // 
            // bendingControl1
            // 
            this.bendingControl1.Location = new System.Drawing.Point(210, 37);
            this.bendingControl1.Name = "bendingControl1";
            this.bendingControl1.Size = new System.Drawing.Size(615, 500);
            this.bendingControl1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(44, 531);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "All rights reserved";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 560);
            this.Controls.Add(this.shearControl1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.bendingControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button ButtonShear;
        private System.Windows.Forms.Button ButtonBending;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ButtonAbout;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Label label2;
        private CircleButton circleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonMinimize;
        private BendingControl bendingControl1;
        private ShearControl shearControl1;
        private System.Windows.Forms.Label label13;
    }
}

