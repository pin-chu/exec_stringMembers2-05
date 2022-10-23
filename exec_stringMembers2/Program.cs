using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_stringMembers2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Q1將" abc "左右的空白刪除

			string originalvalue = " abc ";
			string trimResult = originalvalue.Trim();
			Console.WriteLine(trimResult);

            //Q2將字串"Allen kuo"轉AlEN KUO"

            string name1 = "Allen kuo";
            string nameup = name1.ToUpper();
            Console.WriteLine(nameup);

            //Q3將字串"aLLeN Kuo"轉"Allen kuo"

            string name2 = "aLLeN Kuo";
            string[] namelo = name2.ToLower().Split(' ');
            string name3 = "";

            for (int i = 0; i < namelo.Length; i++)
            {
                namelo[i] = namelo[i].Substring(0, 1).ToUpper()+namelo[i].Substring(1);
            }
            name3 = string.Join(" ", namelo);
            
            Console.WriteLine(name3);

            //Q4"1100225",轉成西元年20210225
            //string roc = "1100225";
            string roc = "1100225";
            int number = Convert.ToInt32(roc.Substring(0,3)) + 1911;
            string ad = number.ToString();
            Console.WriteLine(ad +roc.Substring(3));

            //Q5比對使用者輸入質是否為"Allen"不拘大小寫
            string answer = "Allen";
            Console.WriteLine("請輸入您的名字:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("您沒輸入");
            }
            else if (answer.ToLower() == input.ToLower())
            {
                Console.WriteLine("正確");
            }
            else
            {
                Console.WriteLine("error");
            }

            //Q6比對使用者輸入質是否為"Allen"區分大小寫
            string answer2 = "Allen";
            Console.WriteLine("請輸入您的名字:");
            string input2 = Console.ReadLine();

            if (string.IsNullOrEmpty(input2))
            {
                Console.WriteLine("您沒輸入");
            }
            if (answer2 == input)
            {
                Console.WriteLine("正確");
            }
            else
            {
                Console.WriteLine("error");
            }
            //Q7計算兩樹之和，並呈現小數二位數

            double n1 = 0.14159;
            double n2 = 0.34425;

            double sum = n1 + n2;

            Console.WriteLine(sum.ToString("0.00"));

            //Q8呈現0935****46
            Console.WriteLine(" 輸入您的電話");
            string phone = Console.ReadLine();
            if (string.IsNullOrEmpty(phone) || phone.Length != 10)
            {
                Console.WriteLine("格式不對");
                return;
            }
            string encryptedphone = phone.Substring(0, 4) + new string('*',4) + phone.Substring(8,2);
            Console.WriteLine(encryptedphone);







        }
    }
}
