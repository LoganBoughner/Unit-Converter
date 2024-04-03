namespace Unit_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDist = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpDist = new System.Windows.Forms.GroupBox();
            this.radKm = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.radCm = new System.Windows.Forms.RadioButton();
            this.radMM = new System.Windows.Forms.RadioButton();
            this.grpConvertDist = new System.Windows.Forms.GroupBox();
            this.radKmCalc = new System.Windows.Forms.RadioButton();
            this.radMmCalc = new System.Windows.Forms.RadioButton();
            this.radCmCalc = new System.Windows.Forms.RadioButton();
            this.radMCalc = new System.Windows.Forms.RadioButton();
            this.grpWeight = new System.Windows.Forms.GroupBox();
            this.radPounds = new System.Windows.Forms.RadioButton();
            this.radKilo = new System.Windows.Forms.RadioButton();
            this.grpConvertWeight = new System.Windows.Forms.GroupBox();
            this.radConvertPounds = new System.Windows.Forms.RadioButton();
            this.radConvertKilo = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConvertWeight = new System.Windows.Forms.Button();
            this.btnConvertDist = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.imgChoice = new System.Windows.Forms.PictureBox();
            this.grpDist.SuspendLayout();
            this.grpConvertDist.SuspendLayout();
            this.grpWeight.SuspendLayout();
            this.grpConvertWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(98, 211);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(75, 23);
            this.btnDist.TabIndex = 0;
            this.btnDist.Text = "Distance";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Location = new System.Drawing.Point(314, 211);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(75, 23);
            this.btnWeight.TabIndex = 1;
            this.btnWeight.Text = "Weight";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(86, 240);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 20);
            this.txtDist.TabIndex = 3;
            this.txtDist.Visible = false;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(300, 240);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Visible = false;
            // 
            // grpDist
            // 
            this.grpDist.Controls.Add(this.radKm);
            this.grpDist.Controls.Add(this.radM);
            this.grpDist.Controls.Add(this.radCm);
            this.grpDist.Controls.Add(this.radMM);
            this.grpDist.Location = new System.Drawing.Point(58, 266);
            this.grpDist.Name = "grpDist";
            this.grpDist.Size = new System.Drawing.Size(177, 75);
            this.grpDist.TabIndex = 34;
            this.grpDist.TabStop = false;
            this.grpDist.Text = "Start";
            this.grpDist.Visible = false;
            // 
            // radKm
            // 
            this.radKm.AutoSize = true;
            this.radKm.Location = new System.Drawing.Point(99, 50);
            this.radKm.Name = "radKm";
            this.radKm.Size = new System.Drawing.Size(40, 17);
            this.radKm.TabIndex = 40;
            this.radKm.TabStop = true;
            this.radKm.Text = "Km";
            this.radKm.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(18, 51);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(34, 17);
            this.radM.TabIndex = 39;
            this.radM.TabStop = true;
            this.radM.Text = "M";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // radCm
            // 
            this.radCm.AutoSize = true;
            this.radCm.Location = new System.Drawing.Point(99, 19);
            this.radCm.Name = "radCm";
            this.radCm.Size = new System.Drawing.Size(40, 17);
            this.radCm.TabIndex = 38;
            this.radCm.TabStop = true;
            this.radCm.Text = "Cm";
            this.radCm.UseVisualStyleBackColor = true;
            // 
            // radMM
            // 
            this.radMM.AutoSize = true;
            this.radMM.Location = new System.Drawing.Point(18, 19);
            this.radMM.Name = "radMM";
            this.radMM.Size = new System.Drawing.Size(42, 17);
            this.radMM.TabIndex = 37;
            this.radMM.TabStop = true;
            this.radMM.Text = "Mm";
            this.radMM.UseVisualStyleBackColor = true;
            // 
            // grpConvertDist
            // 
            this.grpConvertDist.Controls.Add(this.radKmCalc);
            this.grpConvertDist.Controls.Add(this.radMmCalc);
            this.grpConvertDist.Controls.Add(this.radCmCalc);
            this.grpConvertDist.Controls.Add(this.radMCalc);
            this.grpConvertDist.Location = new System.Drawing.Point(58, 347);
            this.grpConvertDist.Name = "grpConvertDist";
            this.grpConvertDist.Size = new System.Drawing.Size(177, 75);
            this.grpConvertDist.TabIndex = 35;
            this.grpConvertDist.TabStop = false;
            this.grpConvertDist.Text = "Convert to";
            this.grpConvertDist.Visible = false;
            // 
            // radKmCalc
            // 
            this.radKmCalc.AutoSize = true;
            this.radKmCalc.Location = new System.Drawing.Point(99, 51);
            this.radKmCalc.Name = "radKmCalc";
            this.radKmCalc.Size = new System.Drawing.Size(40, 17);
            this.radKmCalc.TabIndex = 43;
            this.radKmCalc.TabStop = true;
            this.radKmCalc.Text = "Km";
            this.radKmCalc.UseVisualStyleBackColor = true;
            // 
            // radMmCalc
            // 
            this.radMmCalc.AutoSize = true;
            this.radMmCalc.Location = new System.Drawing.Point(18, 25);
            this.radMmCalc.Name = "radMmCalc";
            this.radMmCalc.Size = new System.Drawing.Size(42, 17);
            this.radMmCalc.TabIndex = 41;
            this.radMmCalc.TabStop = true;
            this.radMmCalc.Text = "Mm";
            this.radMmCalc.UseVisualStyleBackColor = true;
            // 
            // radCmCalc
            // 
            this.radCmCalc.AutoSize = true;
            this.radCmCalc.Location = new System.Drawing.Point(99, 25);
            this.radCmCalc.Name = "radCmCalc";
            this.radCmCalc.Size = new System.Drawing.Size(40, 17);
            this.radCmCalc.TabIndex = 42;
            this.radCmCalc.TabStop = true;
            this.radCmCalc.Text = "Cm";
            this.radCmCalc.UseVisualStyleBackColor = true;
            // 
            // radMCalc
            // 
            this.radMCalc.AutoSize = true;
            this.radMCalc.Location = new System.Drawing.Point(18, 51);
            this.radMCalc.Name = "radMCalc";
            this.radMCalc.Size = new System.Drawing.Size(34, 17);
            this.radMCalc.TabIndex = 44;
            this.radMCalc.TabStop = true;
            this.radMCalc.Text = "M";
            this.radMCalc.UseVisualStyleBackColor = true;
            // 
            // grpWeight
            // 
            this.grpWeight.Controls.Add(this.radPounds);
            this.grpWeight.Controls.Add(this.radKilo);
            this.grpWeight.Location = new System.Drawing.Point(273, 266);
            this.grpWeight.Name = "grpWeight";
            this.grpWeight.Size = new System.Drawing.Size(177, 48);
            this.grpWeight.TabIndex = 35;
            this.grpWeight.TabStop = false;
            this.grpWeight.Text = "Start";
            this.grpWeight.Visible = false;
            // 
            // radPounds
            // 
            this.radPounds.AutoSize = true;
            this.radPounds.Location = new System.Drawing.Point(27, 18);
            this.radPounds.Name = "radPounds";
            this.radPounds.Size = new System.Drawing.Size(61, 17);
            this.radPounds.TabIndex = 41;
            this.radPounds.TabStop = true;
            this.radPounds.Text = "Pounds";
            this.radPounds.UseVisualStyleBackColor = true;
            // 
            // radKilo
            // 
            this.radKilo.AutoSize = true;
            this.radKilo.Location = new System.Drawing.Point(119, 19);
            this.radKilo.Name = "radKilo";
            this.radKilo.Size = new System.Drawing.Size(42, 17);
            this.radKilo.TabIndex = 42;
            this.radKilo.TabStop = true;
            this.radKilo.Text = "Kilo";
            this.radKilo.UseVisualStyleBackColor = true;
            // 
            // grpConvertWeight
            // 
            this.grpConvertWeight.Controls.Add(this.radConvertPounds);
            this.grpConvertWeight.Controls.Add(this.radConvertKilo);
            this.grpConvertWeight.Location = new System.Drawing.Point(273, 347);
            this.grpConvertWeight.Name = "grpConvertWeight";
            this.grpConvertWeight.Size = new System.Drawing.Size(177, 48);
            this.grpConvertWeight.TabIndex = 36;
            this.grpConvertWeight.TabStop = false;
            this.grpConvertWeight.Text = "Convert to";
            this.grpConvertWeight.Visible = false;
            // 
            // radConvertPounds
            // 
            this.radConvertPounds.AutoSize = true;
            this.radConvertPounds.Location = new System.Drawing.Point(27, 19);
            this.radConvertPounds.Name = "radConvertPounds";
            this.radConvertPounds.Size = new System.Drawing.Size(61, 17);
            this.radConvertPounds.TabIndex = 43;
            this.radConvertPounds.TabStop = true;
            this.radConvertPounds.Text = "Pounds";
            this.radConvertPounds.UseVisualStyleBackColor = true;
            // 
            // radConvertKilo
            // 
            this.radConvertKilo.AutoSize = true;
            this.radConvertKilo.Location = new System.Drawing.Point(119, 20);
            this.radConvertKilo.Name = "radConvertKilo";
            this.radConvertKilo.Size = new System.Drawing.Size(42, 17);
            this.radConvertKilo.TabIndex = 44;
            this.radConvertKilo.TabStop = true;
            this.radConvertKilo.Text = "Kilo";
            this.radConvertKilo.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(314, 62);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 20);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConvertWeight
            // 
            this.btnConvertWeight.Location = new System.Drawing.Point(314, 123);
            this.btnConvertWeight.Name = "btnConvertWeight";
            this.btnConvertWeight.Size = new System.Drawing.Size(75, 20);
            this.btnConvertWeight.TabIndex = 38;
            this.btnConvertWeight.Text = "Convert";
            this.btnConvertWeight.UseVisualStyleBackColor = true;
            this.btnConvertWeight.Visible = false;
            this.btnConvertWeight.Click += new System.EventHandler(this.btnConvertWeight_Click);
            // 
            // btnConvertDist
            // 
            this.btnConvertDist.Location = new System.Drawing.Point(98, 123);
            this.btnConvertDist.Name = "btnConvertDist";
            this.btnConvertDist.Size = new System.Drawing.Size(75, 20);
            this.btnConvertDist.TabIndex = 39;
            this.btnConvertDist.Text = "Convert";
            this.btnConvertDist.UseVisualStyleBackColor = true;
            this.btnConvertDist.Visible = false;
            this.btnConvertDist.Click += new System.EventHandler(this.btnConvertDist_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(323, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Visible = false;
            // 
            // imgChoice
            // 
            this.imgChoice.Location = new System.Drawing.Point(429, 32);
            this.imgChoice.Name = "imgChoice";
            this.imgChoice.Size = new System.Drawing.Size(235, 146);
            this.imgChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgChoice.TabIndex = 42;
            this.imgChoice.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgChoice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConvertDist);
            this.Controls.Add(this.btnConvertWeight);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpConvertWeight);
            this.Controls.Add(this.grpWeight);
            this.Controls.Add(this.grpConvertDist);
            this.Controls.Add(this.grpDist);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.btnDist);
            this.Name = "Form1";
            this.Text = "Units";
            this.grpDist.ResumeLayout(false);
            this.grpDist.PerformLayout();
            this.grpConvertDist.ResumeLayout(false);
            this.grpConvertDist.PerformLayout();
            this.grpWeight.ResumeLayout(false);
            this.grpWeight.PerformLayout();
            this.grpConvertWeight.ResumeLayout(false);
            this.grpConvertWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox grpDist;
        private System.Windows.Forms.GroupBox grpConvertDist;
        private System.Windows.Forms.GroupBox grpWeight;
        private System.Windows.Forms.GroupBox grpConvertWeight;
        private System.Windows.Forms.RadioButton radKm;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.RadioButton radCm;
        private System.Windows.Forms.RadioButton radMM;
        private System.Windows.Forms.RadioButton radKmCalc;
        private System.Windows.Forms.RadioButton radMmCalc;
        private System.Windows.Forms.RadioButton radCmCalc;
        private System.Windows.Forms.RadioButton radMCalc;
        private System.Windows.Forms.RadioButton radPounds;
        private System.Windows.Forms.RadioButton radKilo;
        private System.Windows.Forms.RadioButton radConvertPounds;
        private System.Windows.Forms.RadioButton radConvertKilo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConvertWeight;
        private System.Windows.Forms.Button btnConvertDist;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox imgChoice;
    }
}

