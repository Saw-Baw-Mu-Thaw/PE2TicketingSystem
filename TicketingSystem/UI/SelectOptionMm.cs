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
    public partial class SelectOptionMm: Form
    {
        private int destId;

        public SelectOptionMm()
        {
            InitializeComponent();
        }

        public SelectOptionMm(int destId)
        {
            this.destId = destId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paymentMethod = "CreditCard";
            CardInsertFormMm ci = new CardInsertFormMm(paymentMethod,destId);
            ci.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paymentMethod = "CreditCard";
            QRPayment qr = new QRPayment(paymentMethod,destId);
            qr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelTransactionForm cf = new CancelTransactionForm();
            cf.Show();
            this.Hide();
        }
    }
}
