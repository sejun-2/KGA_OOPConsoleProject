using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject.Scenes
{
    public class ForestScene : FieldScene
    {
        public ForestScene()
        {
            name = "Forest";

            mapData = new string[]
            {
                "  ######",
                "#      #",
                "#      #",
                "#   ## #",
                "#   #  #",
                "########"
            };

            map = new bool[6, 8];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            
        }

        public override void Enter()
        {
            if (Game.prevSceneName == "NormalField")
            {
                Game.Player.Position = new Vector2(1, 1);
            }
            Game.Player.map = map;
        }

    }

    
    
}
