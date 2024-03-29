﻿using System;
using System.Windows.Forms;

namespace DLH
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            createButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == string.Empty || linkBox.Text == string.Empty || typeBox.SelectedIndex == -1)
            {
                MessageBox.Show("Name, Link and Type are obligatory.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
