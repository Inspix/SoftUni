package com.softuni;

public class SequencesOfEqualStrings {
	
	public static void FindSequences(String str){
		String[] words = str.split(" ");
		String last = "";
		boolean first = true;
		for (String string : words) {
			if(last.equals(string)){
				System.out.print(first ? string : (", " + string));
				first = false;				
			}	
			else{				
				System.out.print("\n" + string);
				first = false;
			}
			last = string;
		}
	}
	
}
