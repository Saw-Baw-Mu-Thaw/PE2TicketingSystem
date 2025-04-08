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
    public partial class SelectOption: Form
    {
        private int destId;

        public SelectOption()
        {
            InitializeComponent();
        }

        public SelectOption(int destId)
        {
            this.destId = destId;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paymentMethod = "CreditCard";
            CardInsertForm ci = new CardInsertForm(paymentMethod,destId);
            ci.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string paymentMethod = "QR";
            QRPayment qr = new QRPayment(paymentMethod, destId);
            qr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelTransactionForm cf = new CancelTransactionForm();
            cf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SelectOption_Load(object sender, EventArgs e)
        {

        }
    }
}
