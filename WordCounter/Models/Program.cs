using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
	public class Program
	{
		 public static void Main()
		{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine(@" ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ ____ ____ 
||W |||O |||R |||D |||       |||C |||H |||E |||C |||K |||E |||R ||
||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|");
		InputGather();
		}
		public static void InputGather()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Where we count the frequency of words in a sentence!");
			Console.WriteLine("Enter a sentence:");
			string userSentence = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Enter a word you would like to count in your sentence:");
			string userWord = Console.ReadLine();
			DisplayOutput(userWord, userSentence);
		}
		public static void DisplayOutput(string userWord, string userSentence)
		{
			Sentence newSentence = new Sentence(userWord, userSentence);
			string cleanUserSentence = newSentence.SentenceCleaner(userSentence);
			string cleanUserWord = newSentence.WordCleaner(userWord);

			string[] userSentenceArray = newSentence.SentenceToWordArray(cleanUserSentence);

			Console.WriteLine("================================================");
			Console.WriteLine("Total count of the word " + " ' "+ (userWord) + " ' " + " in the sentence "+ " ' " + (userSentence) + " ' " + " : " + newSentence.SentenceChecker(userSentenceArray, cleanUserWord));
		}
	}
}