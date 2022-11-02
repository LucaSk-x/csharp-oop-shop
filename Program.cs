// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Prodotto prodottoNuovo = new Prodotto(1000, "gioco", "gioco molto divertente", 100, 22);

Console.WriteLine("Il prezzo compreso senza Iva è: " + prodottoNuovo.getPrezzo() + "€");
Console.WriteLine("Il prezzo compreso di Iva è: " + prodottoNuovo.prezzoIntero() + "€");

Console.WriteLine("Il nome del prodotto è: " + prodottoNuovo.getNome());
Console.WriteLine("Il nome del prodotto completo è: " + prodottoNuovo.nomeIntero());

Console.WriteLine("Il codice del prodotto completo è: " + prodottoNuovo.addPad());

public class Prodotto
{
    private int codice;
    private string nome;
    private string descrizione;
    private double prezzo;
    private int iva;


    public Prodotto(int codice, string nome, string descrizione, double prezzo, int iva)
    {
        this.codice = codice;
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = iva;
    }

    //Codice del prodotto
    public int getCodice()
    {
        return this.codice;
    }

    //Nome del prodotto
    public string getNome()
    {
        return this.nome;
    }

    public string setNome()
    {
        return this.nome = nome;
    }

    //Descrizione del prodotto
    public string getDescrizione()
    {
        return this.descrizione;
    }

    public string setDescrizione()
    {
        return this.descrizione = descrizione;
    }

    //Prezzo del pprodotto
    public double getPrezzo()
    {
        return this.prezzo;
    }

    public double setPrezzo()
    {
        return this.prezzo = prezzo;
    }

    //Iva del prodotto
    public int getIva()
    {
        return this.iva;
    }

    public double setIva()
    {
        return this.iva = iva;
    }

    public double prezzoIntero()
    {
        return prezzo + (prezzo / 100 * iva);
    }

    public string nomeIntero()
    {
        return codice + nome;
    }

    public string addPad()
        
    {
        string codiceStr = codice.ToString();
        while (codiceStr.Length < 8)
        {
            codiceStr = "0" + codiceStr;
        }
        return codiceStr;
    }
}