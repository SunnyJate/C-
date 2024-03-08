// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Sunny!");

string firstFriend = "       Maria     ";
firstFriend = firstFriend.Trim();
string secondFriend = "Sage    ";
// secondFriend = secondFriend.TrimEnd();
String friends = $"My friends are {firstFriend} and {secondFriend.Trim()}.";

Console.WriteLine(friends);

Console.WriteLine($"{friends.ToUpper()}, {friends.ToLower()}");
//Console.WriteLine(friends.ToLower());
Console.WriteLine(friends = friends.Replace("Sage","Samar"));

Console.WriteLine(friends.Contains("Sa"));

Console.WriteLine(friends.Length);

Console.WriteLine(friends.StartsWith("M"));
Console.WriteLine(friends.EndsWith(".   "));