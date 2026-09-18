/*
 * Student ID : 1690703598
 * Name       : Thana Rodprasert
 * Section    : 129B
 * No.        : 35
 * Course     : GI113 Computer Programming (GI)
 */
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment1
{



    namespace Assignment1
    {
        // ==========================================================================
        //  SOUL KNIGHT — CHARACTER DATA MODULE
        //  ไฟล์นี้จำลองการแสดงผลข้อมูลตัวละครในเกม Soul Knight ในรูปแบบ "Stat Card"
        //  โดยใช้หลักการประกาศตัวแปรครบ 6 ชนิดข้อมูลพื้นฐานของ C#, การแปลงชนิดข้อมูล
        //  ทั้งแบบ Implicit และ Explicit และการจัดรูปแบบผลลัพธ์ให้อ่านง่ายแบบ UI เกม
        //  MMORPG โดยไม่มีการใช้ตัวดำเนินการทางคณิตศาสตร์ (+ - * /) ในทุกขั้นตอน
        // ==========================================================================
        internal class Program
        {
            static void Main(string[] args)
            {
                // ----------------------------------------------------------------
                // [1] ค่าคงที่ประจำเกม (const)
                // ใช้ PascalCase เพราะเป็นค่าคงที่ระดับโปรแกรม ไม่ควรเปลี่ยนแปลง
                // ไม่ว่าจะรันกี่ครั้งก็ตาม เปรียบเสมือนชื่อเกมที่ปักหมุดตายตัวไว้
                // บนหัวการ์ดตัวละครเสมอ
                // ----------------------------------------------------------------
                const string GameTitle = "SOUL KNIGHT";

                // ----------------------------------------------------------------
                // [2] ตัวแปรที่ใช้ var โดยให้ compiler อนุมานชนิดข้อมูลเอง
                // กลุ่มแรกเป็น string และ char ซึ่งเป็นข้อมูลประจำตัวละครที่ผู้เล่น
                // ตั้งค่าเอง จึงเหมาะกับการใช้ var เพื่อให้โค้ดอ่านลื่นและกระชับ
                // ----------------------------------------------------------------
                var knightName = "Frostblade Nova";   // var บนชนิด string
                var knightRank = 'S';                 // var บนชนิด char (S = Special Rank)

                // ----------------------------------------------------------------
                // [3] ตัวแปรชนิดข้อมูลพื้นฐานที่เหลือ ประกาศแบบระบุชนิดตรงๆ
                // เพื่อความชัดเจนของค่าที่มีผลต่อการคำนวณสถานะตัวละครในเกมจริง
                // ทุกตัวแปรตั้งชื่อแบบ camelCase และสื่อความหมายตรงกับสถานะที่ใช้
                // ----------------------------------------------------------------
                int weaponLevel = 8;                  // int    : เลเวลของอาวุธที่ถืออยู่
                float dodgeRate = 0.42f;              // float  : อัตราการหลบหลีกของตัวละคร
                double staminaPrecise = 63.75;        // double : ค่าพลังงาน (Stamina) แบบละเอียดทศนิยม
                bool isDungeonCleared = true;          // bool   : สถานะว่าผ่านดันเจี้ยนล่าสุดแล้วหรือยัง

                // ----------------------------------------------------------------
                // [4] แสดงการ์ดสถานะตัวละคร (Stat Card) ในสไตล์ UI เกม MMORPG
                // ใช้กรอบเส้น Unicode Box-Drawing เพื่อจำลองกรอบการ์ดในเกม พร้อม
                // สัญลักษณ์ตกแต่งให้ดูเหมือนหน้าต่างแสดงสถานะตัวละครของจริง
                // ----------------------------------------------------------------
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine($"║        ⚔  {GameTitle} — STAT CARD  ⚔        ║");
                Console.WriteLine("╠══════════════════════════════════════════════╣");
                Console.WriteLine($"║ ★ Name        : {knightName,-29}║");
                Console.WriteLine($"║ ★ Rank        : {knightRank,-29}║");
                Console.WriteLine($"║ ★ Weapon Lv.  : {weaponLevel,-29}║");
                Console.WriteLine($"║ ★ Dodge Rate  : {dodgeRate,-29}║");
                Console.WriteLine($"║ ★ Stamina     : {staminaPrecise,-29}║");
                Console.WriteLine($"║ ★ Dungeon OK  : {isDungeonCleared,-29}║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");
                Console.WriteLine();

                // ----------------------------------------------------------------
                // [5] Implicit Conversion (การแปลงชนิดข้อมูลแบบอัตโนมัติ)
                // นำค่า weaponLevel ซึ่งเป็น int ไปเก็บในตัวแปรชนิด double โดยตรง
                // โดยไม่ต้อง cast ใดๆ เพราะ C# อนุญาตให้แปลงจากชนิดข้อมูลที่มี
                // ขนาดเล็กกว่า (int) ไปเป็นชนิดข้อมูลที่มีขนาดใหญ่กว่า (double)
                // ได้โดยอัตโนมัติ เนื่องจากไม่มีความเสี่ยงข้อมูลสูญหาย
                // ----------------------------------------------------------------
                double weaponLevelForUpgradeMeter = weaponLevel; // implicit int -> double

                Console.WriteLine("┌──────────────────────────────────────────────┐");
                Console.WriteLine("│           UPGRADE METER (IMPLICIT)            │");
                Console.WriteLine("├──────────────────────────────────────────────┤");
                Console.WriteLine($"│ Weapon Lv. as double : {weaponLevelForUpgradeMeter,-22}│");
                Console.WriteLine("└──────────────────────────────────────────────┘");
                Console.WriteLine();

                // ----------------------------------------------------------------
                // [6] Explicit Cast vs Convert.ToInt32()
                // ใช้ค่าทศนิยมตัวเดียวกันคือ staminaPrecise (63.75) ซึ่งเลขหลัง
                // จุดทศนิยมตัวแรกคือ 7 (มากกว่าหรือเท่ากับ 5) เพื่อให้เห็นผลลัพธ์
                // ที่แตกต่างกันอย่างชัดเจนระหว่างสองวิธี:
                //   - (int) cast        : ตัดทศนิยมทิ้งตรงๆ (Truncate) โดยไม่ปัดเศษ
                //   - Convert.ToInt32() : ปัดเศษตามหลักคณิตศาสตร์ (Round) ก่อนแปลง
                // ผลลัพธ์จึงออกมาไม่เท่ากันจริง คือ 63 กับ 64 ตามลำดับ
                // ตัวแปรผลลัพธ์ใช้ var เพราะให้ compiler เดาชนิด int จากค่าที่
                // ฟังก์ชันแปลงชนิดข้อมูลส่งกลับมาให้เอง
                // ----------------------------------------------------------------
                var staminaTruncated = (int)staminaPrecise;              // explicit cast (ตัดทิ้ง)
                var staminaRounded = Convert.ToInt32(staminaPrecise);    // Convert (ปัดเศษ)

                Console.WriteLine("┌──────────────────────────────────────────────┐");
                Console.WriteLine("│         STAMINA CONVERSION COMPARISON         │");
                Console.WriteLine("├──────────────────────────────────────────────┤");
                Console.WriteLine($"│ Original Stamina         : {staminaPrecise,-18}│");
                Console.WriteLine($"│ (int) Cast (Truncate)    : {staminaTruncated,-18}│");
                Console.WriteLine($"│ Convert.ToInt32 (Round)  : {staminaRounded,-18}│");
                Console.WriteLine("└──────────────────────────────────────────────┘");
                Console.WriteLine();

                // ----------------------------------------------------------------
                // [7] ปิดท้ายการ์ดสถานะด้วยข้อความสรุปสไตล์เกม เพื่อให้ผู้เล่น
                // รู้สึกเหมือนกำลังอ่านหน้าจอ Character Info จริงๆ ในเกม
                // ----------------------------------------------------------------
                Console.WriteLine("══════════════════════════════════════════════════");
                Console.WriteLine($"   ✦ {knightName} the {knightRank}-Rank Knight is ready to dive! ✦");
                Console.WriteLine("══════════════════════════════════════════════════");
            }
        }
    }
}
            
        
    