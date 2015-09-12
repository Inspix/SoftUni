package com.softuni.products;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class ProductParser {
	
	
	public static void ReadProductsFromFile(String filename, String outputfile){
		
		List<Product> products = readFromFile(filename);
		products.sort(new Comparator<Product>() {
			
			@Override
			public int compare(Product o1, Product o2) {
				return Double.compare(o1.price,o2.price);
			}
		});
		
		for (Product product : products) {
			System.out.println(product.toString());
		}
		
		writeToFile(outputfile, products);
		
	}
	
	public static List<Product> readFromFile(String filename){
		List<Product> products = new ArrayList<Product>();
		try {
			BufferedReader br  = new BufferedReader(new FileReader(filename));
			String line;
			while((line = br.readLine()) != null){
				products.add(getProduct(line));
			}
			
			br.close();
			
		} catch (IOException e) {
			System.out.println("Error");
		}
		return products;
	}
	
	public static void writeToFile(String filename, List<Product> products){
		try {
			FileWriter fw = new FileWriter(filename);
			for (Product product : products) {
				fw.write(product.toString() + System.lineSeparator());				
			}
			fw.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	public static void calculateOrder(String productFile, String orderFile, String outputFile){
		List<Product> products = readFromFile(productFile);
		double sum = 0;
		try {
			BufferedReader br = new BufferedReader(new FileReader(orderFile));
			String[] tokens;
			String line;			
			while((line = br.readLine()) != null){
				tokens = line.split(" ");
				for (Product product : products) {
					if (product.name.equals(tokens[1])) {
						sum += product.price * Double.parseDouble(tokens[0]);
					}
				}
			}
			br.close();			
			System.out.println(String.format("%.2f", sum));
		} catch (IOException e) {
			System.out.println("Error:" + e.getMessage());
		}
		
		try {
			FileWriter fw = new FileWriter(outputFile);
			fw.write(String.format("%.2f", sum));
			fw.close();
		} catch (IOException e) {
			System.out.println("Error:" + e.getMessage());
		}
	}
	
	private static Product getProduct(String input){
		String[] tokens = input.split(" ");
		double price = Double.parseDouble(tokens[1]);
		
		return new Product(tokens[0],price);		
	}
	
}
