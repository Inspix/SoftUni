package com.softuni.homeworkone;

import java.io.IOException;

public class Main {

	public static void main(String[] args) throws IOException {
		// Automatic Input
		
		PrintYourHometown.Run(); // Print Your Hometown
		System.out.println();
		
		PrintCurrentDateTime.Run(); // Print the Current Date and Time
		System.out.println();
		
		SumTwoNumbers.Run(5, 8); // Sum Two Numbers example 1
		SumTwoNumbers.Run(12,-7); // Sum Two Numbers example 2
		System.out.println();
		
		SortArrayOfStrings.Run("Sofia","Plovdiv","Varna","Pleven","Bourgas"); // Sort Array of Strings
		System.out.println();

		GeneratePDF.Run(); // Generate a PDF by External Library
		System.out.println("Press enter...");
		System.in.read();
	}
}