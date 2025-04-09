using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public abstract class GameObject : IInteractable
    {
        public ConsoleColor color;
        public char symbol; // 게임 오브젝트 기호
        public Vector2 Position; // 게임 오브젝트 위치
        public bool isOnce; // 게임 오브젝트 활성화 여부

        public GameObject(ConsoleColor color, char symbol, Vector2 position, bool isOnce)
        {
            this.color = color;
            this.symbol = symbol;
            this.Position = position;
            this.isOnce = isOnce;
        }
        public void print() // 게임 오브젝트 출력 메서드
        {
            Console.SetCursorPosition((int)Position.x, (int)Position.y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ResetColor();
        } 

        public abstract void Interact(Player player); // 상호작용 메서드






    }
}
