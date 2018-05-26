using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Drawing.Printing;



namespace AdvanceSub
{
    public partial class Printer : Form
    {   
         [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern long SetDefaultPrinter(string pszPrinter);
        public Printer()
        {
            InitializeComponent();

            //listBox1.Dock = DockStyle.Fill;
            foreach (String fPrinterName in LocalPrinter.GetLocalPrinters())
            {
                listBox1.Items.Add(fPrinterName);
            }
            this.Controls.Add(listBox1);
          
        }

       

        public class LocalPrinter
        {
            private static PrintDocument fPrintDocument = new PrintDocument();
            ///
            /// 获取本机默认打印机名称
            ///
            public static String DefaultPrinter
            {
                get { return fPrintDocument.PrinterSettings.PrinterName; }
            }
            ///
            /// 获取本机的打印机列表。列表中的第一项就是默认打印机。
            ///
            public static List<string> GetLocalPrinters()
            {
                List<string> fPrinters = new List<string>();
                fPrinters.Add(DefaultPrinter); // 默认打印机始终出现在列表的第一项
                foreach (String fPrinterName in PrinterSettings.InstalledPrinters)
                {
                    if (!fPrinters.Contains(fPrinterName))
                    { fPrinters.Add(fPrinterName); }
                }
                return fPrinters;
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SetDefaultPrinter(listBox1.SelectedItem.ToString());
            MessageBox.Show("您选择了" + listBox1.SelectedItem.ToString() + "打印机！");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
  
        private void Printer_Load(object sender, EventArgs e)
        {

        }

        private void SetDefaultPrinter_Load(object sender, EventArgs e)
        {
            listBox1.Dock = DockStyle.Fill;
            foreach (String fPrinterName in LocalPrinter.GetLocalPrinters())
            {
                listBox1.Items.Add(fPrinterName);
            }
            this.Controls.Add(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void metroDMButton2_Click(object sender, EventArgs e)
        {
            SetDefaultPrinter(listBox1.SelectedItem.ToString());
            MessageBox.Show("您选择了" + listBox1.SelectedItem.ToString() + "打印机！");
            this.DialogResult = DialogResult.OK;
            this.Close();    
        } 

    }
}
