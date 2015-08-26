package com.softuni.homeworkone;

import java.util.Scanner;

public class SumTwoNumbers {
	
	public static void Run(){
		
		Scanner scanner = new Scanner(System.in);
		
		int a = scanner.nextInt();
		int b = scanner.nextInt();
		
		scanner.close();
		System.out.println(String.format("%d + %d = %d",a,b, a+b));
	}
	
	public static void Run(int a, int b){
				
		System.out.println(String.format("%d + %d = %d",a,b, a+b));
	}
}
