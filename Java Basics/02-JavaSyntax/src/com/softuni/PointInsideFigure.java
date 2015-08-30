package com.softuni;

public class PointInsideFigure {
		
	public static void Run(double x, double y){
		boolean inside = isInFirstRect(x, y) || isInSecondRect(x, y) || isInThirdRect(x, y);
		
		System.out.println(String.format("Is Point: %s, %s inside the figure? %s",x,y, inside ? "Inside" : "Outside"));
	}
	
	
	private static boolean isInFirstRect(double x,double y){
		if (x >= 12.5 && x <= 22.5d && y >= 6 && y <= 8.5) {
			return true;
		}
		return false;
	}
	
	private static boolean isInSecondRect(double x,double y){
		if (x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5) {
			return true;
		}
		return false;
	}
	
	private static boolean isInThirdRect(double x,double y){
		if (x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5) {
			return true;
		}
		return false;
	}
	
}
