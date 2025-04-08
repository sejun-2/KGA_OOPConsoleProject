using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    internal class CaveScene : BaseScene
    {
        private ConsoleKey input;
        public CaveScene()
        {
            name = "Cave";
        }
        public override void Render()
        {
            Util.Print("*          동굴 탐험              *", ConsoleColor.Yellow);
            Console.WriteLine();
            Console.WriteLine("당신은 해안가 동굴에 들어왔습니다.");
            Console.WriteLine("꽤 깊은 동굴이며 육안으론 끝이 보이지 않습니다.");
            Console.WriteLine("동굴 앞쪽은 사람이 누워 자기에도 충분히 넓고 쾌적해 보입니다.");
            Console.WriteLine("지친 당신은 누워 쉬고 싶은 마음이 간절합니다.");
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("1. 동굴 안쪽을 조사한다.");
            Console.WriteLine("2. 일단 누워 한숨 잔다.");
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
                    Game.GameOver("동굴 깊숙히 들어간 당신.\n박쥐와 여러 벌레들에 감염되어 사망하셨습니다...");
                    break;
                case ConsoleKey.D2:
                    Game.GameOver("동굴입구에서 잠이든 당신.\n만조에 순식간에 바닷물이 밀려와 그만... 사망하셨습니다...");
                    break;
                case ConsoleKey.D3:
                    Game.ChangeScene("Beach");
                    break;
                default:
                    Util.Print("잘못된 입력입니다. 다시 시도하세요.", ConsoleColor.Red);
                    break;
            }
        }
    }
    
    
}
