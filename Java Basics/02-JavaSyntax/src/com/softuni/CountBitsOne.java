package com.softuni;

public class CountBitsOne {

	public static void Count(int number){
		
		int temp = number;
		int count = 0;
		
		for (int i = 0; i < 16; i++) {
			if((temp & 1) != 0){
				count++;
			}
			temp = temp >> 1;
		}
		
		System.out.println(String.format("Number %d has %d turned on bits.", number,count));
		
	}
	
}
