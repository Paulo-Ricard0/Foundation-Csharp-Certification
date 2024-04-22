/*
 * Descrição:
 * Nesse desafio é preciso combinar valores de uma matriz como cadeias de caracteres e inteiros.
 * 
 * Para instanciar a matriz de cadeia de caracteres, insira o seguinte código:
 * string[] values = { "12.3", "45", "ABC", "11", "DEF" };
 * 
 * É necessário implementar as seguintes regras de negócio na lógica do código:
 * Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.
 * Regra 2: se o valor for numérico, adicione-o ao total.
 * Regra 3: o resultado deve corresponder à seguinte saída:
 * 
 * Saída: 
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
