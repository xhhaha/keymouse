using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyClickEvent4
{
    /// <summary>
    /// 模拟键盘点击类
    /// </summary>
    public class Run
    {

        #region 单次按键操作
        /// <summary>
        /// 单次按键操作
        /// </summary>
        /// <param name="A">输入的键码 通过KeyClickEvent.KeyVal 来调用或者自己输入</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为0毫秒</param>
        public static void KeyRun(byte A)
        {
            keybd_event(A, 0, 0, 0);
            keybd_event(A, 0, 2, 0);
        }
        #endregion

        #region 单次按键操作
        /// <summary>
        /// 单次按键操作
        /// </summary>
        /// <param name="A">输入的键码 通过KeyClickEvent.KeyVal 来调用或者自己输入</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为0毫秒</param>
        public static void KeyRun(byte A, int millis = 0)
        {
            keybd_event(A, 0, 0, 0);
            keybd_event(A, 0, 2, 0);
            Thread.Sleep(millis);
        }
        #endregion

        #region 单次按键操作
        /// <summary>
        /// 单次按键操作
        /// </summary>
        /// <param name="A">输入的键码 通过KeyClickEvent.KeyVal 来调用或者自己输入</param>
        /// <param name="j">这是该键执行的次数 默认是1  可不填写，如果需要多次按键请输入指定的按键次的阿拉伯数字</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为800毫秒</param>
        public static void KeyRun(byte A, int j = 1, int millis = 0)
        {
            for (int i = 0; i < j; i++)
            {
                keybd_event(A, 0, 0, 0);
                keybd_event(A, 0, 2, 0);
                Thread.Sleep(millis);
            }
        }
        #endregion

        #region 双组合键执行
        /// <summary>
        /// 双组合键执行
        /// </summary>
        /// <param name="A">接受的第一个键码</param>
        /// <param name="B">接受的第二个键码</param>
        /// <param name="j">这是该键执行的次数 默认是1  可不填写，如果需要多次按键请输入指定的按键次的阿拉伯数字</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为0毫秒</param>
        public static void KeyRun(byte A, byte B, int j = 1, int date = 0)
        {
            for (int i = 0; i < j; i++)
            {
                KeyDown(A);
                KeyDown(B);
                KeyUp(A);
                KeyUp(B);
                Thread.Sleep(date);
            }
        }
        #endregion

        #region 三组合键
        /// <summary>
        /// 三组合键
        /// </summary>
        /// <param name="A">接受的第一个键码</param>
        /// <param name="B">接受的第二个键码</param>
        /// <param name="C">接受的第三个键码</param>
        /// <param name="J">执行的次数，默认为一次</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为800毫秒</param>
        public static void KeyRun(byte A, byte B, byte C, int J = 1, int date = 0)
        {
            for (int i = 0; i < J; i++)
            {
                KeyDown(A);
                KeyDown(B);
                KeyDown(C);
                KeyUp(A);
                KeyUp(B);
                KeyUp(C);
                Thread.Sleep(date);
            }
        }
        #endregion

        #region 四组合键
        /// <summary>
        /// 四组合键
        /// </summary>
        /// <param name="A">接受的第一个键码</param>
        /// <param name="B">接受的第二个键码</param>
        /// <param name="C">接受的第三个键码</param>
        /// <param name="D">接受的第四个键码</param>
        /// <param name="J">执行的次数，默认为一次</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为0毫秒</param>
        public static void KeyRun(byte A, byte B, byte C, byte D, int J = 1, int date = 0)
        {
            for (int i = 0; i < J; i++)
            {
                KeyDown(A);
                KeyDown(B);
                KeyDown(C);
                KeyDown(D);
                KeyUp(A);
                KeyUp(B);
                KeyUp(C);
                KeyUp(D);
                Thread.Sleep(date);
            }
        }
        #endregion

        #region 五组合键
        /// <summary>
        /// 五组合键
        /// </summary>
        /// <param name="A">接受的第一个键码</param>
        /// <param name="B">接受的第二个键码</param>
        /// <param name="C">接受的第三个键码</param>
        /// <param name="D">接受的第四个键码</param>
        /// <param name="E">接受的第五个键码</param>
        /// <param name="J">执行的次数，默认为一次</param>
        /// <param name="date">延时的毫秒数，根据计算机性能不同，部分计算机需要延时大一些，才能执行成功，默认时间为0毫秒</param>
        public static void KeyRun(byte A, byte B, byte C, byte D, byte E, int J = 1, int date = 0)
        {
            for (int i = 0; i < J; i++)
            {
                KeyDown(A);
                KeyDown(B);
                KeyDown(C);
                KeyDown(D);
                KeyDown(E);
                KeyUp(A);
                KeyUp(B);
                KeyUp(C);
                KeyUp(D);
                KeyUp(E);
                Thread.Sleep(date);
            }
        }

        #endregion

        #region 作者相关信息
        /// <summary>
        /// 作者相关信息
        /// </summary>
        /// <returns></returns>
        public static string About()
        {
            return "此插件由QQ:35924908编写";
        }
        #endregion

        #region 按键
        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        private static extern void keybd_event(
            byte bVk,    //虚拟键值

            byte bScan,// 一般为0

            int dwFlags,  //这里是整数类型  0 为按下，2为释放

            int dwExtraInfo  //这里是整数类型 一般情况下设成为 0
        );
        #endregion

        #region 按下键盘
        /// <summary>
        /// 按下键盘
        /// </summary>
        /// <param name="A">接收的按键码</param>
        private static void KeyDown(byte A)
        {
            keybd_event(A, 0, 0, 0);
        }
        #endregion

        #region 松开键盘
        /// <summary>
        /// 松开键盘
        /// </summary>
        /// <param name="A"></param>
        private static void KeyUp(byte A)
        {
            keybd_event(A, 0, 2, 0);
        }
        #endregion

        #region 按键执行 这里一般是指令输入
        /// <summary>
        /// 按键执行 这里一般是指令输入
        /// </summary>
        /// <param name="list">一系列指令码</param>
        /// <param name="millis">间隔时间</param>
        public static void KeyRuns(List<byte> list, int millis = 0)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (millis > 0)
                {
                    Thread.Sleep(millis);
                    KeyRun(list[i], millis);
                }
                else
                {
                    KeyRun(list[i]);
                }
            }
        }
        #endregion


        #region 模拟字符串输入
        /// <summary>
        /// 模拟字符串输入 
        /// </summary>
        /// <param name="keys">字符串</param>
        /// <param name="millis">间隔的时间</param>
        public static void KeyRuns(string keystring, int millis = 0)
        {
            keystring = keystring.ToUpper();
            char[] tempstrarr = keystring.ToCharArray();
            List<byte> templist = new List<byte>();
            for (int i = 0; i < tempstrarr.Length; i++)
            {
                templist.Add((byte)((Keys)tempstrarr[i]));
            }
            KeyRuns(templist, millis);
        }
        #endregion

    }
}
