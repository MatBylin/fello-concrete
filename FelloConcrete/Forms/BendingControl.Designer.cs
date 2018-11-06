namespace FelloConcrete
{
    partial class BendingControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BendingControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxBendingB = new System.Windows.Forms.TextBox();
            this.TextBoxBendingH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxBendingA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxBendingM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonBendingResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBendingAmax = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelBendingAs2 = new System.Windows.Forms.Label();
            this.labelBendingAs1 = new System.Windows.Forms.Label();
            this.labelBendingAmin = new System.Windows.Forms.Label();
            this.labelBendingFyd = new System.Windows.Forms.Label();
            this.labelBendingFcd = new System.Windows.Forms.Label();
            this.labelBendingF = new System.Windows.Forms.Label();
            this.labelBendingN = new System.Windows.Forms.Label();
            this.labelBendingA = new System.Windows.Forms.Label();
            this.labelBendingD = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxBendingSteele = new System.Windows.Forms.ComboBox();
            this.ComboBoxBendingConcrete = new System.Windows.Forms.ComboBox();
            this.labelBendingWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zginany przekrój prostokątny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procedura według PN-EN 1992-1-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "b (mm):";
            // 
            // TextBoxBendingB
            // 
            this.TextBoxBendingB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBendingB.Location = new System.Drawing.Point(128, 116);
            this.TextBoxBendingB.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxBendingB.Name = "TextBoxBendingB";
            this.TextBoxBendingB.Size = new System.Drawing.Size(74, 26);
            this.TextBoxBendingB.TabIndex = 0;
            this.TextBoxBendingB.Text = "250";
            this.TextBoxBendingB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBendingB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBendingB_KeyPress);
            // 
            // TextBoxBendingH
            // 
            this.TextBoxBendingH.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBendingH.Location = new System.Drawing.Point(128, 154);
            this.TextBoxBendingH.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxBendingH.Name = "TextBoxBendingH";
            this.TextBoxBendingH.Size = new System.Drawing.Size(74, 26);
            this.TextBoxBendingH.TabIndex = 1;
            this.TextBoxBendingH.Text = "450";
            this.TextBoxBendingH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBendingH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBendingH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "h (mm):";
            // 
            // TextBoxBendingA
            // 
            this.TextBoxBendingA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBendingA.Location = new System.Drawing.Point(128, 192);
            this.TextBoxBendingA.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxBendingA.Name = "TextBoxBendingA";
            this.TextBoxBendingA.Size = new System.Drawing.Size(74, 26);
            this.TextBoxBendingA.TabIndex = 2;
            this.TextBoxBendingA.Text = "25";
            this.TextBoxBendingA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBendingA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBendingA_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(45, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "a (mm):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(45, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "stal :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(45, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "beton :";
            // 
            // TextBoxBendingM
            // 
            this.TextBoxBendingM.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxBendingM.Location = new System.Drawing.Point(128, 380);
            this.TextBoxBendingM.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxBendingM.Name = "TextBoxBendingM";
            this.TextBoxBendingM.Size = new System.Drawing.Size(76, 26);
            this.TextBoxBendingM.TabIndex = 5;
            this.TextBoxBendingM.Text = "105,5";
            this.TextBoxBendingM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxBendingM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxBendingM_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(45, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "My (kNm):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(40, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Geometria :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(40, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Parametry :";
            // 
            // ButtonBendingResults
            // 
            this.ButtonBendingResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonBendingResults.FlatAppearance.BorderSize = 0;
            this.ButtonBendingResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBendingResults.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBendingResults.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonBendingResults.Location = new System.Drawing.Point(49, 442);
            this.ButtonBendingResults.Name = "ButtonBendingResults";
            this.ButtonBendingResults.Size = new System.Drawing.Size(159, 51);
            this.ButtonBendingResults.TabIndex = 6;
            this.ButtonBendingResults.Text = "Obliczenia";
            this.ButtonBendingResults.UseVisualStyleBackColor = false;
            this.ButtonBendingResults.Click += new System.EventHandler(this.ButtonZginanieObliczenia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(341, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBendingAmax);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.labelBendingAs2);
            this.groupBox1.Controls.Add(this.labelBendingAs1);
            this.groupBox1.Controls.Add(this.labelBendingAmin);
            this.groupBox1.Controls.Add(this.labelBendingFyd);
            this.groupBox1.Controls.Add(this.labelBendingFcd);
            this.groupBox1.Controls.Add(this.labelBendingF);
            this.groupBox1.Controls.Add(this.labelBendingN);
            this.groupBox1.Controls.Add(this.labelBendingA);
            this.groupBox1.Controls.Add(this.labelBendingD);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(266, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 217);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wyniki";
            // 
            // labelBendingAmax
            // 
            this.labelBendingAmax.AutoSize = true;
            this.labelBendingAmax.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingAmax.Location = new System.Drawing.Point(262, 124);
            this.labelBendingAmax.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingAmax.Name = "labelBendingAmax";
            this.labelBendingAmax.Size = new System.Drawing.Size(21, 20);
            this.labelBendingAmax.TabIndex = 22;
            this.labelBendingAmax.Text = "...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.Location = new System.Drawing.Point(164, 124);
            this.label21.Margin = new System.Windows.Forms.Padding(6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Amax(cm2):";
            // 
            // labelBendingAs2
            // 
            this.labelBendingAs2.AutoSize = true;
            this.labelBendingAs2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingAs2.Location = new System.Drawing.Point(260, 184);
            this.labelBendingAs2.Margin = new System.Windows.Forms.Padding(4);
            this.labelBendingAs2.Name = "labelBendingAs2";
            this.labelBendingAs2.Size = new System.Drawing.Size(21, 19);
            this.labelBendingAs2.TabIndex = 20;
            this.labelBendingAs2.Text = "...";
            // 
            // labelBendingAs1
            // 
            this.labelBendingAs1.AutoSize = true;
            this.labelBendingAs1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingAs1.Location = new System.Drawing.Point(111, 184);
            this.labelBendingAs1.Margin = new System.Windows.Forms.Padding(4);
            this.labelBendingAs1.Name = "labelBendingAs1";
            this.labelBendingAs1.Size = new System.Drawing.Size(21, 19);
            this.labelBendingAs1.TabIndex = 19;
            this.labelBendingAs1.Text = "...";
            // 
            // labelBendingAmin
            // 
            this.labelBendingAmin.AutoSize = true;
            this.labelBendingAmin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingAmin.Location = new System.Drawing.Point(262, 92);
            this.labelBendingAmin.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingAmin.Name = "labelBendingAmin";
            this.labelBendingAmin.Size = new System.Drawing.Size(21, 20);
            this.labelBendingAmin.TabIndex = 18;
            this.labelBendingAmin.Text = "...";
            // 
            // labelBendingFyd
            // 
            this.labelBendingFyd.AutoSize = true;
            this.labelBendingFyd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingFyd.Location = new System.Drawing.Point(264, 60);
            this.labelBendingFyd.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingFyd.Name = "labelBendingFyd";
            this.labelBendingFyd.Size = new System.Drawing.Size(21, 20);
            this.labelBendingFyd.TabIndex = 17;
            this.labelBendingFyd.Text = "...";
            // 
            // labelBendingFcd
            // 
            this.labelBendingFcd.AutoSize = true;
            this.labelBendingFcd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingFcd.Location = new System.Drawing.Point(264, 28);
            this.labelBendingFcd.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingFcd.Name = "labelBendingFcd";
            this.labelBendingFcd.Size = new System.Drawing.Size(21, 20);
            this.labelBendingFcd.TabIndex = 16;
            this.labelBendingFcd.Text = "...";
            // 
            // labelBendingF
            // 
            this.labelBendingF.AutoSize = true;
            this.labelBendingF.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingF.Location = new System.Drawing.Point(85, 124);
            this.labelBendingF.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingF.Name = "labelBendingF";
            this.labelBendingF.Size = new System.Drawing.Size(21, 20);
            this.labelBendingF.TabIndex = 15;
            this.labelBendingF.Text = "...";
            // 
            // labelBendingN
            // 
            this.labelBendingN.AutoSize = true;
            this.labelBendingN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingN.Location = new System.Drawing.Point(85, 92);
            this.labelBendingN.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingN.Name = "labelBendingN";
            this.labelBendingN.Size = new System.Drawing.Size(21, 20);
            this.labelBendingN.TabIndex = 14;
            this.labelBendingN.Text = "...";
            // 
            // labelBendingA
            // 
            this.labelBendingA.AutoSize = true;
            this.labelBendingA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingA.Location = new System.Drawing.Point(87, 60);
            this.labelBendingA.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingA.Name = "labelBendingA";
            this.labelBendingA.Size = new System.Drawing.Size(21, 20);
            this.labelBendingA.TabIndex = 13;
            this.labelBendingA.Text = "...";
            // 
            // labelBendingD
            // 
            this.labelBendingD.AutoSize = true;
            this.labelBendingD.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingD.Location = new System.Drawing.Point(87, 28);
            this.labelBendingD.Margin = new System.Windows.Forms.Padding(6);
            this.labelBendingD.Name = "labelBendingD";
            this.labelBendingD.Size = new System.Drawing.Size(21, 20);
            this.labelBendingD.TabIndex = 12;
            this.labelBendingD.Text = "...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(167, 184);
            this.label19.Margin = new System.Windows.Forms.Padding(4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 18);
            this.label19.TabIndex = 11;
            this.label19.Text = "As2(cm2) :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(18, 184);
            this.label18.Margin = new System.Windows.Forms.Padding(4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.TabIndex = 10;
            this.label18.Text = "As1(cm2) :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(14, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "ξef:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(14, 92);
            this.label16.Margin = new System.Windows.Forms.Padding(6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "μ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(14, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "A (cm2):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(164, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Amin(cm2):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(166, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "fyd (MPa):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(168, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "fcd (MPa):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "d (mm):";
            // 
            // ComboBoxBendingSteele
            // 
            this.ComboBoxBendingSteele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBendingSteele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBendingSteele.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxBendingSteele.FormattingEnabled = true;
            this.ComboBoxBendingSteele.Items.AddRange(new object[] {
            "B400",
            "B500"});
            this.ComboBoxBendingSteele.Location = new System.Drawing.Point(128, 303);
            this.ComboBoxBendingSteele.Name = "ComboBoxBendingSteele";
            this.ComboBoxBendingSteele.Size = new System.Drawing.Size(76, 28);
            this.ComboBoxBendingSteele.TabIndex = 3;
            // 
            // ComboBoxBendingConcrete
            // 
            this.ComboBoxBendingConcrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBendingConcrete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBendingConcrete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ComboBoxBendingConcrete.FormattingEnabled = true;
            this.ComboBoxBendingConcrete.Items.AddRange(new object[] {
            "C12/15",
            "C16/20",
            "C20/25",
            "C25/30",
            "C30/37",
            "C35/45"});
            this.ComboBoxBendingConcrete.Location = new System.Drawing.Point(128, 342);
            this.ComboBoxBendingConcrete.Name = "ComboBoxBendingConcrete";
            this.ComboBoxBendingConcrete.Size = new System.Drawing.Size(76, 28);
            this.ComboBoxBendingConcrete.TabIndex = 4;
            // 
            // labelBendingWarning
            // 
            this.labelBendingWarning.AutoSize = true;
            this.labelBendingWarning.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBendingWarning.ForeColor = System.Drawing.Color.Red;
            this.labelBendingWarning.Location = new System.Drawing.Point(284, 256);
            this.labelBendingWarning.Margin = new System.Windows.Forms.Padding(4);
            this.labelBendingWarning.Name = "labelBendingWarning";
            this.labelBendingWarning.Size = new System.Drawing.Size(0, 18);
            this.labelBendingWarning.TabIndex = 21;
            // 
            // BendingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBendingWarning);
            this.Controls.Add(this.ComboBoxBendingConcrete);
            this.Controls.Add(this.ComboBoxBendingSteele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonBendingResults);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxBendingM);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxBendingA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxBendingH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxBendingB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BendingControl";
            this.Size = new System.Drawing.Size(615, 520);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxBendingB;
        private System.Windows.Forms.TextBox TextBoxBendingH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBendingA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxBendingM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonBendingResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxBendingSteele;
        private System.Windows.Forms.ComboBox ComboBoxBendingConcrete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelBendingAs2;
        private System.Windows.Forms.Label labelBendingAs1;
        private System.Windows.Forms.Label labelBendingAmin;
        private System.Windows.Forms.Label labelBendingFyd;
        private System.Windows.Forms.Label labelBendingFcd;
        private System.Windows.Forms.Label labelBendingF;
        private System.Windows.Forms.Label labelBendingN;
        private System.Windows.Forms.Label labelBendingA;
        private System.Windows.Forms.Label labelBendingD;
        private System.Windows.Forms.Label labelBendingWarning;
        private System.Windows.Forms.Label labelBendingAmax;
        private System.Windows.Forms.Label label21;
    }
}
