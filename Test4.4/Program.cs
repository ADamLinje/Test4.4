// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("Weektest 44!");

Console.WriteLine("Opgave 1");

//TODO: Opgave 1
// Lav et For loop som udskriver tallene fra og med 15 til og med 25
// skriv din kode her

for (int n1 = 15; n1 <= 25; n1++)
{
    Console.WriteLine(n1);
}

Console.WriteLine("\nSlut på opgave 1");


Console.WriteLine("\nOpgave 2");
//TODO: Opgave 2
// Lav et WHILE loop som udskriver tallene fra og med 15 til og med 25
// skriv din kode her

int n2 = 14;
while (n2 < 25)
{
    n2 = n2 + 1;
    Console.WriteLine(n2);
}


Console.WriteLine("\nSlut på opgave 2");


Console.WriteLine("\nOpgave 3");
//TODO: Opgave 3
// Lav et FOR loop som beregner summen af tallene fra og med 15 til og med 25

int Start = 15;
int increment = Start++;
int sum = Start + increment;
for (int i = 0; i < 9; i++)
{

    sum = sum + increment;
}


// skriv din kode her

Console.WriteLine($"Summen af tallene fra og med 15 til og med 25 er : /*{sum}*/");
Console.WriteLine("Slut på opgave 3");

Console.WriteLine("\nOpgave 4");
// TODO: Opgave 4
// Lav et FOREACH loop som udskriver alle tallene i myFirstArray
// skriv din kode her

int[] myFirstArray = new int[7];

myFirstArray[0] = 34;
myFirstArray[1] = 12;
myFirstArray[2] = 1;
myFirstArray[3] = 7;
myFirstArray[4] = 2;
myFirstArray[5] = 9;
myFirstArray[6] = 7;
foreach (int i in myFirstArray)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nSlut opgave 4");


Console.WriteLine("\nOpgave 5");
// TODO: Opgave 5
// Lav et FOR loop som beregner summen af tallene i myFirstArray



int arraySum = myFirstArray.Sum();



// skriv din kode her


Console.WriteLine($"Summen af alle tallen i myFirstArray er: {arraySum}");

Console.WriteLine("Slut opgave 5");


Console.WriteLine("Opgave 6");
// TODO: Opgave 6
// Lav et FOREACH loop som udskriver tallene i listOfInt
// skriv din kode her

List<int> listOfInt = new List<int>();
listOfInt.Add(4);
listOfInt.Add(12);
listOfInt.Add(9);
listOfInt.Add(5);
listOfInt.Add(12);
listOfInt.Add(2);
foreach (int i in listOfInt)
{
    Console.WriteLine(i);
}


Console.WriteLine("\nSlut opgave 6");

Console.WriteLine("Opgave 7");
// TODO: Opgave 7
// Lav et FOR loop som beregner summen som af tallene i listOfInt

int listSum = listOfInt.Sum();


// skriv din kode her

Console.WriteLine();
Console.WriteLine($"Summen af tallene i listOfInt: {listSum}");


Console.WriteLine("\nSlut opgave 7");


Console.WriteLine("Opgave 8");
// TODO: Opgave 8
// Lav et While loop som beregner summen som af alle de lige tal i listOfInt

//int listSumWhile = 
//while (1 % 2 == 0)
//{
//    listSumWhile = listOfInt.Sum();
//}





// skriv din kode her


//Console.WriteLine();
//Console.WriteLine($"Summen af de lige tal i listOfInt: /*{listSumWhile}*/");
Console.WriteLine("\nSlut opgave 8");

Console.WriteLine("Opgave 9");
// TODO: Opgave 9
//Lav et loop som undersøger om tallet i variablen searchNumber findes i listOfInt
// Hvis tallet i searchNumber findes skal det udskrives at det findes. 
// Hvis tallet ikke findes skal det udskrives at searchNumber ikke findes


int searchNumber = listOfInt.IndexOf(5);
if (searchNumber != -1)
    Console.WriteLine("Det findes");
else
    Console.WriteLine("Det findes ikke");

// skriv din kode her

Console.WriteLine("\nSlut opgave 9");


Console.WriteLine("Opgave 10");
// TODO: Opgave 10
// Lav et loop som beregner om tallet i variablen searchNumer findes i listOfInt
// Hvis tallet i searchNumber findes skal det udskrives at det findes. 
// Hvis tallet ikke findes skal det udskrives at searchNumber ikke findes


int aNumber = 12;
int countOfaNumber = 0;


// skriv din kode her

Console.WriteLine($"Tallet {aNumber}  findes {countOfaNumber} gange i listOfInt");

Console.WriteLine("\nSlut opgave 10");
