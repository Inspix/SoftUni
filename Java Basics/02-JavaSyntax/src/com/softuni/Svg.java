package com.softuni;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Paint;
import java.awt.Stroke;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.security.InvalidParameterException;
import java.util.Scanner;

import org.jfree.graphics2d.svg.SVGGraphics2D;

public class Svg {
	
	// Left Square
	private static int[] xPoints = new int[]{
			125*2,175*2,175*2,125*2
	};
	// Left/Right Square
	private static int[] yPoints = new int[]{
			85*2,85*2,135*2,135*2
	};
	// Right Square
	private static int[] xPoints2 = new int[]{
			200*2,225*2,225*2,200*2
	};	
	// Triangle
	private static int[] xPoints3 = new int[]{
			125*2,175*2,225*2
	};
	// Triangle
	private static int[] yPoints3 = new int[]{
			85*2,35*2,85*2
	};
	
	private static SVGGraphics2D graphics;
	
	public static void Setup(){
		graphics = new SVGGraphics2D(1000, 1000);
		graphics.scale(2, 2);
		DrawGrid();
		DrawHouse();		
	}
	
	public static void Run(double... args){
		if (args.length % 2 != 0) {
			throw new InvalidParameterException();
		}
		for (int i = 0; i < args.length; i+=2) {
			SetPoint(args[i], args[i+1]);
		}
		
		WriteToFile(graphics.getSVGDocument());
	}
	
	public static void Run(){
		Scanner scan = new Scanner(System.in);
		int numbers = scan.nextInt();
		for (int i = 0; i < numbers; i+=2) {
			double x = scan.nextDouble();
			double y = scan.nextDouble();
			SetPoint(x,y);
		}
		scan.close();
		
		WriteToFile(graphics.getSVGDocument());
	}
	
	private static void SetPoint(double x, double y){
		boolean inside = PointInsideHouse.Check(x, y);		
		
		if (inside) {
			graphics.setColor(Color.BLACK);
			graphics.fillOval((int)(x*10*2-2), (int)(y*10*2-2), 4, 4);
		}
		else
		{	
			graphics.setColor(Color.LIGHT_GRAY);
			graphics.fillOval((int)(x*10*2-2), (int)(y*10*2-2), 4, 4);
		}
	}
	
	private static void DrawHouse(){
		Paint defaultPaint = graphics.getPaint();
		Stroke defaultStroke = graphics.getStroke();
		graphics.setStroke(new BasicStroke(1f));
		graphics.setColor(new Color(0f,0f,0.7f));
		graphics.drawPolygon(xPoints, yPoints, 4);
		graphics.drawPolygon(xPoints2, yPoints, 4);
		graphics.drawPolygon(xPoints3, yPoints3, 3);
		
		graphics.setPaint(new Color(0.33f,0.33f,0.33f,0.3f));	
		graphics.fillPolygon(xPoints, yPoints, 4);
		graphics.fillPolygon(xPoints2, yPoints, 4);
		graphics.fillPolygon(xPoints3, yPoints3, 3);	
		
		graphics.setPaint(defaultPaint);
		graphics.setStroke(defaultStroke);
		
	}
	
	private static void DrawGrid(){
		int x = 100*2, y = 25*2;
		Stroke def = graphics.getStroke();;
		float[] dash = new float[]{
			2,2	
		};
		graphics.setStroke(new BasicStroke(0.1f, 0, 1, 0,dash,1));
		float value = 10f;
		for (int i = 0; i < 6; i++) {
			graphics.drawString(String.valueOf(value),x-10,y-5);
			graphics.drawLine(x, y, x, y+300);
			value += 2.5f;
			x+=25*2;
		}
		
		x = 25*2;
		y = 35*2;
		value = 3.5f;
		for (int i = 0; i < 6; i++) {
			graphics.drawString(String.valueOf(value),x+50*2,y+5);
			graphics.drawLine(x+65*2, y, x + 300*2, y);
			value += 2.5f;
			y+=25*2;
		}
		
		graphics.setStroke(def);
	}
	
	private static void WriteToFile(String svg){
		FileOutputStream fs = null;
		try {
			fs = new FileOutputStream("house.html");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		try {
			fs.write(svg.getBytes());
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
