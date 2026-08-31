/*
 * Student ID :1690703598
 * Name       :Lab03
 * Section    :129B 
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
using System.Collections;

namespace Lab03

{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            //boss stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"NAME: {bossName}" +
               $"\nRank: {rank}" +
               $"\nLevel: {level} / {MaxLevel}" +
               $"\nHP: {currentHp} / {maxHp}" +
               $"\nAttack Power: {attackPower}" +
               $"\nCrit Multiplier: {critMultiplier}" +
               $"\nIs Boss: {isBoss}");
            
            //Implicit Conversion: HP(int) as double
            Console.WriteLine("\n-----Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"Hp (double): {currentHpDouble}");

            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent(exact): { hpPercentExact}%");

            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critMultiplier = (int)critMultiplier;
            int critMultiplier = (int)Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (cast): {critMultiplier}");
            Console.WriteLine($"Crit Multiplier (Convert): {critMultiplier}");
        }
    }
}