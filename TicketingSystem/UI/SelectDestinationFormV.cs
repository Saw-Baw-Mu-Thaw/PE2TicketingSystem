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
    public partial class SelectDestinationFormV: Form
    {
        public SelectDestinationFormV()
        {
            InitializeComponent();
        }

        private void btnCancelV_Click(object sender, EventArgs e)
        {
            CancelTransactionForm cancelForm = new CancelTransactionForm();
            cancelForm.Show();
            this.Hide();
        }

        private void btnBenThanhV_Click(object sender, EventArgs e)
        {
            SelectOptionFormV so = new SelectOptionFormV();
            so.Show();
            this.Hide();
        }

        private void btnOperaHouse_Click(object sender, EventArgs e)
        {
            SelectOptionFormV so = new SelectOptionFormV();
            so.Show();
            this.Hide();
        }

        private void btnThuDuc_Click(object sender, EventArgs e)
        {
            SelectOptionFormV so = new SelectOptionFormV();
            so.Show();
            this.Hide();
        }
    }
}
