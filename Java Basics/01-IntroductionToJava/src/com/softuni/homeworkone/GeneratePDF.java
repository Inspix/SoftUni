package com.softuni.homeworkone;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfContentByte;
import com.itextpdf.text.pdf.PdfWriter;

public class GeneratePDF {
	
	private float margin = 5f;
	private float cardHeight = 60f;
	private float cardWidth = 40f;
	private float startPosition = 25f;	
	private float top;
	
	private BaseFont font;
	
	public static void Run(){
		GeneratePDF pdf = new GeneratePDF();
		pdf.printCards();
		try {
			pdf.generatePdfFile();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	private void generatePdfFile() throws IOException{
		Document doc = new Document();
		
		try {
			PdfWriter writer = PdfWriter.getInstance(doc, new FileOutputStream("Test.pdf"));
			font = BaseFont.createFont("c:/windows/fonts/arialbd.ttf",BaseFont.IDENTITY_H,BaseFont.EMBEDDED);
			doc.open();
			top = doc.top();	
			PdfContentByte canvas = writer.getDirectContent();
			float y = startPosition;
			int counter = 0;
			for (int i = 1; i < 14; i++) {
				for (int j = 0; j < 4; j++) {
					boolean color = false;
					if(j == 1 || j == 2) color = true;
					
					DrawCard(canvas, getCard(i,j), getSpacing(counter), y, color);
					counter++;
				}
				if(counter == 12){
					y += cardHeight+margin;
					counter = 0;
				}
			}
			doc.close();
			
		
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (DocumentException e) {
			e.printStackTrace();
		}
	}
	
	private float getSpacing(int col){
		if(col == 0){
			return startPosition;
		}
		return (startPosition + cardWidth*col) + margin * col;
	}
	
	private void DrawCard(PdfContentByte canvas, String card, float x, float y, boolean red){
		canvas.beginText();
		canvas.setFontAndSize(font,12);
		canvas.setTextMatrix(-1,0,0,-1, x + cardWidth-2.5f, top - y - cardHeight+15f);
		if (red) {
			canvas.setRGBColorFill(255, 0, 0);
		}		
		canvas.showText(card);
		canvas.setTextMatrix(1, 0, 0, 1, x+2.5f, top - y - 15f);
		canvas.showText(card);
		canvas.endText();
				
		canvas.resetRGBColorFill();
		canvas.rectangle(x, top - y-cardHeight, cardWidth, cardHeight);
		canvas.stroke();
		
	}
	
	
	private void printCards(){
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i <= 3 ; i++) {
			
			for (int j = 1; j <= 13; j++) {
				sb.append(getCard(j,i) + " ");
			}
			sb.append('\n');
		}
		System.out.println(sb.toString());
	}
	
	private String getCard(int type, int suite){
		return getType(type) + getSuite(suite);		
	}
	
	private String getSuite(int suite){
		switch(suite){
			case 0: return "\u2660"; // Spades
			case 1: return "\u2665"; // Hearts
			case 2: return "\u2666"; // Diamonds
			case 3: return "\u2663"; // Clubs
		}
		return null;
	}
	
	private String getType(int type){
				
		switch(type){
			case 1:
				return "A";
			case 2: 
			case 3: 
			case 4: 
			case 5: 
			case 6: 
			case 7: 
			case 8: 
			case 9:
			case 10: return String.valueOf(type);
			case 11: return "J";
			case 12: return "Q";
			case 13: return "K";
		}
		
		return null;
	}
}
