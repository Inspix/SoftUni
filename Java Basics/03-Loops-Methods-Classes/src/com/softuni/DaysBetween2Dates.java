package com.softuni;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class DaysBetween2Dates {
	
	public static void GetDifference(String[] dates){
		SimpleDateFormat format = new SimpleDateFormat("dd-MM-yyyy");
		
		long diff = 0l;
		try {
			Date first = format.parse(dates[0]);
			Date second = format.parse(dates[1]);
			diff = second.getTime() - first.getTime();
		} catch (ParseException e) {
			e.printStackTrace();
		}
		
		System.out.println(TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS));		
	}
}
