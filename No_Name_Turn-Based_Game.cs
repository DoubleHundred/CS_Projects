/*
    "No Name Turn-Based RPG!"

    * Made By DoubleHundred
    * Ver Still Making...
    * It's practice of C#
    * CC - BY - NC - SA
    
 */

using System.Net.NetworkInformation;
using System;

using Game_System;
using Character;
using Food;

/* ========= Class ========= */

namespace Game_System
{
    class Player_system
    {

        /* ======= Settings ======= */

        public static void Start_settings()
        {
            int hp_temp = 0;
            int atk_temp = 0;
            string name_temp = null;

            Console.Write("\n\n당신의 이름은 무엇입니까?\n> ");
            name_temp = Console.ReadLine();

            Console.Write("\n\n당신의 체력은?\n> ");
            hp_temp = int.Parse(Console.ReadLine());

            Console.Write("\n\n좋습니다. 그렇다면 당신의 공격력은?\n> ");
            atk_temp = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n모든 설정이 완료되었습니다! \nname : {0} \nhp : {1} \natk : {2} \n\n\n", name_temp, hp_temp, atk_temp);

            Player.Hp_settings(hp_temp);
            Player.Atk_settings(atk_temp);
            Player.Name_settings(name_temp);

        } // Start_system

        /* ======= Input ======= */

        public static int Player_input()
        {
            int temp = 0;

            Console.Write("Write value and Enter\n>> ");
            temp = int.Parse(Console.ReadLine());


            return temp;

        } // Player_input

        public static void Wrong_Answer()
        {
            Console.WriteLine("\nWrong Value! \n");
            Player_input();

        } // Wrong_Answer

    } // Player_settings

} // Settings

namespace Character
{
    class Player
    {
        private static int hp;
        private static int atk;
        private static string name;

        /* ======= Player Settings ======= */

        public static void Hp_settings(int i)
        {
            hp = i;

        } // hp_settings

        public static void Atk_settings(int i)
        {
            atk = i;

        } // atk_settings

        public static void Name_settings(string a)
        {
            name = a;

        } // name_settings

        /* ======= Player Actions ======= */

        // 여기 설정해야함

    } // Player

    namespace Boss
    {
        public class Stage_1
        {
            public const string name = "Untitled";
            public int hp = 2000;
            public int atk = 10;

            /* ======= Boss Attack ======= */

            // 여기 설정해야함. 참고로 게임 시스템 어떻게 할건지 구상해야함.

        } // Stage_1

    } // Boss

} // Character

namespace Food
{

    /* ======= Food number ======= */

    public class Food_num
    {
        public static int[] food_num = new int[4] { 3, 2, 1, 1 };

        public static int Is_food_zero(int num)
        {
            if (food_num[num] <= 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }

        } // Is_food_zero

    } // Food_num

    /* ======= Food ======= */

    public class Apple
    {
        private const int recover = 3;

        public const int num = 0;
        public const string name = "apple";

    } // Apple

    public class Bread
    {
        private const int recover = 5;

        public const int num = 1;
        public const string name = "bread";

    } // Bread

    public class Cake
    {
        private const int recover = 7;

        public const int num = 2;
        public const string name = "cake";

    } // cake

    public class Somthing_strange
    {
        private const int recover = 9;

        public const int num = 3;
        public const string name = "somthing_strange";

    } // Something_strange

} // Food

/* ========= Main Code ========= */

namespace No_Name_Turn_Based_Game
{
    public class Program
    {
        public static void Main()
        {
            Player_system.Start_settings();


            Console.ReadKey();    // 창 바로 꺼지는 것 방지 / 아무 키나 누르시오..    

        } // Main

    } // Program

} // PnP_CS_230525_1_1
