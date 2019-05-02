using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timmy
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 네이버관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 구글ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void okbtn_Click(object sender, EventArgs e)
        {

            String[] arr = new String[3];

                    arr[0] = site.Text;
                    arr[1] = ID.Text;
                    arr[2] = PW.Text;
                    ListViewItem lvt = new ListViewItem(arr);
                    //listView1.Items.Add(lvt);
                    site.Text = "";
                    ID.Text = "";
                    PW.Text = "";

        }

        private void delebtn_Click(object sender, EventArgs e)
        {
            /*
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(index);
                MessageBox.Show("삭제되었습니다");
            }
            else
            {
                MessageBox.Show("항목을 선택하세요");
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main = new MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
