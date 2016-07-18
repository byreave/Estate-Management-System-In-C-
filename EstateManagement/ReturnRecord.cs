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
    public partial class ReturnRecord : Form
    {
        public ReturnRecord()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Skins//Longhorn.ssk";
            //设置在其他界面中的效果同步
            Sunisoft.IrisSkin.SkinEngine skinEngine = null;
            skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            skinEngine.SkinAllForm = true;
        }

        private void ReturnRecord_Load(object sender, EventArgs e)
        {
            DataSet ds = EstateOperation.GetAllReturnEstate();
            dgvReturn.DataSource = ds.Tables[0].DefaultView;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            string keyword = txtSrch.Text;
            if(keyword == "")
            {
                MessageBox.Show("输入查找的关键字");
                txtSrch.Focus();
                return;
            }

            DataSet ds = EstateOperation.GetReturnEstateByID(keyword);
            dgvReturn.DataSource = ds.Tables[0].DefaultView;
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = EstateOperation.GetAllReturnEstate();
            dgvReturn.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
