namespace UI
{
    partial class SelectDestinationForm
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
            this.lblSelectDestination = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnBenThanh = new System.Windows.Forms.Button();
            this.btnOperaHouse = new System.Windows.Forms.Button();
            this.btnThuDuc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectDestination
            // 
            this.lblSelectDestination.AutoSize = true;
            this.lblSelectDestination.Location = new System.Drawing.Point(308, 82);
            this.lblSelectDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDestination.Name = "lblSelectDestination";
            this.lblSelectDestination.Size = new System.Drawing.Size(177, 20);
            this.lblSelectDestination.TabIndex = 0;
            this.lblSelectDestination.Text = "Select Your Destination";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::UI.Properties.Resources.Locomotive_Train_Transportation_Logo1;
            this.pbLogo.Location = new System.Drawing.Point(44, 78);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(205, 223);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnBenThanh
            // 
            this.btnBenThanh.Location = new System.Drawing.Point(311, 135);
            this.btnBenThanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBenThanh.Name = "btnBenThanh";
            this.btnBenThanh.Size = new System.Drawing.Size(160, 54);
            this.btnBenThanh.TabIndex = 5;
            this.btnBenThanh.Text = "Ben Thanh Station";
            this.btnBenThanh.UseVisualStyleBackColor = true;
            // 
            // btnOperaHouse
            // 
            this.btnOperaHouse.Location = new System.Drawing.Point(311, 197);
            this.btnOperaHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOperaHouse.Name = "btnOperaHouse";
            this.btnOperaHouse.Size = new System.Drawing.Size(160, 54);
            this.btnOperaHouse.TabIndex = 6;
            this.btnOperaHouse.Text = "Opera House";
            this.btnOperaHouse.UseVisualStyleBackColor = true;
            // 
            // btnThuDuc
            // 
            this.btnThuDuc.Location = new System.Drawing.Point(311, 255);
            this.btnThuDuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuDuc.Name = "btnThuDuc";
            this.btnThuDuc.Size = new System.Drawing.Size(160, 54);
            this.btnThuDuc.TabIndex = 7;
            this.btnThuDuc.Text = "Thu Duc";
            this.btnThuDuc.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(496, 316);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectDestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThuDuc);
            this.Controls.Add(this.btnOperaHouse);
            this.Controls.Add(this.btnBenThanh);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSelectDestination);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectDestinationForm";
            this.Text = "Select Destination";
            this.Load += new System.EventHandler(this.SelectDestinationFormEng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDestination;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBenThanh;
        private System.Windows.Forms.Button btnOperaHouse;
        private System.Windows.Forms.Button btnThuDuc;
        private System.Windows.Forms.Button btnCancel;
    }
}