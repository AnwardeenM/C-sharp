// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Anwar!");

string firstFriend = "  shaheel    ";
firstFriend = firstFriend.TrimStart();// trims the white spaces from the start of the string

string secondFriend = "   Sayed   ";

string thirdFriend = "Khaled   ";
thirdFriend = thirdFriend.TrimEnd();// trims the white spaces from the end of the string    


Console.WriteLine($"My friends are: {firstFriend}, {secondFriend.Trim()}, and {thirdFriend}.");


