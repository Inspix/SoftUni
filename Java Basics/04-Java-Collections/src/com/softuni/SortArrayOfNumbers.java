package com.softuni;

public class SortArrayOfNumbers {
	
	public static void Sort(int[] numbers){
		printArray(numbers);
		sort(numbers);
		printArray(numbers);		
	}
	
	
	private static void printArray(int[] numbers){
		for (int i = 0; i < numbers.length; i++) {
			System.out.print(i != numbers.length-1 ?
					(String.valueOf(numbers[i]) + ", ")
					:String.valueOf(numbers[i]));
		}
		System.out.println();
	}
	
	private static int[] sort(int [] numbers){
		int iMin;
		for (int j = 0; j < numbers.length-1; j++) {
		    iMin = j;
		    for (int i = j+1; i < numbers.length; i++) {
		        if (numbers[i] < numbers[iMin]) {
		            iMin = i;
		        }
		    }

		    if(iMin != j) {
		        int temp = numbers[j];
		        numbers[j] = numbers[iMin];
		        numbers[iMin] = temp;
		    }
		}
		return numbers;
	}
	
}
