using KGA_OOPConsoleProject.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class OceanScene : BaseScene
    {
        private ConsoleKey input;

        Food fish = new Food(); // 해양 생물 아이템 생성
        Player player = new Player(); // 플레이어 객체를 가져옵니다.

        public OceanScene()
        {
            name = "Ocean";
        }
        public override void Render()
        {
            Util.Print("*          바다 탐험              *", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 바다를 탐험하기로 결심했습니다.");
            Console.WriteLine("주변을 둘러보니 해양 생물들이 보입니다.");
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 해양 생물을 조사한다.");
            Console.WriteLine("2. 낚시를 한다.");
            Console.WriteLine("3. 뒤로가기.");
        }
        public override void Input()
        {
            input = Console.ReadKey(true).Key;  // true는 키를 누른 후 화면에 출력하지 않음
        }
        public override void Update()
        {
            // 예를 들어, 해양 생물 조사 결과를 업데이트하는 등의 작업을 수행할 수 있습니다.

            // 여기서는 랜덤으로 해양 생물 조사 성공 여부를 결정합니다.
            Random rand = new Random();
            int result = rand.Next(1, 10); // 1부터 3까지의 랜덤 숫자 생성
            switch (input)
            {
                case ConsoleKey.D1:
                    if (result >= 7)
                    {
                        Util.Print("해양 생물을 조사하는 중입니다...", ConsoleColor.Cyan);
                        System.Threading.Thread.Sleep(1000); // 1초 대기 -> 안하면 화면 초기 전환이 너무 빨라서 사라짐
                        Util.Print("해양 생물 조사가 성공했습니다.", ConsoleColor.Green);
                        System.Threading.Thread.Sleep(1000); // 1초 대기 
                        player.Inventory.Add(fish); // 플레이어의 인벤토리에 해양 생물 추가
                    }
                    else
                    {
                        Util.Print("해양 생물을 조사하는 중입니다...", ConsoleColor.Cyan);
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                        Util.Print("해양 생물 조사가 실패했습니다.", ConsoleColor.Red);
                        System.Threading.Thread.Sleep(1000); // 1초 대기 
                    }
                    break;
                case ConsoleKey.D2:
                    if (result >= 7)
                    {
                        Util.Print("낚시를 하는 중입니다...", ConsoleColor.Cyan);
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                        Util.Print("낚시에 성공했습니다.\n 물고기를 낚았습니다.", ConsoleColor.Green);
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                        player.Inventory.Add(fish); // 플레이어의 인벤토리에 해양 생물 추가
                    }
                    else
                    {
                        Util.Print("낚시를 하는 중입니다...", ConsoleColor.Cyan);
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                        Util.Print("낚시에 실패했습니다.", ConsoleColor.Red);
                        System.Threading.Thread.Sleep(1000); // 1초 대기
                    }
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }
            
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    player.activity(10); // 활동 시 체력 감소
                    break;
                case ConsoleKey.D2:
                    player.activity(10); // 활동 시 체력 감소
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Beach");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    System.Threading.Thread.Sleep(500); // 0.5초 대기
                    break;
            }
        }
    }
    
    
}
