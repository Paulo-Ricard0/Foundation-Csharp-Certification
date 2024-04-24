# Formatando dados alfanum�ricos em Csharp

A formata��o de dados alfanum�ricos envolve a apresenta��o de dados de uma maneira que seja f�cil de ler e entender. Em C#, existem v�rias maneiras de formatar dados alfanum�ricos, incluindo o uso de m�todos de string, como�`String.Format()`,�`String.Format()`�com interpola��o de strings, e o uso de classes como�`StringBuilder`�para constru��o de strings complexas.

---
### O que � a Formata��o Composta?
- A�**formata��o composta**�usa espa�os reservados numerados dentro de uma cadeia de caracteres. No runtime, tudo o que est� dentro das chaves � resolvido para um valor que tamb�m � transmitido com base na posi��o.

Este exemplo de formata��o composta usa um m�todo interno�`Format()`�na palavra-chave do tipo de dados�`string`.

```js
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result); // Sa�da: Hello World!
```

Coisas importantes a se observar sobre esse c�digo:
- Os tipos de dados e as vari�veis de um determinado tipo de dados t�m �m�todos auxiliares� internos para facilitar determinadas tarefas.
- A cadeia de caracteres literal�`"{0} {1}!"`�forma um modelo que tem suas partes substitu�das no runtime.
- O token�`{0}`�� substitu�do pelo primeiro argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da vari�vel�`first`.
- O token�`{1}`�� substitu�do pelo segundo argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da vari�vel�`second`.

```js
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second); // Sa�da: World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); // Sa�da: Hello Hello Hello!
```

Coisas importantes a se observar sobre esse c�digo:
- Para a primeira instru��o�`Console.WriteLine()`, observe que os tokens podem ser organizados em qualquer ordem. O c�digo de exemplo tem�`{1}`�antes de�`{0}`.
- Para a segunda instru��o�`Console.WriteLine()`, observe que os tokens podem ser reutilizados com tr�s inst�ncias de�`{0}`. Al�m disso, o segundo argumento de vari�vel,�`second`, n�o � usado. No entanto, o c�digo ainda � executado sem erros.

---

### Interpola��o
- A�_interpola��o de cadeia de caracteres_�� uma t�cnica que simplifica a formata��o composta.
- Em vez de usar um token numerado e incluir o valor literal ou nome da vari�vel em uma lista de argumentos em�`String.Format()`�ou�`Console.WriteLine()`, voc� pode apenas usar o nome da vari�vel dentro das chaves.

```csharp
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); // Sa�da: Hello World!
Console.WriteLine($"{second} {first}!"); // Sa�da: World Hello!
Console.WriteLine($"{first} {first} {first}!"); // Sa�da: Hello Hello Hello!
```

---

### Formatar moedas
- A formata��o composta e a interpola��o de cadeia de caracteres podem ser usadas para formatar valores para exibi��o considerando uma linguagem e cultura espec�ficas. No exemplo a seguir, o especificador de formato de moeda�`:C`�� usado para apresentar as vari�veis�`price`�e�`discount`�como moeda. 

```csharp
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Sa�da: Price: R$ 123,45 (Save R$ 50,00)
```

---

### Formatar  n�meros
- Ao trabalhar com dados num�ricos, talvez deseje formatar o n�mero para facilitar a leitura, incluindo v�rgulas para delinear milhares, milh�es, bilh�es e assim por diante.
- O especificador de formato num�rico�`N`�torna os n�meros mais leg�veis.

```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); 
// Sa�da: Measurement: 123.456,79 units
```

- Por padr�o, o especificador de formato num�rico�`N`�exibe apenas dois d�gitos ap�s o ponto decimal.
- Se desejar mostrar mais precis�o, adicione um n�mero ap�s o especificador.

```csharp
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
// Sa�da: Measurement: 123.456,7891 units
```

---

### Formatar percentuais
- Use o especificador de formato�`P`�para formatar percentuais. Adicione um n�mero posteriormente para controlar o n�mero de valores exibidos ap�s o ponto decimal. 

```csharp
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); // Sa�da: Tax rate: 36,79%
```

---

### Combinar abordagens de formata��o
- Vari�veis de cadeia de caracteres podem armazenar as cadeias de caracteres criadas usando t�cnicas de formata��o.

```csharp
decimal�price�=�67.55m;
decimal�salePrice�=�59.99m;
 
string�yourDiscount�=�String.Format("You�saved�{0:C2}�off�the�regular�{1:C2}�price.�",�(price�-�salePrice),�price);
 
yourDiscount�+=�$"A�discount�of�{((price�-�salePrice)�/�price):P2}!";
Console.WriteLine(yourDiscount);
// Sa�da: You saved R$ 7,56 off the regular R$ 67,55 price. A discount of 11,19%!
```

---

## M�todos

### ToString()
- A formata��o de n�meros � uma parte importante da formata��o de dados alfanum�ricos. O C# oferece v�rias maneiras de formatar n�meros, incluindo o uso de m�todos como�`ToString()`�com formatadores de string.

```csharp
double valor = 1234.5678;
string valorFormatado = valor.ToString("C"); // Formata como moeda
// valorFormatado � "R$1,234.57" (dependendo da cultura do sistema)
```

---

### StringBuilder
- Para constru��es de strings mais complexas, como a concatena��o de v�rias partes de uma string com base em condi��es, o�`StringBuilder`�� uma escolha eficiente.

```csharp
StringBuilder sb = new StringBuilder();
sb.Append("Ol�, ");
if (true) // Exemplo de condi��o
{
    sb.Append("este � um exemplo de formata��o complexa.");
}
string mensagemComplexa = sb.ToString();
// mensagemComplexa � "Ol�, este � um exemplo de formata��o complexa."
```

---

- M�todos que adicionam espa�os em branco para fins de formata��o (`PadLeft()`,�`PadRight()`)

- M�todos que comparam duas cadeias de caracteres ou facilitam a compara��o (`Trim()`,�`TrimStart()`,�`TrimEnd()`,�`GetHashcode()`, a propriedade�`Length`)

- M�todos que ajudam a determinar o que h� dentro de uma cadeia de caracteres ou at� mesmo recuperar apenas uma parte da cadeia de caracteres (`Contains()`,�`StartsWith()`,�`EndsWith()`,�`Substring()`)

- M�todos que alteram o conte�do da cadeia de caracteres substituindo, inserindo ou removendo partes (`Replace()`,�`Insert()`,�`Remove()`)

- M�todos que transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres ou de caracteres (`Split()`,�`ToCharArray()`)

---

