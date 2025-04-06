using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace UI
{
    public partial class QRPayment: Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public QRPayment()
        {
            InitializeComponent();
        }

        private void QRPayment_Load(object sender, EventArgs e)
        {
            // after 7 seconds it will go to success screen
            timer.Interval = 7000;
            timer.Tick += new EventHandler(changeForm);
            timer.Start();
        }

        private void changeForm(object source, EventArgs e)
        {
            PaymentSuccessfulForm psf = new PaymentSuccessfulForm();
            psf.Show();
            timer.Stop();
            this.Hide();
        }
        
    }
}
