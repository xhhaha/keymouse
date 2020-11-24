using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//引用命名空间
using KeyClickEvent4;
namespace MySoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Shown(object sender, EventArgs e)
        {            
            //模拟鼠标移动点击   335是X轴 701是Y轴   1 是点击的次数    这里的1是可选参数
            Mouse.Move_Click(335, 701, 1);
            //这是模拟键盘点击  如果是一个值的话 输入一个键值就可以了，多个是组合键  最多五个组合键  1000是每次执行后的延时  根据电脑性能决定  也可以自己自定义输入延时毫秒
            Run.KeyRun(KeyVal.Win,0);
            
        }
    }
}
