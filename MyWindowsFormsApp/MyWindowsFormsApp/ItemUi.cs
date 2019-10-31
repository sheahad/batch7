﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyWindowsFormsApp.Model.Model;
using MyWindowsFormsApp.BLL.BLL;

namespace MyWindowsFormsApp
{
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            Item item = new Item();


            item.Name = nameTextBox.Text;
            
            //Check UNIQUE
            if (_itemManager.IsNameExists(item))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            item.Price = Convert.ToDouble(priceTextBox.Text);
            
            //Add/Insert Item
            bool isAdded = _itemManager.Add(item);

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            
            {
                MessageBox.Show("Not Saved");
            }

            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Display();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            //Set Id as Mandatory
            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("Id Can not be Empty!!!");
            //    return;
            //}

            MessageBox.Show("Name: " + itemComboBox.Text + " Id: "+ itemComboBox.SelectedValue);
            
            //Delete
            if (_itemManager.Delete(Convert.ToInt32(itemComboBox.SelectedValue)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            showDataGridView.DataSource = _itemManager.Display();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.Search(nameTextBox.Text);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_itemManager.Update(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
                showDataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void ItemUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _itemManager.ItemCombo();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            ListUi listUi = new ListUi("Asif",10);
            listUi.Show();
            this.Hide();
        }
    }
}
