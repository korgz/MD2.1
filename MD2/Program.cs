// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

// 1. Paprasam lietotajam ievadit vardu.
Console.WriteLine("Ka tevi sauc?");
// 2. Sagaida ievadi.
string userName = Console.ReadLine();
// 3. Sasveicinamies lietojot ievadito.
Console.WriteLine("Hi again:" + userName);

Console.WriteLine("Kads ir tavs vecums?");
string userNumberString = Console.ReadLine();
int userNumber = int.Parse(userNumberString);

int byThenLarger = userNumber + 1;
Console.WriteLine("Tev 2023 gada bus : " + byThenLarger);



