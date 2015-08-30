package com.softuni;

import java.util.Scanner;

public class RectangleArea {
	
	public static void CalculateArea(int a, int b){
		System.out.println(String.format("The Area of a rectangle with sides A:%s and B:%s = %s",a,b,a * b));
	}
	
	public static void CalculateArea(){
		
		Scanner scan = new Scanner(System.in);
				
		int a = scan.nextInt();
		int b = scan.nextInt();
		
		scan.close();
		
		CalculateArea(a,b);
	}
	
}
