﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            settings1.Hide();
           // add_patient_user_control1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
