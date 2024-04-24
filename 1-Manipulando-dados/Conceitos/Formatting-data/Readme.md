# Formatando dados alfanuméricos em Csharp

A formatação de dados alfanuméricos envolve a apresentação de dados de uma maneira que seja fácil de ler e entender. Em C#, existem várias maneiras de formatar dados alfanuméricos, incluindo o uso de métodos de string, como `String.Format()`, `String.Format()` com interpolação de strings, e o uso de classes como `StringBuilder` para construção de strings complexas.

---
### O que é a Formatação Composta?
- A **formatação composta** usa espaços reservados numerados dentro de uma cadeia de caracteres. No runtime, tudo o que está dentro das chaves é resolvido para um valor que também é transmitido com base na posição.

Este exemplo de formatação composta usa um método interno `Format()` na palavra-chave do tipo de dados `string`.

```js
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); // Saída: Hello World!
```

Coisas importantes a se observar sobre esse código:
- Os tipos de dados e as variáveis de um determinado tipo de dados têm “métodos auxiliares” internos para facilitar determinadas tarefas.
- A cadeia de caracteres literal `"{0} {1}!"` forma um modelo que tem suas partes substituídas no runtime.
- O token `{0}` é substituído pelo primeiro argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da variável `first`.
- O token `{1}` é substituído pelo segundo argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da variável `second`.

```js
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second); // Saída: World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); // Saída: Hello Hello Hello!
```

Coisas importantes a se observar sobre esse código:
- Para a primeira instrução `Console.WriteLine()`, observe que os tokens podem ser organizados em qualquer ordem. O código de exemplo tem `{1}` antes de `{0}`.
- Para a segunda instrução `Console.WriteLine()`, observe que os tokens podem ser reutilizados com três instâncias de `{0}`. Além disso, o segundo argumento de variável, `second`, não é usado. No entanto, o código ainda é executado sem erros.

---

### Interpolação
- A _interpolação de cadeia de caracteres_ é uma técnica que simplifica a formatação composta.
- Em vez de usar um token numerado e incluir o valor literal ou nome da variável em uma lista de argumentos em `String.Format()` ou `Console.WriteLine()`, você pode apenas usar o nome da variável dentro das chaves.

```csharp
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); // Saída: Hello World!
Console.WriteLine($"{second} {first}!"); // Saída: World Hello!
Console.WriteLine($"{first} {first} {first}!"); // Saída: Hello Hello Hello!
```

---

### Formatar moedas
- A formatação composta e a interpolação de cadeia de caracteres podem ser usadas para formatar valores para exibição considerando uma linguagem e cultura específicas. No exemplo a seguir, o especificador de formato de moeda `:C` é usado para apresentar as variáveis `price` e `discount` como moeda. 

```csharp
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Saída: Price: R$ 123,45 (Save R$ 50,00)
```

---

### Formatar  números
- Ao trabalhar com dados numéricos, talvez deseje formatar o número para facilitar a leitura, incluindo vírgulas para delinear milhares, milhões, bilhões e assim por diante.
- O especificador de formato numérico `N` torna os números mais legíveis.

```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); 
// Saída: Measurement: 123.456,79 units
```

- Por padrão, o especificador de formato numérico `N` exibe apenas dois dígitos após o ponto decimal.
- Se desejar mostrar mais precisão, adicione um número após o especificador.

```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
// Saída: Measurement: 123.456,7891 units
```

---

### Formatar percentuais
- Use o especificador de formato `P` para formatar percentuais. Adicione um número posteriormente para controlar o número de valores exibidos após o ponto decimal. 

```csharp
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); // Saída: Tax rate: 36,79%
```

---

### Combinar abordagens de formatação
- Variáveis de cadeia de caracteres podem armazenar as cadeias de caracteres criadas usando técnicas de formatação.

```csharp
decimal price = 67.55m;
decimal salePrice = 59.99m;
 
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
 
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);
// Saída: You saved R$ 7,56 off the regular R$ 67,55 price. A discount of 11,19%!
```

---

## Métodos

### ToString()
- A formatação de números é uma parte importante da formatação de dados alfanuméricos. O C# oferece várias maneiras de formatar números, incluindo o uso de métodos como `ToString()` com formatadores de string.

```csharp
double valor = 1234.5678;
string valorFormatado = valor.ToString("C"); // Formata como moeda
// valorFormatado é "R$1,234.57" (dependendo da cultura do sistema)
```

---

### StringBuilder
- Para construções de strings mais complexas, como a concatenação de várias partes de uma string com base em condições, o `StringBuilder` é uma escolha eficiente.

```csharp
StringBuilder sb = new StringBuilder();
sb.Append("Olá, ");
if (true) // Exemplo de condição
{
    sb.Append("este é um exemplo de formatação complexa.");
}
string mensagemComplexa = sb.ToString();
// mensagemComplexa é "Olá, este é um exemplo de formatação complexa."
```

---

- Métodos que adicionam espaços em branco para fins de formatação (`PadLeft()`, `PadRight()`)

- Métodos que comparam duas cadeias de caracteres ou facilitam a comparação (`Trim()`, `TrimStart()`, `TrimEnd()`, `GetHashcode()`, a propriedade `Length`)

- Métodos que ajudam a determinar o que há dentro de uma cadeia de caracteres ou até mesmo recuperar apenas uma parte da cadeia de caracteres (`Contains()`, `StartsWith()`, `EndsWith()`, `Substring()`)

- Métodos que alteram o conteúdo da cadeia de caracteres substituindo, inserindo ou removendo partes (`Replace()`, `Insert()`, `Remove()`)

- Métodos que transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres ou de caracteres (`Split()`, `ToCharArray()`)

---

