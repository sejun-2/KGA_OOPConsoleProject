using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class ForestScene : BaseScene
    {
        private ConsoleKey input;
        public ForestScene()
        {
            name = "Forest";
        }
        public override void Render()
        {
            Util.Print("*          숲 탐험              *", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 울창한 숲 안으로 들어갔습니다.");
            Console.WriteLine("주변을 둘러보니 다양한 식물과 동물들이 보입니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 나무를 조사한다.");
            Console.WriteLine("2. 풀밭을 조사한다.");
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
                    Util.Print("나무를 조사합니다.", ConsoleColor.Cyan);
                    break;
                case ConsoleKey.D2:
                    Util.Print("풀밭을 조사합니다.", ConsoleColor.Cyan);
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Island");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    System.Threading.Thread.Sleep(500); // 0.5초 대기
                    break;
            }
        }
    }
    
    
}
