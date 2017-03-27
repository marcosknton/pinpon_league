using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pinpon_league
{
    public partial class Form1 : Form
    {
        private Liga LligaActual;

        public Form1()
        {
            InitializeComponent();
            LligaActual = new Liga("liga1");
            //insert("marcos","no ruta",0,0);
            //insert("lluis", "no ruta", 0, 0);
            //insertpartido("marcos", "lluis", 1, 21);

        }

      

        private async void insert(String nombre, String photopath, int puntos, int num_partidos)
        {
            var client = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = client.Child("jugadors");
            Jugador jugador = new Jugador(nombre, photopath,  puntos,  num_partidos);
            var p1 = await child.PostAsync(jugador);
            Console.WriteLine($"{p1.Key}");
            jugador.idJugador= p1.Key;
            LligaActual.NouJugador(jugador);
        }

        private async void insertpartido(String jugador1,String jugador2,int puntuacion1,int puntuacion2)
        {
            var client = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = client.Child("partidos");

            Partido partido = new Partido(jugador1,jugador2,puntuacion1,puntuacion2);
            partido.setGanador(partido.getGanador());
        
            var p1 = await child.PostAsync(partido);
            Console.WriteLine($"{p1.Key}");
            partido.IdPartido = p1.Key;

        }


        
        private void añadir_jugador_Click(object sender, EventArgs e)
        {
            String nombre = Tbnombre.Text;
            String partidos = Tbpartidos.Text;
            String fotopath = Tbfoto.Text;
            String puntos = Tbpuntos.Text;
            int ipuntos = Convert.ToInt32(puntos);
            int ipartidos = Convert.ToInt32(partidos);

            insert(nombre, fotopath, ipuntos, ipartidos);
        }

      
    }

}

    
   

