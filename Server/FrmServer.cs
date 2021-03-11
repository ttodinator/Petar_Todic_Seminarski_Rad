﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            //s = new Server();
            //s.Start();
            btnStartServer.Enabled = false;
            lblStatus.Text = "Server je iskljucen";
            lblStatus.ForeColor = Color.Red;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;
                s.Zaposlenis.ListChanged += Zaposlenis_ListChanged;
                lblStatus.Text = "Server je ukljucen";
                lblStatus.ForeColor = Color.Green;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Zaposlenis_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgvZaposleni.Invoke(new Action(() => dgvZaposleni.DataSource = s.Zaposlenis.ToList()));
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            s.Stop();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            lblStatus.Text = "Server je iskljucen";
            lblStatus.ForeColor = Color.Red;
        }
    }
}
