using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBatisNet.DataMapper;
using IBatisNet.Common;

namespace Timmy
{
    public partial class InternetListForm : Form
    {
        public InternetListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main = new MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);
            main.Show();
        }

        private void InternetListForm_Load(object sender, EventArgs e)
        {
            try
            {
                IList<Site> list = Mapper.Instance().QueryForList<Site>("SelectSite", null);
                dgvSite.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
