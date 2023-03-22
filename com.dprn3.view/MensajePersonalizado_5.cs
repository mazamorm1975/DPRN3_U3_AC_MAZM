﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class MensajePersonalizado_5 : Form
    {
        public MensajePersonalizado_5()
        {
            InitializeComponent();
        }

        public Image MensajeIcono
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        public String Mensaje
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MensajePersonalizado_Load(object sender, EventArgs e)
        {

        }
    }
}
