package com.softuni;

import java.util.Scanner;

public class TriangleArea {
	public static void CalculateArea(int ax, int ay, int bx, int by, int cx, int cy){
		
		
		double a = ax * (by - cy);
		double b = bx * (cy - ay);
		double c = cx * (ay - by);
		
		double result = Math.abs((a + b + c)/2);
		
		System.out.println(String.format("The area of triagnle with points Ax:%s,Ay:%s,Bx:%s,By:%s,Cx:%s,Cy:%s = %s",ax,ay,bx,by,cx,cy,(int)result));
	}
	
	
	public static void CalculateArea(){
		
		int ax,ay,bx,by,cx,cy;
		
		Scanner scan = new Scanner(System.in);
		
		ax = scan.nextInt();
		ay = scan.nextInt();
		bx = scan.nextInt();
		by = scan.nextInt();
		cx = scan.nextInt();
		cy = scan.nextInt();
		
		scan.close();
		
		CalculateArea(ax, ay, bx, by, cx, cy);
	}
}
