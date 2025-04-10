using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        // 플레이어의 기본 정보들
        public Vector2 position; // 플레이어 위치

        private Inventory inventory; // 플레이어 인벤토리
        public Inventory Inventory { get { return inventory; } } // 플레이어 인벤토리 접근자
        public bool[,] map;


        private int maxHP; // 플레이어 최대 체력
        public int MaxHP { get { return maxHP; } }

        private int curHP;  // 플레이어 현재 체력
        public int CurHP { get { return curHP; } }

        public Player()
        {
            inventory = new Inventory();    // 플레이어 인벤토리 초기화
            position = new Vector2(1,1);    // 플레이어 시작위치 지정.

            maxHP = 100; // 플레이어 최대 체력
            curHP = maxHP; // 플레이어 현재 체력
        }
        public void Eat(int amount)
        {
            curHP += amount; // 플레이어 체력 회복
            if (curHP > maxHP) // 최대 체력 초과 방지
            {
                curHP = maxHP;
            }
        }
        public void activity(int amount)
        {
            // 플레이어의 활동을 나타내는 메서드
            curHP -= amount; // 플레이어 체력 감소
            if (curHP < 0) // 체력 0 이하면 game over
            {
                Game.GameOver("체력이 전부 소진되어 사망하셨습니다."); // 게임 오버 처리
            }
        }
        public void Print()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('P');
            Console.ResetColor();
        }
        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    Move(input);
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
        }

        private void Move(ConsoleKey input)
        {
            Vector2 targetPos = position;

            switch (input)
            {
                case ConsoleKey.UpArrow:
                    targetPos.y--;
                    break;
                case ConsoleKey.DownArrow:
                    targetPos.y++;
                    break;
                case ConsoleKey.LeftArrow:
                    targetPos.x--;
                    break;
                case ConsoleKey.RightArrow:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }






        }
    }
}
