package com.softuni;

import java.util.HashMap;
import java.util.Map.Entry;

public class MostFrequentWord {

	public static void Check(String input){
		HashMap<String,Integer> words = new HashMap<String,Integer>();
		
		String[] tokens = input.split("\\W+");
		
		for (String string : tokens) {
			if (words.containsKey(string.toLowerCase())) {
				words.compute(string.toLowerCase(), (x,y) -> ++y);
			}else {
				words.put(string.toLowerCase(), 1);
			}
		}
		
		int maxCount = 0;
		
		for(Entry<String,Integer> pair : words.entrySet()){
			if (maxCount < pair.getValue()) {
				maxCount = pair.getValue();
			}
		}
		
		for(Entry<String,Integer> pair : words.entrySet()){
			if (maxCount == pair.getValue()) {
				System.out.println(pair.getKey() + " -> " + pair.getValue() + "times");
			}
		}
	}
	
}
