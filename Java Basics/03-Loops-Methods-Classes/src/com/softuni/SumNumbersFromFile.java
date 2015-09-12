package com.softuni;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SumNumbersFromFile {
	
	public static void CalculateFromFile(String path){
		try {
			BufferedReader br = new BufferedReader(new FileReader(path));
			int sum = 0;
			String line;
			while((line = br.readLine()) != null){
				sum += Integer.parseInt(line);
			}			
			System.out.println(sum);
			br.close();
		} catch (IOException e) {
			System.out.println("Error");
		}
	}	
}
