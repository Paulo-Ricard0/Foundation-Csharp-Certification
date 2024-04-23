/*
 * Descrição:
 * Nesse desafio é preciso inverter palavras em uma frase.
 *
 * Para começar:
 * 1. Atualize seu código no Editor da seguinte maneira:
 * string pangram = "The quick brown fox jumps over the lazy dog";
 *
 * 2. Escreva o código necessário para inverter as letras de cada palavra no lugar e exibir o resultado.
 *
 * Em outras palavras, não basta inverter todas as letras na variável pangram. Em vez disso, você precisará inverter apenas as letras de cada palavra, mas imprimir a palavra invertida em sua posição original na mensagem.
 * 
 * Seu código deverá produzir a seguinte saída:
 * ehT kciuq nworb xof spmuj revo eht yzal god
 * 
 */

string pangram = "The quick brown fox jumps over the lazy dog";

string[] phrases = pangram.Split(' ');
string reversedPangram = "";

foreach (string phrase in phrases)
{
  char[] letters = phrase.ToCharArray();
  Array.Reverse(letters);

  string reversedPhrase = String.Join("", letters);

  reversedPangram += $"{reversedPhrase} ";
}

Console.WriteLine(reversedPangram);
