using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace KeyClickEvent4
{
    /// <summary>
    /// 鼠标的移动和点击了类
    /// </summary>
    public class Mouse
    {
        #region 键盘码
        const int MOVE = 0x0001;      //移动鼠标 
        const int LEFTDOWN = 0x0002; //模拟鼠标左键按下 
        const int LEFTUP = 0x0004; //模拟鼠标左键抬起 
        const int RIGHTDOWN = 0x0008;// 模拟鼠标右键按下 
        const int RIGHTUP = 0x0010;// 模拟鼠标右键抬起 
        const int MIDDLEDOWN = 0x0020;// 模拟鼠标中键按下 
        const int MIDDLEUP = 0x0040; //模拟鼠标中键抬起 
        const int ABSOLUTE = 0x8000; //标示是否采用绝对坐标 
        #endregion
        
        #region 鼠标移动到指定位置点击左键
        /// <summary>
        /// 鼠标移动到指定位置点击左键
        /// </summary>
        /// <param name="X">鼠标的X轴，屏幕的绝对位置</param>
        /// <param name="Y">鼠标的Y轴，屏幕的绝对位置</param>
        /// <param name="Count">点击的次数</param>
        public static void Move_Click(int X, int Y, int Count = 1)
        {
            for (int i = 0; i < Count; i++)
            {
                SetCursorPos(X, Y);
                mouse_event(LEFTDOWN | LEFTUP, X, Y, 0, 0);//点击
                mouse_event(LEFTUP, X, Y, 0, 0);//抬起
            }

        } 
        #endregion
                          
        #region 鼠标点击
        /// <summary>
        /// 鼠标点击函数
        /// </summary>
        /// <param name="dwFlags">对应的代码参数</param>
        /// <param name="dx">x位置</param>
        /// <param name="dy">y位置</param>
        /// <param name="dwData"></param>
        /// <param name="dwExtraInfo"></param>
        [DllImport("user32")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        #endregion

        #region 设置鼠标位置
        /// <summary>
        /// 设置鼠标位置
        /// </summary>
        /// <param name="X">鼠标的X轴</param>
        /// <param name="Y">鼠标的Y轴</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        static extern int SetCursorPos(int X, int Y);
        #endregion

        #region 作者的话
        /// <summary>
        /// 作者的话
        /// </summary>
        /// <returns></returns>
        public static string About()
        {
            return "百度搜索 ChnHonKer-小河   中国红客联盟------有你更精彩！";
        }
        #endregion
        
    }
}
