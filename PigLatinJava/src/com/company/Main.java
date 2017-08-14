package com.company;

// import scanner class
import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
	    // create scanner class
        Scanner keyboard = new Scanner(System.in);

        // give instruction
        System.out.println("Enter a sentence and I will convert it to Pig Latin! ");

        // create variable to hold input
        String input = keyboard.nextLine();

        // loop to convert input
        for (String word:input.split(" ")
             )
        {
            System.out.println(word.substring(1) + word.substring(0,1) + "ay");
        }
    }
}
