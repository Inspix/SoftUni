package com.softuni;

public class Main {

	/*
	 * Almost every class has overloaded method for manual input...
	 * I make the homework this way, because its easier to test.
	 * */
	
	
	private static double[] arguments = new double[]{
			10, 	9.7,
			11.6, 	7,
			12.5, 	6,
			12.5, 	14.5,
			13.13, 	9.15,
			13.5, 	6.9,
			15, 	6,
			15.02, 	4.83,
			15.11, 	7.01,
			16.33, 	14.03,
			16.4, 	5.4,
			17.5, 	3,
			17.51, 	4.01,
			17.5, 	13.5,
			17.60, 	8.50,
			17.72, 	9.12,
			18.6, 	3.9,
			18.6, 	6,
			19.693, 13.4,
			20, 	6,
			21, 	7.5,
			21, 	13.5,
			21.3,	5.5,
			21.45,	9.7,
			22, 	14,
			22.5, 	8.5,
			23, 	7.5,
			23.001, 11.01	
	};
	
	public static void main(String[] args) {
		System.out.println("Rectangle Area:");
		RectangleArea.CalculateArea(7, 20);
		RectangleArea.CalculateArea(5, 12);
		System.out.println();
		
		System.out.println("Triangle Area:");
		TriangleArea.CalculateArea(-5,10,25,30,60,15);
		TriangleArea.CalculateArea(53,18,56,23,24,27);
		TriangleArea.CalculateArea(1, 1, 2, 2, 3, 3);		
		System.out.println();
		
		System.out.println("Points inside figure:");
		PointInsideFigure.Run(10, 9.7);
		PointInsideFigure.Run(11.6, 7);
		PointInsideFigure.Run(12.5, 6);
		PointInsideFigure.Run(12.5, 14.5);
		PointInsideFigure.Run(13.13, 9.15);
		PointInsideFigure.Run(15.02, 4.83);
		PointInsideFigure.Run(15.11, 7.01);
		PointInsideFigure.Run(16.33, 14.03);
		PointInsideFigure.Run(17.5, 13.5);
		PointInsideFigure.Run(17.60, 8.50);
		PointInsideFigure.Run(17.72, 9.12);
		PointInsideFigure.Run(18.6, 6);
		PointInsideFigure.Run(19.693, 13.4);
		PointInsideFigure.Run(21, 13.5);
		PointInsideFigure.Run(21.3, 5.5);
		PointInsideFigure.Run(21.45, 9.7);
		PointInsideFigure.Run(22, 14);
		PointInsideFigure.Run(22.5, 8.5);
		PointInsideFigure.Run(23, 7.5);
		PointInsideFigure.Run(23.001, 11.01);
		System.out.println();
		
		System.out.println("Smallest of three numbers:");
		SmallestOf3Numbers.Min(5,2,2);
		SmallestOf3Numbers.Min(2,2,1);
		SmallestOf3Numbers.Min(22,4,13);
		SmallestOf3Numbers.Min(0, -2.5, -5);
		SmallestOf3Numbers.Min(-1.1, -0.5, -0.1);
		System.out.println();
		
		System.out.println("Decimal to Hexadecimal:");
		DecimalToHex.Convert(254);
		DecimalToHex.Convert(6779);
		System.out.println();
		
		System.out.println("Format Numbers");
		FormatNumbers.Format(254, 11.6, 0.5);
		FormatNumbers.Format(499, -0.5559, 10000);
		FormatNumbers.Format(0, 3, -0.1234);
		FormatNumbers.Format(444, -7.5, 7.5);
		System.out.println();
		
		System.out.println("Count bits of one:");
		CountBitsOne.Count(5);
		CountBitsOne.Count(0);
		CountBitsOne.Count(15);
		CountBitsOne.Count(5343);
		CountBitsOne.Count(62241);
		CountBitsOne.Count(17263);
		System.out.println();
		
		System.out.println("Count bit pairs:");
		CountOfEqualPairs.Count(5);
		CountOfEqualPairs.Count(0);
		CountOfEqualPairs.Count(15);
		CountOfEqualPairs.Count(5343);
		CountOfEqualPairs.Count(62241);
		System.out.println();
		
		System.out.println("Points inside house:");
		PointInsideHouse.IsPointIn(10, 9.7);
		PointInsideHouse.IsPointIn(11.6, 7);
		PointInsideHouse.IsPointIn(12.5, 6);
		PointInsideHouse.IsPointIn(12.5, 14.5);
		PointInsideHouse.IsPointIn(13.13, 9.15);
		PointInsideHouse.IsPointIn(15.02, 4.83);
		PointInsideHouse.IsPointIn(15.11, 7.01);
		PointInsideHouse.IsPointIn(16.33, 14.03);
		PointInsideHouse.IsPointIn(17.5, 13.5);
		PointInsideHouse.IsPointIn(17.60, 8.50);
		PointInsideHouse.IsPointIn(17.72, 9.12);
		PointInsideHouse.IsPointIn(18.6, 6);
		PointInsideHouse.IsPointIn(19.693, 13.4);
		PointInsideHouse.IsPointIn(21, 13.5);
		PointInsideHouse.IsPointIn(21.3, 5.5);
		PointInsideHouse.IsPointIn(21.45, 9.7);
		PointInsideHouse.IsPointIn(22, 14);
		PointInsideHouse.IsPointIn(22.5, 8.5);
		PointInsideHouse.IsPointIn(23, 7.5);
		PointInsideHouse.IsPointIn(23.001, 11.01);
		System.out.println();
		
		System.out.println("Points inside house SVG");
		Svg.Setup();
		Svg.Run(arguments);
		System.out.println("Check house.html in the root folder.");
	}
}