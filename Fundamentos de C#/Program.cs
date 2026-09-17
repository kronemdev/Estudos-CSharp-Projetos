/* 5. Saudação Personalizada
Crie um programa que declare uma variável String chamada nome com o valor "Ana". Depois, exiba uma mensagem de boas-vindas, como "Olá, Ana!".*/

String nome = "Ana";
Console.WriteLine(" Boas vindas , " + " Olá " + nome + "!");

/*6. Calcular o Dobro
Declare uma variável inteira valor. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.*/

int valor = 5;
valor = valor * 2;
Console.WriteLine( valor);

/* **7. Média de três números**
Escreva um programa que recebe três números e imprime a média aritmética deles.*/

int n1 = 5;
int n2 = 6;
int n3 = 7;
int media = (n1 + n2 + n3) / 3;
Console.WriteLine(media);

/* **8. Ficha de Cadastro**
Peça ao usuário que digite, um de cada vez, o seu **nome**, a sua **idade** e a sua **cidade**. Depois, monte uma única frase com as três informações.*/

Console.WriteLine("Digite seu nome :");
string nomeUsuario = Console.ReadLine();
Console.WriteLine("Digite sua idade :");
int idadeUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite sua cidade :");
string cidadeUsuario = Console.ReadLine();
Console.WriteLine("Olá, " + nomeUsuario + "! Você tem " + idadeUsuario + " anos e mora em " + cidadeUsuario + ".");

/* **9. Comparar Dois Números**
Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20. O programa deve comparar se `x` é menor que `y` (`<`) e imprimir o resultado (`true` ou `false`) no console.*/
int x = 10;
int y = 20;
bool resultado = x < y;
Console.WriteLine(resultado);


/***9. Verificação de Idade para Votar**
Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (
`true` ou `false`).*/

Console.WriteLine("Digite sua idade :");
int idade = Convert.ToInt32(Console.ReadLine());
bool podeVotar = idade >= 16;
Console.WriteLine(podeVotar);

/***10. Usando o Operador Lógico "E" (&&)**
Declare uma variável int temperatura = 28. Escreva uma expressão lógica que verifique se a
`temperatura` é maior que 25 **E** menor que 30. Imprima o resultado `true` ou `false` no console.*/
int temperatura = 28;
bool resultadoTemperatura = temperatura > 25 && temperatura < 30;
Console.WriteLine(resultadoTemperatura);


/* **11. Usando o Operador Lógico "OU" (||)**
Declare uma variável booleana temCartao = true e uma variável double compra = 50.0. O cliente ganha um desconto se temCartao for verdadeiro OU se o valor da compra for maior que 100.0. Escreva a expressão lógica e imprima o resultado
`true` ou `false`). */

bool temCartao = true;
double compra = 50.0;
bool desconto = temCartao || compra > 100.0;
Console.WriteLine(desconto);