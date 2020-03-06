using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
	public class Sentence
	{
		public string InputWord {get; set;}
		public string InputSentence {get; set;}
		public int WordCount = 0;

		public Sentence(string inputWord, string inputSentence)
		{
			InputWord = inputWord;
			InputSentence = inputSentence;
		}
		
		public string WordCleaner(string inputWord)
		{
			string cleanInputWord = inputWord.ToLower();
			return cleanInputWord;
		}
		public string SentenceCleaner(string inputSentence)
		{
			string cleanInputSentence = inputSentence.ToLower();
			return cleanInputSentence;
		}
		public string[] SentenceToWordArray(string cleanInputSentence)
		{
			string[] inputSentenceArray = cleanInputSentence.Split(' ');
			return inputSentenceArray;
		}

		public int SentenceChecker(string[] inputSentenceArray, string cleanInputWord)
		{
			foreach (string word in inputSentenceArray)
			{
				if (cleanInputWord.Contains(word))
				{
					WordCount += 1;
				}
				else
				{
					WordCount += 0;
				}
			}
			return WordCount;
		}                  
	}
}