class Product
{
    public string Name;
    public int Price;

    //public Product() { }//default parameter, will give warning

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}