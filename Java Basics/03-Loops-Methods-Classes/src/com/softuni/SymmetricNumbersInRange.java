package com.softuni;

import javax.naming.OperationNotSupportedException;

public class SymmetricNumbersInRange {
	
	public static void GetInRange(int min, int max) throws OperationNotSupportedException{
		if (min >= max) {
			throw new OperationNotSupportedException("The min cannot be equal or less than the max number.");
		}
		
		for (int i = min; i <= max; i++) {
			if (i < 10) {
				System.out.print(i + " ");
			}else if (i < 100) {
				int tens = i / 10;
				int ones = i % 10;
				
				if (tens == ones) {
					System.out.print(i + " ");
				}
			}else{
				int hundreds = i /100;
				int ones = i % 10;
				if(hundreds == ones){
					System.out.print(i + " ");
				}
			}
		}
		System.out.println();
	}
	
}
