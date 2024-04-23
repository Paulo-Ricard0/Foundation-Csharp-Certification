# M�todos de Arrays em Csharp

Os m�todos de arrays s�o fun��es que operam em arrays, permitindo realizar v�rias opera��es, como adicionar, remover, ordenar e pesquisar elementos.

---
## M�todos:

### Array.Sort()
- O m�todo�`Array.Sort()`�� usado para ordenar os elementos de um array. Este m�todo modifica o array original.

```csharp
int[] numeros = { 5, 3, 1, 4, 2 };
Array.Sort(numeros);
// numeros agora � { 1, 2, 3, 4, 5 }
```

---

### Array.Reverse()
- O m�todo�`Array.Reverse()`�inverte a ordem dos elementos em um array.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Reverse(numeros);
// numeros agora � { 5, 4, 3, 2, 1 }
```

----

### Array.Clear()
- O m�todo�`Array.Clear()`�� usado para definir todos os elementos de um array para o valor padr�o do tipo de elemento do array. Para tipos de valor, como�`int`,�`float`, etc., o valor padr�o �`0`�ou�`null`�para tipos de refer�ncia.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Clear(numeros, 0, numeros.Length);
// numeros agora � { 0, 0, 0, 0, 0 }
```

---

### Array.Resize()
- O m�todo�`Array.Resize()`�� usado para alterar o tamanho de um array. Se o novo tamanho for maior que o tamanho original, o array � preenchido com o valor padr�o do tipo de elemento. Se o novo tamanho for menor, os elementos excedentes s�o descartados.

```csharp
int[] numeros = { 1, 2, 3, 4, 5 };
Array.Resize(ref numeros, 3);
// numeros agora � { 1, 2, 3 }

Array.Resize(ref numeros, 5);
// numeros agora � { 1, 2, 3, 0, 0 }
```

- `Array.Resize()`�cria um novo array e copia os elementos do array original para o novo, ent�o o uso frequente deste m�todo pode ter implica��es de desempenho.

---

### Split()
- O m�todo�`Split()`�� usado para dividir uma string em um array de substrings com base em um conjunto de caracteres delimitadores. Este m�todo � muito �til para analisar strings que cont�m dados separados por um delimitador espec�fico, como v�rgulas, espa�os ou qualquer outro caractere.

```csharp
string frase = "Ol�, Mundo!";
string[] palavras = frase.Split(',', ' ');
// palavras agora � { "Ol�", "Mundo!" }
```

```csharp
string�value�=�"abc123";
char[]�valueArray�=�value.ToCharArray();
Array.Reverse(valueArray);
string�result�=�String.Join(",",�valueArray);
Console.WriteLine(result);
 
string[]�items�=�result.Split(',');
foreach�(string�item�in�items)
{
��Console.WriteLine(item);
}
```

---

### ToCharArray()
- O m�todo�`ToCharArray()`�� usado para converter uma string em um array de caracteres (`char[]`). Este m�todo � �til quando voc� precisa manipular uma string como uma cole��o de caracteres individuais, permitindo opera��es como ordena��o, pesquisa ou substitui��o de caracteres espec�ficos.

```csharp
string frase = "Ol�, Mundo!";
char[] caracteres = frase.ToCharArray();
// caracteres agora � { 'O', 'l', '�', ',', ' ', 'M', 'u', 'n', 'd', 'o', '!' }
```

---

### Join()
- O m�todo�`Join()`�� usado para concatenar os elementos de um array em uma �nica string, com um delimitador especificado entre cada elemento. Este m�todo � �til para combinar v�rias strings em uma �nica string, facilitando a manipula��o ou exibi��o de dados.

```csharp
string�value�=�"abc123";
char[]�valueArray�=�value.ToCharArray();
Array.Reverse(valueArray);
string�result�=�String.Join(",",�valueArray);
Console.WriteLine(result); // Sa�da: 3,2,1,c,b,a
```

---

