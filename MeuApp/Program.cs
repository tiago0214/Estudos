using System;
using System.Text;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Collections;

Console.Clear();
Console.WriteLine("=======================Time Zones===============================");
//recomendavel usar. Porque aqui pega a data global.( sem o +/- por causa dos fuso horário.)
var utcDate = DateTime.UtcNow;
Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

//posso utilizar o timezone de outro lugar.

var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
//essa variavel de cima, somente pega o time zone, mas não aplica em nada.
Console.WriteLine(timeZoneAustralia);
//para aplicar eu preciso fazer isso:
var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
Console.WriteLine(horaAustralia);

//Para pegar e saber o time zone de tudo instalado no meu sistema operacional.
Console.WriteLine("Time zones instalados-----------------");
var timezones = TimeZoneInfo.GetSystemTimeZones();

foreach (TimeZoneInfo timezone in timezones)
{
    //Console.WriteLine(timezone.Id);
    //Console.WriteLine(timezone);
    //Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
    //Console.WriteLine("-------------");
}



Console.WriteLine("=================Globalização de datas==========================");
//acho que todas essas culturas influenciam em tudo, NO IDIOMA, NA MOEDA...
var pt = new System.Globalization.CultureInfo("pt-PT");
var br = new System.Globalization.CultureInfo("pt-BR");
var en = new System.Globalization.CultureInfo("en-US");
var de = new System.Globalization.CultureInfo("de-DE");
var maquina = CultureInfo.CurrentCulture; //Mostra a cultura da minha maquina. 
//para que eu possa formatar a data, preciso converter para to string.
//também, eu posso emitir O "System.Globalization" e utilizar somente o CultureInfo. Se eu importar o "System.Globalization" no começo, com o using.
var enUk = new CultureInfo("en-UK");

Console.WriteLine(DateTime.Now.ToString("D", en));
Console.WriteLine(DateTime.Now.ToString("D", pt));
//perceba, que eu acho que por ser uma struct, eu não preciso salvar em uma variavel primeiro, eu posso mandar imprimir de cara
//O formato eu coloquei em "D" e a cultura é depois da virgula.






Console.WriteLine("=====================Comparando datas===========================");
//se eu tentar comparar as datas. Nunca vai dar certo, porque ele pegas toda a estrutura do struct, e com isso ele usa até os milisegundos.
/*Ex Porque nesse exemplo de baixo, ele compara a estrutura toda, ou seja. Ele compara a Hora*/
var data1 = DateTime.Now;
if (data1 == DateTime.Now)
{
    Console.WriteLine("É igual");
}
else
{
    Console.WriteLine("False");
}
//posso fazer assim
var data2 = DateTime.Now;
if (data2.Date == DateTime.Now.Date)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


Console.WriteLine("=====================Formatando datas===========================");

//pegar a data atual.
var data = DateTime.Now; //não abre e fecha parenteses no Now, porque ele não é um método e sim uma propriedade. F12 para inspencionar
//formatar a data acima.
string formatada = String.Format("{0:yyyy-MM-dd hh:mm:ss}", data);
Console.WriteLine(formatada);
Console.WriteLine(data.ToString("yyyy"));
//os dois ai de cima, se comportam igual, 
Console.WriteLine(data.ToString("g"));//tem um punhado de outras formatações , d,D,t,T,r,
//cada letra representa uma formatação pré pronta.
//a formatação com o "s" é muito usada no tipo de dado Json, seu eu precisar converter algo para o front-end, eu tenho que usar.
//e o "u", é para o json







//Isso aqui, eu criei "Instancia", na real não é instancia, porque é um struct. Eu crio uma estrutura que esta vindo com os valores padrões.
var dataa = new DateTime(1994, 08, 16, 08, 50, 13);


Console.WriteLine("=================Utilizando o String Builder====================");

// //gerar textos muito grandes, não posso abrir de uma vez, porque se não da erro de memória.
// //não posso ficar utilizando o +=, para ficar adicionando, porque se não vai dar erro de memória. Porque toda vez ele cria uma cópia do meu texto.
// //melhor opção é o stringBuilder();

// var texto = new StringBuilder();
// texto.Append("Esse ");
// texto.Append("é ");
// texto.Append("um ");
// texto.Append("texto ");
// texto.Append("válido ");
// //porém eu tenho que converter com o toString(). Porque isso não é uma string e sim um stringBuilder();
// //eu não converti, porque o console.WriteLine(), faz essa conversão automatica,mas se eu quiser usar em outro lugar, eu preciso converter.
// Console.WriteLine(texto);










































// var texto = "este texto é um teste";

// Console.WriteLine(texto.IndexOf("é"));
// //se atentar que se eu pedir para que ele pegue um indice de alguma palavra, ele vai pegar o primeiro caracter dessa palavra.
// Console.WriteLine(texto.IndexOf("teste"));

// Console.WriteLine(texto.Length);
// Console.WriteLine(texto.LastIndexOf("e"));
// //last indexOf. pega o ultimo indice de alguma palavra ou letra que ele encontrar.
// Console.WriteLine(texto.Insert(5, "Aqui "));
// Console.WriteLine(texto.Remove(5, 5));
// //esse metodo ai de cima, ele recebe o indice onde eu quero inciar e remover, e depois pede quantos caracteres, eu quero remover.
// Console.WriteLine(texto.Replace("e", "X"));

// //o metod Split, permite que eu selecione algo do meu texto e separe todo oque tiver ele.
// //com isso , ele vai criar um array de strings, ou seja, para acessar eu preciso ir pelos indices.
// var divisao = texto.Split(" ");
// Console.WriteLine(divisao[0]);
// Console.WriteLine(divisao[1]);
// Console.WriteLine(divisao[2]);
// Console.WriteLine(divisao[3]);
// Console.WriteLine(divisao[4]);

// //Trim, é um metodo que remove os espaços no final.
// var texto2 = " Aqui é um texto como espaço no final e no começo ";
// Console.WriteLine(texto2.Trim());





































// //outro modo de comparar strings.
// //temos o equals.pode ser usado para outros valores,que nao sejam string.
// var texto = "Tem que ser o texto todo igual";
// Console.WriteLine(texto.Equals("tem que ser o texto todo igual", StringComparison.OrdinalIgnoreCase));












































// string texto = "Meu texto é esse";

// Console.WriteLine(texto.StartsWith("meu", StringComparison.OrdinalIgnoreCase));
// Console.WriteLine(texto.StartsWith("Meu"));
// Console.WriteLine(texto.StartsWith("teste"));
// Console.WriteLine("----------");
// Console.WriteLine(texto.EndsWith("esse"));
// Console.WriteLine(texto.EndsWith("Esse"));
// Console.WriteLine(texto.EndsWith("asdas"));






































// Console.Clear();

// //Comparando strings
// string texto = "Este é um texto de teste";
// //melhor modo de comparar é Contains(); Verifica sem tem uma palavra dentro de um texto.ou compara dois textos
// Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));

// //lembrando que o C# é case sensitive. Se eu quiser desligar , eu preciso .StringComparison.OrdinalIgnoreCase

// //Console.WriteLine(texto.CompareTo("foi"));
// //CompareTo();verificar se tem duas strings iguais.










































// var preco = 10.2;
// var texto = String.Format("O preco do produto {0} apenas {1}", preco, true);
// //modo de formatar uma string.
// var textoo = $@"Esse é um modo de formatação
// que permite quebra de linha";

// Console.WriteLine(texto);
// Console.WriteLine(textoo);







































// var id = Guid.NewGuid();
// //esse método, colocar uma hash, e toda vez que eu dar run no meu programa, um novo valor é atribuido.
// //quando eu dou console.Writeline, eu estou convertendo ele em string para imprimir.
// //tem várias maneiras que eu consigo usar ele.
// id.ToString();
// id = new Guid("dd468791-3fb4-4350-b9d3-b882a2f3fc58");
// //se eu não passar com esse tanto de caracter, ele vai dar erro. Preciso ser preciso.
// var primeiros = id.ToString().Substring(0, 8);

// Console.WriteLine(id);
// Console.WriteLine(primeiros);

// //se eu usar new Guild(); ele somente inicializa o identificador com tudo 0;
// //preciso do Guid.newGuid() para gerar um guid;












































// var pro = new Product(1, "a", 2.2, EProduct.Product);

// Console.WriteLine(pro.Id);
// Console.WriteLine(pro.Name);
// Console.WriteLine(pro.Price);


// enum EProduct
// {
//     Product = 1,
//     Service = 2
// }
// struct Product
// {

//     public Product(int id, string name, double price, EProduct produto)
//     {
//         Id = id;
//         Name = name;
//         Price = price;
//         Produto = produto;
//     }

//     public int Id;
//     public string Name;
//     public double Price;
//     public EProduct Produto;

//     public double PriceInDolar(double dolar)
//     {
//         return Price * dolar;
//     }
//     //não é possivel criar uma propriedade dentro da minha classe que recebe como um tipo um ENUM, porém, eu consigo criar dentro de uma estrutura.

// }














