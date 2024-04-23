/*
 * Descri��o:
 * Nesse desafio � preciso analisar uma cadeia de caracteres de pedidos, classific�-los e marcar poss�veis erros.
 * Os dados v�m em muitos formatos. Neste desafio, voc� dever� analisar as "IDs do pedido" individuais e ger�-las classificadas e marcadas como "Erro" quando n�o tiverem exatamente quatro caracteres.
 *
 * Para come�ar:
 * 1. Atualize seu c�digo no Editor da seguinte maneira:
 * string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
 *
 * 2. Escreva o c�digo necess�rio para analisar as "IDs de pedido" dos pedidos de entrada string e armazenar as "IDs do pedido" em uma matriz.
 *
 * 3. Adicione o c�digo para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que n�o tiverem exatamente quatro caracteres como "- Erro"
 * 
 * Seu c�digo dever� produzir a seguinte sa�da:
 * A345
 * B123
 * B177
 * B179
 * C15     - Error
 * C234
 * C235
 * G3003   - Error
 * 
 */

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

Array.Sort(orders);

foreach (string order in orders)
{
  if (order.Length == 4)
  {
    Console.WriteLine(order);
  }
  else
  {
    Console.WriteLine($"{order}\t - Error");
  }
}
