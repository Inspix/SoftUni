package com.softuni;

import java.util.ArrayList;

public class CombineListsOfLetters {
	
	public static void Combine(String first, String second){
		String[] tokens = first.split(" ");
		String[] tokens2 = second.split(" ");
		
		ArrayList<String> firstList = new ArrayList<String>();
		ArrayList<String> secondList = new ArrayList<String>();
		
		for (String string : tokens) {
			firstList.add(string);
		}
		
		for (String string : tokens2) {
			if (firstList.contains(string)) {
				continue;
			}
			secondList.add(string);
		}
		
		System.out.print(String.join(" ", firstList) + " ");
		System.out.print(String.join(" ", secondList));
		System.out.println();
	}
}
