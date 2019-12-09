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
using Timmy.ClassFile;

namespace Timmy.Forms
{
    public partial class SetLoginForm : Form
    {
        IList<Login> list;
        Login selectedLogin = new Login();
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
            this.selectedLogin.siteName = cbxSite.Text;
            this.selectedLogin.id = tbxId.Text;
            this.selectedLogin.pw = tbxPw.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();

                login.siteName = cbxSite.Text;
                login.id = tbxId.Text;
                login.pw = tbxPw.Text;
                
                if(this.selectedLogin.siteName == null)
                {
                    this.selectedLogin = Mapper.Instance().QueryForObject<Login>("SelectSiteLogin", login.siteName);
                }
                else
                {
                    this.selectedLogin = Mapper.Instance().QueryForObject<Login>("SelectSiteLogin", this.selectedLogin.siteName);
                }

                Dictionary<string, Login> dic = new Dictionary<string, Login>();
                dic.Add("editLogin", login);
                dic.Add("selectedLogin", this.selectedLogin);

                if (this.selectedLogin.siteName == null)
                {
                    Mapper.Instance().Insert("setLoginIns", login);
                    MessageBox.Show("입력 완료!");
                }
                else
                {
                    Mapper.Instance().Update("setLoginUpdate", dic);
                    MessageBox.Show("수정 완료!");
                }
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
                MessageBox.Show("삭제 완료!");
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
            MainForm main = (MainForm)Singleton.getMainInstance();
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

        private void SetLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void dgvLogin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvLogin.Columns[e.ColumnIndex].Index == 2)
            {
                dgvLogin.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
