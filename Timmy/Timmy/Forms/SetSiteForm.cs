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
    public partial class SetSiteForm : Form
    {
        IList<Site> list;
        public SetSiteForm()
        {
            this.list = Mapper.Instance().QueryForList<Site>("SelectSite", null);
            InitializeComponent();
        }

        private void dgvSite_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex;
            selectedRowIndex = dgvSite.CurrentCell.RowIndex;
            cbxSite.Text = dgvSite.Rows[selectedRowIndex].Cells[0].Value.ToString();
            tbxUrl.Text = dgvSite.Rows[selectedRowIndex].Cells[1].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Site site = new Site();

                site.siteName = cbxSite.Text;
                site.url = tbxUrl.Text;

                Mapper.Instance().Insert("setSiteIns", site);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cbxSite.Text = "";
                tbxUrl.Text = "";
                list = Mapper.Instance().QueryForList<Site>("SelectSite", null);
                dgvSite.DataSource = list;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                Site site = new Site();

                site.siteName = cbxSite.Text;
                site.url = tbxUrl.Text;

                Mapper.Instance().Delete("setSiteDel", site);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cbxSite.Text = "";
                tbxUrl.Text = "";
                list = Mapper.Instance().QueryForList<Site>("SelectSite", null);
                dgvSite.DataSource = list;
            }
        }

        private void SetSiteForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSite.DataSource = list;
                dgvSite.Columns[0].HeaderText = "사이트";
                dgvSite.Columns[1].HeaderText = "URL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void SetSiteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
