namespace AdvanceSub
{
    partial class reportsView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReportId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddvanceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AdvanceSub = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportId,
            this.Time,
            this.OrdersNum,
            this.AddvanceId,
            this.ViewDetails,
            this.AdvanceSub,
            this.Delete,
            this.Print});
            this.dataGridView1.Location = new System.Drawing.Point(32, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(806, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReportId
            // 
            this.ReportId.HeaderText = "序号";
            this.ReportId.Name = "ReportId";
            // 
            // Time
            // 
            this.Time.HeaderText = "统计时间";
            this.Time.Name = "Time";
            // 
            // OrdersNum
            // 
            this.OrdersNum.HeaderText = "订单数";
            this.OrdersNum.Name = "OrdersNum";
            // 
            // AddvanceId
            // 
            this.AddvanceId.HeaderText = "预分装号";
            this.AddvanceId.Name = "AddvanceId";
            // 
            // ViewDetails
            // 
            this.ViewDetails.HeaderText = "查看详情";
            this.ViewDetails.Name = "ViewDetails";
            // 
            // AdvanceSub
            // 
            this.AdvanceSub.HeaderText = "预分装";
            this.AdvanceSub.Name = "AdvanceSub";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Print
            // 
            this.Print.HeaderText = "打印";
            this.Print.Name = "Print";
            // 
            // reportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 415);
            this.Controls.Add(this.dataGridView1);
            this.Name = "reportsView";
            this.Text = "预分装列表";
            this.Load += new System.EventHandler(this.reportsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddvanceId;
        private System.Windows.Forms.DataGridViewButtonColumn ViewDetails;
        private System.Windows.Forms.DataGridViewButtonColumn AdvanceSub;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}