using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seagull.BarTender.Print;
using System.Configuration;

using Test = AdvanceSub.cn.com.sngoo.app8;

namespace AdvanceSub
{
    public partial class Main : Form
    {
        //初始化绑定默认关键词（此数据源可以从数据库取）
        List<string> listOnit = new List<string>();   //取货点列表
        //输入key之后，返回的关键词
        List<string> listNew = new List<string>();   // 模糊查询之后的列表

        DateTime StartTime;
        DateTime EndTime;

        string pickPointName;

        Test.database SQL = new Test.database();
        List<Pickpoint> list = new List<Pickpoint>();

        public Main()
        {
            InitializeComponent();
            listOnit = SQL.getPickPointList().ToList();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.AddRange(listOnit.ToArray());

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            //清空combobox
            this.comboBox1.Items.Clear();
            //清空listNew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if (item.Contains(this.comboBox1.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
            }
            //combobox添加已经查到的关键词
            this.comboBox1.Items.AddRange(listNew.ToArray());
            //设置光标位置，否则光标位置始终保持在第一列，造成输入关键词的倒序排列
            this.comboBox1.SelectionStart = this.comboBox1.Text.Length;
            //保持鼠标指针原来状态，有时候鼠标指针会被下拉框覆盖，所以要进行一次设置。
            Cursor = Cursors.Default;
            //自动弹出下拉框
            this.comboBox1.DroppedDown = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartTime = startTimePicker.Value;
            EndTime = endTimePicker.Value;
            
            List<Test.GoodsOrder> DataGoodsOrder;
            if (comboBox1.Text == "" || comboBox1.Text == "全部提货点")
            {
                 DataGoodsOrder = SQL.getALLGoodsOrder(StartTime, EndTime).ToList();
                
            }
            else
            {
                pickPointName = comboBox1.SelectedItem.ToString();
                 DataGoodsOrder = SQL.getGoodsOrder(pickPointName, StartTime, EndTime).ToList();
            }
            dataGridView1.Rows.Clear();

            for(int i=0;i<DataGoodsOrder.Count;i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value = DataGoodsOrder[i].OrderNo;
                dataGridView1.Rows[i].Cells["ColumePayTime"].Value = DataGoodsOrder[i].PayTime;
                dataGridView1.Rows[i].Cells["ColumePickPoint"].Value = DataGoodsOrder[i].PickPointName;
                dataGridView1.Rows[i].Cells["ColumeReceiName"].Value = DataGoodsOrder[i].RecevieName;
                dataGridView1.Rows[i].Cells["ColumeTel"].Value = DataGoodsOrder[i].ReceiveTel;
                dataGridView1.Rows[i].Cells["ColumeDetails"].Value = "详情";


            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            Details newDetails;
            
            if (dataGridView1.Columns[e.ColumnIndex].Name =="ColumeDetails")
            {

                 newDetails = new Details(dataGridView1.Rows[e.RowIndex].Cells["ColumeGoodsNo"].Value.ToString());
                 newDetails.ShowDialog();
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView3.Rows.Add("False", dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value, dataGridView1.Rows[i].Cells["ColumePickPoint"].Value, dataGridView1.Rows[i].Cells["ColumeReceiName"].Value, dataGridView1.Rows[i].Cells["ColumeTel"].Value, dataGridView1.Rows[i].Cells["ColumePayTime"].Value, "详情");
                //dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value = dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value;
                //dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value = dataGridView1.Rows[i].Cells["ColumePickPoint"].Value;
                //dataGridView3.Rows[i].Cells["ColumeReceiName1"].Value = dataGridView1.Rows[i].Cells["ColumeReceiName"].Value;
                //dataGridView3.Rows[i].Cells["ColumePayTime1"].Value = dataGridView1.Rows[i].Cells["ColumePayTime"].Value;
                //dataGridView3.Rows[i].Cells["ColumeTel1"].Value = dataGridView1.Rows[i].Cells["ColumeTel"].Value;
                //dataGridView3.Rows[i].Cells["Selected1"].Value = dataGridView1.Rows[i].Cells["Selected"].Value;
                SQL.alterAddvanceSubStatus(dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value.ToString(),"1");
                
                    
            
            
            }
            dataGridView1.Rows.Clear();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = dataGridView1.Rows.Count-1; i >=0; i--)
            {

                if (dataGridView1.Rows[i].Cells["Selected"].EditedFormattedValue.ToString() == "True")
                {
                    dataGridView3.Rows.Add("False", dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value, dataGridView1.Rows[i].Cells["ColumePickPoint"].Value, dataGridView1.Rows[i].Cells["ColumeReceiName"].Value,  dataGridView1.Rows[i].Cells["ColumeTel"].Value, dataGridView1.Rows[i].Cells["ColumePayTime"].Value,"详情");
                    SQL.alterAddvanceSubStatus(dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value.ToString(), "1");
                    dataGridView1.Rows.RemoveAt(i);
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView3.Rows.Count - 1; i >= 0; i--)
            {

                if (dataGridView3.Rows[i].Cells["Selected1"].EditedFormattedValue.ToString() == "True")
                {
                    dataGridView1.Rows.Add("False", dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value, dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value, dataGridView3.Rows[i].Cells["ColumeReceiName1"].Value, dataGridView3.Rows[i].Cells["ColumeTel1"].Value, dataGridView3.Rows[i].Cells["ColumePayTime1"].Value, "详情");
                    SQL.alterAddvanceSubStatus(dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value.ToString(), "0");
                    dataGridView3.Rows.RemoveAt(i);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                dataGridView1.Rows.Add("False", dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value, dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value, dataGridView3.Rows[i].Cells["ColumeReceiName1"].Value, dataGridView3.Rows[i].Cells["ColumeTel1"].Value, dataGridView3.Rows[i].Cells["ColumePayTime1"].Value, "详情");
                //dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value = dataGridView1.Rows[i].Cells["ColumeGoodsNo"].Value;
                //dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value = dataGridView1.Rows[i].Cells["ColumePickPoint"].Value;
                //dataGridView3.Rows[i].Cells["ColumeReceiName1"].Value = dataGridView1.Rows[i].Cells["ColumeReceiName"].Value;
                //dataGridView3.Rows[i].Cells["ColumePayTime1"].Value = dataGridView1.Rows[i].Cells["ColumePayTime"].Value;
                //dataGridView3.Rows[i].Cells["ColumeTel1"].Value = dataGridView1.Rows[i].Cells["ColumeTel"].Value;
                //dataGridView3.Rows[i].Cells["Selected1"].Value = dataGridView1.Rows[i].Cells["Selected"].Value;
                SQL.alterAddvanceSubStatus(dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value.ToString(), "0");



            }
            dataGridView3.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Selected"].Value = "True";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Details newDetails;

            if (dataGridView3.Columns[e.ColumnIndex].Name == "ColumeDetails1")
            {

                newDetails = new Details(dataGridView3.Rows[e.RowIndex].Cells["ColumeGoodsNo1"].Value.ToString());
                newDetails.ShowDialog();


            }
        }

        public class Pickpoint
        {
            public string PickpointName;
            public Dictionary<string,int> Goods;

            

        
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.Count == 0)
            {
                MessageBox.Show("没有统计的订单");
                return;
            
            }
            
            list.Clear();
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                
                if (list.FindIndex(o => o.PickpointName == dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value.ToString()) != -1)
                {
                    int index = list.FindIndex(o => o.PickpointName == dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value.ToString()); //得到索引
                    //item.PickpointName = dataGridView3.Rows[i].Cells["ColumePickPoint1"].ToString();

                    Details info =new Details(dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value.ToString());
                    for (int j = 0; j < info.dataGridView1.Rows.Count; j++)
                    {
                        if (list[index].Goods.ContainsKey(info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString()))
                        {

                            list[index].Goods[info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString()] += Convert.ToInt32(info.dataGridView1.Rows[j].Cells["GoodsNum"].Value);


                        }
                        else
                        {

                            list[index].Goods.Add(info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString(),Convert.ToInt32( info.dataGridView1.Rows[j].Cells["GoodsNum"].Value));
                        }
                    
                    }
                    


                }
                else
                {
                    Pickpoint item = new Pickpoint();
                    item.PickpointName= "";
                    item.Goods = new Dictionary<string, int>();

                     item.PickpointName = dataGridView3.Rows[i].Cells["ColumePickPoint1"].Value.ToString();
                     Details info = new Details(dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value.ToString());
                     //info.ShowDialog();
                     for (int j = 0; j < info.dataGridView1.Rows.Count; j++)
                     {
                         if (item.Goods.ContainsKey(info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString()))
                         {

                             item.Goods[info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString()] += Convert.ToInt32(info.dataGridView1.Rows[j].Cells["GoodsNum"].Value);


                         }
                         else
                         {

                             item.Goods.Add(info.dataGridView1.Rows[j].Cells["GoodsName"].Value.ToString(), Convert.ToInt32(info.dataGridView1.Rows[j].Cells["GoodsNum"].Value));
                         }

                     }
                     list.Add(item);

                
                }

              
            
            }

            report newReport = new report();

            for (int k = 0; k < list.Count; k++)
            {
                newReport.textBox1.Text += (list[k].PickpointName + ":" + "\r\n");

                foreach (var item in list[k].Goods)
                {
                    newReport.textBox1.Text += (item.Key + ":" + item.Value + "份" + "\r\n");
                }


                newReport.textBox1.Text += "\r\n\r\n\r\n";
            
            }


            Test.AddvanceSubInfo WriteInfo = new Test.AddvanceSubInfo();
            WriteInfo.AddvanceSubState = 0;
            WriteInfo.CountTime = DateTime.Now;
            WriteInfo.Details = newReport.textBox1.Text;
            WriteInfo.OrderNum = dataGridView3.Rows.Count;
            DateTime time = DateTime.Now;
                string strtime = DateTime.Now.ToString("yyyyMMddHHmmssff");
                WriteInfo.AddvanceId = "AD"+strtime;


                List<string> OrderNoList=new List<string>();
            //统计关联表
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                OrderNoList.Add(dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Value.ToString());

               
            
            }

            string[] OrderNoListData = OrderNoList.ToArray();
            //写入关联表
            SQL.InputAssociationList(OrderNoListData, WriteInfo.AddvanceId);

                 //写入数据库
                SQL.WriteIntoSub(WriteInfo);
                
                

            newReport.ShowDialog();

            dataGridView3.Rows.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reportsView newView = new reportsView();
            newView.ShowDialog();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int r = rd.Next(256); int g = rd.Next(256); int b = rd.Next(256);
            Printer PrinterSetting = new Printer();
            PrinterSetting.ShowDialog();
            if (PrinterSetting.DialogResult == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    if (dataGridView3.Rows[i].Cells["Selected1"].EditedFormattedValue.ToString() == "True")
                    {

                        BartenderprintShow(i, 0);
                        dataGridView3.Rows[i].Cells["ColumeGoodsNo1"].Style.ForeColor = Color.FromArgb(r, g, b);
                        dataGridView3.Rows[i].Cells["ColumePickPoint1"].Style.ForeColor = Color.FromArgb(r, g, b);
                        dataGridView3.Rows[i].Cells["ColumeReceiName1"].Style.ForeColor = Color.FromArgb(r, g, b);
                        //dataGridView3.Rows[i].Cells["Address"].Style.ForeColor = Color.FromArgb(r, g, b);

                    }


                }
            }
            
            //BartenderprintShow();

        }


        public void BartenderprintShow(int k,int count)
        {
            Engine btEngine = new Engine();
            bool isAlive = btEngine.IsAlive;

            string path = ConfigurationManager.AppSettings["OrderPath"];
            btEngine.Start();
            LabelFormatDocument btFormat = btEngine.Documents.Open(path);//这里是Bartender软件生成的模板文件，你需要先把模板文件做好。
            //btFormat.PrintSetup.PrinterName = "Foxit Reader PDF Printer";
            //btFormat.PrintSetup.IdenticalCopiesOfLabel = 1; //打印份数
            //btFormat.SubStrings["s0"].Value = value;
            //Messages messages;
            //int waitout = 10000; // 10秒 超时
            //Result nResult = btFormat.Print("标签打印软件", waitout, out messages);
            //string messageString = "\n\nMessages:";
            //foreach (Seagull.BarTender.Print.Message message in messages)
            //{
            //    messageString += "\n\n" + message.Text;
            //}
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();

            //int rawKind = 1;
            //for (int i = 0; i <= doc.PrinterSettings.PaperSizes.Count - 1; i++)
            //{
            //    if (doc.PrinterSettings.PaperSizes[i].PaperName == "订单打印")
            //    {
            //        rawKind = doc.PrinterSettings.PaperSizes[i].RawKind;
            //    }
            //}


            btFormat.PrintSetup.PrinterName = doc.PrinterSettings.PrinterName;
            



            btFormat.SubStrings["Name"].Value = dataGridView3.Rows[k].Cells["ColumeReceiName1"].Value.ToString();//为Bartender里的数据源（文本框、条码等等）传值
            btFormat.SubStrings["TEL"].Value = dataGridView3.Rows[k].Cells["ColumeTel1"].Value.ToString();
            btFormat.SubStrings["PickPoint"].Value = dataGridView3.Rows[k].Cells["ColumePickPoint1"].Value.ToString();
            btFormat.SubStrings["GoodsNo"].Value = dataGridView3.Rows[k].Cells["ColumeGoodsNo1"].Value.ToString();


            Details goodsinfo = new Details(dataGridView3.Rows[k].Cells["ColumeGoodsNo1"].Value.ToString());

            for (; count < goodsinfo.dataGridView1.RowCount ; count++)
            {
                if ((count + 1) % 3 == 0)
                {
                    BartenderprintShow(k, count + 1);
                    btFormat.SubStrings["GoodsInfo"].Value += (count + 1).ToString() + "," + goodsinfo.dataGridView1.Rows[count].Cells["GoodsName"].Value.ToString() + "\n"
                   + "数量：" + goodsinfo.dataGridView1.Rows[count].Cells["GoodsNum"].Value.ToString() + "份" + "\n";
                    break;

                }
                btFormat.SubStrings["GoodsInfo"].Value += (count + 1).ToString() + "," + goodsinfo.dataGridView1.Rows[count].Cells["GoodsName"].Value.ToString() + "\n"
                    + "数量：" + goodsinfo.dataGridView1.Rows[count].Cells["GoodsNum"].Value.ToString() + "份" + "\n";



            }
            
            //btFormat.SubStrings["k3"].Value = batch;
            //btFormat.SubStrings["s0"].Value = value;
            //Result nResult1 = btFormat.Print("标签打印软件", waitout, out messages);
            //btFormat.PrintSetup.Cache.FlushInterval = CacheFlushInterval.PerSession;


            btFormat.Print();
            btFormat.Close(SaveOptions.DoNotSaveChanges);//不保存对打开模板的修改
            btEngine.Stop();

            return ;


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                dataGridView3.Rows[i].Cells["Selected1"].Value = "True";
            
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                dataGridView3.Rows[i].Cells["Selected1"].Value = "False";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
        }
    }
}
