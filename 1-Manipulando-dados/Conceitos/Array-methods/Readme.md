# Métodos de Arrays em Csharp

Os métodos de arrays são funções que operam em arrays, permitindo realizar várias operações, como adicionar, remover, ordenar e pesquisar elementos.

---
## Métodos:

### Array.Sort()
- O método `Array.Sort()` é usado para ordenar os elementos de um array. Este método modifica o array original.

```csharp
int[] numeros = { 5, 3, 1, 4, 2 };
Array.Sort(numeros);
// numeros agora é { 1, 2, 3, 4, 5 }
```

---

### Array.Reverse()
- O método `Array.Reverse()` inverte a ordem dos elementos em um array.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Reverse(numeros);
// numeros agora é { 5, 4, 3, 2, 1 }
```

----

### Array.Clear()
- O método `Array.Clear()` é usado para definir todos os elementos de um array para o valor padrão do tipo de elemento do array. Para tipos de valor, como `int`, `float`, etc., o valor padrão é `0` ou `null` para tipos de referência.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Clear(numeros, 0, numeros.Length);
// numeros agora é { 0, 0, 0, 0, 0 }
```

---

### Array.Resize()
- O método `Array.Resize()` é usado para alterar o tamanho de um array. Se o novo tamanho for maior que o tamanho original, o array é preenchido com o valor padrão do tipo de elemento. Se o novo tamanho for menor, os elementos excedentes são descartados.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Resize(ref numeros, 3);
// numeros agora é { 1, 2, 3 }

Array.Resize(ref numeros, 5);
// numeros agora é { 1, 2, 3, 0, 0 }
```

- `Array.Resize()` cria um novo array e copia os elementos do array original para o novo, então o uso frequente deste método pode ter implicações de desempenho.

---

### Split()
- O método `Split()` é usado para dividir uma string em um array de substrings com base em um conjunto de caracteres delimitadores. Este método é muito útil para analisar strings que contêm dados separados por um delimitador específico, como vírgulas, espaços ou qualquer outro caractere.

```csharp
string frase = "Olá, Mundo!";
string[] palavras = frase.Split(',', ' ');
// palavras agora é { "Olá", "Mundo!" }
```

```csharp
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
 
string[] items = result.Split(',');
foreach (string item in items)
{
  Console.WriteLine(item);
}
```

---

### ToCharArray()
- O método `ToCharArray()` é usado para converter uma string em um array de caracteres (`char[]`). Este método é útil quando você precisa manipular uma string como uma coleção de caracteres individuais, permitindo operações como ordenação, pesquisa ou substituição de caracteres específicos.

```csharp
string frase = "Olá, Mundo!";
char[] caracteres = frase.ToCharArray();
// caracteres agora é { 'O', 'l', 'á', ',', ' ', 'M', 'u', 'n', 'd', 'o', '!' }
```

---

### Join()
- O método `Join()` é usado para concatenar os elementos de um array em uma única string, com um delimitador especificado entre cada elemento. Este método é útil para combinar várias strings em uma única string, facilitando a manipulação ou exibição de dados.

```csharp
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result); // Saída: 3,2,1,c,b,a
```

---

### Array.IndexOf()
- O método `Array.IndexOf()` retorna o índice da primeira ocorrência de um elemento específico em um array. Se o elemento não for encontrado, retorna -1.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
int indice = Array.IndexOf(numeros, 3);
// indice é 2
```

---

### Array.Find()
- O método `Array.Find()` retorna o primeiro elemento de um array que satisfaz uma condição especificada.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
int primeiroPar = Array.Find(numeros, x => x % 2 == 0);
// primeiroPar é 2
```

---

### Array.FindAll()
- O método `Array.FindAll()` retorna todos os elementos de um array que satisfazem uma condição especificada.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
int[] pares = Array.FindAll(numeros, x => x % 2 == 0);
// pares é { 2, 4 }
```

---

###  Array.Exists()
- O método `Array.Exists()` determina se um elemento que satisfaz uma condição especificada existe em um array.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
bool existePar = Array.Exists(numeros, x => x % 2 == 0);
// existePar é true
```

---
### Array.ForEach()
- O método `Array.ForEach()` executa uma ação em cada elemento de um array.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.ForEach(numeros, x => Console.WriteLine(x));
// Imprime cada número na linha de comando
```
