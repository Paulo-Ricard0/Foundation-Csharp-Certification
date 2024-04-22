# Conversão de Tipos de Dados em Csharp

É um processo que permite transformar um valor de um tipo de dados (como `int`, `float`, `double`) para outros tipos de dados.

Há diversas técnicas para executar uma conversão de tipo de dados. A técnica escolhida depende da resposta a duas perguntas importantes:
- É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor gerasse uma exceção em tempo de execução?
- É possível, dependendo do valor, que a tentativa de alterar o tipo de dados do valor resultasse em uma perda de informações?
 ---
## Tipos de Conversão

### Conversão Implícita:
- Ocorre automaticamente quando o tipo de dados de uma variável é compatível com o tipo de dados de outra variável. Por exemplo, a conversão de ``int`` para ``double`` é implícita porque ``double`` tem uma faixa maior que ``int``.
 
```csharp
int numeroInteiro = 10;
double numeroDouble = numeroInteiro; // Conversão implicita
```

```csharp
int myInt = 3;
Console.WriteLine($"int: {myInt}"); // Saída: int: 3

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}") // Saída: decimal: 3
```

O termo ``conversão de expansão`` significa que você está tentando converter um valor de um tipo de dados que poderia armazenar **menos** informações em um tipo de dados que pode armazenar **mais** informações. Neste caso, um valor armazenado em uma variável do tipo `int` convertida em uma variável do tipo `decimal` não perde informação.

Quando você sabe que está realizando uma conversão de expansão, é possível confiar na **conversão implícita**. O compilador lida com conversões implícitas.

---
### Conversão Explícita (Casting): 
- É necessária quando o tipo de dados de uma variável não é compatível com o tipo de dados de outra variável. Por exemplo, converter um ``double`` para um ``int`` pode resultar em perda de dados, pois ``double`` tem uma precisão maior que ``int``.
 
```csharp
double numeroDouble = 10.5;
int numeroInteiro = (int)numeroDouble; // Conversão explicita
```

```csharp
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}"); // Saída: decimal: 3,14
 
int myInt = (int)myDecimal; // Saída: int: 3
Console.WriteLine($"int: {myInt}");
```

A variável `myDecimal` contém um valor que tem precisão após o ponto decimal. Ao adicionar a instrução de coerção `(int)`, você está dizendo ao compilador C# que entende que é possível perder essa precisão e, caso isso aconteça, não será um problema. Você está dizendo ao compilador que está realizando uma conversão intencional, uma **conversão explícita**.

---
### Conversão com a Classe Convert:
- A classe ``Convert`` fornece métodos estáticos para converter tipos de dados de maneira segura, mesmo quando os tipos não são compatíveis. Por exemplo, ``Convert.ToInt32("123")`` converte uma string para um inteiro.

```csharp
string texto = "123";
int numero = Convert.ToInt32(texto); // Conversão de string para int
```

```csharp
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); // Saída: 35 
```

>### ℹ️ Observação
>Por que o nome do método é `ToInt32()`? Por que não `ToInt()`? `System.Int32` é o nome do tipo de dados subjacente na Biblioteca de Classes do .NET que a linguagem de programação C# mapeia para a palavra-chave `int`. Como a classe `Convert` também faz parte da Biblioteca de Classes do .NET, ela é chamada por seu nome completo, não pelo seu nome em C#. Definindo tipos de dados como parte da Biblioteca de Classes do .NET, várias linguagens .NET como Visual Basic, F#, IronPython e outras podem compartilhar os mesmos tipos de dados e as mesmas classes na Biblioteca de Classes do .NET.

---
### Conversão com o Método Parse:
- A maioria dos tipos de dados numéricos tem um método `Parse()`, que converte uma cadeia de caracteres no tipo de dado especificado. Eles **lançam uma exceção** se o dado não puder ser convertido, O compilador C# e o runtime esperam que você se antecipe e evite conversões "ilegais", É possível resolver a exceção do runtime de diversas maneiras.
- A maneira mais fácil é usar `TryParse()`, que é uma versão melhorada do método `Parse()`.

```csharp
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // Saída: 12
```

---
### Conversão com o Método TryParse:
- Métodos como ``int.TryParse()`` e ``double.TryParse()`` tentam converter uma string em um número e retornam um valor booleano indicando sucesso ou falha, sem lançar exceções.

```csharp
string texto = "123";
int numero;
bool sucesso = int.TryParse(texto, out numero); // Conversão segura de string para int
```
