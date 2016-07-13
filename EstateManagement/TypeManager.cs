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
    public partial class TypeManager : Form
    {
        public TypeManager()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void refreshTypeA()
        {
            DataSet ds = EstateOperation.GetAllTypeA();
            dgvTypeA.DataSource = ds.Tables[0].DefaultView;
        }
        private void refreshTypeB(string typeA)
        {
            DataSet ds = EstateOperation.GetTypeBByTypeA(typeA);
            dgvTypeB.DataSource = ds.Tables[0].DefaultView;
        }
        private void TypeAAddBtn_Click(object sender, EventArgs e)
        {
            if(txtType.Text == "")
            {
                MessageBox.Show("输入一个名称！");
                txtType.Focus();
                return;
            }
            EstateOperation.EstateTypeAAdd(txtType.Text);
            MessageBox.Show("添加成功！");
            refreshTypeA();
        }

        private void TypeManager_Load(object sender, EventArgs e)
        {
            DataSet dsA = EstateOperation.GetAllTypeA();
            dgvTypeA.DataSource = dsA.Tables[0].DefaultView;
            DataSet ds = EstateOperation.GetAllTypeA();
            comTypeB.DataSource = ds.Tables[0];
            comTypeB.DisplayMember = ds.Tables[0].Columns["TypeAName"].ToString();
        }

        private void TypeBAddBtn_Click(object sender, EventArgs e)
        {
            if(comTypeB.Text == "")
            {
                MessageBox.Show("选择一个大类");
                return;
            }
            if(txtType.Text == "")
            {
                MessageBox.Show("添加一个名字");
                txtType.Focus();
                return;
            }
            EstateOperation.EstateTypeBAdd(comTypeB.Text, txtType.Text);
            MessageBox.Show("添加成功！");
            refreshTypeB(comTypeB.Text);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            string str = dgvTypeA.SelectedCells[0].Value.ToString();
            string strB = dgvTypeB.SelectedCells[0].Value.ToString();
            if(str != "" && strB == "")
            {
                EstateOperation.TypeADelete(str);
                MessageBox.Show("删除大类成功");
                refreshTypeA();
            }
            else if(strB != "" && str != "" )
            {
                EstateOperation.TypeBDelete(strB);
                MessageBox.Show("删除小类成功");
                refreshTypeB(str);
            }
            else
            {
                MessageBox.Show("失败!");
                return;
            }
        }

        private void dgvTypeA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshTypeB(dgvTypeA.SelectedCells[0].Value.ToString());
        }
    }
}
