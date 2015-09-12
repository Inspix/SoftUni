package com.softuni;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CountSpecifiedWord {
	
	public static void CountWord(String sentence, String word){
		Pattern pattern = Pattern.compile("\\b" + word + "\\b",Pattern.CASE_INSENSITIVE);
		Matcher matches = pattern.matcher(sentence);
		int count = 0;
		while(matches.find()){
			count++;
		}
		
		System.out.println(count);
	}
	
}
