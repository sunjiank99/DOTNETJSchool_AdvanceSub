namespace AdvanceSub
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumeGoodsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumePickPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeReceiName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumePayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Selected1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumeGoodsNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumePickPoint1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeReceiName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeTel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumePayTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumeDetails1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker.Location = new System.Drawing.Point(32, 26);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 21);
            this.startTimePicker.TabIndex = 5;
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker.Location = new System.Drawing.Point(256, 26);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 21);
            this.endTimePicker.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "全部提货点";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "提货点";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "确定";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(697, 539);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 15;
            this.button10.Text = "打印";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(779, 539);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 16;
            this.button11.Text = "统计";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(871, 539);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 17;
            this.button12.Text = "查看报表";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "起始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "结束时间";
            // 
            // Select
            // 
            this.Select.HeaderText = "选择";
            this.Select.Name = "Select";
            // 
            // OderNo
            // 
            this.OderNo.HeaderText = "订单号";
            this.OderNo.Name = "OderNo";
            // 
            // PayTime
            // 
            this.PayTime.HeaderText = "时间";
            this.PayTime.Name = "PayTime";
            this.PayTime.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.ColumeGoodsNo,
            this.ColumePickPoint,
            this.ColumeReceiName,
            this.ColumeTel,
            this.ColumePayTime,
            this.ColumeDetails});
            this.dataGridView1.Location = new System.Drawing.Point(4, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(452, 439);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Selected
            // 
            this.Selected.HeaderText = "选择";
            this.Selected.Name = "Selected";
            this.Selected.Width = 50;
            // 
            // ColumeGoodsNo
            // 
            this.ColumeGoodsNo.HeaderText = "订单号";
            this.ColumeGoodsNo.Name = "ColumeGoodsNo";
            // 
            // ColumePickPoint
            // 
            this.ColumePickPoint.HeaderText = "提货点";
            this.ColumePickPoint.Name = "ColumePickPoint";
            // 
            // ColumeReceiName
            // 
            this.ColumeReceiName.HeaderText = "收货人姓名";
            this.ColumeReceiName.Name = "ColumeReceiName";
            // 
            // ColumeTel
            // 
            this.ColumeTel.HeaderText = "电话";
            this.ColumeTel.Name = "ColumeTel";
            this.ColumeTel.Visible = false;
            // 
            // ColumePayTime
            // 
            this.ColumePayTime.HeaderText = "时间";
            this.ColumePayTime.Name = "ColumePayTime";
            this.ColumePayTime.Visible = false;
            // 
            // ColumeDetails
            // 
            this.ColumeDetails.HeaderText = "详情";
            this.ColumeDetails.Name = "ColumeDetails";
            this.ColumeDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumeDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected1,
            this.ColumeGoodsNo1,
            this.ColumePickPoint1,
            this.ColumeReceiName1,
            this.ColumeTel1,
            this.ColumePayTime1,
            this.ColumeDetails1});
            this.dataGridView3.Location = new System.Drawing.Point(543, 95);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(455, 438);
            this.dataGridView3.TabIndex = 21;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(543, 539);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "全选";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(616, 539);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "取消全选";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(543, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 24;
            this.button8.Text = "清空";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Selected1
            // 
            this.Selected1.HeaderText = "选择";
            this.Selected1.Name = "Selected1";
            this.Selected1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected1.Width = 60;
            // 
            // ColumeGoodsNo1
            // 
            this.ColumeGoodsNo1.HeaderText = "订单号";
            this.ColumeGoodsNo1.Name = "ColumeGoodsNo1";
            // 
            // ColumePickPoint1
            // 
            this.ColumePickPoint1.HeaderText = "提货点";
            this.ColumePickPoint1.Name = "ColumePickPoint1";
            // 
            // ColumeReceiName1
            // 
            this.ColumeReceiName1.HeaderText = "收货人姓名";
            this.ColumeReceiName1.Name = "ColumeReceiName1";
            // 
            // ColumeTel1
            // 
            this.ColumeTel1.HeaderText = "电话";
            this.ColumeTel1.Name = "ColumeTel1";
            this.ColumeTel1.Visible = false;
            // 
            // ColumePayTime1
            // 
            this.ColumePayTime1.HeaderText = "时间";
            this.ColumePayTime1.Name = "ColumePayTime1";
            this.ColumePayTime1.Visible = false;
            // 
            // ColumeDetails1
            // 
            this.ColumeDetails1.HeaderText = "详情";
            this.ColumeDetails1.Name = "ColumeDetails1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 644);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "预分装窗口";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeGoodsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumePickPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeReceiName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumePayTime;
        private System.Windows.Forms.DataGridViewButtonColumn ColumeDetails;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeGoodsNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumePickPoint1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeReceiName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumeTel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumePayTime1;
        private System.Windows.Forms.DataGridViewButtonColumn ColumeDetails1;

    }
}