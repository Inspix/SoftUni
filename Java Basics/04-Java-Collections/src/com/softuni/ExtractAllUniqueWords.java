package com.softuni;

import java.util.HashSet;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractAllUniqueWords {

	public static void Extract(String input){
		HashSet<String> set = new HashSet<String>();
		
		Pattern pattern = Pattern.compile("\\b\\w+\\b", Pattern.CASE_INSENSITIVE);
		Matcher matches = pattern.matcher(input);
		
		while(matches.find()){
			String match = input.substring(matches.start(),matches.end());
			set.add(match.toLowerCase());
		}
		
		System.out.println(String.join(" ", set));
	}
}
