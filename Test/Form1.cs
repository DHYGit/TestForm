using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //动态增加一行
            this.tableLayoutPanel_Test.RowCount++;
            //设置高度
            this.tableLayoutPanel_Test.Height = this.tableLayoutPanel_Test.RowCount * 40;
            //行高
            this.tableLayoutPanel_Test.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            //设置cell样式
            this.tableLayoutPanel_Test.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            int i = this.tableLayoutPanel_Test.RowCount - 1;
            //添加控件
            Label label = new Label();
            label.Text = "第" + this.tableLayoutPanel_Test.RowCount.ToString() + "行";
            label.AutoSize = true;
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.tableLayoutPanel_Test.Controls.Add(label, 0, this.tableLayoutPanel_Test.RowCount - 1);

            Button button = new Button();
            button.Size = new System.Drawing.Size(75, 23);
            button.Text = "button1";
            button.UseVisualStyleBackColor = true;
            this.tableLayoutPanel_Test.Controls.Add(button, this.tableLayoutPanel_Test.ColumnCount - 1, this.tableLayoutPanel_Test.RowCount - 1);
        }

        private void button_Reduce_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel_Test.RowCount == 0) {
                MessageBox.Show("不能再删了");
                return;
            }
            //删除最后一行
            for (int i = 0; i < this.tableLayoutPanel_Test.ColumnCount; i++)
            {
                Control ctl = this.tableLayoutPanel_Test.GetControlFromPosition(i, this.tableLayoutPanel_Test.RowCount - 1);
                this.tableLayoutPanel_Test.Controls.Remove(ctl);

            }
            this.tableLayoutPanel_Test.RowStyles.RemoveAt(this.tableLayoutPanel_Test.RowCount - 1);
            this.tableLayoutPanel_Test.RowCount--;
            this.tableLayoutPanel_Test.Height = this.tableLayoutPanel_Test.RowCount * 40;
            
        }
    }
}
