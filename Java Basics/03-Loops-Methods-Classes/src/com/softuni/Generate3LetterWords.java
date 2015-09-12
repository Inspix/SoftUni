package com.softuni;

public class Generate3LetterWords {
	
	public static void Generate(String characters){
		char[] result = new char[3];
		for(int i = 0; i < characters.length(); i++){
			for (int j = 0; j < characters.length(); j++) {
				for (int k = 0; k < characters.length(); k++) {
					result[0] = characters.charAt(i);
					result[1] = characters.charAt(j);
					result[2] = characters.charAt(k);
					System.out.print(new String(result) + " ");
				}
			}
		}
		System.out.println();
	}
	
}
