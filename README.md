# _Word Counter_

#### _C# Independent Project : MSTest_, _Mar. 6, 2020_

#### By _**Dana Luukko**_

## Description

_This application allows a user to enter a sentence and a word that will be counted throughout the sentence. The frequency in which the user's word appears in the user's sentence will be counted and returned to the user. The user's word will only be counted if it stands alone. For example, if the user's word is "the" and the sentence contains the word "theatre", the word "theatre" will not be counted._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application allows a user to enter a word and constructs a word to be counted instance | "the" | new instance of word to be counted is created with "the" as property |
| Application askes the user to input a sentence from which the frequency of the word to be counted is derived| "The theatre is lovely this time of year." | Application forms Sentence instance with "the" as a string property and "The theatre is lovely this time of year" as a string property |
| Application converts sentence input into an array of words | "The theatre is lovely this time of year." | GetSentenceWordArray(); returns {'the', 'theatre', 'is', 'lovely', 'this', 'time', 'of', 'year'} |
| Application checks to see if the sentence array contains the input word  | InputWord : 'the' Sentence Array : {'the', 'theatre', 'is', 'lovely', 'this', 'time', 'of', 'year'} | SentenceChecker() returns {inputWord} count : 1|


## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* $ cd desktop
* $ git clone https://github.com/dcluukko/8-ind-proj-Word-Counter.git
* $ cd WordCounter.Solution

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dana Luukko_**