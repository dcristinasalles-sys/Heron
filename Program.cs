double lado1, lado2, lado3;
double p;
double area; 

Console.WriteLine("---Calcule a área de um triângulo");

Console.Write("lado1..: ");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado2..:");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("lado3..:");
lado3 = Convert.ToDouble(Console.ReadLine());

p = (lado1 + lado2 + lado3) /2;
area = Math.Sqrt(p * (p- lado1) * (p- lado2) * (p - lado3));

Console.WriteLine($"Semiperimetro..: {p}");
Console.WriteLine($"Area...........: {area}");