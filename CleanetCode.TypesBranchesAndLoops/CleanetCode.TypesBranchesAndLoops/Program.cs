// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Hello, World!");


// numeric types
Console.WriteLine(1);
Console.WriteLine(42);
Console.WriteLine(235893751);
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);


Console.WriteLine(10L);
Console.WriteLine(42L);
Console.WriteLine(235893751L);
Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

Console.WriteLine('A');
Console.WriteLine("sdjlfksjdflsdj");
Console.WriteLine(DateTime.Now);
Console.WriteLine(Guid.NewGuid());

// variables
string name = "Александр Пономарев";
Console.WriteLine(name);
name = "Михаил";
Console.WriteLine(name);

int countOfVideos = 100;
countOfVideos = countOfVideos + 1;
countOfVideos = ++countOfVideos;
countOfVideos += 1;
Console.WriteLine(countOfVideos);

Console.WriteLine(20 + 10);
Console.WriteLine(20 - 10);
Console.WriteLine(20 / 10);
Console.WriteLine(20 * 10);
Console.WriteLine(22 % 10);

Console.WriteLine(true || false);
Console.WriteLine(false || false);
Console.WriteLine(true && false);
Console.WriteLine(true && true);

Console.WriteLine();

Console.WriteLine(10 > 20 || 18 < 35);
Console.WriteLine(10 == 20);
Console.WriteLine(10 <= 20);
Console.WriteLine(10 != 20);


