﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDL_csharp
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }


        private void cate_UC_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = cate_UC.Text;
            data db = new data();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT`ItemName` FROM `foodorder` WHERE `Catagory` = '" + name + "'", db.getConnection());
            db.openConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            itmlist.DataSource = table;
            itmlist.DisplayMember = "Itemname";
            db.closeConnection();
        }

        private void rmvb_Click(object sender, EventArgs e)
        {
            data db = new data();
            String item = itmlist.SelectedValue.ToString();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `foodorder` WHERE `ItemName` = '" + item + "'", db.getConnection());
            db.openConnection();
            if (cate_UC.Text == "")
            {
                MessageBox.Show("You need to select Category First.");
            }
            else if (itmlist.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Select An Item To DELETE from the List.");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully.");
            }
            db.closeConnection();

        }

        private void edtb_Click(object sender, EventArgs e)
        {
            String itm_o = itmlist.SelectedValue.ToString();
            String cst = cst_t.Text;
            String itm = itm_t.Text;
            data db = new data();
            MySqlCommand cmd = new MySqlCommand("UPDATE `foodorder` SET `ItemName`='" + itm +"',`Cost`='" + cst + "' WHERE ItemName = '"+itm_o+"'" , db.getConnection());
            db.openConnection();

            if (itm_t.Text == "") 
            {
                MessageBox.Show("Item Name cant be empty");
            }
            else if (itmlist.SelectedValue.ToString() == itm_t.Text)
            {
                MessageBox.Show("This item is not in Records ");
            }
            else
            {
                cmd.ExecuteNonQuery();
            }
            db.closeConnection();
        }
    }
}
