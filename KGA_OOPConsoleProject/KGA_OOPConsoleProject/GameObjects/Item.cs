using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.GameObjects
{
    public abstract class Item : GameObject
    {
        public string name; // 아이템 이름
        public string description; // 아이템 가치

        public Item(char symbol, Vector2 position) : base(ConsoleColor.Yellow, symbol, position, true)
        {
            
        }
        public override void Interact(Player player)
        {
            player.Inventory.Add(this); // 플레이어의 인벤토리에 아이템 추가
        }
        public abstract void Use(); // 아이템 사용 메서드
    }
    

    
}
