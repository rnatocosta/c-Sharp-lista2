//   1=>Crie um programa que exiba uma sequencia de numeros inteiros
using System;
using System.Threading.Channels;

Console.WriteLine("Sequencia de numeros inteiros");

for (int ii = 0; ii < 10; ii++) {
    Console.Write(" "+ii);
}

// 2=>Crie um programa que exiba uma senquencia de frases

string[] str = new string[] {"a frases", "b frases", "c frases", "d frases", "e frases", "f frases", "g frases", "h frases" };
    Console.WriteLine("Sequência de frases: ");
for (int io = 0; io < str.Length; io++)
{
    
    Console.Write(str[io] +" ");
}

//  3=>Crie um programa que exiba uma sequencia de valores booleanos

Boolean[] b = new Boolean[] { true, false, true, false, true };

Console.WriteLine("Sequência de Booleanos: ");
for (int ib = 0; ib < b.Length; ib++)
{

    Console.Write(str[ib] + " ");
}

//   4=>Crie um programa que exiba uma sequencia de valores doubles

Double[] d = new Double[] { 1111.11d, 22222.22d, 33333.33d, 444444.44d, 5555555.55d };

Console.WriteLine("Sequência de Doubles: ");
for (int iz = 0; iz < b.Length; iz++)
{

    Console.Write(d[iz] + " ");
}

// 5=>Crie um programa que exiba uma sequencia de valores decimais

Decimal[] de = new Decimal[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Sequência de Doubles: ");
for (int iw = 0; iw < de.Length; iw++)
{

    Console.Write(de[iw] + " ");
}

// 1=>Crie um programa que receba 10 numeros e armazene em uma
// lista e exiba os valores armazenados

float[] num = new float[10] ;

Console.WriteLine("Entre com 10 números: ");
for (int iq = 0; iq < num.Length; iq++)
{
    Console.WriteLine("Entre com o número da posição [" +iq+"]: ");
    num[iq]=float.Parse(Console.ReadLine());
}
Console.WriteLine("Os valores armazenados foram: ");
for (int ix = 0; ix < num.Length; ix++)
{
    Console.WriteLine("Número da posição: [" + ix + "]: " + num[ix]);
}

//  2=>Crie um programa que receba 10 frases
//  e armazene em uma lista e exiba os valores armazenados

string[] fra = new string[10];

Console.WriteLine("Entre com 10 frases: ");
for (int ih = 0; ih < fra.Length; ih++)
{
    Console.WriteLine("Entre com a frase da posição [" + ih + "]: ");
    fra[ih] = Console.ReadLine();
}
Console.WriteLine("As frases armazenadas foram: ");
for (int iu = 0; iu < fra.Length; iu++)
{
    Console.WriteLine("Frase da posição: [" + iu + "]: " + fra[iu]);
}

//3=>Crie um programa que receba qualquer valor
//mas so adicione na lista valores impares e exiba seus valores

float[] impares = new float[10];

Console.WriteLine("Entre com 10 números: ");
for (int im = 0; im < impares.Length; im++)
{
    Console.WriteLine("Entre com o número: ");
    int n = int.Parse(Console.ReadLine());

    if (n % 2 != 0) { }
        impares[im] = n;
}
Console.WriteLine("Os números ímpares armazenados são: ");
for (int inn = 0; inn < impares.Length; inn++)
{
    if (impares[inn] != null)
    {
        Console.Write(" " + impares[inn]);
    }
}

//  4=>Cria um programa que receba
//  qualquer valor mas so adicione na lista valores pares e exiba seus valores


float[] pares = new float[10];

Console.WriteLine("Entre com 10 números: ");
for (int irr = 0; irr < impares.Length; irr++)
{
    Console.WriteLine("Entre com o número: ");
    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0) { }
    pares[irr] = n;
}
Console.WriteLine("Os números pares armazenados são: ");
for (int ijj = 0; ijj < pares.Length; ijj++)
{
    if (pares[ijj] != null)
    {
        Console.Write(" " + pares[ijj]);
    }
}

//   5=>Crie um programa que receba 10 valores
//   em uma lista e calcule sua media e exiba o valor da media.

float[] nums = new float[10];

Console.WriteLine("Entre com 10 números: ");
for (int ikk = 0; ikk < nums.Length; ikk++)
{
    Console.WriteLine("Entre com a nota "+ikk+":");
    nums[ikk] = float.Parse(Console.ReadLine());

}
Console.WriteLine("A média é : ");
float total = 0;
for (int ibn = 0; ibn < nums.Length; ibn++)
{
    total += nums[ibn];
}
/*
 *   1=>Adriano adora ir ao mercado aos finais de semana, geralmente ele anota em um papel
  a lista dos itens que precisam ser comprados e o quanto ele pode gastar com cada item. 
     Crie um programa  que gerencie suas compras e o ajude a controlar seus gastos.
 */

Console.WriteLine("Programa para ajudar Adriano a Gastar!");
Console.WriteLine("Qual o valor maximo que você desejar gastar? R$");
float maximo = float.Parse(Console.ReadLine());

Console.WriteLine("Entre com a quantidade de itens que deseja comprar no maximo 100: ");
float qtd = float.Parse(Console.ReadLine());

float somatorio = 0;

string[] produto = new string[100];
float[] preco = new float[100];
float tot = 0;

for (int y = 0; y < qtd; y++)
{
    Console.WriteLine("Entre com o nome do Produto: ");
    string nomeP = Console.ReadLine();

    Console.WriteLine("Entre com o valor do Produto: ");
    float valorP = float.Parse(Console.ReadLine());

    tot += valorP;
    Console.WriteLine("- - - - -  - - - - -  - - - - -");

    float totSoma = 0;
    if (tot <= maximo) {
        produto[y] = nomeP;
        preco[y] = valorP;
    }
    if (tot > maximo) {
        Console.WriteLine("Você excedeu o maximo que pode gastar!");
        Console.WriteLine("Sua lista fechou!, Você pode comprar: ");

        for (int k = 0; y < qtd; y++) {
            Console.WriteLine("Produto: " + produto[k]);
            Console.WriteLine("Preço: " + preco[k]);
            Console.WriteLine(" - - - - - - - - - - - - - ");
            totSoma += totSoma + preco[k];
        }
        Console.WriteLine("Com total de: R$"+ totSoma +" Reais");
    }
}

/*
 * 2=>Adhemir trabalha em uma banca de frutas e todos os dias antes de montar a 
 * banca ele desenha o layoult para organizar
  o posicionamento de suas frutas. Em cada dia da semana ademir monta um 
layoult diferente porem na hora de contabilizar adhemir muitas
  vezes se perde devido ao cansaco do dia de trabalho. Crie um programa
que estabeleca um layoult de bancada pre definido para aldemir e ajude ele 
a contabilizar suas
  vendas.
  
 */

Console.WriteLine("Adhemir e sua banca de frutas");
Console.WriteLine("Como é um layout, vms definir o número de linhas e colunas!");

Console.WriteLine("Entre com o numero de linhas: ");
int ii2 = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o numero de colunas: ");
int jj2 = int.Parse(Console.ReadLine());

Console.WriteLine("Agora vms trabalhar com o layout ["+ii2+"]["+jj2+"]");
Console.WriteLine("-----------------");

string[][] fruta = new string[ii2][];
float[][] valorVenda = new float[ii2][];


Console.WriteLine("Vamos cadastrar as frutas e seus respectivos valores de venda: ");
for (int i1 = 0; i1 < ii2; i1++) {
    for (int j2 = 0; j2 < jj2; j2++) {
        Console.WriteLine("Entre com o nome da Fruta da posição[" +i1+"]["+j2+"]: ");
        fruta[i1][j2] = Console.ReadLine();

        Console.WriteLine("Entre com o valor da fruta R$:" );
        valorVenda[i1][j2] = float.Parse(Console.ReadLine());
        Console.WriteLine("Item cadastrado com Sucesso! ");
    }
}



