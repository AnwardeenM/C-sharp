// int a = 18;
// int b =6;
// int c = a + b;
// Console.WriteLine("The sum of a and b is: " + c);

// But to check it's maximum capacity wil set these values to their limits.

int a = 2100000000; // max value for int is 2147483647
int b = 2000000000;
// int c = a + b;
// Console.WriteLine("The sum of a and b is: " + c);

// The output will be a negative number due to integer overflow. The sum of a and b is: -194967296
//That's because when the sum exceeds the maximum limit of the int data type, it wraps around to the negative side of the range.

// To handle such situations, we can use the 'checked' keyword to enable overflow checking for integral-type arithmetic operations and conversions.
long c = checked((long)a + (long)b);
Console.WriteLine("The sum of a and b is: " + c);


// int d = 42.1; // This will cause a compilation error because we are trying to assign a double value to an int variable.
// int e= 38.9; // This will also cause a compilation error for the same reason.
// long f = checked(d + e);
// Console.WriteLine("The sum of d and e is: " + f);

// To overcome this issue, we can explicitly cast the double values to int before performing the addition.
int d_int = (int)42.1; // Explicitly casting double to int 
int e_int = (int)38.9; // Explicitly casting double to int
long f_checked = checked(d_int + e_int);
Console.WriteLine("The sum of d and e is: " + f_checked);
// But running this code will give the output as The sum of d and e is: 80
// This is because when we cast a double to an int, the fractional part is truncated. So, 42.1 becomes 42 and 38.9 becomes 38. Therefore, the sum is 42 + 38 = 80.



// To get a more accurate result, we can first perform the addition using double data type and then cast the result to long.
double d = 42.1;
double e = 38.9;
double f_accurate = checked((long)(d + e));
Console.WriteLine("The sum of d and e is: " + f_accurate);

//will try another example with double and float 
double g = 42.1; // This was natural type
float h = 38.9F;
double i = g + h;
Console.WriteLine("The sum of g and h using floating arithmetic is: " + i);
//The Answer will be something like The sum of g and h is:  81.0000015258789 rather than 81 exactly due to precision limitations of floating-point arithmetic(f).

// Let's see about decimal type
decimal j = 42.1M; //This is explicit type
decimal k = 38.9M;
decimal l = j + k;
Console.WriteLine("The sum of j and k is: " + l);
// And we can also the String with interpolation
Console.WriteLine($"The sum of j and k using string interpolation is: {l}");

// With the above examples we have learnt about integer, floating-point, double and decimal types and how to handle overflow and precision issuses in c#.