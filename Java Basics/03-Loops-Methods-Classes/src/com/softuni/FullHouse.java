package com.softuni;

import java.util.ArrayList;
import java.util.List;

public class FullHouse {
	
	private static char[] suits = new char[]{
	'\u2660', // Spades
	'\u2665', // Hearts
	'\u2666', // Diamonds
	'\u2663' // Clubs	
	};
	
	private static char[] suitsOf3 = new char[]{
			suits[0],suits[1],suits[2],
			suits[0],suits[1],suits[3],
			suits[0],suits[2],suits[3],
			suits[1],suits[2],suits[3],
	};
	
	private static char[] suitsOf2 = new char[]{
			suits[0],suits[1],
			suits[0],suits[2],
			suits[0],suits[3],
			suits[1],suits[2],
			suits[1],suits[3],
			suits[2],suits[3]
	};
	
	private static String[] cards = new String[]{
		"2","3","4","5","6","7","8","9","10","J","Q","K","A"	
	};
	
	
	public static void Generate(){
		List<String> result = generateFullHouse();
		
		String output = String.join("\n", result);
		System.out.println(output);
		System.out.println(result.size());
	}
	
	private static List<String> generateFullHouse(){
		
		List<String> fullhouses = new ArrayList<String>();
		StringBuilder sb = new StringBuilder(50);
		for (int i = 0; i < cards.length; i++) {
			for (int j = 0; j < cards.length; j++) {
				if (j == i) {
					continue;
				}
				for (int k = 0; k < suitsOf3.length; k+=3) {
					for (int l = 0; l < suitsOf2.length; l+=2) {
						sb.append('(')
						.append(cards[i]).append(suitsOf3[k]).append(' ')
						.append(cards[i]).append(suitsOf3[k+1]).append(' ')
						.append(cards[i]).append(suitsOf3[k+2]).append(' ')
						.append(cards[j]).append(suitsOf3[l]).append(' ')
						.append(cards[j]).append(suitsOf3[l+1])
						.append(')');
						
						fullhouses.add(sb.toString());
						sb.delete(0, sb.length());
					}
				}
			}
		}		
		return fullhouses;
	}	
}