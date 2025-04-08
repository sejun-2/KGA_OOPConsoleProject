using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Util
    {
        public static void Print(string text, ConsoleColor textColor, int delay = 0)
        {
            Console.ForegroundColor = textColor; // 글자 색상 변경
            Console.WriteLine(text); // 글자 출력
            Thread.Sleep(delay); // 지연 시간 설정
            Console.ResetColor(); // 글자 색상 초기화
        }
    }
}
