package com.softuni;

public class DecimalToHex {
	
	public static void Convert(int a){
		System.out.println(
				String.format("Integer %s in decimal is %s in hexadecimal."
						, a
						, Integer.toHexString(a).toUpperCase()));
	}
	
}
