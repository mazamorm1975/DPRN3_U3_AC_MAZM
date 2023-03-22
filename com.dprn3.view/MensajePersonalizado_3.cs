﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace DPRNIII_U2_A1_MAZM
{
    public partial class MensajePersonalizado_3 : Form
    {
        public MensajePersonalizado_3()
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

        private void MensajePersonalizado_3_Load(object sender, EventArgs e)
        {

        }
    }
}
