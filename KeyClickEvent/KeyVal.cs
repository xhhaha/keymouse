using System;
using System.Collections.Generic;
using System.Text;

namespace KeyClickEvent4
{
    /// <summary>
    /// 模拟键盘的值类   后边的值  在这个类中选择即可
    /// </summary>
    public class KeyVal
    {
        /// <summary>
        /// 常用键 字母键A到Z 的A
        /// </summary>
        public const byte A = 65;
        /// <summary>
        /// 常用键 字母键B
        /// </summary>
        public const byte B = 66;
        /// <summary>
        /// 常用键 字母键C
        /// </summary>
        public const byte C = 67;        
        /// <summary>
        /// 常用键 字母键D
        /// </summary>
        public const byte D = 68;        
        /// <summary>
        /// 常用键 字母键E
        /// </summary>
        public const byte E = 69;        
        /// <summary>
        /// 常用键 字母键F
        /// </summary>
        public const byte F = 70;       
        /// <summary>
        /// 常用键 字母键B
        /// </summary>
        public const byte G = 71;        
        /// <summary>
        /// 常用键 字母键H
        /// </summary>
        public const byte H = 72;        
        /// <summary>
        /// 常用键 字母键I
        /// </summary>
        public const byte I = 73;        
        /// <summary>
        /// 常用键 字母键J
        /// </summary>
        public const byte J = 74;        
        /// <summary>
        /// 常用键 字母键K
        /// </summary>
        public const byte K = 75;        
        /// <summary>
        /// 常用键 字母键L
        /// </summary>
        public const byte L = 76;        
        /// <summary>
        /// 常用键 字母键M
        /// </summary>
        public const byte M = 77;        
        /// <summary>
        /// 常用键 字母键N
        /// </summary>
        public const byte N = 78;        
        /// <summary>
        /// 常用键 字母键O
        /// </summary>
        public const byte O = 79;        
        /// <summary>
        /// 常用键 字母键P
        /// </summary>
        public const byte P = 80;        
        /// <summary>
        /// 常用键 字母键Q
        /// </summary>
        public const byte Q = 81;        
        /// <summary>
        /// 常用键 字母键R
        /// </summary>
        public const byte R = 82;        
        /// <summary>
        /// 常用键 字母键S
        /// </summary>
        public const byte S = 83;        
        /// <summary>
        /// 常用键 字母键T
        /// </summary>
        public const byte T = 84;        
        /// <summary>
        /// 常用键 字母键U
        /// </summary>
        public const byte U = 85;        
        /// <summary>
        /// 常用键 字母键V
        /// </summary>
        public const byte V = 86;        
        /// <summary>
        /// 常用键 字母键W
        /// </summary>
        public const byte W = 87;        
        /// <summary>
        /// 常用键 字母键X
        /// </summary>
        public const byte X = 88;
        /// <summary>
        /// 常用键 字母键Y
        /// </summary>
        public const byte Y = 89;
        /// <summary>
        /// 常用键 字母键Z
        /// </summary>
        public const byte Z = 90;

        
        /// <summary>
        /// F1 键
        /// </summary>
        public const byte F1 = 112;
        /// <summary>
        /// F2 键
        /// </summary>
        public const byte F2 = 113;
        /// <summary>
        /// F3 键
        /// </summary>
        public const byte F3 = 114;
        /// <summary>
        /// F4 键  
        /// </summary>     
        public const byte F4 = 115;
        /// <summary>
        /// F5 键  
        /// </summary>
        public const byte F5 = 116;
        /// <summary>
        /// F6 键     
        /// </summary>
        public const byte F6 = 117;
        /// <summary>
        /// F7 键   
        /// </summary>
        public const byte F7 = 118;
        /// <summary>
        /// F8 键  
        /// </summary>    
        public const byte F8 = 119;
        /// <summary>
        /// F9 键 
        /// </summary>     
        public const byte F9 = 120;
        /// <summary>
        /// F10 键 
        /// </summary>
        public const byte F10 =121;
        /// <summary>
        /// F11 键 
        /// </summary>    
        public const byte F11 =122;
        /// <summary>
        /// F12 键  
        /// </summary>   
        public const byte F12 =123;
        /// <summary>
        /// Enter回车键
        /// </summary>
        public const byte Enter = 13;
        /// <summary>
        /// BACKSPACE 键
        /// </summary>
        public const byte BACKSPACE = 8; 
        /// <summary>
        /// TAB 键
        /// </summary>
        public const byte Tab = 9;
        /// <summary>
        /// SHIFT 键
        /// </summary>
        public const byte Shift = 16;
        /// <summary>
        /// CTRL 键
        /// </summary>
        public const byte Control = 17;
        /// <summary>
        ///  Alt 键
        /// </summary>
        public const byte Alt = 18;         
        /// <summary>
        ///  PAUSE 键
        /// </summary>
        public const byte Pause = 19;     
        /// <summary>
        /// CAPS LOCK 键
        /// </summary>
        public const byte Capital = 20;   
        /// <summary>
        /// ESC 键
        /// </summary>
        public const byte Escape = 27;
        /// <summary>
        /// SPACEBAR 键
        /// </summary>
        public const byte Space = 32;     
        /// <summary>
        /// PAGE UP 键
        /// </summary>
        public const byte PageUp = 33;
        /// <summary>
        ///  PAGE UP 键
        /// </summary>
        public const byte PageDown = 34;
        /// <summary>
        /// End 键
        /// </summary>
        public const byte End = 35;
        /// <summary>
        /// HOME 键
        /// </summary>
        public const byte Home = 36;
        /// <summary>
        /// LEFT ARROW 键
        /// </summary>
        public const byte Left = 37;
        /// <summary>
        /// UP ARROW 键
        /// </summary>
        public const byte Up = 38;        
        /// <summary>
        /// RIGHT ARROW 键
        /// </summary>
        public const byte Right = 39; 
        /// <summary>
        /// DOWN ARROW 键
        /// </summary>
        public const byte Down = 40;   
        /// <summary>
        /// Delete 键
        /// </summary>
        public const byte Delete = 46;    // 
        /// <summary>
        /// HELP 键
        /// </summary>
        public const byte Help = 47;      
        /// <summary>
        /// NUM LOCK 键
        /// </summary>
        public const byte Numlock = 144;   
        /// <summary>
        /// window键盘
        /// </summary>
        public const byte Win = 91;
        /// <summary>
        /// Insert键 
        /// </summary>
        public const byte Insert = 45;///
        
        /// <summary>
        /// Add 加号键
        /// </summary>
        public const byte Add = 107;
        /// <summary>
        /// Subtract 减号键
        /// </summary>
        public const byte Subtract = 109;
        /// <summary>
        /// Multiply  +号键
        /// </summary>
        public const byte Multiply = 106;
        /// <summary>
        /// Divide ÷
        /// </summary>
        public const byte Divide = 111;



    }
}
