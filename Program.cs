Console.WriteLine("Entre com seu nome:");
string nome = Console.ReadLine();

Console.WriteLine ("Entre com sua altura. Ex: 1,65");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Entre com seu peso em Kg. Ex: 67,7");
float peso = Convert.ToSingle(Console.ReadLine());

double imc = peso/ (altura * altura);

Console.WriteLine ("{0} sua altura é {1}m e seu peso {2}kg", nome, altura, peso);

Console.WriteLine("Seu IMC {0}", imc);

if(imc < 18.5)
{
    Console.WriteLine("Abaixo do Peso.");
}

else if(imc <= 24.9)
{
    Console.WriteLine("Peso Normal.");
}

else if(imc <= 29.9)
{
    Console.WriteLine("Sobrepeso.");
}

else if(imc <= 34.9)
{
    Console.WriteLine("Obesidade Grau I.");
}

else if(imc <= 39.9)
{
    Console.WriteLine("Obesidade Grau II.");
}

else
{
    Console.WriteLine("Obesidade Grau III ou Mórbida.");
}
    