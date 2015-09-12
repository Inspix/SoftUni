package com.softuni;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSubstringOccurrences {

	public static void Count(String input,String word){
		Pattern pattern = Pattern.compile(word,Pattern.CASE_INSENSITIVE);
		Matcher matches = pattern.matcher(input);
		int index = 0;
		int count = 0;
		while(matches.find(index)){
			count++;
			index = matches.start()+1;
		}
		
		System.out.println(count);
	}
	
}
