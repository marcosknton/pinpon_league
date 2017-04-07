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
            obtener_jugador();
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

        private async Task obtener_jugador()

        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.idJugador = p1.Key;
                LligaActual.NouJugador(p1.Object);

                string puntos = p1.Object.Puntos.ToString();
                string partidos = p1.Object.Num_partidos.ToString();

                //creamos un objeto listviewitem con el nombre del jugador(sera el valor)
                ListViewItem lvi = new ListViewItem(p1.Object.Nombre);
                //le asignamos una clave que sera el id
                lvi.Name = p1.Object.idJugador;
                //si en la lista no existe un jugador con la misma clave lo muestra en el listview
                if (!Lvjugadores.Items.ContainsKey(lvi.Name))
                {
                    lvi.SubItems.Add(puntos);
                    lvi.SubItems.Add(partidos);
                    lvi.SubItems.Add(p1.Object.Photopath);
                    Lvjugadores.Items.Add(lvi);
                }
            }
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
            obtener_jugador();
            MessageBox.Show("jugador creado pulse cargar para visualizarlo en la lista");
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            //Lvjugadores.Clear();
            obtener_jugador();

         
        }

    }

}

    
   

