# Manipulando strings em Csharp

Em C#, as strings são imutáveis, o que significa que uma vez criada, uma string não pode ser alterada. No entanto, existem várias maneiras de manipular strings para criar novas strings com base nas originais.

---

### IndexOf()
- O método `IndexOf()` é uma ferramenta poderosa para encontrar a posição de uma substring dentro de uma string. Ele retorna o índice da primeira ocorrência da substring especificada. Se a substring não for encontrada, o método retorna -1.

```csharp
string frase = "Olá, Mundo! Mundo é belo.";
int indicePrimeiraOcorrencia = frase.IndexOf("Mundo");
int indiceSegundaOcorrencia = frase.IndexOf("Mundo", indicePrimeiraOcorrencia + 1);
// indicePrimeiraOcorrencia é 5, indiceSegundaOcorrencia é 15
```

---

### Substring()
- O método `String.Substring()` é usado para extrair uma parte de uma string.
- O método `Substring()` precisa da posição inicial e do número de caracteres, ou comprimento, para recuperar.

```csharp
string frase = "Olá, Mundo!";
string parte = frase.Substring(0, 4);
// parte é "Olá,"
```


```csharp
string message = "Find what is (inside the parentheses)";
 
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
 
openingPosition++;
 
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
// Saída: inside the parentheses
```

---

### Evitar valores mágicos

```csharp
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
```

- As cadeias de caracteres embutidas em código como `"<span>"`, no código acima, são conhecidas como "cadeias de caracteres mágicas", e os valores numéricos embutidos em código como `6` são conhecidos como "números mágicos". Esses valores "Mágicos" não são recomendados por muitos motivos e devem ser evitados sempre que possível.
- No código anterior se você embutir a cadeia de caracteres `"<span>"` várias vezes, no código, mas tiver escrito uma instância dela incorretamente como `"<sapn>"`. 
- O compilador não detecta `"<sapn>"` em tempo de compilação porque o valor está em uma cadeia de caracteres. O erro de ortografia leva a problemas em tempo de execução e, dependendo da complexidade do seu código, poderá ser difícil de rastrear. 
- Além disso, se você alterar a cadeia de caracteres `"<span>"` para a `"<div>"` mais curta, mas esquecer de alterar o número `6` para `5`, o código produzirá resultados indesejáveis.

**Código sem números mágicos:**
```csharp
string message = "What is the value <span>between the tags</span>?";
 
const string openSpan = "<span>";
const string closeSpan = "</span>";
 
int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);
 
openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
// Saída: between the tags
```

- O código usa uma constante com a palavra-chave `const`. Uma constante permite definir e inicializar uma variável cujo valor nunca pode ser alterado.

---

### IndexOfAny()
- O método `IndexOfAny()` é usado para encontrar o índice da primeira ocorrência de qualquer caractere de um conjunto de caracteres especificados em uma string. Ele retorna o índice da primeira ocorrência de qualquer caractere do conjunto fornecido. Se nenhum caractere do conjunto for encontrado, o método retorna -1.

```csharp
string frase = "Olá, Mundo!";
char[] caracteres = { 'M', 'm' };
int indice = frase.IndexOfAny(caracteres);
// indice é 5, pois 'M' é encontrado na posição 5
```

---

### LastIndexOf()
- O método `LastIndexOf()` é semelhante ao `IndexOf()`, mas em vez de encontrar a primeira ocorrência de uma substring, ele procura pela última ocorrência. Ele retorna o índice da última ocorrência da substring especificada. Se a substring não for encontrada, o método retorna -1.

```csharp
string frase = "Olá, Mundo! Mundo é belo.";
int indice = frase.LastIndexOf("Mundo");
// indice é 15, pois a última ocorrência de "Mundo" começa na posição 15
```

---

### Remove()
- O método `Remove()` é usado para criar uma nova string removendo uma parte específica da string original. Ele aceita dois argumentos: o índice inicial da remoção e o número de caracteres a serem removidos.

```csharp
string frase = "Olá, Mundo!";
string novaFrase = frase.Remove(5, 5);
// novaFrase é "Olá,!"
```

- O método `Remove()` funciona de forma semelhante ao método `Substring()`. Defina uma posição inicial e o comprimento para remover esses caracteres da cadeia de caracteres.

---

### Replace()
- O método `Replace()` é usado quando você precisa substituir um ou mais caracteres por outro (ou nenhum). O método `Replace()` é diferente dos outros usados até agora, pois **substitui todas as instâncias** dos caracteres especificados, não apenas a primeira ou a última.

```csharp
string frase = "Olá, Mundo!";
string novaFrase = frase.Replace("Mundo", "World");
// novaFrase é "Olá, World!"
```

