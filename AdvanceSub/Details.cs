using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test = AdvanceSub.cn.com.sngoo.app8;


namespace AdvanceSub
{
    public partial class Details : Form
    {

        private string GoodsNo;
        private List<Test.GoodsOrderInfo> newList=new List<Test.GoodsOrderInfo>();
        Test.database SQL = new Test.database();
        public Details(string GoodsNo)
        {
            InitializeComponent();
            this.GoodsNo = GoodsNo;
            newList = SQL.getGoodsOrderInfo(GoodsNo).ToList() ;

            for(int i=0;i<newList.Count;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["GoodsName"].Value = newList[i].GoodsName;
                dataGridView1.Rows[i].Cells["GoodsNum"].Value = newList[i].GoodsNum;
            }


        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
