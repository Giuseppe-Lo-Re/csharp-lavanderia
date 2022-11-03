using System;
using static Lavatrice;

//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
//I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni)
//e di una specifica durata. Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice.
//Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.
//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.
//Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.
//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e
//quali non lo sono (in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario,
//stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.

//LAVANDERIA
public class Lavanderia
{
    private Lavatrice[] lavatriceArray;
    private Asciugatrice[] AsciugatriceArray;

    public Lavanderia()
    {
        lavatriceArray = new Lavatrice[5];
        AsciugatriceArray = new Asciugatrice[5]

        for (int i = 0; i < 5; i++)
        {
            lavatriceArray[i] = new Lavatrice("Lavatrice " + i, false, null, 1000, 500, 0);
        }

        for (int i = 0; i < 5; i++)
        {
            AsciugatriceArray[i] = new Asciugatrice("Asciugatrice " + i, false, null, 1000, 500, 0);
        }
    }
}

//LAVAGGIO
public class Lavaggio
{
    public string Tipo { get; set; }
    public int Costo { get; set; }
    public int Durata { get; set; }
    public int Detersivo { get; set; }
    public int Ammorbidente { get; set; }

    public Lavaggio(string tipo, int costo, int durata, int detersivo, int ammorbidente)
    {
        Tipo = tipo;
        Costo = costo;
        Durata = durata;
        Detersivo = detersivo;
        Ammorbidente = ammorbidente;
    }
}

//LAVATRICE
public class Lavatrice
{
   public string Nome { get; private set; }
   public bool Stato { get; set; }
   Lavaggio Programma { get; set; }
   public int Detersivo { get; set; }
   public int Ammorbidente { get; set; }
   public int Durataprogramma { get; set; }
   public double Incasso { get; set; }  

    public Lavatrice(string nome, bool stato, Lavaggio programma, int detersivo, int ammorbidente, int durataprogramma, double incasso )
    {
        nome = nome;
        stato = false;
        programma = programma;
        detersivo = detersivo;
        ammorbidente = ammorbidente;
        durataprogramma = durataprogramma;
        incasso = incasso;

        Lavaggio rinfrescante = new Lavaggio("rinfrescante", 2, 20, 20, 5);
        Lavaggio rinnovante = new Lavaggio("rinnovante", 3, 40, 40, 10);
        Lavaggio sgrassante = new Lavaggio("sgrassante", 4, 60, 60, 15);
    }
}

//ASCIUGATRICE
public class Asciugatrice
{
    public string Nome { get; set; }
    public bool Stato { get; set; }
    public Lavaggio Programma { get; set; }
    public int Durataprogramma { get; set; }
    public int Incasso { get; set; }

    public Asciugatrice(string nome, bool stato, Lavaggio programma, int durataprogramma, double incasso)
    {
        nome = nome;
        stato = false;
        programma = programma;
        durataprogramma = durataprogramma;
        incasso = incasso;
    }
    
    Lavaggio rapido = new Lavaggio("rapido", 2, 20, 0, 0);
    Lavaggio intenso = new Lavaggio("Intenso", 4, 20, 0, 0);
}

//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e
//quali non lo sono (in lavaggio / asciugatura oppure ferme)
public void StatoUtilizzo()
{
    Console.WriteLine("Stato Lavatrici");
    for (int i = 0; i < lavatriceArray.Length; i++)
    {
        if (LavatriceArray[i].Stato)
        {
            Console.WriteLine(LavatriceArray[i].Nome + " è in funzione");
        }
        else
        {
            Console.WriteLine(LavatriceArray[i].Nome + " non è in funzione");
        }
    }
    Console.WriteLine("Stato Asciugatrici")
    for (int i = 0; i < asciugatriceArray.Length; i++)
    {
        if (asciugatriceArray[i].Stato)
        {
            Console.WriteLine(asciugatriceArray[i].Nome + " è in funzione");
        }
        else
        {
            Console.WriteLine(asciugatriceArray[i].Nome + " non è in funzione");
        }
    }
}

//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario,
//stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio.

public void DettaglioMacchina()
{
    Console.WriteLine("Vuoi informazioni su lavatrice o asciugatrice?");

    int risposta = Convert.ToInt32(Console.ReadLine());

}