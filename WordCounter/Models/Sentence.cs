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
		
		public string[] SentenceToWordArray()
		{
			string[] inputSentenceToArray = InputSentence.Split(' ');
			return inputSentenceArray;
		}

		public void WordChecker(string[] inputSentenceArray, string inputWord )
		{
			
		}
	}
}