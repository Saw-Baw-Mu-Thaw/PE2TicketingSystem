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
    public partial class CardInsertFormMm: Form
    {
        private System.Windows.Forms.Timer timer = new Timer();

        public CardInsertFormMm()
        {
            InitializeComponent();
        }

        private void CardInsertFormMm_Load(object sender, EventArgs e)
        {
            timer.Interval = 7000;
            timer.Tick += new EventHandler(changeForms);
            timer.Start();
        }

        private void changeForms(object o, EventArgs e)
        {
            PaymentSuccessfulFormMm psf = new PaymentSuccessfulFormMm();
            psf.Show();
            timer.Stop();
            this.Hide();
        }
    }
}
