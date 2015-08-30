package com.softuni;

import java.util.Scanner;

public class FormatNumbers {
	
	// Direct input
	public static void Format(int a, double b, double c){
		String result = String.format("|%-10s|%-10s|%10.2f|%-10.3f",
				Integer.toHexString(a).toUpperCase(),
				binaryWithPadding(a),
				b,
				c);
		
		System.out.println(result);
	}
	
	// Manual Input
	public static void Format(){
		Scanner scan = new Scanner(System.in);
		
		int a = scan.nextInt();
		double b = scan.nextDouble();
		double c = scan.nextDouble();
		
		scan.close();
		
		Format(a,b,c);
		
	}
	
	private static String binaryWithPadding(int number){
		return String.format("%10s", Integer.toBinaryString(number)).replace(' ','0');
	}
}
