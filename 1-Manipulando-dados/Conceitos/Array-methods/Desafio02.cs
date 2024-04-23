/*
 * Descrição:
 * Nesse desafio é preciso analisar uma cadeia de caracteres de pedidos, classificá-los e marcar possíveis erros.
 * Os dados vêm em muitos formatos. Neste desafio, você deverá analisar as "IDs do pedido" individuais e gerá-las classificadas e marcadas como "Erro" quando não tiverem exatamente quatro caracteres.
 *
 * Para começar:
 * 1. Atualize seu código no Editor da seguinte maneira:
 * string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
 *
 * 2. Escreva o código necessário para analisar as "IDs de pedido" dos pedidos de entrada string e armazenar as "IDs do pedido" em uma matriz.
 *
 * 3. Adicione o código para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que não tiverem exatamente quatro caracteres como "- Erro"
 * 
 * Seu código deverá produzir a seguinte saída:
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
