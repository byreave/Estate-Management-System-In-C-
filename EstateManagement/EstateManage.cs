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
    public partial class EstateManage : Form
    {
        string admin;
        public EstateManage(string a)
        {
            admin = a;
            InitializeComponent();
        }

        private void EstateManage_Load(object sender, EventArgs e)
        {
            //初始化列表
            refreshEstate();
            refreshUser();
        }
        /// <summary>
        /// 刷新列表
        /// </summary>
        private void refreshEstate()
        {
            DataSet ds = EstateOperation.GetAllEstate();
            dgvEstate.DataSource = ds.Tables[0].DefaultView;
        }
        /// <summary>
        /// 根据数据源刷新资产列表
        /// </summary>
        /// <param name="ds"></param>
        private void refreshEstate(DataSet ds)
        {
            dgvEstate.DataSource = ds.Tables[0].DefaultView;
        }
        /// <summary>
        /// 刷新人员
        /// </summary>
        private void refreshUser()
        {
            DataSet ds = UserOperation.GetAllUser();
            dgvUser.DataSource = ds.Tables[0].DefaultView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estAddBtn_Click(object sender, EventArgs e)
        {
            EstateEdit ee = new EstateEdit(false);
            ee.Show();
        }

        private void estEditBtn_Click(object sender, EventArgs e)
        {
            string editID = dgvEstate.SelectedCells[0].Value.ToString();
            if (editID == "")
            {
                MessageBox.Show("选择一个编辑的资产！");
                return;
            }
            EstateEdit ee = new EstateEdit(true, editID);
            ee.Show();
        }

        private void usrAddBtn_Click(object sender, EventArgs e)
        {
            UserEdit ue = new UserEdit(false);
            ue.Show();
        }

        private void usrEditBtn_Click(object sender, EventArgs e)
        {
            string editID = dgvUser.SelectedCells[0].Value.ToString();
            if(editID == "")
            {
                MessageBox.Show("选择一个编辑的用户！");
                return;
            }
            UserEdit ue = new UserEdit(true, editID);
            ue.Show();
        }

        private void estDelBtn_Click(object sender, EventArgs e)
        {
            string delID = dgvEstate.SelectedCells[0].Value.ToString();
            if (delID == "")
            {
                MessageBox.Show("选择一个要删除的资产！", "注意");
                return;
            }
            EstateOperation.EstateDelete(delID);
            refreshEstate();
        }

        private void usrDelBtn_Click(object sender, EventArgs e)
        {
            string delID = dgvUser.SelectedCells[0].Value.ToString();
            if (delID == "")
            {
                MessageBox.Show("选择一个要删除的人员！", "注意");
                return;
            }
            UserOperation.UserDelete(delID);
            refreshUser();
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            TypeManager tm = new TypeManager();
            tm.Show();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            string outID = dgvEstate.SelectedCells[0].Value.ToString();
            if (outID == "")
            {
                MessageBox.Show("选择一个要出租的资产！", "注意");
                return;
            }

            EstateOut eo = new EstateOut(outID, admin);
            eo.Show();
        }

        private void retBtn_Click(object sender, EventArgs e)
        {
            RentForm rf = new RentForm(admin);
            rf.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ReturnRecord rr = new ReturnRecord();
            rr.Show();
        }

        private void srchBtn_Click(object sender, EventArgs e)
        {
            string srchText = txtSrch.Text;
            if(srchText == "")
            {
                MessageBox.Show("输入要搜索的内容！");
                txtSrch.Focus();
                return;
            }
            int srchType = comSrchType.SelectedIndex; //得到搜索类型 按照combox里面的引索
            switch(srchType) //0大类 1小类 2人员 3资产编号
            {
                case -1:
                    MessageBox.Show("请选择一个搜索类型！");
                    comSrchType.Focus();
                    return;
                case 0:
                    DataSet ds = EstateOperation.GetAllEstateByCatagory(srchText, 'A');
                    refreshEstate(ds);
                    break;
                case 1:
                    DataSet ds1 = EstateOperation.GetAllEstateByCatagory(srchText, 'B');
                    refreshEstate(ds1);
                    break;
                case 2:
                    DataSet ds2 = EstateOperation.GetEstateByUser(srchText);
                    refreshEstate(ds2);
                    break;
                case 3:
                    DataSet ds3 = EstateOperation.GetEstateByID(srchText);
                    refreshEstate(ds3);
                    break;
                default:
                    break;
            }
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            refreshEstate();
            refreshUser();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(admin);
            cp.Show();
        }

        

        
    }
}
