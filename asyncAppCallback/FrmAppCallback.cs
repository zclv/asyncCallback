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

namespace asyncAppCallback
{
    public partial class FrmAppCallback : Form
    {
        public FrmAppCallback()
        {
            InitializeComponent();
            this.objCal = new MyDelegate(ExecuteTask);//初始化成员变量
            //this.objCal = (num, ms)=>
            //{
            //    Thread.Sleep(ms);
            //    return num * num;
            //};

        }
        //【1】声明一个委托
        public delegate int MyDelegate(int num, int ms);
        //【2】根据委托声明一个方法 
        private int ExecuteTask(int num, int ms)
        {
            Thread.Sleep(ms);
            return num * num;
        }
        //【3】创建委托变量
        MyDelegate objCal = null;//ExecuteTask;
        //【4】同步执行多个任务
        private void btnExecu_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                objCal.BeginInvoke(10 * i, 1000 * i, MyCallback,i);
            }
        }
        //【5】创建回调函数
        private void MyCallback(IAsyncResult result)
        {
           int res= objCal.EndInvoke(result);
            //异步显示结果
            Console.WriteLine("第{0}个计算结果：{1}",result.AsyncState,res);
        }
    }
}
