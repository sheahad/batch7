using System;
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
    public partial class ArrayUi : Form
    {
        int[] element = new int[10];
        int size = 0;
        int index = 0;
        public ArrayUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string message = "";
            for (int i = 0; i < size; i++)
            {
                message += " " + element[i];
            }

            MessageBox.Show("Elemens are: " + message);


        }

        private void addSizeButton_Click(object sender, EventArgs e)
        {
            size =Convert.ToInt32(sizeTextBox.Text);
        }

        private void addElementButton_Click(object sender, EventArgs e)
        {
            element[index] = Convert.ToInt32(elementTextBox.Text);
            index++;
        }
    }
}
