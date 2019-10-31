using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWindowsFormsApp.BLL.BLL;
using MyWindowsFormsApp.Model.Model;

namespace MyWindowsFormsApp
{
    public partial class OrderUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public OrderUi()
        {
            InitializeComponent();
        }

        private void OrderUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Display();
        }
    }
}
