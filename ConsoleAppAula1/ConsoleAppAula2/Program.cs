//Se o aluno tiver mais que 3 faltas ROdou

//Se a nota do aluno ser menor que 60 Rodou tbm


/*
string nomeAluno;
int nota;
int faltas;
string continuar;

while(true){

    Console.WriteLine("Qual o nome do aluno");
    nomeAluno = Console.ReadLine();

    Console.WriteLine($"Quantas faltas o aluno {nomeAluno} possui:");
    faltas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Qual a nota do aluno {nomeAluno}:");
    nota = Convert.ToInt32(Console.ReadLine());

    if (nota >= 60 || faltas <= 3)
    {

        Console.WriteLine($"O aluno {nomeAluno} está Aprovado!");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAluno} está Reprovado!");
    }

    Console.WriteLine("Deseja continuar s/n");
    continuar = Console.ReadLine();
    if(continuar == "n")
    {
        break;
    }
    else { Console.Clear(); }
}

*/

#region Estrutura de Repeticao

//FOR 
/*
int  contador = 0;
int tabuada;

Console.WriteLine("Informe a tabuada:");
tabuada = Convert.ToInt32(Console.ReadLine());

for (contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($" {tabuada} X {contador}: {tabuada * contador}");
}
*/

//While
/*
int contador = 0;
while (contador < 10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do
{
    Console.WriteLine(contador);
    contador++;
} while (contador < 10);
*/

//Foreach
/*
string[] nomes =
{
"Abacaxi", "Maçã", "Banana"
};

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };


foreach (int i in numeros)
{
    Console.WriteLine(numeros[i]);
}


Console.ReadKey();

*/
#endregion



int idadeAluno;

/*
bool MaiorDeIdade(int idade)
{
 
    if (idade >= 18)
    {
        return true;
    }else
    {
        return false;
    }
}

Console.WriteLine("Informe sua idade:");
idadeAluno= Convert.ToInt32(Console.ReadLine());
if(MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de Idade!! ");
}
else
{
    Console.WriteLine("Aluno menor de Idade!!");
}
*/
/*
void MaiorDeIdade2(int idade)
{

    if (idade >= 18)
    {
        Console.WriteLine("Aluno maior de idade!");
    }
    else
    {
        Console.WriteLine("Aluno menor de idade");
    }
}


MaiorDeIdade2(20);
*/

//Funçao para somar do tipo Void
//Funcao que retorne a multiplicação Resultado int

void Soma(int n1, int n2)
{
    Console.WriteLine(n1 + n2);
}

Soma(1 , 2);

int Multiplica(int n1, int n2)
{
    return n1 * n2;
}


int valor = Multiplica(20, 5);
Console.WriteLine(valor);
