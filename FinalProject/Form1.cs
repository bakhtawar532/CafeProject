﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 0)
                label1.Text = "Loading......";
            if (a == 10)
                label1.Text = "Loading Coffee Shop Manegement System.......";
            if (a == 20)
                label1.Text = "Please Wait.......!";
            if (a == 30)
                label1.Text = "Loading Coffee Shop Manegement System.........";
            if (a == 40)
                label1.Text = "Please Wait.............!";
            if (a == 50)
                label1.Text = "Loading.........";
            if (a == 60)
                label1.Text = "Loading Coffee Shop Manegement System.........";
            if (a == 70)
                label1.Text = "Please Wait.....!";
            if (a == 80)
                label1.Text = "Loading Coffee Shop Manegemnt System.......";
            if (a == 90)
                label1.Text = "Almost Done....";
            if (a == 95)
                label1.Text = "Done!";
            //a++;
            a += 1;
            if(a >= 100)
            {
                this.Hide();
                timer1.Enabled = false;
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
            }
            progressBar1.Value = a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
