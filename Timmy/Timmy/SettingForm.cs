using IBatisNet.DataMapper;
using IBatisNet.Common;
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
        IList<Login> list;
        public SettingForm()
        {
            this.list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLogin.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.siteName = site.Text;
                login.id = ID.Text;
                login.pw = PW.Text;
                
                Mapper.Instance().Insert("setLoginIns", login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                site.Text = "";
                ID.Text = "";
                PW.Text = "";
                list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
                dgvLogin.DataSource = list;
            }
            

        }

        private void delebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.siteName = site.Text;
                login.id = ID.Text;
                login.pw = PW.Text;

                Mapper.Instance().Delete("setLoginDel", login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                site.Text = "";
                ID.Text = "";
                PW.Text = "";
                list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
                dgvLogin.DataSource = list;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main = new MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);
            main.Show();
        }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex;
            selectedRowIndex = dgvLogin.CurrentCell.RowIndex;
            site.Text = dgvLogin.Rows[selectedRowIndex].Cells[0].Value.ToString();
            ID.Text = dgvLogin.Rows[selectedRowIndex].Cells[1].Value.ToString();
            PW.Text = dgvLogin.Rows[selectedRowIndex].Cells[2].Value.ToString();
        }
    }
}
