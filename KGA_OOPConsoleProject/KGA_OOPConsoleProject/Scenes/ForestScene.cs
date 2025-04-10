using KGA_OOPConsoleProject.GameObjects;
using KGA_OOPConsoleProject.Items;
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
                "################################",
                "# #       #      #      #      #",
                "# #  #### # ###### ######   # ##",
                "# #     # # #              ##  #",
                "# ####  # # ###### #############",
                "#       # #                    #",
                "######### ########## #######  ##",
                "#         #          #         #",
                "# #########  ##### ###  ###### #",
                "# #       #      # #    #      #",
                "# #  ## # #####  # #  ### ######",
                "# #   # #        # #  #        #",
                "# ##### ######## # ########### #",
                "#                #         # # #",
                "################################"
            };

            map = new bool[15, 32];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    map[y, x] = mapData[y][x] == '#' ? false : true;
                }
            }

            gameObjects = new List<GameObject>();
            gameObjects.Add(new Fruit(new Vector2(1, 4)));
            gameObjects.Add(new Fruit(new Vector2(5, 11)));
            gameObjects.Add(new Fruit(new Vector2(23, 11)));
            gameObjects.Add(new Place("Beach", 'B', new Vector2(30, 13)));
        }

        public override void Enter()
        {
            if (Game.prevSceneName == "Beach")
            {
                Game.Player.position = new Vector2(30, 13);
            }
            Game.Player.map = map;
        }

    }

    
    
}
