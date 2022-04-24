Individuo in1 = new Individuo (); 

Console.WriteLine("Entre com seu nome:");
in1.Nome = Console.ReadLine();

Console.WriteLine ("Entre com sua altura em m. Ex: 1,65");
in1.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Entre com seu peso em Kg. Ex: 67,7");
in1.Peso = Convert.ToSingle(Console.ReadLine());

Console.WriteLine ("{0} sua altura é {1}m e seu peso {2}kg", in1.Nome, in1.Altura, in1.Peso);

Console.WriteLine("Seu IMC {0}", Math.Round(in1.IMC, 2));

Console.WriteLine (in1.SituacaoIndividuo);

Console.WriteLine (in1.AlcancarPesoIdeal);