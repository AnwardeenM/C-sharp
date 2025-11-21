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