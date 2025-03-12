//chi vince a carte: 3 carte a giocatore e 4 semi diversi (coppe, denari, spade, bastoni) 
// l'asso 11 il tre 10 punti; il re ne vale 4, la donna (o cavallo) 3, il fante 2, le altre carte non hanno valore.
//briscola (che è un seme definito a inizio partita) ha la priorità e quella piu alta si prende la mano
//se non è stata giocata la briscola , vince la carta più alta del seme giocato per primo
//fare un enum con il seme delle carte
//fare tre domande all'operatore: quale è la briscola (e risponde con seme e numero)
//giocata del primo giocatore (seme e numero), giocata del secondo giocatore (seme e numero)
//stampare chi ha vinto la mano
Console.WriteLine("Quale è la briscola?");
Seme briscola = Enum.Parse<Seme>(Console.ReadLine());
Console.WriteLine("Quanto vale la briscola?");
int valoreBriscola = int.Parse(Console.ReadLine());

//prima giocata
Console.WriteLine("inserisci il punteggio della prima giocata (digitare 8 per il fante; 9 per la donna; 10 per il re)");
int punteggio1 = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il seme della carta giocata");
Seme seme1 = Enum.Parse<Seme>(Console.ReadLine());

//caso in cui la carta giocata è uguale alla briscola
while (punteggio1 == valoreBriscola && seme1 == briscola)
{
    Console.WriteLine("ATTENZIONE:la carta giocata non può essere uguale alla briscola");
    Console.WriteLine("inserisci il punteggio della prima giocata (digitare 8 per il fante; 9 per la donna; 10 per il re)");
    punteggio1 = int.Parse(Console.ReadLine());
    Console.WriteLine("inserisci il seme della carta giocata");
    seme1 = Enum.Parse<Seme>(Console.ReadLine());
}

//seconda giocata
Console.WriteLine("inserisci il punteggio della seconda giocata (digitare 8 per il fante; 9 per la donna; 10 per il re)");
int punteggio2 = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il seme della seconda carta giocata");
Seme seme2 = Enum.Parse<Seme>(Console.ReadLine());

    //caso in cui la carta giocata è uguale alla briscola

        while (punteggio2 == valoreBriscola && seme2 == briscola)
    {
        Console.WriteLine("ATTENZIONE:la carta giocata non può essere uguale alla briscola");
        Console.WriteLine("inserisci il punteggio della seconda giocata (digitare 8 per il fante; 9 per la donna; 10 per il re)");
        punteggio2 = int.Parse(Console.ReadLine());
        Console.WriteLine("inserisci il seme della seconda carta giocata");
        seme2 = Enum.Parse<Seme>(Console.ReadLine());
    }

        //caso in cui la seconda carta è uguale alla prima

            while (punteggio2 == punteggio1 && seme2 == seme1)
            {
                Console.WriteLine("ATTENZIONE:la seconda carta giocata non può essere uguale alla prima carta giocata");
                Console.WriteLine("inserisci il punteggio della seconda giocata (digitare 8 per il fante; 9 per la donna; 10 per il re)");
                punteggio2 = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci il seme della seconda carta giocata");
                seme2 = Enum.Parse<Seme>(Console.ReadLine());
            }


//conversione punteggio in valore punteggio 1
if (punteggio1 == 8)
{
    punteggio1 = 2;
}
else if (punteggio1 == 9)
{
    punteggio1 = 3;
}
else if (punteggio1 == 10)
{
    punteggio1 = 4;
}
else if (punteggio1 == 1)
{
    punteggio1 = 11;
}
else if (punteggio1 == 3)
{
    punteggio1 = 10;
}

//conversione punteggio in valore punteggio 2
if (punteggio2 == 8)
{
    punteggio2 = 2;
}
else if (punteggio2 == 9)
{
    punteggio2 = 3;
}
else if (punteggio2 == 10)
{
    punteggio2 = 4;
}
else if (punteggio2 == 1)
{
    punteggio2 = 11;
}
else if (punteggio2 == 3)
{
    punteggio2 = 10;
}

//chi ha vinto la mano


// caso in cui entrambi sono briscole
if (seme1 == briscola && seme2 == briscola)
{
    if (punteggio1 > punteggio2)
    {
        Console.WriteLine("ha vinto il primo giocatore");
    }
    else
    {
        Console.WriteLine("ha vinto il secondo giocatore");
    }

}

// caso in cui uno dei due è briscola
else if (seme1 == briscola && seme2 != briscola)
{
    Console.WriteLine("ha vinto il primo giocatore");
}
else if (seme1 != briscola && seme2 == briscola)
{
    Console.WriteLine("ha vinto il secondo giocatore");
}

// caso in cui entrambi non sono briscole
else if (seme1 != briscola && seme2 != briscola)
{
    briscola = seme1;

    if (seme1 == briscola && seme2 == briscola)
    {
        if (punteggio1 > punteggio2)
        {
            Console.WriteLine("ha vinto il primo giocatore");
        }
        else
        {

            Console.WriteLine("ha vinto il secondo giocatore");
        }
    }
    else if (seme1 == briscola && seme2 != briscola)
    {
        Console.WriteLine("ha vinto il primo giocatore");
    }
    else if (seme1 != briscola && seme2 == briscola)
    {
        Console.WriteLine("ha vinto il secondo giocatore");
    }

}

enum Seme
{
    Coppe,
    Denari,
    Spade,
    Bastoni,
}