using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class UninhabitedScene : BaseScene
    {
        private ConsoleKey input;
        public UninhabitedScene()
        {
            name = "Uninhabited";
        }
        public override void Render()
        {
            Util.Print("*          무인도              *",ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 휴가를 맞이하여 낚시를 하기 위해 바다로 향했습니다.");
            Console.WriteLine("태평양 미크로네시아의 풀로왓 환초에서 만선의 꿈을 꾸고 출항했습니다만...");
            Console.WriteLine("갑자기 밀어닥친 파도가 당신이 탄 보트의 선외모터를 휩쓰는 바람에 고장이 나고 말았습니다.");
            Console.WriteLine("당신은 그렇게 파도에 떠밀려 가던 중 불행 중 다행으로 한 무인도에 도착했습니다.");
            Console.WriteLine();
            Console.WriteLine("주위엔 인기척도 없으며 가진것은 낚시대 하나 뿐입니다. 당신은 어떻게 살아 남으시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 해변에 앉아 구조를 기다린다.");
            Console.WriteLine("2. 해변을 떠나 섬을 탐험한다.");
            Console.Write("어디로 가시겠습니까? ");
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
            switch(input)
            {
                case ConsoleKey.D1:
                    Game.GameOver("당신은 탈수로 사망하였습니다.");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Island");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    break;
            }
            
        }
    }
    
}
