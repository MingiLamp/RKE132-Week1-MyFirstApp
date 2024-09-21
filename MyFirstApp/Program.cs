//This is a comment for my code and I can write what I like here
//Rakendus kysib kasutajal sisestada tema nime
//rakendus tervitab kasutajat



Console.WriteLine("Enter your name");
//sting - sõne
string userName =Console.ReadLine();

Console.WriteLine("Hello" + ", " + userName + "!");

//string interpolation

Console.WriteLine($"Hello, {userName}!");