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

        // 화면 전환
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;  // 현재 씬

        // 게임에 필요한 기능들
        // 1. 게임 시작
        public static void Start()
        {
            // 게임 시작시에 필요한 작업들
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());

            curScene = sceneDic["Title"]; // 현재 씬을 타이틀 씬으로 설정
        }

        //2. 게임 종료
        public static void End()
        {
            // 게임 종료시에 필요한 작업들
            Console.WriteLine("Game Over!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        //3. 게임동작
        public static void Run()
        {
            // 게임 동작시에 필요한 작업들
            while (gameOver == false)
            {
                Console.Clear();    // 화면 초기화



            }
        }

    }
}
