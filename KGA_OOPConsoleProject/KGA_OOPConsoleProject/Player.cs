using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Player
    {
        // 플레이어의 기본 정보들
        private string Name { get; set; } // 플레이어 이름
    
        private int maxHP; // 플레이어 최대 체력
        public int MaxHP { get { return maxHP; } }

        private int curHP;  // 플레이어 현재 체력
        public int CurHP { get { return curHP; } }

        public Player() 
        {
            maxHP = 100; // 플레이어 최대 체력
            curHP = maxHP; // 플레이어 현재 체력
        }







    }
}
