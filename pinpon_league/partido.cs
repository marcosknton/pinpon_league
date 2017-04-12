using Newtonsoft.Json;
using System;


public class Partido
{
    [JsonIgnore]
    public String IdPartido { get; set; }
    public String Idjugador1 { get; set; }
    public String Njugador1 { get; set; }
    public String Idjugador2 { get; set; }
    public String Njugador2 { get; set; }
    public int Puntuacion1 { get; set; }
    public int Puntuacion2 { get; set; }
    public String Ganador;



    public Partido(String njugador1,String njugador2,String idjugador1,String idjugador2,int puntuacion1,int puntuacion2)
	{
        Idjugador1 = idjugador1;
        Idjugador2 = idjugador2;
        Puntuacion1= puntuacion1;
        Puntuacion2 = puntuacion2;
        Njugador1 = njugador1;
        Njugador2 = njugador2;
    }

    public String getGanador()
    {
        if (Puntuacion1 > Puntuacion2)
        {
            return Idjugador1;
        }
        else
        {
            return Idjugador2;
        }
    }

    public String setGanador(String ganador)
    {
        return Ganador = ganador;
    }
}
