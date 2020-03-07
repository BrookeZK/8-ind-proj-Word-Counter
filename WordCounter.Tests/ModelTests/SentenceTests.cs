using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
	[TestClass]
	public class SentenceTests
	{
		[TestMethod]
		public void SentenceConstructor_CreatesInstanceOfSentence_Word()
		{
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);

			string actual = sentence.InputWord;

			Assert.AreEqual(myWord, actual);
		}
		[TestMethod]
		public void SentenceConstructor_CreatesInstanceOfSentence_Sentence()
		{
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);

			string actual = sentence.InputSentence;

			Assert.AreEqual(mySentence, actual);
		}
		[TestMethod]
		public void inputWord_WordCleaner_Word()
		{
			//Arrange
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence inputFunSentence = new Sentence("WORD", mySentence);
			//Act
			string myLowerWord = myWord.ToLower();
			string lowerWord = inputFunSentence.WordCleaner(myWord);
			//Assert
			Assert.AreEqual(myLowerWord, lowerWord);
		}
		[TestMethod]
		public void inputSentence_SentenceCleaner_Sentence()
		{
			//Arrange
			string myWord = "word";
			string mySentence = "THESE APPLES ARE THE BEST APPLES IN ALL THE LAND";
			Sentence inputFunSentence = new Sentence(myWord, "these apples are the best apples in all the land");
			//Act
			string myLowerSentence = mySentence.ToLower();
			string lowerSentence = inputFunSentence.WordCleaner(mySentence);
			//Assert
			Assert.AreEqual(myLowerSentence, lowerSentence);
		}
		

		[TestMethod]
		public void SentenceToWordArray_ConvertsUserSentenceToArrayOfStrings_Array()
		{
			//Arrange
			string mySentence = "These apples are the best apples in all the land.";
			Sentence inputFunSentence = new Sentence("the", mySentence);
			//Act

			string [] mySentenceArray = mySentence.Split(' ');
			string [] sentenceArray = inputFunSentence.SentenceToWordArray(mySentence);
			
			//Assert
			CollectionAssert.AreEqual(mySentenceArray, sentenceArray);
		}
		[TestMethod]
		public void SentenceChecker_ChecksSentenceForWordAnReturnsWordCount_Integer()
		{
			//Arrange
			string myWord = "the";
			string mySentence = "these the apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);
			//Act
			string[] intoArray = sentence.SentenceToWordArray(mySentence);
			int result = sentence.SentenceChecker(intoArray, myWord);
			//Assert
			Assert.AreEqual(result, 3);
		}
	}
}