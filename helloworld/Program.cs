// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Anwar!");

string firstFriend = "  shaheel    ";
firstFriend = firstFriend.TrimStart();// trims the white spaces from the start of the string

string secondFriend = "   Sayed   ";

string thirdFriend = "Khaled   ";
thirdFriend = thirdFriend.TrimEnd();// trims the white spaces from the end of the string    


// Console.WriteLine($"My friends are: {firstFriend}, {secondFriend.Trim()}, and {thirdFriend}.");
// i have just commented the above line and wrote that in line 19.

// Replace--------------------------->
// we can write the line 13 into like this as well.
string friends = $"My friends are: {firstFriend.Trim()}, {secondFriend.Trim()}, and {thirdFriend.TrimEnd()}.";
Console.WriteLine(friends);

// Let's try Replace methods by c# here.
Console.WriteLine(friends.Replace("Sayed", "mohammed"));
Console.WriteLine(friends);

// The above steps just returned an equivalent string with the replacement but did not change the original string "friends".
// In general strings are immutable in C#.
// So, if we want to change the original string we have to assign it again like this

friends = friends.Replace("Sayed", "mohammed");
Console.WriteLine(friends);


// Contains----------------------------> 
Console.WriteLine(friends.Contains("mohammed")); // returns true
Console.WriteLine(friends.Contains("Sayed")); // returns false

//ToUpper and ToLower---------------------------->  
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.ToLower());

//length---------------------------->
Console.WriteLine(friends.Length);

//startsWith and endsWith---------------------------->
Console.WriteLine(friends.StartsWith("My"));
Console.WriteLine(friends.EndsWith("khaled."));