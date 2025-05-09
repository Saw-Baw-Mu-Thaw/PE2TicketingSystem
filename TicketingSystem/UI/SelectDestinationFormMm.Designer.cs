﻿namespace UI
{
    partial class SelectDestinationFormMm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThuDucMm = new System.Windows.Forms.Button();
            this.btnOperaHouseMm = new System.Windows.Forms.Button();
            this.btnBenThanhMm = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblSelectDestinationMm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(478, 282);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "ပယ်ဖျက်မည်";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThuDucMm
            // 
            this.btnThuDucMm.Location = new System.Drawing.Point(294, 221);
            this.btnThuDucMm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuDucMm.Name = "btnThuDucMm";
            this.btnThuDucMm.Size = new System.Drawing.Size(160, 54);
            this.btnThuDucMm.TabIndex = 13;
            this.btnThuDucMm.Text = "သုဒု ဘူတာ";
            this.btnThuDucMm.UseVisualStyleBackColor = true;
            this.btnThuDucMm.Click += new System.EventHandler(this.btnThuDucMm_Click);
            // 
            // btnOperaHouseMm
            // 
            this.btnOperaHouseMm.Location = new System.Drawing.Point(294, 162);
            this.btnOperaHouseMm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOperaHouseMm.Name = "btnOperaHouseMm";
            this.btnOperaHouseMm.Size = new System.Drawing.Size(160, 54);
            this.btnOperaHouseMm.TabIndex = 12;
            this.btnOperaHouseMm.Text = "အော်ပရာရုံ";
            this.btnOperaHouseMm.UseVisualStyleBackColor = true;
            this.btnOperaHouseMm.Click += new System.EventHandler(this.btnOperaHouseMm_Click);
            // 
            // btnBenThanhMm
            // 
            this.btnBenThanhMm.Location = new System.Drawing.Point(294, 101);
            this.btnBenThanhMm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBenThanhMm.Name = "btnBenThanhMm";
            this.btnBenThanhMm.Size = new System.Drawing.Size(160, 54);
            this.btnBenThanhMm.TabIndex = 11;
            this.btnBenThanhMm.Text = "ဘင်ထန်းဘူတာ";
            this.btnBenThanhMm.UseVisualStyleBackColor = true;
            this.btnBenThanhMm.Click += new System.EventHandler(this.btnBenThanhMm_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::UI.Properties.Resources.Locomotive_Train_Transportation_Logo1;
            this.pbLogo.Location = new System.Drawing.Point(27, 44);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(205, 223);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lblSelectDestinationMm
            // 
            this.lblSelectDestinationMm.AutoSize = true;
            this.lblSelectDestinationMm.Location = new System.Drawing.Point(290, 55);
            this.lblSelectDestinationMm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDestinationMm.Name = "lblSelectDestinationMm";
            this.lblSelectDestinationMm.Size = new System.Drawing.Size(207, 20);
            this.lblSelectDestinationMm.TabIndex = 9;
            this.lblSelectDestinationMm.Text = "သွားရောက်လိုသည့် ဘူတာရုံကိုရွေးချယ်ပါ";
            // 
            // SelectDestinationFormMm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThuDucMm);
            this.Controls.Add(this.btnOperaHouseMm);
            this.Controls.Add(this.btnBenThanhMm);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSelectDestinationMm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectDestinationFormMm";
            this.Text = "SelectDestinationFormMm";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThuDucMm;
        private System.Windows.Forms.Button btnOperaHouseMm;
        private System.Windows.Forms.Button btnBenThanhMm;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSelectDestinationMm;
    }
}