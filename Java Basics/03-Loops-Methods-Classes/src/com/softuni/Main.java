package com.softuni;

import javax.naming.OperationNotSupportedException;

import com.softuni.products.ProductParser;

public class Main {

	public static void main(String[] args) {
		
		System.out.println("Symmetric Numbers in Range:");
		try {
			SymmetricNumbersInRange.GetInRange(5, 11);
			SymmetricNumbersInRange.GetInRange(101,110);
			SymmetricNumbersInRange.GetInRange(555, 777);
		} catch (OperationNotSupportedException e) {			
			e.printStackTrace();
		}
		System.out.println();
		
		System.out.println("Generate 3 letter words.");
		Generate3LetterWords.Generate("x");
		Generate3LetterWords.Generate("ab");
		Generate3LetterWords.Generate("abx");
		System.out.println();
		
		System.out.println("Generate Full houses");
		FullHouse.Generate();
		System.out.println();
		
		System.out.println("Angle Unit Converter");
		AngleUnitConverter.Convert("180 deg");
		AngleUnitConverter.Convert("90 deg");
		AngleUnitConverter.Convert("3 rad");
		AngleUnitConverter.Convert("3.141592 rad");
		AngleUnitConverter.Convert("5.5 rad");
		AngleUnitConverter.Convert("0 rad");
		AngleUnitConverter.Convert("120 deg");
		AngleUnitConverter.Convert("1.55 rad");
		AngleUnitConverter.Convert("2.1 rad");
		System.out.println();
		
		System.out.println("Random hands of 5 Cards");
		RandomHandsOf5Cards.GetHands(5);
		System.out.println();
		RandomHandsOf5Cards.GetHands(3);
		System.out.println();
		
		System.out.println("Days between 2 dates");
		DaysBetween2Dates.GetDifference(new String[]{"1-01-2014","2-01-2014"});
		DaysBetween2Dates.GetDifference(new String[]{"28-02-2000","8-03-2000"});
		DaysBetween2Dates.GetDifference(new String[]{"30-11-2014","27-03-2015"});
		DaysBetween2Dates.GetDifference(new String[]{"14-05-2014","14-06-1980"});
		System.out.println();
		
		System.out.println("Sum numbers from file:");
		SumNumbersFromFile.CalculateFromFile("src/first.txt");
		SumNumbersFromFile.CalculateFromFile("src/second.txt");
		SumNumbersFromFile.CalculateFromFile("src/third.txt");
		System.out.println();
		
		System.out.println("List of products:");
		ProductParser.ReadProductsFromFile("src/Input.txt","src/Output.txt");
		System.out.println();
		ProductParser.ReadProductsFromFile("src/Input2.txt","src/Output2.txt");
		System.out.println();
		
		System.out.println("Order of products:");
		ProductParser.calculateOrder("src/Products.txt", "src/Order.txt", "src/OrderTotal.txt");
		System.out.println();
		ProductParser.calculateOrder("src/Products2.txt", "src/Order2.txt", "src/OrderTotal2.txt");
		System.out.println();
		
		Excel.Run();
	}	
}