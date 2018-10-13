namespace Test
{
    partial class Form1
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
            this.tableLayoutPanel_Test = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Reduce = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Test
            // 
            this.tableLayoutPanel_Test.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_Test.ColumnCount = 3;
            this.tableLayoutPanel_Test.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Test.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Test.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Test.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel_Test.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel_Test.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel_Test.Controls.Add(this.button2, 2, 1);
            this.tableLayoutPanel_Test.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel_Test.Location = new System.Drawing.Point(49, 79);
            this.tableLayoutPanel_Test.Name = "tableLayoutPanel_Test";
            this.tableLayoutPanel_Test.RowCount = 2;
            this.tableLayoutPanel_Test.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Test.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Test.Size = new System.Drawing.Size(280, 100);
            this.tableLayoutPanel_Test.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "第1行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "第2行";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(418, 79);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(126, 37);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "添加一行";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Reduce
            // 
            this.button_Reduce.Location = new System.Drawing.Point(418, 142);
            this.button_Reduce.Name = "button_Reduce";
            this.button_Reduce.Size = new System.Drawing.Size(126, 37);
            this.button_Reduce.TabIndex = 2;
            this.button_Reduce.Text = "删除一行";
            this.button_Reduce.UseVisualStyleBackColor = true;
            this.button_Reduce.Click += new System.EventHandler(this.button_Reduce_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 391);
            this.Controls.Add(this.button_Reduce);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.tableLayoutPanel_Test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel_Test.ResumeLayout(false);
            this.tableLayoutPanel_Test.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Reduce;
    }
}

