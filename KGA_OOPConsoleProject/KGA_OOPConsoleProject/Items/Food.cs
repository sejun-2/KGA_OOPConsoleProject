using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Items
{
    public class Food : Item
    {
        public Food() : base('I', new Vector2(0, 0))
        {
            name = "생선";
            description = "신선한 생선입니다. 소량의 체력을 회복합니다.";
        }

        public Food(Vector2 position) : base('I', position)
        {
            name = "생선";
            description = "신선한 생선입니다. 소량의 체력을 회복합니다.";
        }
        public override void Use()
        {
            // 아이템 사용 로직
            Game.Player.Eat(30);
        }

    }
    
    
}
