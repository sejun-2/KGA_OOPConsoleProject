using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class BeachScene : BaseScene
    {
        private ConsoleKey input;
        public BeachScene()
        {
            name = "Beach";
        }
        public override void Render()
        {
            Util.Print("*          해안가 탐험              *", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 해안가를 탐색하기로 결심했습니다.");
            Console.WriteLine("주변을 둘러보니 바다와 동굴이 보입니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 동굴을 조사한다.");
            Console.WriteLine("2. 바다를 조사한다.");
            Console.WriteLine("3. 뒤로가기.");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;  // true는 키를 누른 후 화면에 출력하지 않음
        }
        public override void Update()
        {
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Cave");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Ocean");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Island");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    break;
            }
        }
    }
    
    
}
