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
        public Vector2 Position; // 플레이어 위치
        private Inventory inventory; // 플레이어 인벤토리
        public Inventory Inventory { get { return inventory; } } // 플레이어 인벤토리 접근자

        private string Name { get; set; } // 플레이어 이름
    
        private int maxHP; // 플레이어 최대 체력
        public int MaxHP { get { return maxHP; } }

        private int curHP;  // 플레이어 현재 체력
        public int CurHP { get { return curHP; } }

        public Player() 
        {
            inventory = new Inventory(); // 플레이어 인벤토리 초기화

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







    }
}
