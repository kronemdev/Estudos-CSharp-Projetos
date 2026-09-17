
// comparar Valores = True (verdadeiro) - False (falso)
/*
int a = 10;
int b = 5;

// = Atribucao
// == Comparacao de igualdade.

Console.WriteLine(a == b); // A e igual a b ? False
Console.WriteLine(a != b); // a e de diferente de b ? true
Console.WriteLine(a > b); // a e maior que b ? true
Console.WriteLine(a < b); // a e menor que b? false

Console.WriteLine(a >= b); // a e maior ou igual a b? true
Console.WriteLine(a <= b); // a e menor ou igual a b? false


// nomenclatura
//int idadedoaluno = 9;

// metodos , classes - pascalcase
Console.WriteLine();

// Operadores logicos e (Juntar perguntas) 
bool a = true;
bool b = false;

// && = E ( se as duas condicoes forem verdadeiras sera true, caso contrario sera falso)
bool resultado = a && b;
Console.WriteLine(resultado);

// || = OU (se um dos lados for verdade = retorana verdade)
resultado = a || b;
Console.WriteLine(resultado);


// ! = Negacao ( Traz o oposto do que estiver na variavel (true -> false) (false -> true)
resultado = !a;
Console.WriteLine(resultado);

// Condicionais 
// Tomar uma acao se o cara e maior de idade
// Criança, Adulto e Idoso 

int idade = 20;

if (idade >= 60)
{
    Console.WriteLine("Idoso");  
}

else if (idade >= 18)
{
    Console.WriteLine("Adulto");
}
else if (idade >= 14)
{
    Console.WriteLine("Adolescente");
}
else
{
    Console.WriteLine("Criança");
}
*/











using System.Runtime.Intrinsics.X86;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;










/** 1. Verificador de Maioridade**

Crie um programa que declare uma variável **`idade`**. 

Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 

O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira, e "*Você é menor de idade*" caso contrário 


int idade = 18;
if (idade >= 18)
{
    Console.WriteLine("Maior de Idade");
}
else
{
    Console.WriteLine("Menor de Idade");
}



*//**2.Verificador de Número(Positivo, Negativo ou Zero)**
Crie um programa que declare uma variável **`numero`**;
Utilize uma estrutura **`if/else if/else`** para verificar e imprimir uma das seguintes mensagens: "*O número é positivo.*", 
"*O número é negativo.*" ou "*O número é zero.*". 

Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());
if (numero >= 1)
{
    Console.WriteLine("Numero Positivo");
}
else if (numero <= -1)  
{
    Console.WriteLine("Numero Negativo");
}
else
{
    Console.WriteLine("O número é zero.");
}


/***3. Classificação de Aluno**

Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno (um valor **`double`**). 

Em seguida, use uma estrutura **`if/else`** simples para imprimir "Aprovado" se a nota for maior ou igual a 7.0, e "Reprovado" caso contrário


Console.WriteLine("Digite a nota do aluno : ");
double nota = Convert.ToDouble(Console.ReadLine());
if(nota >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

*/



/***4. Classificação por Faixa Etária**

Peça a idade do usuário e classifique: até 12 anos → `"Criança"`, de 13 a 17 → `"Adolescente"`, 18 ou mais → `"Adulto"`. Use condicional encadeada (`else if`).

Console.WriteLine("Digite a idade do usuario : ");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());
if (idadeUsuario <= 12)
{
    Console.WriteLine("Criança");
}
else if (idadeUsuario >13 && idadeUsuario <= 17)
{
    Console.WriteLine("adolescente");
}
else
{
    Console.WriteLine("Adulto");
}



/***5. Status de Tarefa**

Declare uma variável **`boolean tarefaConcluida`**. 

Usando uma estrutura **`if/else`**, exiba a mensagem "A tarefa está pendente!" se a variável for **`false`**, e "A tarefa foi finalizada com sucesso!" se for **`true`**.

bool tarefaConcluida = false;
if (tarefaConcluida)
{
    Console.WriteLine("A tarefa foi finalizada com sucesso!");
}
else 
{
    Console.WriteLine("A tarefa está pendente!");
}
*/



/*
**6.Nota Válida(operador &&) * *

Peça uma nota ao usuário. Use o operador `&&` para verificar se ela está dentro do intervalo válido (entre 0 e 10). Exiba `"Nota válida"` ou `"Nota inválida"`.

Console.WriteLine("Digite a nota :");
double nota = Convert.ToDouble(Console.ReadLine());
 if(nota <= 10 && nota >= 0) 
 {
     Console.WriteLine("Nota válida");
 }
 else
 {
     Console.WriteLine("Nota inválida");
 }
*/



/* 
**7.Aprovação de Empréstimo**

Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e não possua restrições de crédito. 

Crie um programa com as variáveis **`double salarioMensal`**; e * *`boolean possuiRestricao`** . 
Use o operador lógico "E" (**`&&`**) em uma estrutura **`if`** para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado." 

Console.WriteLine("Digite o salário mensal:");

double salarioMensal = Convert.ToDouble(Console.ReadLine());
bool possuiRestricao = false;
if (salarioMensal >=2000.00 && !possuiRestricao)
{
    Console.WriteLine("Emprestimo Aprovado");
}
else
{
    Console.WriteLine("Emprestimo negado");
}

/***8. Classificação de Média Escolar Completa**

Crie um programa que solicita ao usuário que digite uma nota (um valor

**`double`**). Utilizando uma estrutura **`if/ else if /else`**, classifique a nota da seguinte forma:

- Se a nota for 7.0 ou maior, imprima "Aprovado!".
- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
- Se a nota for menor que 5.0, imprima "Reprovado.". 


Console.WriteLine("digite uma nota : ");
double nota = Convert.ToDouble(Console.ReadLine());
if(nota >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else if (nota >=5.0 && nota < 7.0)
{
    Console.WriteLine("Recuperacao");
}
else
{
    Console.WriteLine("Reprovado");
}
*/


/* **9. Par ou Ímpar com Operador Ternário**

Declare uma variável **`numero`**; Utilizando o operador ternário (**`? :`**), crie uma variável String resultado que receba o texto "Par" se o número for par, ou "Ímpar" se for ímpar. Ao final, imprima o resultado.

int numero = 15;
string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine(resultado);*/


/*
**10.Cálculo de Desconto Progressivo * *

Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável

`double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:

-Compras acima de R$ 200,00 têm 20% de desconto.
- Compras entre R$ 100,00 (inclusive) e R$ 200,00 (exclusive) têm 10% de desconto.
- Compras abaixo de R$ 100,00 não têm desconto.
    
    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.
*/












