﻿// App Name : Race Form
// Author's Name : Kinjal Patel 
// Student ID : 200334364
// App Creation Date : February 22, 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334364
{
    public partial class RaceForm : Form
    {
        public Form previousForm;
        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();

            jobForm.previosForm = this;
            jobForm.Show();
            this.Hide();
        }
    }
}
