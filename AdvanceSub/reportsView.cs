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
    public partial class reportsView : Form
    {

        List<Test.AddvanceSubInfo> list = new  List<Test.AddvanceSubInfo> ();
        Test.database SQL = new Test.database();
        
        public reportsView()
        {
            InitializeComponent();
            list = SQL.ReadSubInfo().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].AddvanceSubState == 0)
                {
                    dataGridView1.Rows.Add(list[i].id, list[i].CountTime, list[i].OrderNum,list[i].AddvanceId ,"查看详情", "预分装", "删除","");
                }
                else
                {
                    dataGridView1.Rows.Add(list[i].id, list[i].CountTime, list[i].OrderNum,list[i].AddvanceId, "查看详情", "已完成预分装", "已完成预分装","打印");
                
                }

            
            
            
            }
            
        }

        private void reportsView_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ViewDetails"&&dataGridView1.Rows[e.RowIndex].Cells["ViewDetails"].Value!="已完成预分装")
            {
                report newreport = new report();
                newreport.textBox1.Text= list[e.RowIndex].Details.ToString();
                newreport.ShowDialog();

            
            }

            //点击预分装
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AdvanceSub" && dataGridView1.Rows[e.RowIndex].Cells["AdvanceSub"].Value != "已完成预分装")
            {
                SQL.AlterSubStatus(1, Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ReportId"].Value));

                List<string> list = SQL.getOrderList(dataGridView1.Rows[e.RowIndex].Cells["AddvanceId"].Value.ToString()).ToList(); //根据预分装号获取相应的订单编号

                string[] listData = list.ToArray();

                List<Test.GoodsOrder> GoodsOrderList = new List<Test.GoodsOrder>();
               
                GoodsOrderList = SQL.getGoodsOrderListByAddvanceId(listData).ToList(); //获取详细订单信息
                
                //写入发货单号

                for (int i = 0; i < GoodsOrderList.Count; i++)
                {


                    Test.BoxInfo BoxInfo = new Test.BoxInfo();
                    BoxInfo = SQL.GetBoxInfo(GoodsOrderList[i].OrderNo);

                    if (BoxInfo.BoxGroupId != null && BoxInfo.BoxGroupOpenCode != null)  
                    {
                        int BoxGroupId = Convert.ToInt32(BoxInfo.BoxGroupId);
                        int BoxGroupOpenCode = Convert.ToInt32(BoxInfo.BoxGroupOpenCode);
                        //生成发货单号
                        string ShoppingCode = DateTime.Now.ToString("yyyyMMdd") + BoxGroupId.ToString("000") + (BoxGroupOpenCode - 1).ToString("00") + DateTime.Now.ToString("HHmmssf");

                        SQL.WriteShoppingNo(ShoppingCode, GoodsOrderList[i].OrderNo);//执行数据库接口写入发货单号
                    }
                        
                    
                     
                
                }



                    SQL.alterGoodsOrderShoppingState(1, listData);//变更订单状态为打包中
                
                

                //dataGridView1.Rows[e.RowIndex].Cells["ViewDetails"].Value = "已完成预分装";
                dataGridView1.Rows[e.RowIndex].Cells["AdvanceSub"].Value = "已完成预分装";
                dataGridView1.Rows[e.RowIndex].Cells["Delete"].Value = "已完成预分装";
                dataGridView1.Rows[e.RowIndex].Cells["Print"].Value = "打印";

            
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && dataGridView1.Rows[e.RowIndex].Cells["Delete"].Value != "已完成预分装")
            {
                SQL.DeleteSubInfo(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ReportId"].Value));

                string[] List = SQL.getOrderList(dataGridView1.Rows[e.RowIndex].Cells["AddvanceId"].Value.ToString());

                SQL.AlterGoodsOderStatus(0,List);


                dataGridView1.Rows.RemoveAt(e.RowIndex);
            
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Print" && dataGridView1.Rows[e.RowIndex].Cells["Print"].Value != "")
            {
                PrintList newPrintWindow = new PrintList(dataGridView1.Rows[e.RowIndex].Cells["AddvanceId"].Value.ToString());
                newPrintWindow.ShowDialog();
                
            
            }
        }
    }
}
