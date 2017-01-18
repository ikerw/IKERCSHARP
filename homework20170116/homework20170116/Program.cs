using System;

namespace homework20170116
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// for/while loop practice 

			// 1. write a for loop that sums from 1 to n
			//int n = 10;
			//int n_sum = 0;
			//for (int i = 0; i <= n; i++)
			//{
			//	n_sum = n_sum + i;	
			//}

			//Console.Write(n_sum);

			// 2. Keep asking for username and password unless username = "hello" or password = "123"
			//Console.WriteLine("Please enter your username");
			//string userName = Console.ReadLine();
			//Console.WriteLine("Please enter your password");
			//string password = Console.ReadLine();

			//while (userName != "hello" || password != "123")
			//{
			//	Console.WriteLine("Please enter your username");
			//	userName = Console.ReadLine();
			//	Console.WriteLine("Please enter your password");
			//	password = Console.ReadLine();	
			//}

			// 3. enter numbers; end and return the sum when the user types "end"
			//double sumEntry = 0.0;
			//Console.WriteLine("Please enter a number, or \"end\" to obtain the sum");
			//string entry = Console.ReadLine();
			//while (entry != "end")
			//{
			//	sumEntry = sumEntry + Convert.ToDouble(entry);
			//	Console.WriteLine("Please enter a number, or \"end\" to obtain the sum");
			//	entry = Console.ReadLine();
			//}
			//Console.WriteLine("The sum of your entries is " + sumEntry);

			// 4. Fibonacci
			//Fibonacci(8);

			// String Practice

			// 1. Reverse string
			//string stringTest = "abcdef";
			//Console.WriteLine(ReverseString(stringTest));

			// 2. Reverse sentence
			//string sentence = "I think C# is fun";
			//Console.WriteLine(ReverseSentence(sentence));

			// 3. Extract username and domain name from email address
			//Console.WriteLine("Please enter your E-mail address");
			//string address = Console.ReadLine();

			//char standard = '@';
			//char standardNew = '.';

			//string[] splitEmail = address.Split(standard);
			//string username = splitEmail[0];

			//string domain = splitEmail[1];
			//string[] domainNew = domain.Split(standardNew);
			//domain = domainNew[0];

			//Console.WriteLine("Your username is " + username);
			//Console.WriteLine("Your domain is " + domain);

			// 4. Convert all numeric character in an input string to respective word

			//string testS = "abc1sc2olc3";
			//char[] test = testS.ToCharArray();
			//string[] testNew = new string[test.Length];

			//for (int i = 0; i < test.Length; i++)
			//{
			//	testNew[i] = test[i].ToString();
			//}


			//for (int i = 0; i < testNew.Length; i++)
			//{
			//	if (testNew[i] == "1")
			//	{
			//		testNew[i] = "one";
			//	}
			//	else if (testNew[i] == "2")
			//	{
			//		testNew[i] = "two";
			//	}
			//	else if (testNew[i] == "3")
			//	{
			//		testNew[i] = "three";
			//	}
			//	else if (testNew[i] == "4")
			//	{
			//		testNew[i] = "four";
			//	}
			//	else if (testNew[i] == "5")
			//	{
			//		testNew[i] = "five";
			//	}
			//	else if (testNew[i] == "6")
			//	{
			//		testNew[i] = "six";
			//	}
			//	else if (testNew[i] == "7")
			//	{
			//		testNew[i] = "seven";
			//	}
			//	else if (testNew[i] == "8")
			//	{
			//		testNew[i] = "eight";
			//	}
			//	else if (testNew[i] == "9")
			//	{
			//		testNew[i] = "nine";
			//	}
			//	else if (testNew[i] == "0")
			//	{
			//		testNew[i] = "zero";
			//	}
			//}
			//string newTestS = string.Join("", testNew);
			//Console.WriteLine(newTestS);
		}

		static void Fibonacci(int n)
		{
			int[] fibonacci = new int[n+1];
			fibonacci[0] = 0;
			fibonacci[1] = 1;

			for (int i = 2; i <= n; i++)
			{
				fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
				Console.WriteLine(i + ":" + fibonacci[i]);
			}
		}

		public static string ReverseString(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		public static string ReverseSentence(string s)
		{
			char space = ' ';
			string[] splitString = s.Split(space);
			string[] reversedString = new string[s.Length];
			string revS = "";
			for (int i = 0; i < splitString.Length; i++)
			{
				reversedString[i] = splitString[splitString.Length - i - 1];
				revS = revS + reversedString[i] + " ";
			}
			return revS;
		}
	}
}
