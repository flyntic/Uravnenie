using ConsoleApp3;

Console.WriteLine("Введите a b и c  первого уравнения");
CoefXY c1=CoefXY.Parse(Console.ReadLine()); 
Console.WriteLine(c1);

Console.WriteLine("Введите a b и c второго уравнения");
CoefXY c2=CoefXY.Parse(Console.ReadLine()); 
Console.WriteLine(c2);

Console.WriteLine(CoefXY.Decide(c1,c2));