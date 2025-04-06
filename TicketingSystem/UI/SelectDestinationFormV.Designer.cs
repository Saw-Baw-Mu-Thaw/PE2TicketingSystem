namespace UI
{
    partial class SelectDestinationFormV
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
            this.btnCancelV = new System.Windows.Forms.Button();
            this.btnThuDuc = new System.Windows.Forms.Button();
            this.btnOperaHouse = new System.Windows.Forms.Button();
            this.btnBenThanhV = new System.Windows.Forms.Button();
            this.lblSelectDestinationV = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelV
            // 
            this.btnCancelV.Location = new System.Drawing.Point(638, 352);
            this.btnCancelV.Name = "btnCancelV";
            this.btnCancelV.Size = new System.Drawing.Size(127, 43);
            this.btnCancelV.TabIndex = 14;
            this.btnCancelV.Text = "Hủy";
            this.btnCancelV.UseVisualStyleBackColor = true;
            this.btnCancelV.Click += new System.EventHandler(this.btnCancelV_Click);
            // 
            // btnThuDuc
            // 
            this.btnThuDuc.Location = new System.Drawing.Point(392, 276);
            this.btnThuDuc.Name = "btnThuDuc";
            this.btnThuDuc.Size = new System.Drawing.Size(214, 67);
            this.btnThuDuc.TabIndex = 13;
            this.btnThuDuc.Text = "Thu Duc";
            this.btnThuDuc.UseVisualStyleBackColor = true;
            // 
            // btnOperaHouse
            // 
            this.btnOperaHouse.Location = new System.Drawing.Point(392, 203);
            this.btnOperaHouse.Name = "btnOperaHouse";
            this.btnOperaHouse.Size = new System.Drawing.Size(214, 67);
            this.btnOperaHouse.TabIndex = 12;
            this.btnOperaHouse.Text = "Opera House";
            this.btnOperaHouse.UseVisualStyleBackColor = true;
            // 
            // btnBenThanhV
            // 
            this.btnBenThanhV.Location = new System.Drawing.Point(392, 126);
            this.btnBenThanhV.Name = "btnBenThanhV";
            this.btnBenThanhV.Size = new System.Drawing.Size(214, 67);
            this.btnBenThanhV.TabIndex = 11;
            this.btnBenThanhV.Text = "Bến Thành Station";
            this.btnBenThanhV.UseVisualStyleBackColor = true;
            // 
            // lblSelectDestinationV
            // 
            this.lblSelectDestinationV.AutoSize = true;
            this.lblSelectDestinationV.Location = new System.Drawing.Point(356, 69);
            this.lblSelectDestinationV.Name = "lblSelectDestinationV";
            this.lblSelectDestinationV.Size = new System.Drawing.Size(320, 25);
            this.lblSelectDestinationV.TabIndex = 9;
            this.lblSelectDestinationV.Text = "Vui lòng chọn điểm đến của bạn";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbLogo.Image = global::UI.Properties.Resources.Locomotive_Train_Transportation_Logo1;
            this.pbLogo.Location = new System.Drawing.Point(36, 55);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(273, 279);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // SelectDestinationFormV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelV);
            this.Controls.Add(this.btnThuDuc);
            this.Controls.Add(this.btnOperaHouse);
            this.Controls.Add(this.btnBenThanhV);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSelectDestinationV);
            this.Name = "SelectDestinationFormV";
            this.Text = "SelectDestinationFormV";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelV;
        private System.Windows.Forms.Button btnThuDuc;
        private System.Windows.Forms.Button btnOperaHouse;
        private System.Windows.Forms.Button btnBenThanhV;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSelectDestinationV;
    }
}