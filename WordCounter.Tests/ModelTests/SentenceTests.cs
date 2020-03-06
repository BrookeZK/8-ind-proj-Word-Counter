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
		public void SentenceConstructor_CreatesInstanceOfWord_Word()
		{
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);

			string actual = sentence.InputWord;

			Assert.AreEqual(myWord, actual);
		}
		

		// [TestMethod]
		// public void SentenceToInputArray_ConvertsUserSentenceToArrayOfStrings_Array()
		// {
		// 	//Arrange
		// 	string mySentence = "These apples are the best apples in all the land.";
		// 	string myWord = "the";
		// 	Sentence sentence = new Sentence("the", "These apples are the best apples in all the land.");
		// 	//Act

		// 	char[] mySentenceArray = mySentence.SentenceToWordArray();
			// char [] sentenceArray.split(' ');
			//Assert
		// }
	}
}