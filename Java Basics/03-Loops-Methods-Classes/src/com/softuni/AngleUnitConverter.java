package com.softuni;

public class AngleUnitConverter {
	
	public static void Convert(String input){
		
		String[] tokens = input.split(" ");
		double result = Double.parseDouble(tokens[0]);
		if (tokens[1].equalsIgnoreCase("deg")) {			
			System.out.printf("%.6f %s%n",toRadians(result),"rad");
		}else{			
			System.out.printf("%.6f %s%n",toDegrees(result),"deg");
		}				
	}
	
	private static double toDegrees(double rad){
		return rad * 180d / Math.PI;
	}
	
	private static double toRadians(double deg){
		return deg * Math.PI / 180d;
	}
}
