using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lisbox_Name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstname.Items.Add(txtname.Text);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            lstname.Items.Add(txtname.Text);
            txtname.Text = "";
            txtname.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (lstname.SelectedIndex < 0)
            {
                MessageBox.Show("hãy chọn tên trong danh sách", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstname.Items[lstname.SelectedIndex] = txtname.Text;
            }

        private void lstname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstname.SelectedIndex < 0)
            {

               
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            lstname.Items.RemoveAt(lstname.SelectedIndex);
        }

       

        private void btninsert_Click(object sender, EventArgs e)
        {
            lstname.Items.Insert(Convert.ToInt32(txtIndex.Text), txtname.Text);
        }
    }
}
