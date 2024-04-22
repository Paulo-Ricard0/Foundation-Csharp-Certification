/*
 * Descri��o:
 * Nesse desafio � preciso combinar valores de uma matriz como cadeias de caracteres e inteiros.
 * 
 * Para instanciar a matriz de cadeia de caracteres, insira o seguinte c�digo:
 * string[] values = { "12.3", "45", "ABC", "11", "DEF" };
 * 
 * � necess�rio implementar as seguintes regras de neg�cio na l�gica do c�digo:
 * Regra 1: Se o valor for alfab�tico, concatene-o para formar uma mensagem.
 * Regra 2: se o valor for num�rico, adicione-o ao total.
 * Regra 3: o resultado deve corresponder � seguinte sa�da:
 * 
 * Sa�da: 
 * Message: ABCDEF
 * Total: 68.3
 */

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
  decimal number;
  if (decimal.TryParse(value, out number))
  {
    total += number;
  }
  else
  {
    message += value;
  }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
