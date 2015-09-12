package com.softuni;

import java.util.ArrayList;

public class LongestIncreasingSequence {
	
	public static void FindLongest(int[] input){
		ArrayList<ArrayList<Integer>> sequences = new ArrayList<ArrayList<Integer>>();
		
		ArrayList<Integer> currentSequence = new ArrayList<Integer>();
		for (int i = 0; i < input.length-1; i++) {
			if (input[i] < input[i+1]) {
				currentSequence.add(input[i]);
			}else {
				currentSequence.add(input[i]);
				sequences.add(currentSequence);
				currentSequence = new ArrayList<Integer>();
			}
		}
		if (input[input.length-2] < input[input.length-1]) {
			currentSequence.add(input[input.length-1]);
			sequences.add(currentSequence);
			
		}else{
			currentSequence.clear();
			currentSequence.add(input[input.length-1]);
			sequences.add(currentSequence);
		}
		int biggestCount = 0;
		for (ArrayList<Integer> arrayList : sequences) {
			for (int i = 0; i < arrayList.size(); i++) {
				System.out.print(i == arrayList.size()-1 
						? String.valueOf(arrayList.get(i))
						: String.valueOf(arrayList.get(i)) + " ");
			}
			System.out.println();
			if(biggestCount < arrayList.size()){
				biggestCount = arrayList.size();
				currentSequence = arrayList;
			}
		}
		
		System.out.println("Longest:");
		for (int i = 0; i < currentSequence.size(); i++) {
			System.out.print(i == currentSequence.size()-1 
					? String.valueOf(currentSequence.get(i))
					: String.valueOf(currentSequence.get(i)) + " ");
		}
		System.out.println();
		
	}
	
}
