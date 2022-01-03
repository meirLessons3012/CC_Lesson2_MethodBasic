using System;

namespace Lesson2_MethodBasic
{
    internal class Program
    {
        static int userAge = 0;

        static void Main(string[] args)
        {
            //if (args.Length > 0)
            //    Console.WriteLine("From args:" + args[0]);

            ////Console.ReadLine();
            ////Console.WriteLine("Hello World!");
            //Console.WriteLine($"userAge = {userAge}.");
            ////לא מקבלת פרמטרים ולא מחזירה ערכים
            //SayHelloFiveTimes();

            ////לא מקבלת פרמטאים ולא מחזירה ערכים
            //PrintUserAge();

            ////לא מקבלת פרמטרים אבל מחזירה מספר
            //int hour = GetCurrentHour();
            //Console.WriteLine($"Current Hour: {hour}");
            //Console.WriteLine(GetCurrentHour());//short way



            ////פונקציה שמקבלת ומחזירה ערכים
            int myNum = int.Parse("23");
            string content = Console.ReadLine();
            bool isSucces = TrySendMessage(token: "asfac", text: "hay" , toNumber: 1726391);

            bool isSucces1 = TrySendMessage(myNum, content, "a1b2c3");
            //bool isSucces2 = TrySendMessage(-2, "Hello Meir", "a1b2c3");
            //bool isSucces3 = TrySendMessage(0546359856, "", "a1b2c3");

            ////קריאה לפונקציות מתוך פונקציה אחרת
            //string userDetails = GetUserDetails();

            #region Exr 1

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("enter word: ");
            //    string word = Console.ReadLine();
            //    PrintWord(word);
            //}

            int[] myNums = { 3, 12, 52, 14, 10,65,13,9,1 };
            GetIntsArray(myNums);

            #endregion
        }

        public static void SayHelloFiveTimes()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }

        public static void PrintUserAge()
        {
            Console.Write("enter your age(only numbers):");
            userAge = 34;//int.Parse(Console.ReadLine());
            Console.WriteLine($"your age is {userAge}");
        }

        public static int GetCurrentHour()
        {
            int curHour = DateTime.Now.Hour;
            return curHour;
        }

        public static bool TrySendMessage(int toNumber, string text, string token)
        {
            if (string.IsNullOrEmpty(text) || toNumber <= 0 || token != "a1b2c3")
                return false;

            Console.WriteLine($"send {text} to {toNumber}...");
            return true;
        }

        public static string GetUserDetails()
        {
            string name = GetNameFromUser();//moshe
            string phone = GetPhoneFromUser();//0123140123
            int age = GetAgeFromUser();//23

            string allDetails = $"Name {name}. Phene: {phone}. Age: {age}";
            return allDetails;
        }

        public static string GetNameFromUser()
        {
            string name;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || name.Length < 3 || name.StartsWith("1"))
                GetNameFromUser();//רקורסיה

            return name;
        }

        public static int GetAgeFromUser()
        {
            int age;

            do
            {
                Console.Write("Enter Your Age: ");
                age = int.Parse(Console.ReadLine());

            } while (age <= 0 || age > 120);

            return age;
        }

        public static string GetPhoneFromUser()
        {
            string phone;

            do
            {
                Console.Write("Enter Your phone: ");
                phone = Console.ReadLine();

            } while (string.IsNullOrEmpty(phone) || phone.Length < 7 || phone.StartsWith(" "));

            return phone;
        }

        public static void PrintWord(string wordToPrint)
        {
            Console.WriteLine(wordToPrint);
        }

        public static void GetIntsArray(int[] theArray)
        {
            for (int i = 0; i < theArray.Length; i++)
            {
                PrintNumber(theArray[i] * 2);
            }
        }

        public static void PrintNumber(int theNumber)
        {
            Console.WriteLine(theNumber);
        }
    }
}
