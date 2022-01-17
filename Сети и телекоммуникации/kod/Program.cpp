//====================================================================================================
//The Free Edition of C# to C++ Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-csharp-to-cplus.html
//====================================================================================================

#include "Program.h"

namespace kod
{

	void Program::Main(std::vector<std::wstring> &args)
	{
		std::wcout << L"Введите код (из 0 и 1)" << std::endl;
		std::wstring s = L"";
		std::wstring sk = L"";
		std::wstring primer = L"";

		ConsoleKeyInfo key;

		do
		{
			key = Console::ReadKey(true);
			switch (key.Key)
			{
				case ConsoleKey::Backspace:
					if (s.length() > 0)
					{
						s.erase(s.length() - 1, 1);
						std::wcout << key.KeyChar << L" " << key.KeyChar;
					}
					break;
				default:
					if ((key.KeyChar <= 49) && (key.KeyChar >= 48))
					{
						std::wcout << key.KeyChar;
						s += key.KeyChar;
					}
					break;
			}
		} while (key.KeyChar != 13);
		std::wcout << L"\n---------------------------" << std::endl;

		primer = s;
//C# TO C++ CONVERTER TODO TASK: There is no C++ equivalent to the .NET String 'Insert' method unless assigning to the string instance:
		primer.insert(0, L"X")->Insert(1, L"X");

		sk = s; // для вывода
//C# TO C++ CONVERTER TODO TASK: There is no C++ equivalent to the .NET String 'Insert' method unless assigning to the string instance:
		s.insert(0, L"0")->Insert(1, L"0"); // вставка нулей в 0, 2^0
		int numBit = 2; //отсчет начинается с двух, так как первый два бита мы уже добавили

		for (int i = 4, j = 3; i < s.length(); i = static_cast<int>(std::pow(2, j)), j++)
		{
			numBit++;
			s.insert(i - 1, L"0");
			primer.insert(i - 1, L"X");
		}
		std::wcout << L"Кол-во контрольных бит: " << numBit << std::endl;
		std::wcout << s << std::endl;
		std::wcout << primer << std::endl;

		//int[] sBoss = s.Select(ch => int.Parse(ch.ToString())).ToArray(); //массив из целых чисел
		//char[] Boss = s.Select(ch => char.Parse(ch.ToString())).ToArray(); //массив из символов
		//string[] str = s.Select(ch => (ch.ToString())).ToArray(); //массив из подстрок

		//Console.WriteLine("\nТеперь это массив");
		//for (int i = 0; i < str.Length; i++)
		//{
		//    Console.WriteLine(" i:{0} /= {1}", i, str[i]);
		//}

		std::wcout << std::endl;

		std::wstring s1 = L"", s2 = L"", s3 = L"", s4 = L"", s5 = L"";
		int x = s.length();

		for (int i = 0; i < s.length() / 2; i++)
		{
			s1 += L"0";
		}
		for (int i = 0; i < s.length(); i = i + 2)
		{
			s1.insert(i, L"1");
		}
		std::wcout << s1 << std::endl;

		if (numBit >= 1)
		{
			for (int i = 0; i < s.length() / 2; i++)
			{
				s2 += L"0";
			}
			for (int i = 1; i < s.length(); i = i + 4)
			{
				s2.insert(i, L"11");
			}
			if (s2.length() > s1.length())
			{
				s2.erase(s2.length() - 1);
			}
			else if (s2.length() < s1.length())
			{
				s2 += L"0";
			}
			std::wcout << s2 << std::endl;
		}
		if (numBit >= 3) // это костыль костылей :)
		{
			s3 = s;
			s3 = StringHelper::replace(s3, L'1', L'0');

			for (int i = 3; i < s.length(); i = i + 8)
			{
					s3.insert(i, L"1111");
			}
			if (s3.length() > s2.length())
			{
				int raznica = s3.length() - s2.length();
				s3.erase(s3.length() - raznica);
			}
			std::wcout << s3 << std::endl;
		}

		if (numBit >= 4) // это костыль костылей :)
		{
			s4 = s;
			s4 = StringHelper::replace(s4, L'1', L'0');

			for (int i = 7; i < s.length(); i = i + 16)
			{
				s4.insert(i, L"11111111");
			}
			if (s4.length() > s3.length())
			{
				int raznica = s4.length() - s3.length();
				s4.erase(s4.length() - raznica);
			}
			std::wcout << s4 << std::endl;
		}

		if (numBit >= 5) // это костыль костылей :)
		{
			s5 = s;
			s5 = StringHelper::replace(s5, L'1', L'0');

			for (int i = 15; i < s.length(); i = i + 32)
			{
				s5.insert(i, L"1111111111111111");
			}
			if (s5.length() > s4.length())
			{
				int raznica = s5.length() - s4.length();
				s5.erase(s5.length() - raznica);
			}
			std::wcout << s5 << std::endl;
		}

		std::vector<int> sBoss = s.Select([&] (std::any ch)
		{
			return std::stoi(ch.ToString());
		})->ToArray(); //массив из целых чисел
		std::vector<int> sBoss1(0);
		std::vector<int> sBoss2(0);
		std::vector<int> sBoss3(0);
		std::vector<int> sBoss4(0);
		std::vector<int> sBoss5(0);

		if (numBit > 0)
		{
			sBoss1 = s1.Select([&] (std::any ch)
			{
				return std::stoi(ch.ToString());
			})->ToArray();
		}
		if (numBit >= 1)
		{
			sBoss2 = s2.Select([&] (std::any ch)
			{
				return std::stoi(ch.ToString());
			})->ToArray();
		}
		if (numBit >= 3)
		{
			sBoss3 = s3.Select([&] (std::any ch)
			{
				return std::stoi(ch.ToString());
			})->ToArray();
		}
		if (numBit >= 4)
		{

//====================================================================================================
//End of the allowed output for the Free Edition of C# to C++ Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-csharp-to-cplus.html
//====================================================================================================
