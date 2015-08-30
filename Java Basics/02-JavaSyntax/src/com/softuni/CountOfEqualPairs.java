package com.softuni;

public class CountOfEqualPairs {
	
	public static void Count(int number){
		int temp = number;
		int count = 0;
		
		int first = temp & 1;
		
		while(temp > 0){
			temp = temp >> 1;
			if ((temp & 1) == first) {
				count++;				
			}
			first = temp & 1;
		}
		
		System.out.println(String.format("Number %d has %d bit pairs.", number,count));
	}
	
}
