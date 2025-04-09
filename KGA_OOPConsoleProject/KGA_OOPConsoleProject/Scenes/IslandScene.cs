using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class IslandScene : BaseScene
    {
        private ConsoleKey input;
        public IslandScene()
        {
            name = "Island";
        }
        public override void Render()
        {
            Util.Print("*          섬 탐험              *", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 섬을 탐험하기로 결심했습니다.");
            Console.WriteLine("주변을 둘러보니 울창한 숲과 해안가 동굴이 보입니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 울창한 숲 안으로 들어간다.");
            Console.WriteLine("2. 해안가를 둘러본다.");
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
                    Game.ChangeScene("Forest");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Beach");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Uninhabited");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    System.Threading.Thread.Sleep(500); // 0.5초 대기
                    break;
            }

        }
    }
    
    
}
