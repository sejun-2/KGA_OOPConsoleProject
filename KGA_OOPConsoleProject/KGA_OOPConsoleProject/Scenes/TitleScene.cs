using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class TitleScene : BaseScene
    {
        public TitleScene()
        {
            name = "Title";
        }
        public override void Render()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*     로빈슨 크루소 따라잡기    *");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Console.WriteLine(" 계속하려면 아무키나 누르세요.....");
        }
        public override void Input()
        {
            Console.ReadKey(true);  // true는 키를 누른 후 화면에 출력하지 않음
        }
        public override void Update()
        {
        }
        public override void Result()
        {
        }
    }
}
