//int idade;
//Console.WriteLine("Informe sua idade!");

//idade = Convert.ToInt32(
//    Console.ReadLine());

/* IF SALARIO
if (idade >= 18)
{
    Console.WriteLine($"Sua idade é {idade},Você é maior de idade");
}
else
{
    Console.WriteLine($"Sua idade é {idade}, Você é menor de idade");
}

salario mínimo ou salário comun

const decimal salarioMinimo = 1518m;

Console.WriteLine("Informe seu salario");
decimal salarioPessoal = decimal.Parse(Console.ReadLine());

if (salarioPessoal < salarioMinimo)
{
    Console.WriteLine($"Você tem um salario menor que o minimo, procure seus direitos. Denuncie seu salario de {salarioPessoal:C}");
}
else
{
    Console.WriteLine($"Você tem o salario maior que o minimo, Parabens!! Seu salario é {salarioPessoal}");
}
*/




//Soma, Multplica, Divisão, Subtracao
float num1 = 0f;
float num2 = 0f;

Console.WriteLine("Informe a operação matematica:\n" +
    "Soma = +\n" +
    "Multiplicacao = *\n" +
    "Divisao = /\n" +
    "Subtração = -\n");
string operacaoMatematica = Console.ReadLine();

Console.WriteLine("Informe o primeiro valor:");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor:");
num2 = float.Parse(Console.ReadLine());


if(operacaoMatematica == "+")
{
    Console.WriteLine($"Soma: {(num1 + num2):F2}");
} else if(operacaoMatematica == "-")
{
    Console.WriteLine($"Subtração: {num1 - num2}");
} else if(operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicacao: {num1 * num2}");
} else if(operacaoMatematica == "/")
{
    Console.WriteLine($"Divisao: {num1 / num2}");
}
else
{
    Console.WriteLine("Nenhuma operação digitada");
}






