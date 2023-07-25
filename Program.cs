using System;
using static System.Console;

Clear();

int[] numbers = new int[] {2, 5, 13, 7, 6, 4};
double size = numbers.Length;
double sum = 0;
double avg = 0;
int index = 0;

for (index = 0; index < size; index ++) {
    sum += numbers[index]; 
}

avg = sum/size;

WriteLine(avg);
