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
    public partial class SelectDestinationFormMm: Form
    {
        public SelectDestinationFormMm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelTransactionForm cancelForm = new CancelTransactionForm();
            cancelForm.Show();
            this.Hide();
        }

        private void btnBenThanhMm_Click(object sender, EventArgs e)
        {
            SelectOptionMm so = new SelectOptionMm();
            so.Show();
            this.Hide();
        }

        private void btnOperaHouseMm_Click(object sender, EventArgs e)
        {
            SelectOptionMm so = new SelectOptionMm();
            so.Show();
            this.Hide();
        }

        private void btnThuDucMm_Click(object sender, EventArgs e)
        {
            SelectOptionMm so = new SelectOptionMm();
            so.Show();
            this.Hide();
        }
    }
}
