﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class ListUi : Form
    {
        List<string> names = new List<string> { "Asad" };
        List<int> ages = new List<int> { 15 };
        public ListUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //names.Add(nameTextBox.Text);
            //ages.Add(Convert.ToInt32(ageTextBox.Text));
            try {
                if (String.IsNullOrEmpty(ageTextBox.Text))
                {
                    MessageBox.Show("Please Enter Age!");
                    return;
                    
                }
                else {
                    AddCustomer(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            
            ShowCustomer();            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private void ShowCustomer()
        {
            string message = "";
            for (int i = 0; i < names.Count(); i++)
            {
                message += "Name: " + names[i] + " Age: " + ages[i] + "\n";
            }
            MessageBox.Show(message);

            //string message = "";
            //foreach (string name in names)
            //{
            //    message += "Name: " + name +" Age: "+ ages[0]+ "\n";
            //}
            //MessageBox.Show(message);
        }
        private void AddCustomer(string name, int age)
        {
            names.Add(name);
            ages.Add(age);
        }
    }
}
