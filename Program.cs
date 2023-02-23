Console.WriteLine("Ingresa primer valor");
String Valor = Console.ReadLine();
int A = Convert.ToInt32(Valor);

Console.WriteLine("Ingresa Segundo valor");
String Valor2 = Console.ReadLine();
int Valor_2 = Convert.ToInt32(Valor2);

for (int indice = A; indice < Valor_2; indice++)
{
    if (indice % 2 == 0) Console.WriteLine(indice);
}