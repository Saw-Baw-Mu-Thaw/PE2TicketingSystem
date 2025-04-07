namespace UI
{
    partial class SelectLanguageForm
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
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnVietnamese = new System.Windows.Forms.Button();
            this.btnMyanmar = new System.Windows.Forms.Button();
            this.pbVietnamFlag = new System.Windows.Forms.PictureBox();
            this.pbBritishFlag = new System.Windows.Forms.PictureBox();
            this.pbMyanmarFlag = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbVietnamFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBritishFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyanmarFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.AutoSize = true;
            this.lblSelectLanguage.Location = new System.Drawing.Point(445, 74);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(174, 25);
            this.lblSelectLanguage.TabIndex = 0;
            this.lblSelectLanguage.Text = "Select Language";
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(309, 212);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(143, 40);
            this.btnEnglish.TabIndex = 3;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnVietnamese
            // 
            this.btnVietnamese.Location = new System.Drawing.Point(628, 212);
            this.btnVietnamese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVietnamese.Name = "btnVietnamese";
            this.btnVietnamese.Size = new System.Drawing.Size(143, 40);
            this.btnVietnamese.TabIndex = 4;
            this.btnVietnamese.Text = "Vietnamese";
            this.btnVietnamese.UseVisualStyleBackColor = true;
            this.btnVietnamese.Click += new System.EventHandler(this.btnVietnamese_Click);
            // 
            // btnMyanmar
            // 
            this.btnMyanmar.Location = new System.Drawing.Point(467, 212);
            this.btnMyanmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyanmar.Name = "btnMyanmar";
            this.btnMyanmar.Size = new System.Drawing.Size(143, 40);
            this.btnMyanmar.TabIndex = 5;
            this.btnMyanmar.Text = "Myanmar";
            this.btnMyanmar.UseVisualStyleBackColor = true;
            this.btnMyanmar.Click += new System.EventHandler(this.btnMyanmar_Click);
            // 
            // pbVietnamFlag
            // 
            this.pbVietnamFlag.Image = global::UI.Properties.Resources.VietnamFlag;
            this.pbVietnamFlag.Location = new System.Drawing.Point(648, 158);
            this.pbVietnamFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbVietnamFlag.Name = "pbVietnamFlag";
            this.pbVietnamFlag.Size = new System.Drawing.Size(100, 50);
            this.pbVietnamFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVietnamFlag.TabIndex = 8;
            this.pbVietnamFlag.TabStop = false;
            // 
            // pbBritishFlag
            // 
            this.pbBritishFlag.Image = global::UI.Properties.Resources.BritishFlag;
            this.pbBritishFlag.Location = new System.Drawing.Point(337, 158);
            this.pbBritishFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBritishFlag.Name = "pbBritishFlag";
            this.pbBritishFlag.Size = new System.Drawing.Size(100, 50);
            this.pbBritishFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBritishFlag.TabIndex = 7;
            this.pbBritishFlag.TabStop = false;
            // 
            // pbMyanmarFlag
            // 
            this.pbMyanmarFlag.Image = global::UI.Properties.Resources.Myanmar_flag;
            this.pbMyanmarFlag.Location = new System.Drawing.Point(487, 158);
            this.pbMyanmarFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMyanmarFlag.Name = "pbMyanmarFlag";
            this.pbMyanmarFlag.Size = new System.Drawing.Size(100, 50);
            this.pbMyanmarFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMyanmarFlag.TabIndex = 6;
            this.pbMyanmarFlag.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::UI.Properties.Resources.Locomotive_Train_Transportation_Logo1;
            this.pbLogo.Location = new System.Drawing.Point(28, 74);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(252, 262);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbVietnamFlag);
            this.Controls.Add(this.pbBritishFlag);
            this.Controls.Add(this.pbMyanmarFlag);
            this.Controls.Add(this.btnMyanmar);
            this.Controls.Add(this.btnVietnamese);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSelectLanguage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SelectLanguageForm";
            this.Text = "SelectLanguageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbVietnamFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBritishFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyanmarFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnVietnamese;
        private System.Windows.Forms.Button btnMyanmar;
        private System.Windows.Forms.PictureBox pbMyanmarFlag;
        private System.Windows.Forms.PictureBox pbBritishFlag;
        private System.Windows.Forms.PictureBox pbVietnamFlag;
        private System.Windows.Forms.Button btnCancel;
    }
}