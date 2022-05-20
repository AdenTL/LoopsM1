# We Can Code It - Looping Engine
All of the following exercies MUST utilize loops to receive a PASSING grade.  
Make sure you only code where prompted in the Exercises.cs file. This means any code you write should be one line directly under "//SOLUTION HERE" and should never go beyond "Console.Write("Press enter to return to the Main Menu");" Once you are done with one solution, find the next spot down in the code to start your next solution to the next problem. 

## Primary Objectives
> The WCCI Looping Engine needs to be completed. Use the following User stories and method descriptions to determine feature functionality

- As a User I should be able to print numbers in reverse from 5 to 1 so that I can prove the Loop Engine is working
- As a User I should be able to count down from 20 so that I can prove the Loop Engine is working
- As a User I should be able to print the squares of the even numbers between 1- 9 so that I can prove the Loop Engine is working
- As a User I should be able to be able to guess indefinitely until I arrive at the magic number so that I can prove the Loop Engine is working

## Numbers In Reverse
Print out numbers from 5 to 1.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No Input

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 5 4 3 2 1

## Reverse Counting
Ask the user for an integer input between 1 and 20 inclusive. Starting at the number given, count backwards to 1 and print the result.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 15

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 

## Square Of Even Numbers
Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No Input

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 1 4 3 16 5 36 7 64 9

## Guess Magic Number
Write a console application that asks the user for an integer.
- If that integer is evenly divisible by 3, then print “You Won!”.
- If it isn’t, ask the user to “Try again.”

Keep asking them for a number (looping) until they win.
**HINT:** Use a while loop and Console.ReadLine() to keep updating the user's input.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 1

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "Try again."


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 2

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "Try again."


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 3

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "You Won!"
