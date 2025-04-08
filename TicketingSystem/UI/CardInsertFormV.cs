using BLL;
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
        private readonly TicketBLL service;
        private System.Windows.Forms.Timer timer = new Timer();
        private string paymentMethod = "";
        private int destId;
        private int amount = 50_000;
        private string res;

        public CardInsertFormV(string paymentMethod, int destId)
        {
            this.paymentMethod = paymentMethod;
            this.destId = destId;
            service = new TicketBLL();
            InitializeComponent();

        }

        public CardInsertFormV()
        {
            InitializeComponent();
        }

        private void CardInsertFormV_Load(object sender, EventArgs e)
        {
            res = service.BuyTicket(destId, paymentMethod, amount);
            timer.Interval = 7000;
            if (res.Contains("Insufficient"))
            {
                timer.Tick += new EventHandler(showError);
            }
            else
            {
                timer.Tick += new EventHandler(changeForms);
            }

            timer.Start();
        }

        private void changeForms(object o, EventArgs e)
        {
            PaymentSuccessfulFormV psf = new PaymentSuccessfulFormV();
            psf.Show();
            timer.Stop();
            this.Hide();
        }

        private void showError(object o, EventArgs e)
        {
            ErrorFormV ef = new ErrorFormV();
            ef.Show();
            timer.Stop();
            this.Hide();
        }
    }
}
