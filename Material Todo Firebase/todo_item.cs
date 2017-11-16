using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Material_Todo_Firebase
{
    public partial class todo_item : UserControl
    {
        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(string Text,string key, bool Checked)
        {
            Key = key;
            Value = Text;
            InitializeComponent();
            lbl.Text = Text;
            check.Checked = Checked;
        }

        private void check_OnChange(object sender, EventArgs e)
        {
            if (check.Checked)
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            else
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);

            if (onChange != null)
            {
                onChange.Invoke(this, new EventArgs());
            }
        }

        private void todo_item_Load(object sender, EventArgs e)
        {
            if (check.Checked)
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Strikeout);
            else
                lbl.Font = new Font(lbl.Font.Name, lbl.Font.SizeInPoints, FontStyle.Regular);

            
        }

        public event EventHandler onChange = null;
        public event EventHandler onDelete = null;

        public string Key = null;
        public string Value = null;

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (onDelete != null)
            {
                onDelete.Invoke(this, new EventArgs());
            }
        }
    }
}
