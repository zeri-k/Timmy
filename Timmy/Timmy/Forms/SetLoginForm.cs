using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timmy.Forms
{
    public partial class SetLoginForm : Form
    {
        IList<Login> list;
        public SetLoginForm()
        {
            this.list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
            InitializeComponent();
        }

        private void dgvLogin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex;
            selectedRowIndex = dgvLogin.CurrentCell.RowIndex;
            cbxSite.Text = dgvLogin.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbxId.Text = dgvLogin.Rows[selectedRowIndex].Cells[1].Value.ToString();
            tbxPw.Text = dgvLogin.Rows[selectedRowIndex].Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.siteName = cbxSite.Text;
                login.id = tbxId.Text;
                login.pw = tbxPw.Text;

                Mapper.Instance().Insert("setLoginIns", login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cbxSite.Text = "";
                tbxId.Text = "";
                tbxPw.Text = "";
                list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
                dgvLogin.DataSource = list;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.siteName = cbxSite.Text;
                login.id = tbxId.Text;
                login.pw = tbxPw.Text;

                Mapper.Instance().Delete("setLoginDel", login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cbxSite.Text = "";
                tbxId.Text = "";
                tbxPw.Text = "";
                list = Mapper.Instance().QueryForList<Login>("SelectLogin", null);
                dgvLogin.DataSource = list;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm main = new MainForm();
            main.StartPosition = FormStartPosition.Manual;
            main.Location = new Point(300, 150);
            main.Show();
        }

        private void SetLoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvLogin.DataSource = list;
                dgvLogin.Columns[0].HeaderText = "사이트";
                dgvLogin.Columns[1].HeaderText = "아이디";
                dgvLogin.Columns[2].HeaderText = "패스워드";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
