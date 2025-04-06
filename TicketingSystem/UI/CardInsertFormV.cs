using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CardInsertFormV: Form
    {
        private System.Windows.Forms.Timer timer = new Timer();

        public CardInsertFormV()
        {
            InitializeComponent();
        }

        private void CardInsertFormV_Load(object sender, EventArgs e)
        {
            timer.Interval = 7000;
            timer.Tick += new EventHandler(changeForms);
            timer.Start();
        }

        private void changeForms(object o, EventArgs e)
        {
            PaymentSuccessfulFormV psf = new PaymentSuccessfulFormV();
            psf.Show();
            timer.Stop();
            this.Hide();
        }
    }
}
