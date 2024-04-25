# Manipulando strings em Csharp

Em C#, as strings s�o imut�veis, o que significa que uma vez criada, uma string n�o pode ser alterada. No entanto, existem v�rias maneiras de manipular strings para criar novas strings com base nas originais.

---

### IndexOf()
- O m�todo�`IndexOf()`�� uma ferramenta poderosa para encontrar a posi��o de uma substring dentro de uma string. Ele retorna o �ndice da primeira ocorr�ncia da substring especificada. Se a substring n�o for encontrada, o m�todo retorna -1.

```csharp
string frase = "Ol�, Mundo! Mundo � belo.";
int indicePrimeiraOcorrencia = frase.IndexOf("Mundo");
int indiceSegundaOcorrencia = frase.IndexOf("Mundo", indicePrimeiraOcorrencia + 1);
// indicePrimeiraOcorrencia � 5, indiceSegundaOcorrencia � 15
```

---

### Substring()
- O m�todo�`String.Substring()`�� usado para extrair uma parte de uma string.
- O m�todo�`Substring()`�precisa da posi��o inicial e do n�mero de caracteres, ou comprimento, para recuperar.

```csharp
string frase = "Ol�, Mundo!";
string parte = frase.Substring(0, 4);
// parte � "Ol�,"
```


```csharp
string�message�=�"Find�what�is�(inside�the�parentheses)";
 
int�openingPosition�=�message.IndexOf('(');
int�closingPosition�=�message.IndexOf(')');
 
openingPosition++;
 
int�length�=�closingPosition�-�openingPosition;
Console.WriteLine(message.Substring(openingPosition,�length));
// Sa�da: inside the parentheses
```

---

### Evitar valores m�gicos

```csharp
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
```

- As cadeias de caracteres embutidas em c�digo como�`"<span>"`,�no c�digo acima, s�o conhecidas como "cadeias de caracteres m�gicas", e os valores num�ricos embutidos em c�digo como�`6`�s�o conhecidos como "n�meros m�gicos". Esses valores "M�gicos" n�o s�o recomendados por muitos motivos e devem ser evitados sempre que poss�vel.
- No c�digo anterior se voc� embutir a cadeia de caracteres�`"<span>"`�v�rias vezes, no c�digo, mas tiver escrito uma inst�ncia dela incorretamente como�`"<sapn>"`. 
- O compilador n�o detecta�`"<sapn>"`�em tempo de compila��o porque o valor est� em uma cadeia de caracteres. O erro de ortografia leva a problemas em tempo de execu��o e, dependendo da complexidade do seu c�digo, poder� ser dif�cil de rastrear. 
- Al�m disso, se voc� alterar a cadeia de caracteres�`"<span>"`�para a�`"<div>"`�mais curta, mas esquecer de alterar o n�mero�`6`�para�`5`, o c�digo produzir� resultados indesej�veis.

**C�digo sem n�meros m�gicos:**
```csharp
string�message�=�"What�is�the�value�<span>between�the�tags</span>?";
 
const�string�openSpan�=�"<span>";
const�string�closeSpan�=�"</span>";
 
int�openingPosition�=�message.IndexOf(openSpan);
int�closingPosition�=�message.IndexOf(closeSpan);
 
openingPosition�+=�openSpan.Length;
int�length�=�closingPosition�-�openingPosition;
Console.WriteLine(message.Substring(openingPosition,�length));
// Sa�da: between the tags
```

- O c�digo usa uma constante com a palavra-chave�`const`. Uma constante permite definir e inicializar uma vari�vel cujo valor nunca pode ser alterado.

---

### IndexOfAny()
- O m�todo�`IndexOfAny()`�� usado para encontrar o �ndice da primeira ocorr�ncia de qualquer caractere de um conjunto de caracteres especificados em uma string. Ele retorna o �ndice da primeira ocorr�ncia de qualquer caractere do conjunto fornecido. Se nenhum caractere do conjunto for encontrado, o m�todo retorna -1.

```csharp
string frase = "Ol�, Mundo!";
char[] caracteres = { 'M', 'm' };
int indice = frase.IndexOfAny(caracteres);
// indice � 5, pois 'M' � encontrado na posi��o 5
```

---

### LastIndexOf()
- O m�todo�`LastIndexOf()`�� semelhante ao�`IndexOf()`, mas em vez de encontrar a primeira ocorr�ncia de uma substring, ele procura pela �ltima ocorr�ncia. Ele retorna o �ndice da �ltima ocorr�ncia da substring especificada. Se a substring n�o for encontrada, o m�todo retorna -1.

```csharp
string frase = "Ol�, Mundo! Mundo � belo.";
int indice = frase.LastIndexOf("Mundo");
// indice � 15, pois a �ltima ocorr�ncia de "Mundo" come�a na posi��o 15
```

---

### Remove()
- O m�todo�`Remove()`�� usado para criar uma nova string removendo uma parte espec�fica da string original. Ele aceita dois argumentos: o �ndice inicial da remo��o e o n�mero de caracteres a serem removidos.

```csharp
string frase = "Ol�, Mundo!";
string novaFrase = frase.Remove(5, 5);
// novaFrase � "Ol�,!"
```

- O m�todo�`Remove()`�funciona de forma semelhante ao m�todo�`Substring()`. Defina uma posi��o inicial e o comprimento para remover esses caracteres da cadeia de caracteres.

---

### Replace()
- O m�todo�`Replace()`�� usado quando voc� precisa substituir um ou mais caracteres por outro (ou nenhum). O m�todo�`Replace()`�� diferente dos outros usados at� agora, pois�**substitui todas as inst�ncias**�dos caracteres especificados, n�o apenas a primeira ou a �ltima.

```csharp
string frase = "Ol�, Mundo!";
string novaFrase = frase.Replace("Mundo", "World");
// novaFrase � "Ol�, World!"
```

