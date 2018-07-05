using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncApp
{
    public partial class FrmAsync : Form
    {
        public FrmAsync()
        {
            InitializeComponent();
        }
        public int ExecuteTask1(int num)
        {
            Thread.Sleep(5000);
            return num * num;
        }
        public int ExecuteTask2(int num)
        {
            return num * num;
        }
        private void btnExectue1_Click(object sender, EventArgs e)
        {
            this.lblCount1.Text = ExecuteTask1(10).ToString();
            this.lblCount2.Text = ExecuteTask2(10).ToString();
        }

        private void btnExecute2_Click(object sender, EventArgs e)
        {
            MyDelegate dete = ExecuteTask1;
            //异步操作执行状态借口
            IAsyncResult result = dete.BeginInvoke(10,null,null);
            this.lblCount1.Text = "正在计算......";
            this.lblCount2.Text = ExecuteTask2(10).ToString();
            //EndInvoke方法借助IAsyncResult借口对象，不断地查询异步调用是否结束；
            //该方法知道异步调用的方法所有参数，所以异步调用完毕以后，取出异步调用结果作为返回值
            int res = dete.EndInvoke(result);
            this.lblCount1.Text = res.ToString();
        }
        public delegate int MyDelegate(int num);
    }
}
