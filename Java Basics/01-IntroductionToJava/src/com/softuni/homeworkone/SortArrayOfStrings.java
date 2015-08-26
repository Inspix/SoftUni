package com.softuni.homeworkone;

public class SortArrayOfStrings {
	
	public static void Run(String... words){
		
		System.out.println("Unsorted:");
		System.out.println(String.join(", ", words));
		
		boolean finished = false;
		while(!finished){
			finished = true;
			for (int i = 0; i < words.length-1; i++) {
				if(words[i].compareTo(words[i+1]) > 0){
					String temp = words[i];
					words[i] = words[i+1];
					words[i + 1] = temp;
					finished = false;
				}
			}
		}
		
		System.out.println("Sorted:");
		System.out.println(String.join(", ", words));
		
	}
}
