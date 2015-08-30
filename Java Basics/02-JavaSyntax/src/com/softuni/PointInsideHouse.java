package com.softuni;

public class PointInsideHouse {
	
	public static void IsPointIn(double x, double y){
		
		boolean check = PointInTriangle(x, y) || isInFirstRect(x, y) | isInSecondRect(x, y);
		
		System.out.printf("Point %.2f, %.2f is %s%n",x,y, check ? "INSIDE the house" : "OUTSIDE the house");
		
	}
	
	
	public static boolean Check(double x, double y){
		return PointInTriangle(x, y) || isInFirstRect(x, y) | isInSecondRect(x, y);
	}
	
	private static boolean PointInTriangle(double x, double y){
		
		double ax = 12.5,ay = 8.5,bx = 17.5,by = 3.5,cx = 22.5,cy = 8.5;		
		
	    double s = ay * cx - ax * cy + (cy - ay) * x + (ax - cx) * y;
	    double t = ax * by - ay * bx + (ay - by) * x + (bx - ax) * y;

	    if ((s < 0) != (t < 0))
	        return false;

	    double A = -by * cx + ay * (cx - bx) + ax * (by - cy) + bx * cy;
	    if (A < 0.0)
	    {
	        s = -s;
	        t = -t;
	        A = -A;
	    }
	    return s >= 0 && t >= 0 && (s + t) <= A;
	}
	
	private static boolean isInFirstRect(double x,double y){
		if (x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5) {
			return true;
		}
		return false;
	}
	
	private static boolean isInSecondRect(double x,double y){
		if (x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5) {
			return true;
		}
		return false;
	}
	
}
