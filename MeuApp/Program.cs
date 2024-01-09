using System;

var pro = new Product(1, "a", 2.2, EProduct.Product);


Console.WriteLine(pro.Id);
Console.WriteLine(pro.Name);
Console.WriteLine(pro.Price);


enum EProduct
{
    Product = 1,
    Service = 2
}
struct Product
{

    public Product(int id, string name, double price, EProduct produto)
    {
        Id = id;
        Name = name;
        Price = price;
        Produto = produto;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProduct Produto;

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }
    //não é possivel criar uma propriedade dentro da minha classe que recebe como um tipo um ENUM, porém, eu consigo criar dentro de uma estrutura.

}














