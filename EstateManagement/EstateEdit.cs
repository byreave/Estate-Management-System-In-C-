using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using DAL;

namespace EstateManagement
{
    public partial class EstateEdit : Form
    {
        private bool isEdit;//判断是否是编辑模式
        private string eid;
        public EstateEdit(bool isedit)
        {
            isEdit = isedit;
            InitializeComponent();
        }

        public EstateEdit(bool isedit, string e)
        {
            isEdit = isedit;
            eid = e;
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            Estate est = new Estate();
            if(txtName.Text == "")
            {
                MessageBox.Show("资产名字不能为空！");
                txtName.Focus();
                return;
            }
            est.EstateName = txtName.Text;

            if(comType.Text == "")
            {
                MessageBox.Show("资产类型不能为空！");
                return;
            }
            est.TypeBID = EstateOperation.GetTypeBIDByName(comType.Text);

            if(txtModel.Text == "")
            {
                MessageBox.Show("资产型号不能为空！");
                txtModel.Focus();
                return;
            }
            est.Model = txtModel.Text;

            if(txtPrice.Text == "")
            {
                MessageBox.Show("输入资产价值！");
                txtPrice.Focus();
                return;
            }
            try
            {
                est.Price = Convert.ToDouble(txtPrice.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            string pdate = purDate.Value.ToShortDateString();
            pdate = pdate.Replace('/', '-'); //转换为 xxxx-xx-xx 格式

            est.PurchaseDate = pdate;

            if(comStatus.Text == "")
            {
                MessageBox.Show("选择一个状态！");
                return;
            }
            est.Status = comStatus.Text;

            est.Comment = txtComm.Text;

            if(isEdit)
            {
                EstateOperation.EstateEdit(est, eid);
                MessageBox.Show("修改成功!");
                Close();
            }
            else
            {
                EstateOperation.EstateAdd(est);
                MessageBox.Show("添加成功！");
                Close();
            }
        }

        private void EstateEdit_Load(object sender, EventArgs e)
        {
            DataSet ds = EstateOperation.GetAllTypeB();
            comType.DataSource = ds.Tables[0];
            comType.DisplayMember = ds.Tables[0].Columns["TypeBName"].ToString();
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
