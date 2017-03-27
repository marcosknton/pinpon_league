using System;

public class Jugador
{

    public String Nombre { get; set; }
    public String Photopath { get; set; }
    public String idJugador { get; set; }
    public int Puntos { get; set; }
    public int Num_partidos {get;set;}


    public Jugador(String nombre,String photopath,int puntos,int num_partidos)
    {
        Nombre = nombre;
        Photopath = photopath;
        Puntos = puntos;
        Num_partidos = num_partidos;
    }
    
}
