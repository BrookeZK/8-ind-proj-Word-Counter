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
		public void SentenceToWordArray_ConvertsUserSentenceToArrayOfStrings_Array()
		{
			//Arrange
			string mySentence = "These apples are the best apples in all the land.";
			Sentence inputFunSentence = new Sentence("the", mySentence);
			//Act

			string [] sentenceArray = mySentence.Split(' ');
			string [] mySentenceArray = inputFunSentence.SentenceToWordArray(mySentence);
			
			//Assert
			CollectionAssert.AreEqual(mySentenceArray, sentenceArray);
		}
		[TestMethod]
		public void SentenceChecker_ChecksSentenceForWordAnReturnsWordCount_Integer()
		{
			//Arrange
			string myWord = "the";
			string mySentence = "these apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);
			//Act
			string[] intoArray = sentence.SentenceToWordArray(mySentence);
			int result = sentence.SentenceChecker(intoArray);
			//Assert
			Assert.AreEqual(result, 2);
		}

	}
}