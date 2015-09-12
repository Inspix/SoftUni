package com.softuni;

import java.io.FileInputStream;
import java.io.IOException;
import java.util.Iterator;
import java.util.Map;
import java.util.TreeMap;

import org.apache.poi.ss.usermodel.Row;
import org.apache.poi.xssf.usermodel.XSSFSheet;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

public class Excel {
	public static void Run(){
		TreeMap<String, Double> result = new TreeMap<>();
		try 
		{
	        // Get the workbook instance for XLS file
	        XSSFWorkbook xlsx = new XSSFWorkbook(new FileInputStream("src/report.xlsx"));
	        // Get first sheet from the workbook
	        XSSFSheet sheet = xlsx.getSheetAt(0);
	        Row row;
	        Iterator<Row> rowIterator = sheet.iterator();
	        rowIterator.next();
	        while (rowIterator.hasNext()) 
	        {
                row = rowIterator.next();
                
                String town = row.getCell(0).getStringCellValue();
                double income = row.getCell(3).getNumericCellValue();
                
                if (result.containsKey(town)) {
					result.compute(town,(k,v) -> v += income + (income * 0.2));
				}else{
					result.put(town, income + (income * 0.2));
				}
	        }
	        
	        xlsx.close();
		}
		catch(IOException e){
			e.printStackTrace();
		}
		
		double total = 0;
		for (Map.Entry<String,Double> set : result.entrySet()) {
			total += set.getValue();
			System.out.printf("%s Total -> %.2f%n",set.getKey(),set.getValue());
		}
		System.out.printf("Grand Total -> %.2f%n",total);
	}
}
