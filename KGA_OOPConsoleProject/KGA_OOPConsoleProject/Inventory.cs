﻿using KGA_OOPConsoleProject.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    public class Inventory
    {
        private List<Item> items; // 아이템 리스트
        private Stack<string> stack;
        private int selectIndex; // 선택된 아이템 인덱스

        public Inventory()
        {
            items = new List<Item>(); // 아이템 리스트 초기화
            stack = new Stack<string>();
        }
        public void Add(Item item)
        {
            items.Add(item); // 아이템 추가
        }
        public void Remove(Item item)
        {
            items.Remove(item); // 아이템 제거
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items.RemoveAt(index); // 인덱스에 해당하는 아이템 제거
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다.");
            }
        }
        public void UseAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                items[index].Use(); // 인덱스에 해당하는 아이템 사용
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다.");
            }
        }

        public void Open()
        {
            stack.Push("Menu"); // 메뉴를 스택에 추가
            while (stack.Count > 0)
            {
                Console.Clear(); // 화면 지우기
                switch (stack.Peek())   // 스택의 맨 위 요소를 확인
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "DropMenu":
                        DropMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "DropConfirm":
                        DropConfirm();
                        break;
                }
            }
        }

        private void Menu()
        {
            PrintAll();

            Console.WriteLine("1. 사용하기");
            Console.WriteLine("2. 버리기");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key; // true는 키를 누른 후 화면에 출력하지 않음
            switch (input)
            {
                case ConsoleKey.D1:
                    stack.Push("UseMenu");
                    break;
                case ConsoleKey.D2:
                    stack.Push("DropMenu");
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        private void UseMenu()
        {
            PrintAll();

            Console.WriteLine("사용할 아이템을 선택해 주세요.");
            Console.WriteLine("0. 뒤로가기");

            ConsoleKey input = Console.ReadKey(true).Key; // true는 키를 누른 후 화면에 출력하지 않음
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1; // 선택한 아이템 인덱스
                if(select < 0 || items.Count <= select)
                {
                    Console.WriteLine("잘못된 선택입니다.");
                }
                else
                {
                    selectIndex = select;
                    stack.Push("UseConfirm");
                }
            }
        }

        private void DropMenu()
        {
            PrintAll();

            Console.WriteLine("버릴 아이템을 선택해주세요.");
            Console.WriteLine("뒤로가기는 0");

            ConsoleKey input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
            }
            else
            {
                int select = (int)input - (int)ConsoleKey.D1;
                if (select < 0 || items.Count <= select)
                {
                    Util.Print("범위 내의 아이템을 선택하세요.", ConsoleColor.Yellow);
                }
                else
                {
                    selectIndex = select;
                    stack.Push("DropConfirm");
                }
            }
        }

        private void UseConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} 을/를 사용하시겠습니까? (y/n)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    selectItem.Use();
                    Util.Print($"{selectItem.name} 을/를 사용했습니다.", ConsoleColor.Yellow);
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }

        private void DropConfirm()
        {
            Item selectItem = items[selectIndex];
            Console.WriteLine("{0} 을/를 버리시겠습니까? (y/n)", selectItem.name);

            ConsoleKey input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.Y:
                    Util.Print($"{selectItem.name} 을/를 버렸습니다.", ConsoleColor.Yellow);
                    Remove(selectItem);
                    stack.Pop();
                    break;
                case ConsoleKey.N:
                    stack.Pop();
                    break;
            }
        }

        public void PrintAll()
        {
            Player player = new Player();
            Console.WriteLine("체력 : {0}", player.MaxHP);
            Console.WriteLine();
            Console.WriteLine("===============소유한 아이템===============");
            if (items.Count == 0)
            {
                Console.WriteLine(" 없음 ");
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("{0}. {1} : {2}", i + 1, items[i].name, items[i].description);
            }
            Console.WriteLine("===========================================");
        }

    }
}
