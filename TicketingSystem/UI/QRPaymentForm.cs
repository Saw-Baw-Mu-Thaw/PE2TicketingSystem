﻿using BLL;
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

        private int amount = 50_000;
        private string res;
        private readonly TicketBLL service;

        private string paymentMethod = "";
        private int destId;

        public QRPayment(string paymentMethod, int destId)
        {
            this.paymentMethod = paymentMethod;
            this.destId = destId;
            service = new TicketBLL();
            InitializeComponent();
        }

        public QRPayment()
        {
            InitializeComponent();
        }

        private void QRPayment_Load(object sender, EventArgs e)
        {
            // after 7 seconds it will go to success screen
            res = service.BuyTicket(destId, paymentMethod, amount);
            timer.Interval = 7000;
            if (res.Contains("Insufficient"))
            {
                timer.Tick += new EventHandler(showError);
            }
            else
            {
                timer.Tick += new EventHandler(changeForm);
            }
                
            timer.Start();
        }

        private void changeForm(object source, EventArgs e)
        {
            PaymentSuccessfulForm psf = new PaymentSuccessfulForm();
            psf.Show();
            timer.Stop();
            this.Hide();
        }

        private void showError(object o, EventArgs e)
        {
            ErrorForm ef = new ErrorForm();
            ef.Show();
            timer.Stop();
            this.Hide();
        }
    }
}
