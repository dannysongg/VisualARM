﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vano.Tools.Azure.Dialogs
{
    public partial class InfoDialog : Form
    {
        public InfoDialog()
        {
            InitializeComponent();
        }

        private void doogFoodPortalLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://df.onecloud.azure-test.net/");
        }
    }
}
