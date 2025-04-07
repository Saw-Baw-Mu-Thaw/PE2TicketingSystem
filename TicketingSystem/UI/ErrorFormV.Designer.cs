namespace UI
{
    partial class ErrorFormV
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RetryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(33, 365);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(119, 45);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Text = "Hủy bỏ";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // RetryBtn
            // 
            this.RetryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryBtn.Location = new System.Drawing.Point(461, 214);
            this.RetryBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RetryBtn.Name = "RetryBtn";
            this.RetryBtn.Size = new System.Drawing.Size(133, 74);
            this.RetryBtn.TabIndex = 36;
            this.RetryBtn.Text = "Thử lại";
            this.RetryBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 105);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chúng tôi đã gặp phải một vấn đề";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::UI.Properties.Resources.Locomotive_Train_Transportation_Logo1;
            this.pbLogo.Location = new System.Drawing.Point(33, 40);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(261, 276);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 34;
            this.pbLogo.TabStop = false;
            // 
            // ErrorFormV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RetryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ErrorFormV";
            this.Text = "Error";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RetryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}