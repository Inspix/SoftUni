package com.softuni;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractEmail {
	
	public static void Extract(String text){
		Pattern pattern = Pattern.compile("[\\w._-]*@[\\w._-]*\\w");
		Matcher matches = pattern.matcher(text);
		
		while(matches.find()){
			System.out.println(text.substring(matches.start(),matches.end()));
		}
		System.out.println();
		
	}
	
}
