/*
 * Descri��o:
 * Nesse desafio � preciso inverter palavras em uma frase.
 *
 * Para come�ar:
 * 1. Atualize seu c�digo no Editor da seguinte maneira:
 * string pangram = "The quick brown fox jumps over the lazy dog";
 *
 * 2. Escreva o c�digo necess�rio para inverter as letras de cada palavra no lugar e exibir o resultado.
 *
 * Em outras palavras, n�o basta inverter todas as letras na vari�vel pangram. Em vez disso, voc� precisar� inverter apenas as letras de cada palavra, mas imprimir a palavra invertida em sua posi��o original na mensagem.
 * 
 * Seu c�digo dever� produzir a seguinte sa�da:
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
