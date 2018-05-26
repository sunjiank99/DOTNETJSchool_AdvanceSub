namespace AdvanceSub
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new DMSkin.Controls.DMButton();
            this.ID = new DMSkin.Controls.MetroTextBox();
            this.PS = new DMSkin.Controls.MetroTextBox();
            this.dmLabel1 = new DMSkin.Controls.DMLabel();
            this.dmLabel2 = new DMSkin.Controls.DMLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "鲜女果预分装系统";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DM_DisabledColor = System.Drawing.Color.Empty;
            this.button1.DM_DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.button1.DM_MoveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.button1.DM_NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.button1.DM_Radius = 10;
            this.button1.Image = null;
            this.button1.Location = new System.Drawing.Point(157, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.IsPassWord = false;
            this.ID.Location = new System.Drawing.Point(143, 74);
            this.ID.MaximumSize = new System.Drawing.Size(195, 30);
            this.ID.MinimumSize = new System.Drawing.Size(195, 30);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(195, 30);
            this.ID.TabIndex = 10;
            this.ID.WaterText = "";
            // 
            // PS
            // 
            this.PS.BackColor = System.Drawing.Color.Transparent;
            this.PS.IsPassWord = true;
            this.PS.Location = new System.Drawing.Point(142, 139);
            this.PS.MaximumSize = new System.Drawing.Size(195, 30);
            this.PS.MinimumSize = new System.Drawing.Size(195, 30);
            this.PS.Name = "PS";
            this.PS.Size = new System.Drawing.Size(195, 30);
            this.PS.TabIndex = 11;
            this.PS.WaterText = "";
            // 
            // dmLabel1
            // 
            this.dmLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel1.DM_Color = System.Drawing.Color.Black;
            this.dmLabel1.DM_Font_Size = 18F;
            this.dmLabel1.DM_Key = DMSkin.Controls.DMLabelKey.用户;
            this.dmLabel1.DM_Text = "";
            this.dmLabel1.Location = new System.Drawing.Point(81, 75);
            this.dmLabel1.Name = "dmLabel1";
            this.dmLabel1.Size = new System.Drawing.Size(30, 30);
            this.dmLabel1.TabIndex = 12;
            this.dmLabel1.Text = "dmLabel1";
            // 
            // dmLabel2
            // 
            this.dmLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dmLabel2.DM_Color = System.Drawing.Color.Black;
            this.dmLabel2.DM_Font_Size = 18F;
            this.dmLabel2.DM_Key = DMSkin.Controls.DMLabelKey.锁;
            this.dmLabel2.DM_Text = "";
            this.dmLabel2.Location = new System.Drawing.Point(81, 144);
            this.dmLabel2.Name = "dmLabel2";
            this.dmLabel2.Size = new System.Drawing.Size(30, 30);
            this.dmLabel2.TabIndex = 13;
            this.dmLabel2.Text = "dmLabel2";
            // 
            // login
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 278);
            this.Controls.Add(this.dmLabel2);
            this.Controls.Add(this.dmLabel1);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "login";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DMSkin.Controls.DMButton button1;
        private DMSkin.Controls.MetroTextBox ID;
        private DMSkin.Controls.MetroTextBox PS;
        private DMSkin.Controls.DMLabel dmLabel1;
        private DMSkin.Controls.DMLabel dmLabel2;
    }
}

