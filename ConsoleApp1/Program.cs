using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string repeat;
            do
            {

                headProgram("wira wongpol");//เรียกใช้ฟังชันที่สร้างไว้ 

                //รับค่า น้ำหนัก ส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                Console.WriteLine("input your weight(kg): ");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("input your height(cm): ");
                height = Convert.ToDouble(Console.ReadLine());
                line("#", 40);

                bmi(weight, height);//เรียกใช้ฟังชัน pirocess ประมวลผล

                line("%", 40);

                // ถามผู้ใช้ว่าต้องการคำนวณอีกครั้งหรือไม่

                Console.Write("Do you want to calculate again? (y/n): ");
                repeat = Console.ReadLine().ToLower();

            } while (repeat == "y");

            Console.WriteLine("Thank you for using the BMI calculator!");
        }
        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter; ;
            }
            Console.WriteLine(str);
        }
        static void headProgram(string programmerName)
        {
            Console.WriteLine("Body mass index (BMI)");
            line("*", 40);        
            WriteLineColer("Develop by " + programmerName, ConsoleColor.Red, ConsoleColor.White);
            line("-", 40);
            Console.WriteLine("Please input you Information");
        }
        
        static void WriteLineColer(string text,ConsoleColor fg,ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void bmi(double weight, double height)
        {

            //pirocess ประมวลผล
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "Obesity";
            }
            Console.WriteLine("Your Body mass index (BMI) is " + bmi.ToString("0.00"));
            Console.WriteLine("From your body mass index ,you are" + result);
        }
    }
}

 