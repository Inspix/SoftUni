package com.softuni;

public class CountAllWords {
	public static void Count(String input){
		String[] words = input.split("[^a-zA-Z_0-9]+");
		System.out.println(words.length);		
	}
}
