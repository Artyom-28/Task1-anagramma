using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_Anagramma
{
	/// <summary>
	/// Logic for reversing each letter sequences in entered stringы
	/// </summary>
	public 	class Anagramma
	{
		private string _stringOriginal { get; set; }

		public Anagramma(string originalString)
		{
			_stringOriginal = originalString;
		}


		private string GetRewerseWord(string wordOriginal)
		{
			string wordReverse = String.Empty;
			int currentCharIndex = -1;
			Stack<char> stackChar = new Stack<char>();
			Dictionary<int, char> notLettersInfo = new Dictionary<int, char>();

			foreach (var charOriginalWord in wordOriginal.ToCharArray())
			{
				currentCharIndex++;
				if (Char.IsLetter(charOriginalWord))
				{
					stackChar.Push(charOriginalWord);
				}
				else
				{
					notLettersInfo.Add(currentCharIndex, charOriginalWord);
				}
			}

			wordReverse = string.Join("", stackChar.Select(e => e));
			foreach (var notLettersCharInfo in notLettersInfo)
			{
				wordReverse = wordReverse.Insert(notLettersCharInfo.Key, notLettersCharInfo.Value.ToString());
			}

			return wordReverse;
		}


		public string GetAnagramma()
		{
			StringBuilder anagrammaStr = new StringBuilder();
			bool isPreviosWordNotEmpty = false;
			
			if (string.IsNullOrEmpty( _stringOriginal))
			{
				return String.Empty;
			}

			List<string> wordsOriginalList = _stringOriginal.Split(" ", StringSplitOptions.None).ToList();

			foreach (var wordOriginal in wordsOriginalList)
			{
				string reverseWord = string.IsNullOrEmpty(wordOriginal) ? " " : GetRewerseWord(wordOriginal);

				anagrammaStr.Append((isPreviosWordNotEmpty ? " " : "") + reverseWord);
				isPreviosWordNotEmpty = !string.IsNullOrEmpty(wordOriginal);
			}

			if (string.IsNullOrEmpty(wordsOriginalList.Last()))
			{
				anagrammaStr.Remove(anagrammaStr.Length - 1, 1);
			}

			return anagrammaStr.ToString();
		}
	}
}
