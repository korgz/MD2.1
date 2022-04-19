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


Console.WriteLine("Ievadiet jebkuru - vienu no diviem skaitliem, kuri pectam bus apstradati datu izvadei");
string userNumberString2 = Console.ReadLine();
int userNumber2 = int.Parse(userNumberString2);
Console.WriteLine("Ievadiet otro");
string userNumberString3 = Console.ReadLine();
int userNumber3 = int.Parse(userNumberString3);


int largerNumber = Math.Max(userNumber2, userNumber3);
Console.WriteLine("Lielakais skaitlis ko ievadijat: " + largerNumber);

int smallerNumber = Math.Min(userNumber2, userNumber3);
Console.WriteLine("Mazakais skaitlis ko ievadijat: " + smallerNumber);

Console.WriteLine("Ievadiet pirmo no diviem skaitliem, lai iegutu atlikumu dalijumu %");
string userNumberString4 = Console.ReadLine();
int userNumber4 = int.Parse(userNumberString4);
Console.WriteLine("Ievadiet otro");
string userNumberString5 = Console.ReadLine();
int userNumber5 = int.Parse(userNumberString5);

int divisionLeft = userNumber4 % userNumber5;
Console.WriteLine("rezultats " + divisionLeft);

Console.WriteLine("Ievadiet skaitli, lai noteiktu Odd or Even");
string userNumberString6 = Console.ReadLine();
int userNumber6 = int.Parse(userNumberString6);

if (userNumber6 % 2 == 0) 
{
    Console.WriteLine("Number is even");
}
else
{
    Console.WriteLine("Number is odd");
}


Console.WriteLine("Ievadiet pirmo skaitli, lai aprekinatu taisnstura laukumu");
string userNumberString7 = Console.ReadLine();
int userNumber7 = int.Parse(userNumberString7);
Console.WriteLine("Ievadiet otro skaitli, lai aprekinatu taisnstura laukumu");
string userNumberString8 = Console.ReadLine();
int userNumber8 = int.Parse(userNumberString8);

int lauk = userNumber7 * userNumber8;
Console.WriteLine("laukuma rezultats " + lauk);

Console.WriteLine("Ievadiet pirmo skaitli, kas ir vienads ar trijstura malas garumu");
string userNumberString9 = Console.ReadLine();
int userNumber9 = int.Parse(userNumberString9);
int lauk2 = userNumber9 * userNumber9 / 2;
Console.WriteLine("laukuma rezultats " + lauk2);

Console.WriteLine("Ievadiet savu vardu");
string userNumberString10 = Console.ReadLine();

Console.WriteLine("Ievadiet savu vecumu");
string userNumberString11 = Console.ReadLine();
int userNumber11 = int.Parse(userNumberString11);
Console.WriteLine($"Hi, {userNumberString10}, jums ir {userNumber11} gadi.");
Console.WriteLine("Paldies");