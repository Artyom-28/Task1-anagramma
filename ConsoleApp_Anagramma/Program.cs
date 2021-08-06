using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp_Anagramma
{
	class Program
	{
		static void Main(string[] args)
		{
			string NewLine = "\r\n";
			bool quitFlag = false;
			do
			{
				Console.WriteLine($@"{NewLine}Ener your string to create anagramma{NewLine}(example   string: 'Dar3Vin red  888   лето21 '{NewLine} anagramma string: 'niV2raD der  888   отел21 '){NewLine}");
				
				if(!quitFlag)
				{
					string originalString = Console.ReadLine();
					string anagramma = (new Anagramma(originalString)).GetAnagramma();

					Console.Write($"Original  string: \"{originalString}\"{NewLine}");
					Console.Write($"Anagramma string: \"{anagramma}\"{NewLine}{NewLine}");
				}

				Console.WriteLine($"Quit - press 'q' or 'Q'{NewLine}Continue - press any key");
				char charQuit = Console.ReadKey().KeyChar;

				quitFlag = new List<char>() { 'q', 'Q' }.Contains(charQuit);
			}
			while (!quitFlag); 
		}
	}
}
