using System;
using System.Collections.Generic;

public class Liga
{
    private String nombre_;
    private List<Jugador> Jugadors;
    private List<Partido> Partidos;

    public int getnombre { get; }

    public Liga(String nombre)
	{
        nombre_ = nombre;
        Jugadors = new List<Jugador>();
        Partidos = new List<Partido>();
    }

    public void NouJugador(Jugador jugador)
    {
        Jugadors.Add(jugador);
    }

    public void NouPartit(Partido partido)
    {
        Partidos.Add(partido);
    }

    public Partido getPartido(int i)
    {
        if (i < Partidos.Count)
            return Partidos[i];
        else
            return null;
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

    public List<Jugador> lista()
    {
        return this.Jugadors;
    }

    public List<Partido> listapartidos()
    {
        return this.Partidos;
    }
}
