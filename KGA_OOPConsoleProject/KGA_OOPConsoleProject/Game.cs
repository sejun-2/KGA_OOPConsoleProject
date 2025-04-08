using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public static class Game
    {
        // 게임에 필요한 정보들
        private static bool gameOver;
        //private Stack<string> sceneStack; // 씬 스택 (뒤로가기 기능을 위해서 씬을 스택에 저장함)

        // 화면 전환
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene CurScene;  // 현재 씬

        // 게임에 필요한 기능들
        // 1. 게임 시작
        public static void Start()
        {
            // 게임 시작시에 필요한 작업들
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Uninhabited", new UninhabitedScene());
            sceneDic.Add("Island", new IslandScene());
            sceneDic.Add("Beach", new BeachScene());
            sceneDic.Add("Forest", new ForestScene());
            sceneDic.Add("Cave", new CaveScene());

            CurScene = sceneDic["Title"]; // 현재 씬을 타이틀 씬으로 설정
        }

        //2. 게임 종료
        public static void End()
        {
            // 게임 종료시에 필요한 작업들
        }

        //3. 게임동작
        public static void Run()
        {
            // 게임 동작시에 필요한 작업들
            while (gameOver == false)
            {
                Console.Clear();    // 화면 초기화

                CurScene.Render();
                Console.WriteLine();
                CurScene.Input();
                Console.WriteLine();
                CurScene.Update();
                Console.WriteLine();
                CurScene.Result();
                Console.WriteLine();

            }
        }

        //4. 현재 씬을 변경하는 기능
        public static void ChangeScene(string sceneName)
        {
            if (sceneDic.ContainsKey(sceneName) == false)
            {
                Console.WriteLine("존재하지 않는 씬입니다.");
                return;
            }
            CurScene = sceneDic[sceneName];
            //curScene.Update();
        }

        //5. 게임 오버
        public static void GameOver(string reason)
        {
            Console.Clear();    // 화면 초기화
            Console.WriteLine("*******************************");
            Console.WriteLine("*           GameOver          *");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            Util.Print(reason, ConsoleColor.Cyan);

            gameOver = true;
        }

    }
}
