using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
	public class Program
	{
		 public static void Main()
		{
				Console.WriteLine("Enter a sentence");
				string userSentence = Console.ReadLine();
				Console.WriteLine("Enter a word you would like to count in your sentence");
				string userWord = Console.ReadLine();

				Sentence newSentence = new Sentence(userWord, userSentence);
				string cleanUserSentence = newSentence.SentenceCleaner(userSentence);
				string cleanUserWord = newSentence.WordCleaner(userWord);

				string[] userSentenceArray = newSentence.SentenceToWordArray(cleanUserSentence);


				Console.WriteLine(newSentence.SentenceChecker(userSentenceArray, cleanUserWord));
		}
	}
}