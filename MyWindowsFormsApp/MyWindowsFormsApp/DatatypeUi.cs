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
    public partial class DatatypeUi : Form
    {
        public DatatypeUi()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //int age=0;
            //string name = "Asad";
            //double salary = 500.50;
            //bool isDone = true;

            //string name = "ali";

            //int firstNumber = 10;
            //int secondNumber = firstNumber;
            //double thirdNumber = firstNumber;

            //secondNumber = (int)thirdNumber;
            //secondNumber = Convert.ToInt32(thirdNumber);

            //name = Convert.ToString(secondNumber);
            //name = secondNumber.ToString();

            if (itemComboBox.Text == "")
            {
                MessageBox.Show("Select item");
            }
            else {
                MessageBox.Show(itemComboBox.Text + " is selected");
            }



        }
    }
}
