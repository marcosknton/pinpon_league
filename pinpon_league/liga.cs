using System;
using System.Collections.Generic;

public class Liga
{
    private String nombre_;
    private List<Jugador> Jugadors;

    public int getnombre { get; }

    public Liga(String nombre)
	{
        nombre_ = nombre;
        Jugadors = new List<Jugador>();
    }

    public void NouJugador(Jugador jugador)
    {
        Jugadors.Add(jugador);
    }

    public Jugador getJugador(int i)
    {
        if (i < Jugadors.Count)
            return Jugadors[i];
        else
            return null;
    }

    public void delJugador(int i)
    {
        if (i < Jugadors.Count)
            Jugadors.RemoveAt(i);
    }
}
