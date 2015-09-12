package com.softuni;

public class Main {

	public static void main(String[] args) {
		
		System.out.println("Sort array of numbers:");
		SortArrayOfNumbers.Sort(new int[]{6, 5, 4, 10, -3, 120, 4});
		SortArrayOfNumbers.Sort(new int[]{10, 9, 8});
		SortArrayOfNumbers.Sort(new int[]{999});
		System.out.println();
		
		System.out.println("Sequences of Equal Strings:");
		SequencesOfEqualStrings.FindSequences("hi yes yes yes bye");
		SequencesOfEqualStrings.FindSequences("SoftUni softUni softuni");
		SequencesOfEqualStrings.FindSequences("1 1 2 2 3 3 4 4 5 5");
		SequencesOfEqualStrings.FindSequences("a b b xxx c c c");
		SequencesOfEqualStrings.FindSequences("hi hi hi hi hi");
		SequencesOfEqualStrings.FindSequences("hello");
		System.out.println();
		
		System.out.println("Largest Sequence of Equal Strings:");
		LargestSequenceОfEqualStrings.FindLargest("hi yes yes yes bye");
		LargestSequenceОfEqualStrings.FindLargest("SoftUni softUni softuni");
		LargestSequenceОfEqualStrings.FindLargest("1 1 2 2 3 3 4 4 5 5");
		LargestSequenceОfEqualStrings.FindLargest("a b b xxx c c c");
		LargestSequenceОfEqualStrings.FindLargest("hi hi hi hi hi");
		LargestSequenceОfEqualStrings.FindLargest("hello");
		System.out.println();
		
		System.out.println("Longest Increasing Sequence:");
		LongestIncreasingSequence.FindLongest(new int[]{2, 3, 4, 1, 50, 2, 3, 4, 5});
		LongestIncreasingSequence.FindLongest(new int[]{8, 9, 9 ,9, -1, 5, 2, 3});
		LongestIncreasingSequence.FindLongest(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9});
		LongestIncreasingSequence.FindLongest(new int[]{5, -1, 10, 20, 3, 4});
		LongestIncreasingSequence.FindLongest(new int[]{10, 9, 8, 7, 6, 5, 4, 3, 2, 1});
		System.out.println();
		
		System.out.println("Count all words:");
		CountAllWords.Count("Welcome to the Software University (SoftUni)!");
		CountAllWords.Count("I am coming...");
		CountAllWords.Count("It's OK, I'm in.");
		CountAllWords.Count("Java is a set of several computer software products and specifications from Oracle Corporation that provides a system for developing application software and deploying it in a cross-platform computing environment. Java is used in a wide variety of computing platforms from embedded devices and mobile phones on the low end, to enterprise servers and supercomputers on the high end.");
		System.out.println();
		
		System.out.println("Count specific word:");
		CountSpecifiedWord.CountWord("Welcome to the Software University (SoftUni)!","welcome");
		CountSpecifiedWord.CountWord("I am coming...","hello");
		CountSpecifiedWord.CountWord("It's OK, I'm in.","i");
		CountSpecifiedWord.CountWord("Java is a set of several computer software products and specifications from Oracle Corporation that provides a system for developing application software and deploying it in a cross-platform computing environment. Java is used in a wide variety of computing platforms from embedded devices and mobile phones on the low end, to enterprise servers and supercomputers on the high end.","is");
		System.out.println();
		
		System.out.println("Count substring occurrences:");
		CountSubstringOccurrences.Count("Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.", "wel");
		CountSubstringOccurrences.Count("aaaaaa", "aa");
		CountSubstringOccurrences.Count("ababa caba", "aba");
		CountSubstringOccurrences.Count("Welcome to SoftUni", "Java");
		System.out.println();
		
		System.out.println("Extract emails:");
		ExtractEmail.Extract("Please contact us at: support@github.com.");
		ExtractEmail.Extract("Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information. ");
		ExtractEmail.Extract("Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.  ");
		System.out.println();
		
		System.out.println("Combine List Of Letters:");
		CombineListsOfLetters.Combine("h e l l o", "l o w");
		CombineListsOfLetters.Combine("a b c d", "x y z");
		CombineListsOfLetters.Combine("a b a", "b a b a");
		CombineListsOfLetters.Combine("w e l c o m e t o s o f t u n i", "j a v a p r o g r a m m i n g");
		System.out.println();
		
		System.out.println("Combine List Of Letters:");
		ExtractAllUniqueWords.Extract("Welcome to SoftUni. Welcome to Java.");
		ExtractAllUniqueWords.Extract("What is better: Java SE or Java EE?");
		ExtractAllUniqueWords.Extract("hello");
		System.out.println();
		
		System.out.println("Most Frequent Word");
		MostFrequentWord.Check("in the middle of the night");
		MostFrequentWord.Check("Welcome to SoftUni. Welcome to Java. Welcome everyone.");
		MostFrequentWord.Check("Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.");
		System.out.println();
		
		System.out.println("Card frequency");
		CardFrequency.Count("8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦");
		CardFrequency.Count("J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠");
		CardFrequency.Count("10♣ 10♥");
		System.out.println();
		
		
	}

}
