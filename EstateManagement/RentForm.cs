using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace EstateManagement
{
    public partial class RentForm : Form
    {
        string admin;
        public RentForm(string a)
        {
            admin = a;
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Skins//Longhorn.ssk";
            //设置在其他界面中的效果同步
            Sunisoft.IrisSkin.SkinEngine skinEngine = null;
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            refresh();
        }
        /// <summary>
        /// 刷新正在租出的资产列表
        /// </summary>
        private void refresh()
        {
            DataSet ds = EstateOperation.GetAllRentEstate();
            dgvRent.DataSource = ds.Tables[0].DefaultView;
        }
        /// <summary>
        /// 根据数据源刷新
        /// </summary>
        /// <param name="ds"></param>
        private void refresh(DataSet ds)
        {
            dgvRent.DataSource = ds.Tables[0].DefaultView;

        }
        private void srchBtn_Click(object sender, EventArgs e)
        {
            string keyword = txtSrch.Text;
            if(keyword == "")
            {
                MessageBox.Show("输入资产ID！");
                txtSrch.Focus();
                return;
            }
            DataSet ds = EstateOperation.GetRentEstateByID(keyword);
            refresh(ds);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void retBtn_Click(object sender, EventArgs e)
        {
            string rentID = dgvRent.SelectedCells[0].Value.ToString();
            if (rentID == "")
            {
                MessageBox.Show("选择一个要归还的资产！");
                return;
            }
            string retdate = returnDate.Value.ToShortDateString();
            retdate = retdate.Replace('/', '-'); //转换为 xxxx-xx-xx 格式
            EstateOperation.EstateReturn(rentID, retdate, admin);
            refresh();
            MessageBox.Show("归还成功");
        }
    }
}
