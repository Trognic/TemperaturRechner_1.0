namespace TemperaturModifikator
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
            this.textBoxTEMP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGrad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCK = new System.Windows.Forms.RadioButton();
            this.radioButtonKC = new System.Windows.Forms.RadioButton();
            this.radioButtonCF = new System.Windows.Forms.RadioButton();
            this.radioButtonFC = new System.Windows.Forms.RadioButton();
            this.radioButtonFK = new System.Windows.Forms.RadioButton();
            this.radioButtonKF = new System.Windows.Forms.RadioButton();
            this.buttonUMRECHNEN = new System.Windows.Forms.Button();
            this.labelEinheit = new System.Windows.Forms.Label();
            this.labelResultat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTEMP
            // 
            this.textBoxTEMP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxTEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTEMP.Location = new System.Drawing.Point(180, 12);
            this.textBoxTEMP.Name = "textBoxTEMP";
            this.textBoxTEMP.Size = new System.Drawing.Size(160, 44);
            this.textBoxTEMP.TabIndex = 0;
            this.textBoxTEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatur:";
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrad.Location = new System.Drawing.Point(346, 18);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(74, 31);
            this.labelGrad.TabIndex = 2;
            this.labelGrad.Text = "Grad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonKF);
            this.groupBox1.Controls.Add(this.radioButtonFK);
            this.groupBox1.Controls.Add(this.radioButtonFC);
            this.groupBox1.Controls.Add(this.radioButtonCF);
            this.groupBox1.Controls.Add(this.radioButtonKC);
            this.groupBox1.Controls.Add(this.radioButtonCK);
            this.groupBox1.Location = new System.Drawing.Point(18, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 243);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCK
            // 
            this.radioButtonCK.AutoSize = true;
            this.radioButtonCK.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCK.Checked = true;
            this.radioButtonCK.Location = new System.Drawing.Point(6, 17);
            this.radioButtonCK.Name = "radioButtonCK";
            this.radioButtonCK.Size = new System.Drawing.Size(232, 29);
            this.radioButtonCK.TabIndex = 0;
            this.radioButtonCK.TabStop = true;
            this.radioButtonCK.Text = "Celsius nach Kelvin";
            this.radioButtonCK.UseVisualStyleBackColor = false;
            this.radioButtonCK.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // radioButtonKC
            // 
            this.radioButtonKC.AutoSize = true;
            this.radioButtonKC.Location = new System.Drawing.Point(6, 52);
            this.radioButtonKC.Name = "radioButtonKC";
            this.radioButtonKC.Size = new System.Drawing.Size(232, 29);
            this.radioButtonKC.TabIndex = 1;
            this.radioButtonKC.Text = "Kelvin nach Celsius";
            this.radioButtonKC.UseVisualStyleBackColor = true;
            this.radioButtonKC.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // radioButtonCF
            // 
            this.radioButtonCF.AutoSize = true;
            this.radioButtonCF.Location = new System.Drawing.Point(6, 87);
            this.radioButtonCF.Name = "radioButtonCF";
            this.radioButtonCF.Size = new System.Drawing.Size(276, 29);
            this.radioButtonCF.TabIndex = 2;
            this.radioButtonCF.Text = "Celsius nach Fahrenheit";
            this.radioButtonCF.UseVisualStyleBackColor = true;
            this.radioButtonCF.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // radioButtonFC
            // 
            this.radioButtonFC.AutoSize = true;
            this.radioButtonFC.Location = new System.Drawing.Point(6, 122);
            this.radioButtonFC.Name = "radioButtonFC";
            this.radioButtonFC.Size = new System.Drawing.Size(276, 29);
            this.radioButtonFC.TabIndex = 3;
            this.radioButtonFC.Text = "Fahrenheit nach Celsius";
            this.radioButtonFC.UseVisualStyleBackColor = true;
            this.radioButtonFC.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // radioButtonFK
            // 
            this.radioButtonFK.AutoSize = true;
            this.radioButtonFK.Location = new System.Drawing.Point(6, 157);
            this.radioButtonFK.Name = "radioButtonFK";
            this.radioButtonFK.Size = new System.Drawing.Size(264, 29);
            this.radioButtonFK.TabIndex = 4;
            this.radioButtonFK.Text = "Fahrenheit nach Kelvin";
            this.radioButtonFK.UseVisualStyleBackColor = true;
            this.radioButtonFK.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // radioButtonKF
            // 
            this.radioButtonKF.AutoSize = true;
            this.radioButtonKF.Location = new System.Drawing.Point(6, 192);
            this.radioButtonKF.Name = "radioButtonKF";
            this.radioButtonKF.Size = new System.Drawing.Size(264, 29);
            this.radioButtonKF.TabIndex = 5;
            this.radioButtonKF.Text = "Kelvin nach Fahrenheit";
            this.radioButtonKF.UseVisualStyleBackColor = true;
            this.radioButtonKF.CheckedChanged += new System.EventHandler(this.radioButton_change);
            // 
            // buttonUMRECHNEN
            // 
            this.buttonUMRECHNEN.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonUMRECHNEN.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonUMRECHNEN.FlatAppearance.BorderSize = 3;
            this.buttonUMRECHNEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUMRECHNEN.Location = new System.Drawing.Point(18, 322);
            this.buttonUMRECHNEN.Name = "buttonUMRECHNEN";
            this.buttonUMRECHNEN.Size = new System.Drawing.Size(322, 72);
            this.buttonUMRECHNEN.TabIndex = 4;
            this.buttonUMRECHNEN.Text = "Umrechnen";
            this.buttonUMRECHNEN.UseVisualStyleBackColor = false;
            this.buttonUMRECHNEN.Click += new System.EventHandler(this.buttonUMRECHNEN_Click);
            // 
            // labelEinheit
            // 
            this.labelEinheit.AutoSize = true;
            this.labelEinheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEinheit.Location = new System.Drawing.Point(426, 18);
            this.labelEinheit.Name = "labelEinheit";
            this.labelEinheit.Size = new System.Drawing.Size(45, 31);
            this.labelEinheit.TabIndex = 5;
            this.labelEinheit.Text = "°C";
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.Location = new System.Drawing.Point(369, 79);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(0, 37);
            this.labelResultat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.labelEinheit);
            this.Controls.Add(this.buttonUMRECHNEN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTEMP);
            this.Name = "Form1";
            this.Text = "Temperatur Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTEMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonKF;
        private System.Windows.Forms.RadioButton radioButtonFK;
        private System.Windows.Forms.RadioButton radioButtonFC;
        private System.Windows.Forms.RadioButton radioButtonCF;
        private System.Windows.Forms.RadioButton radioButtonKC;
        private System.Windows.Forms.RadioButton radioButtonCK;
        private System.Windows.Forms.Button buttonUMRECHNEN;
        private System.Windows.Forms.Label labelEinheit;
        private System.Windows.Forms.Label labelResultat;
    }
}

