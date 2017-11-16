using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Bunifu.Framework;
namespace Material_Todo_Firebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int poss = 10;
        public void additem(string Text, string Key, bool Checked)
        {
            todo_item item = new todo_item(Text, Key, Checked);
            panel2.Controls.Add(item);
            item.onChange += Item_onChange;
            item.onDelete += Item_onDelete;

            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }

        private void Item_onChange(object sender, EventArgs e)
        {
            MessageBox.Show("Change");

        }
        private void Item_onDelete(object sender, EventArgs e)
        {
            MessageBox.Show("Delete");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            additem(txt.Text, "0", true);
            txt.Text = string.Empty;
        }
    }
}
