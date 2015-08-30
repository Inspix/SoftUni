package com.softuni;

import java.util.Scanner;

public class SmallestOf3Numbers {
	
	public static void Min(double a, double b, double c){
		System.out.println(String.format("The minimum number from : %s,%s,%s is = %s", a,b,c, Math.min(c,(Math.min(a, b)))));
	}
	
	public static void Min(){
		
		Scanner scan = new Scanner(System.in);
		
		double a = scan.nextDouble();
		double b = scan.nextDouble();
		double c = scan.nextDouble();
		
		scan.close();
		
		Min(a,b,c);		
	}
	
}
