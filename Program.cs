// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

Product TestProduct = new Product("msi laptop", "lorem", 500, 22);
Console.WriteLine(TestProduct.GetProductNumber());
Console.WriteLine(TestProduct.name);
Console.WriteLine(TestProduct.FullName());
Console.WriteLine(TestProduct.SerialNumber());
class Product
{
    private int productNumber = new Random().Next(1, 100);
    public string name;
    public string description;
    private float price;
    public int iva;

    public Product(string name, string description, int price, int iva)
    {
        this.productNumber = new Random().Next(1, 1000000);
        this.name = name;
        this.description = description;
        this.price = price;
        this.iva = iva;
    }
    public int GetProductNumber()
    {
      return this.productNumber;
    }
    public float BasePrice()
    {
        return this.price;
     }
    public float FullPrice()
    {
        return (this.price + (this.price / 100 * this.iva));
    }
  public string FullName()
    {
        return this.name + GetProductNumber();
    }
    public string SerialNumber()
    {
        string serialNumber = "";
        int serialNumberLength = 8 - this.productNumber.ToString().Length;
        for(int i = 0; i < serialNumberLength; i++)
        {
            serialNumber += '0';
        }
        serialNumber += this.productNumber.ToString();
        return serialNumber;
    }
}

