package com.softuni.products;

public class Product {
	public String name;
	public double price;
	
	public Product(String name, double price){
		this.name = name;
		this.price = price;
	}
	
	public String toString(){
		return price + " " + name;
	}
}
