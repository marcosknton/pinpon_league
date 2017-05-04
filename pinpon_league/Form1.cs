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
        private int index;
        private int indexmatch;
        private string idpartido;
        

        public Form1()
        {
            InitializeComponent();
            LligaActual = new Liga("liga1");
            LligaActual.lista().Clear();
            LligaActual.listapartidos().Clear();
            eliminarjugadores();
            eliminarpartidos();

            //MessageBox.Show(LligaActual.lista().Count.ToString());
            //obtener_jugador();


        }



        private async void insert(String nombre, String photopath, int puntos, int num_partidos)
        {
            var client = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = client.Child("jugadors");
            Jugador jugador = new Jugador(nombre, photopath,  puntos,  num_partidos);
            var p1 = await child.PostAsync(jugador);
            Console.WriteLine($"{p1.Key}");
            jugador.idJugador= p1.Key;
            
           // MessageBox.Show(jugador.idJugador);
            LligaActual.NouJugador(jugador);
        }

        private async void insertpartido(String njugador1, String njugador2, String idjugador1, String idjugador2, int puntuacion1, int puntuacion2)
        {
            var client = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = client.Child("partidos");

            Partido partido = new Partido(njugador1,njugador2,idjugador1,idjugador2,puntuacion1,puntuacion2);
            //partido.setGanador(partido.getGanador());
        
            var p1 = await child.PostAsync(partido);
            Console.WriteLine($"{p1.Key}");
            partido.IdPartido = p1.Key;
            LligaActual.NouPartit(partido);

        }

        private async Task obtener_jugador()

        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.idJugador = p1.Key;
               

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
                    lvi.SubItems.Add(p1.Object.idJugador);
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
            int cuenta = 0;
            int ipuntos = Convert.ToInt32(puntos);
            int ipartidos = Convert.ToInt32(partidos);

            insert(nombre, fotopath, ipuntos, ipartidos);
            obtener_jugador();
            //MessageBox.Show(LligaActual.lista().Count.ToString());
            MessageBox.Show("jugador creado pulse cargar para visualizarlo en la lista");
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            obtener_jugador();

           
        }

      //cuando seleccionamos un jugador en el listview carga datos en el campo eliminar 
        private void Lvjugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Lvjugadores.SelectedItems.Count > 0)
            {
                index = this.Lvjugadores.SelectedIndices[0];
                string nombre = Lvjugadores.Items[index].SubItems[0].Text;
                string puntos = Lvjugadores.Items[index].SubItems[1].Text;
                string partidos= Lvjugadores.Items[index].SubItems[2].Text;
                Tbeliminar.Text = nombre;
                //MessageBox.Show(Convert.ToString(index));
                
            }

            
        }

        private async void Beliminar_Click(object sender, EventArgs e)
        {
            if (Lvjugadores.Items.Count > 0)
            {
                Lvjugadores.Items.Remove(Lvjugadores.SelectedItems[0]);
                Tbeliminar.Text = " ";
                var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
                var child = firebase.Child("jugadors/" + LligaActual.getJugador(index).idJugador);
                await child.DeleteAsync();
                LligaActual.delJugador(index);
            }
        }

        private void logicaLiga()
        {
            int total = LligaActual.lista().Count;
            int lastplayer = 0;
            //MessageBox.Show(total.ToString());
            for (int pos=0; pos<total; pos++)
            {
                for (lastplayer = pos; lastplayer < total; lastplayer++)
                {
                    if (LligaActual.getJugador(pos) != LligaActual.getJugador(lastplayer)) {
                        insertpartido(LligaActual.getJugador(pos).Nombre, LligaActual.getJugador(lastplayer).Nombre,LligaActual.getJugador(pos).idJugador, LligaActual.getJugador(lastplayer).idJugador, 0, 0);

                    }
                }
            }
            
        }

       

        private async Task obtener_partidos()

        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var partidos = await firebase.Child("partidos").OnceAsync<Partido>();

            foreach (var p1 in partidos)
            {
                p1.Object.IdPartido = p1.Key;
              
                
                string jugador1 = p1.Object.Njugador1;
                string jugador2 = p1.Object.Njugador2;
                string puntos1 = p1.Object.Puntuacion1.ToString();
                string puntos2 = p1.Object.Puntuacion2.ToString();


                //creamos un objeto listviewitem con el nombre del jugador(sera el valor)
                ListViewItem lvip = new ListViewItem(jugador1);
                //le asignamos una clave que sera el id
                lvip.Name = p1.Object.IdPartido;
                //si en la lista no existe un partido con la misma clave lo muestra en el listview
                if (!Lvpartidos.Items.ContainsKey(lvip.Name))
                {
                    
                    lvip.SubItems.Add(jugador2);
                    lvip.SubItems.Add(puntos1);
                    lvip.SubItems.Add(puntos2);
                    lvip.SubItems.Add("");
                    lvip.SubItems.Add(p1.Object.IdPartido);
                    Lvpartidos.Items.Add(lvip);
                }
            }
        }



        private void Lvpartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lvpartidos.SelectedItems.Count > 0)
            {
                indexmatch = this.Lvpartidos.SelectedIndices[0];
                string puntuacion1 = Lvpartidos.Items[indexmatch].SubItems[2].Text;
                string puntuacion2 = Lvpartidos.Items[indexmatch].SubItems[3].Text;
                idpartido= Lvpartidos.Items[indexmatch].SubItems[5].Text;
                

                Tbpuntuacion1.Text = puntuacion1;
                Tbpuntuacion2.Text = puntuacion2;
                //MessageBox.Show(Convert.ToString(index));

            }
        }

        private void Bcierre_Click(object sender, EventArgs e)
        {
            logicaLiga();
            MessageBox.Show("partidos organizados pulse  mostrar partidos en la pestaña liga para visualizarlos en la lista");
            //MessageBox.Show(LligaActual.lista().Count.ToString());
        }

        private void Bmostrarpartidos_Click(object sender, EventArgs e)
        {
            obtener_partidos();
        }

        private async void Bmodificarres_Click(object sender, EventArgs e)
        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var partidos = firebase.Child("partidos/" + idpartido);

           // MessageBox.Show(indexmatch.ToString());
            //MessageBox.Show(LligaActual.getPartido(indexmatch).IdPartido);

            for (int pos = 0; pos < LligaActual.listapartidos().Count; pos++)
            {
                if (LligaActual.listapartidos()[pos].IdPartido.Equals(idpartido))
                {

                    int ipuntos1 = Convert.ToInt32(Tbpuntuacion1.Text);
                    int ipuntos2 = Convert.ToInt32(Tbpuntuacion2.Text);
                    String id1 = LligaActual.listapartidos()[pos].Idjugador1;
                    String id2 = LligaActual.listapartidos()[pos].Idjugador2;
                    
                    //la modificación en el campo se verá reflejada en la lista
                    Lvpartidos.Items[indexmatch].SubItems[2].Text = Tbpuntuacion1.Text;
                    //actualizamos los puntos del jugador1 en el objeto partido, guardado en la lista de partidos
                    LligaActual.listapartidos()[pos].Puntuacion1 = ipuntos1;
                    Lvpartidos.Items[indexmatch].SubItems[3].Text = Tbpuntuacion2.Text;
                    LligaActual.listapartidos()[pos].Puntuacion2 = ipuntos2;
                    String id = LligaActual.listapartidos()[pos].getGanador();


                    await partidos.PutAsync(LligaActual.getPartido(pos));


               
                    for (int posi = 0; posi < LligaActual.lista().Count; posi++)
                    {
                        if (id.Equals(LligaActual.lista()[posi].idJugador))
                        {
                           // MessageBox.Show(LligaActual.lista()[posi].idJugador);
                            //MessageBox.Show(id);
                            sumapuntos(firebase, posi);
                        }
                        if (id1.Equals(LligaActual.lista()[posi].idJugador))
                        {
                            sumapartidos(firebase, posi);
                        }
                        if (id2.Equals(LligaActual.lista()[posi].idJugador))
                        {
                            sumapartidos(firebase, posi);
                        }

                    }
                    obtener_jugador();
                }
            }
           
        }
        private async void sumapartidos(FirebaseClient firebase,int pos)
        {
            LligaActual.getJugador(pos).Num_partidos++;
            var child1 = firebase.Child("jugadors/" + LligaActual.getJugador(pos).idJugador);
            await child1.PutAsync(LligaActual.getJugador(pos));
            for (int i = 0; i < Lvjugadores.Items.Count; i++)
            {
                if (Lvjugadores.Items[i].SubItems[4].Text.Equals(LligaActual.getJugador(pos).idJugador))
                    Lvjugadores.Items[i].SubItems[2].Text = LligaActual.getJugador(pos).Num_partidos.ToString();
            }
        }

        private async void sumapuntos(FirebaseClient firebase, int pos)
        {
            LligaActual.getJugador(pos).Puntos = LligaActual.getJugador(pos).Puntos + 3;
            var child2 = firebase.Child("jugadors/" + LligaActual.getJugador(pos).idJugador);
            await child2.PutAsync(LligaActual.getJugador(pos));
            for (int i = 0; i < Lvjugadores.Items.Count; i++)
            {
                if (Lvjugadores.Items[i].SubItems[4].Text.Equals(LligaActual.getJugador(pos).idJugador))
                    Lvjugadores.Items[i].SubItems[1].Text = LligaActual.getJugador(pos).Puntos.ToString();
            }
        }

       

        private async void eliminarpartidos()
        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = firebase.Child("partidos");
            await child.DeleteAsync();
        }

        private async void eliminarjugadores()
        {
            var firebase = new FirebaseClient("https://fir-e4e11.firebaseio.com/");
            var child = firebase.Child("jugadors");
            await child.DeleteAsync();
        }

       
    }
   
}

    
   

