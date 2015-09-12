package com.softuni;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class RandomHandsOf5Cards {
	
	private static List<String> cards;
	private static Random random = new Random();
	
	public static void GetHands(int number){
		if(cards == null){
			cards = new ArrayList<String>();

			for (int i = 0; i <= 3 ; i++) {					
				for (int j = 1; j <= 13; j++) {
					cards.add(getCard(j,i));
				}
			}
		}
		
		for (int i = 0; i < number; i++) {
			System.out.println(generateHand());
		}
	}
	
	private static String generateHand(){
		List<Integer> currentCards = new ArrayList<Integer>();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < 5; i++) {
			int card = random.nextInt(52);
			if(currentCards.contains(card)){
				i--;
				continue;
			}
			currentCards.add(card);
			sb.append(cards.get(card)).append(i == 4 ? "" : " ");
		}
		return sb.toString();
	}
	
	private static String getCard(int type, int suite){
		return getType(type) + getSuite(suite);		
	}
	
	private static String getSuite(int suite){
		switch(suite){
			case 0: return "\u2660"; // Spades
			case 1: return "\u2665"; // Hearts
			case 2: return "\u2666"; // Diamonds
			case 3: return "\u2663"; // Clubs
		}
		return null;
	}
	
	private static String getType(int type){				
		switch(type){
			case 1:
				return "A";			
			case 11: return "J";
			case 12: return "Q";
			case 13: return "K";
			default: return String.valueOf(type);
		}
	}
}
