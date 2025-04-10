using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Items
{
    public class Fruit : Item
    {
        public Fruit(Vector2 position) : base('Q', position)
        {
            name = "과일열매";
            description = "신선한 과일입니다. 소량의 체력을 회복합니다.";
        }

        public override void Use()
        {
            // 아이템 사용 로직
            Game.Player.Eat(30);
        }
    }
}
