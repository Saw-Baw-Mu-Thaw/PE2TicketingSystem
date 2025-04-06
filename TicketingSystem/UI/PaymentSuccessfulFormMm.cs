﻿using System;
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
    public partial class PaymentSuccessfulFormMm: Form
    {
        private System.Windows.Forms.Timer timer = new Timer();

        public PaymentSuccessfulFormMm()
        {
            InitializeComponent();
        }

        private void PaymentSuccessfulFormMm_Load(object sender, EventArgs e)
        {
            timer.Interval = 7000;
            timer.Tick += new EventHandler(goToMain);
            timer.Start();
        }

        private void goToMain(object o, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            timer.Stop();
            this.Hide();
        }
    }
}
