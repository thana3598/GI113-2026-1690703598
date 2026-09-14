/*
 * Student ID : 1690703598
 * Name       : Thana Rodprasert
 * Section    : 129B
 * No.        : 35
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== >> GAME TITTLE << ==");
            Console.WriteLine("Hero VS Monster -- Calculate Damage");

            // Hero Stats
            Console.Write("Hero HP: ");
            bool heroHPOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster Stats
            Console.Write("\nMonster HP: ");
            bool MonHPOk = int.TryParse(Console.ReadLine(), out int MonsHp);
            Console.Write("Monster Attack: ");
            bool MonAtkOk = int.TryParse(Console.ReadLine(), out int MonsAtk);
            Console.Write("Monster Defense: ");
            bool MonDefOk = int.TryParse(Console.ReadLine(), out int MonDef);

            // Check for valid input
            bool heroInputValid = heroHPOk && heroAtkOk && heroDefOk;
            bool monsterInputValid = MonHPOk && MonAtkOk && MonDefOk;
            Console.WriteLine($">> Hero Stats Valid: {heroInputValid}");
            Console.WriteLine($">> Monster Stats Valid: {monsterInputValid}");
            Console.WriteLine($"[Hero] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[Monster] HP: {MonsHp}, ATK: {MonsAtk}, DEF: {MonDef}");

            //Hero drink potion before the fight (compond assignment: += )
            int potionHeal = 14;
            //heroHp = heroHp + potionHeal ผลคือ114
            //heroHp += potionHeal ผลคือ114 การคำนวณเหมือนกัน เเต่เขียนสั้นกว่า
            heroHp += potionHeal;//Hero ดื่มHP potion
            Console.WriteLine($"\nHero drink potion, healing {potionHeal} HP,Hero HP is: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - MonDef); //โจมตีปกติ โดยการลบค่า
            Console.WriteLine($"Normal attack deals: {normalDamage} DMG");

            int powerDamage = Math.Max(0, (heroAtk * 2) - MonDef);//โจมตีพลังโดยการคูณ
            Console.WriteLine($"Power attack deals: {powerDamage} DMG");

            int counterDamage = Math.Max(0, MonsAtk - heroDef);//มอนสเตอร์โจมตีกลับ โดยการลบค่า ไม่ต้องเปลี่ยนสูตร เปลี่ยนเเค่ตัวเเปร
            Console.WriteLine($"Counter attack deals: {counterDamage} DMG");

            Random randomUnLucky = new Random();
            int roll = randomUnLucky.Next(1, 101); //สุ่ม1-100 หรือค่าอื่นๆ ต้อง+1
            bool isCrit = roll <= 10; // โอกาสเลข10 ตัวใน100 คือ10%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; //ได้ค่า1หรือ0 เป็นตัวกำหนดว่าจะติดคริหรือไม่
            Console.WriteLine($"Crit Damage roll: {roll} (Crit?: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");
        }
    }
}
