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
using System.Web;
using System.Web.Script.Serialization;
using Test = AdvanceSub.cn.com.sngoo.app8;

namespace AdvanceSub
{


    
    public partial class PrintList : Form
    {   

        private string AddvanceId;
        Test.database SQL = new Test.database();
        public PrintList(string ID)
        {
            InitializeComponent();
            AddvanceId = ID;

            string[] list = SQL.getOrderList(AddvanceId);
            List<Test.GoodsOrder> DataGoodsOrder = SQL.getGoodsOrderListByAddvanceId(list).ToList();
            for (int i = 0; i < DataGoodsOrder.Count; i++)
            {
                metroGrid1.Rows.Add();

                metroGrid1.Rows[i].Cells["GoodsNo"].Value = DataGoodsOrder[i].OrderNo;
                metroGrid1.Rows[i].Cells["PayTime"].Value = DataGoodsOrder[i].PayTime;
                metroGrid1.Rows[i].Cells["PickPoint"].Value = DataGoodsOrder[i].PickPointName;
                metroGrid1.Rows[i].Cells["ReceiName"].Value = DataGoodsOrder[i].RecevieName;
                metroGrid1.Rows[i].Cells["Tel"].Value = DataGoodsOrder[i].ReceiveTel;
                metroGrid1.Rows[i].Cells["PickCode"].Value = DataGoodsOrder[i].PickCode;
                metroGrid1.Rows[i].Cells["RecoCode"].Value = DataGoodsOrder[i].RecoCode;
                metroGrid1.Rows[i].Cells["ShoppingNo"].Value = DataGoodsOrder[i].ShoppingNo;




                metroGrid1.Rows[i].Cells["Details"].Value = "详情";

            
            
            
            }



        }

        private void PrintList_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Details newDetails;

            if (metroGrid1.Columns[e.ColumnIndex].Name == "Details")
            {

                newDetails = new Details(metroGrid1.Rows[e.RowIndex].Cells["GoodsNo"].Value.ToString());
                newDetails.ShowDialog();


            }
        }


        public void BartenderprintShow(int k, int count)
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




            btFormat.SubStrings["Name"].Value = metroGrid1.Rows[k].Cells["ReceiName"].Value.ToString();//为Bartender里的数据源（文本框、条码等等）传值
            btFormat.SubStrings["TEL"].Value = metroGrid1.Rows[k].Cells["Tel"].Value.ToString();
            btFormat.SubStrings["PickPoint"].Value = metroGrid1.Rows[k].Cells["PickPoint"].Value.ToString();

            string PickCode=metroGrid1.Rows[k].Cells["PickCode"].Value.ToString();;
            string RecoCode=metroGrid1.Rows[k].Cells["RecoCode"].Value.ToString();
            if (metroGrid1.Rows[k].Cells["ShoppingNo"].Value.ToString() != "")
            {

                btFormat.SubStrings["GoodsNo"].Value = metroGrid1.Rows[k].Cells["ShoppingNo"].Value.ToString();

                //string bb = a.GetAllBoxInfo();

                //string SentGoodsID;


            }
            else
            {
                btFormat.SubStrings["GoodsNo"].Value = metroGrid1.Rows[k].Cells["GoodsNo"].Value.ToString();
            }

            Details goodsinfo = new Details(metroGrid1.Rows[k].Cells["GoodsNo"].Value.ToString());

            for (; count < goodsinfo.dataGridView1.RowCount; count++)
            {
                if ((count+1) % 3 == 0)
                {
                    if ((count + 1) < goodsinfo.dataGridView1.RowCount)
                    {
                        BartenderprintShow(k, count + 1);
                    }
                    btFormat.SubStrings["GoodsInfo"].Value += (count+1).ToString() + "," + goodsinfo.dataGridView1.Rows[count].Cells["GoodsName"].Value.ToString() + "\n"
                   + "数量：" + goodsinfo.dataGridView1.Rows[count].Cells["GoodsNum"].Value.ToString() + "份" + "\n";
                    break;

                }
                btFormat.SubStrings["GoodsInfo"].Value += (count+1).ToString() + "," + goodsinfo.dataGridView1.Rows[count].Cells["GoodsName"].Value.ToString() + "\n"
                    + "数量：" + goodsinfo.dataGridView1.Rows[count].Cells["GoodsNum"].Value.ToString() + "份" + "\n";



            }

            //btFormat.SubStrings["k3"].Value = batch;
            //btFormat.SubStrings["s0"].Value = value;
            //Result nResult1 = btFormat.Print("标签打印软件", waitout, out messages);
            //btFormat.PrintSetup.Cache.FlushInterval = CacheFlushInterval.PerSession;


            btFormat.Print();
            btFormat.Close(SaveOptions.DoNotSaveChanges);//不保存对打开模板的修改
            btEngine.Stop();

            return;


        }

        private void dmButton1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int r = rd.Next(256); int g = rd.Next(256); int b = rd.Next(256);
            Printer PrinterSetting = new Printer();
            PrinterSetting.ShowDialog();
            if (PrinterSetting.DialogResult == DialogResult.OK)
            {
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {

                    if (metroGrid1.Rows[i].Cells["Selected"].EditedFormattedValue.ToString() == "True")
                    {

                        BartenderprintShow(i, 0);
                        metroGrid1.Rows[i].Cells["GoodsNo"].Style.ForeColor = Color.FromArgb(r, g, b);
                        metroGrid1.Rows[i].Cells["PickPoint"].Style.ForeColor = Color.FromArgb(r, g, b);
                        metroGrid1.Rows[i].Cells["ReceiName"].Style.ForeColor = Color.FromArgb(r, g, b);
                        //dataGridView3.Rows[i].Cells["Address"].Style.ForeColor = Color.FromArgb(r, g, b);

                    }


                }
            }
        }

        private void dmButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {

                metroGrid1.Rows[i].Cells["Selected"].Value = "True";

            }
        }

        private void dmButton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {

                metroGrid1.Rows[i].Cells["Selected"].Value = "False";

            }

        }
    }




    public class INFO
    {

        public BoxInfo[][] BoxInfo;

    }
    public class BoxInfo
    {
        public int ID;
        public int BoxGroupId;
        public int BoxId;
        public int BoxStatus;
        public string BoxContent;
        public string OrderId;
        public string BoxPwd;
        public string BoxUserCode;
        public string BoxUserCodeB;

    }

    public class JsonPaserWeb
    {
        // Object->Json
        public string Serialize(BoxInfo obj)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            string json = jsonSerializer.Serialize(obj);
            return json;
        }

        // Json->Object
        public INFO Deserialize(string json)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            //执行反序列化
            INFO obj = jsonSerializer.Deserialize<INFO>(json);
            return obj;
        }
    }
}
