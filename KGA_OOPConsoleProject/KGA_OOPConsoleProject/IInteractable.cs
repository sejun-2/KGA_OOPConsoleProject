using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public interface IInteractable  // 상호작용할 수 있는 객체를 나타내는 인터페이스
    {
        public void Interact(Player player);  // 상호작용 메서드
    }
    
}

