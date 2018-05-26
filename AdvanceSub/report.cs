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

namespace AdvanceSub
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Printer newPrinter = new Printer();
            newPrinter.ShowDialog();

            BartenderprintShow();




        }

        public void BartenderprintShow()
        {
            Engine btEngine = new Engine();
            bool isAlive = btEngine.IsAlive;

            string path = ConfigurationManager.AppSettings["CountPath"];
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



            btFormat.SubStrings["Info"].Value =this.textBox1.Text.ToString();//为Bartender里的数据源（文本框、条码等等）传值
            


            

            //btFormat.SubStrings["k3"].Value = batch;
            //btFormat.SubStrings["s0"].Value = value;
            //Result nResult1 = btFormat.Print("标签打印软件", waitout, out messages);
            //btFormat.PrintSetup.Cache.FlushInterval = CacheFlushInterval.PerSession;


            btFormat.Print();
            btFormat.Close(SaveOptions.DoNotSaveChanges);//不保存对打开模板的修改
            btEngine.Stop();

            return;


        }
    }
}
