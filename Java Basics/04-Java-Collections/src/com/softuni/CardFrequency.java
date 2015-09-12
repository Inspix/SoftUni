package com.softuni;

import java.util.ArrayList;
import java.util.HashMap;

public class CardFrequency {
	
	public static void Count(String input){
		HashMap<String,Integer> words = new HashMap<String,Integer>();
		
		String[] tokens = input.split(" ");
		ArrayList<String> unique = new ArrayList<String>();
		
		for (String string : tokens) {
			String face = string.substring(0,string.length()-1);
			if (words.containsKey(face)) {
				words.compute(face, (x,y) -> ++y);
			}else {
				words.put(face, 1);
				unique.add(face);
			}
		}
		for (int i = 0; i < unique.size(); i++) {
			String face = unique.get(i);
			System.out.printf("%s -> %.2f%n", face, (words.get(face) * words.size()) / (double)words.size()*10);
		}		
		System.out.println();
	}
	
}
