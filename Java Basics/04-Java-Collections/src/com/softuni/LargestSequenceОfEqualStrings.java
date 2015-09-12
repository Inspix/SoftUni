package com.softuni;

import java.util.HashMap;
import java.util.Map;
import java.util.Map.Entry;

public class LargestSequenceОfEqualStrings {
	
	public static void FindLargest(String str){
		String[] words = str.split(" ");
		
		Map<String,Integer> wordsCount = new HashMap<String,Integer>();
		
		for (String string : words) {
			if(wordsCount.containsKey(string)){
				wordsCount.compute(string, (x,y) -> ++y);
			}else{
				wordsCount.put(string, 1);
			}
		}
		String biggest = "";
		int count = 0;
		for (Entry<String,Integer> pair : wordsCount.entrySet()) {
			if (pair.getValue() > count) {
				count = pair.getValue();
				biggest = pair.getKey();
			}
		}
		
		for (int i = 0; i < count; i++) {
			System.out.print(i == count -1 ? biggest : (biggest + " "));
		}
		System.out.println();
	}
}
