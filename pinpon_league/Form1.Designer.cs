namespace pinpon_league
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Bcierre = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Lvjugadores = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points_player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.match_played = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foto_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Beliminar = new System.Windows.Forms.Button();
            this.añadir_jugador = new System.Windows.Forms.Button();
            this.Tbfoto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Tbpuntos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbpartidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbeliminar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbnombre = new System.Windows.Forms.TextBox();
            this.liga = new System.Windows.Forms.TabPage();
            this.Bmostrarpartidos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Lvpartidos = new System.Windows.Forms.ListView();
            this.jugador1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jugador2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puntuacion1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.puntuacion2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ganador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bmodificarres = new System.Windows.Forms.Button();
            this.Tbpuntuacion2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tbpuntuacion1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.liga.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.liga);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 660);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Bcierre);
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Lvjugadores);
            this.tabPage1.Controls.Add(this.Beliminar);
            this.tabPage1.Controls.Add(this.añadir_jugador);
            this.tabPage1.Controls.Add(this.Tbfoto);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Tbpuntos);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Tbpartidos);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Tbeliminar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Tbnombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1295, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "jugadores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Bcierre
            // 
            this.Bcierre.AutoSize = true;
            this.Bcierre.Location = new System.Drawing.Point(27, 351);
            this.Bcierre.Margin = new System.Windows.Forms.Padding(4);
            this.Bcierre.Name = "Bcierre";
            this.Bcierre.Size = new System.Drawing.Size(276, 32);
            this.Bcierre.TabIndex = 28;
            this.Bcierre.Text = "cerrar lista";
            this.Bcierre.UseVisualStyleBackColor = true;
            this.Bcierre.Click += new System.EventHandler(this.Bcierre_Click);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Location = new System.Drawing.Point(159, 295);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(144, 34);
            this.refresh.TabIndex = 21;
            this.refresh.Text = "cargar en lista";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(705, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "LISTA DE JUGADORES";
            // 
            // Lvjugadores
            // 
            this.Lvjugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.points_player,
            this.match_played,
            this.foto_path,
            this.columnHeader2});
            this.Lvjugadores.Location = new System.Drawing.Point(321, 49);
            this.Lvjugadores.Margin = new System.Windows.Forms.Padding(4);
            this.Lvjugadores.Name = "Lvjugadores";
            this.Lvjugadores.Size = new System.Drawing.Size(961, 542);
            this.Lvjugadores.TabIndex = 24;
            this.Lvjugadores.UseCompatibleStateImageBehavior = false;
            this.Lvjugadores.View = System.Windows.Forms.View.Details;
            this.Lvjugadores.SelectedIndexChanged += new System.EventHandler(this.Lvjugadores_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "nombre";
            this.name.Width = 146;
            // 
            // points_player
            // 
            this.points_player.Text = "puntos";
            this.points_player.Width = 148;
            // 
            // match_played
            // 
            this.match_played.Text = "partidos jugados";
            this.match_played.Width = 131;
            // 
            // foto_path
            // 
            this.foto_path.Text = "foto";
            this.foto_path.Width = 214;
            // 
            // Beliminar
            // 
            this.Beliminar.AutoSize = true;
            this.Beliminar.Location = new System.Drawing.Point(30, 558);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.Size = new System.Drawing.Size(276, 33);
            this.Beliminar.TabIndex = 22;
            this.Beliminar.Text = "eliminar jugador";
            this.Beliminar.UseVisualStyleBackColor = true;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // añadir_jugador
            // 
            this.añadir_jugador.AutoSize = true;
            this.añadir_jugador.Location = new System.Drawing.Point(27, 295);
            this.añadir_jugador.Margin = new System.Windows.Forms.Padding(4);
            this.añadir_jugador.Name = "añadir_jugador";
            this.añadir_jugador.Size = new System.Drawing.Size(124, 34);
            this.añadir_jugador.TabIndex = 21;
            this.añadir_jugador.Text = "crear  jugador";
            this.añadir_jugador.UseVisualStyleBackColor = true;
            this.añadir_jugador.Click += new System.EventHandler(this.añadir_jugador_Click);
            // 
            // Tbfoto
            // 
            this.Tbfoto.Location = new System.Drawing.Point(159, 236);
            this.Tbfoto.Margin = new System.Windows.Forms.Padding(4);
            this.Tbfoto.Name = "Tbfoto";
            this.Tbfoto.Size = new System.Drawing.Size(144, 22);
            this.Tbfoto.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 239);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "foto";
            // 
            // Tbpuntos
            // 
            this.Tbpuntos.Location = new System.Drawing.Point(159, 181);
            this.Tbpuntos.Margin = new System.Windows.Forms.Padding(4);
            this.Tbpuntos.Name = "Tbpuntos";
            this.Tbpuntos.Size = new System.Drawing.Size(144, 22);
            this.Tbpuntos.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "puntos";
            // 
            // Tbpartidos
            // 
            this.Tbpartidos.Location = new System.Drawing.Point(159, 136);
            this.Tbpartidos.Margin = new System.Windows.Forms.Padding(4);
            this.Tbpartidos.Name = "Tbpartidos";
            this.Tbpartidos.Size = new System.Drawing.Size(144, 22);
            this.Tbpartidos.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "cantidad partidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "nombre";
            // 
            // Tbeliminar
            // 
            this.Tbeliminar.Location = new System.Drawing.Point(159, 509);
            this.Tbeliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Tbeliminar.Name = "Tbeliminar";
            this.Tbeliminar.Size = new System.Drawing.Size(144, 22);
            this.Tbeliminar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = " ELIMINAR JUGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AÑADIR JUGADOR";
            // 
            // Tbnombre
            // 
            this.Tbnombre.AccessibleName = "Tbnombre";
            this.Tbnombre.Location = new System.Drawing.Point(159, 85);
            this.Tbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.Tbnombre.Name = "Tbnombre";
            this.Tbnombre.Size = new System.Drawing.Size(144, 22);
            this.Tbnombre.TabIndex = 0;
            // 
            // liga
            // 
            this.liga.Controls.Add(this.Bmostrarpartidos);
            this.liga.Controls.Add(this.label9);
            this.liga.Controls.Add(this.Lvpartidos);
            this.liga.Controls.Add(this.Bmodificarres);
            this.liga.Controls.Add(this.Tbpuntuacion2);
            this.liga.Controls.Add(this.label7);
            this.liga.Controls.Add(this.Tbpuntuacion1);
            this.liga.Controls.Add(this.label6);
            this.liga.Controls.Add(this.label5);
            this.liga.Location = new System.Drawing.Point(4, 25);
            this.liga.Margin = new System.Windows.Forms.Padding(4);
            this.liga.Name = "liga";
            this.liga.Padding = new System.Windows.Forms.Padding(4);
            this.liga.Size = new System.Drawing.Size(1295, 631);
            this.liga.TabIndex = 1;
            this.liga.Text = "liga";
            this.liga.UseVisualStyleBackColor = true;
            // 
            // Bmostrarpartidos
            // 
            this.Bmostrarpartidos.AutoSize = true;
            this.Bmostrarpartidos.Location = new System.Drawing.Point(17, 105);
            this.Bmostrarpartidos.Margin = new System.Windows.Forms.Padding(4);
            this.Bmostrarpartidos.Name = "Bmostrarpartidos";
            this.Bmostrarpartidos.Size = new System.Drawing.Size(275, 32);
            this.Bmostrarpartidos.TabIndex = 28;
            this.Bmostrarpartidos.Text = "mostrar partidos";
            this.Bmostrarpartidos.UseVisualStyleBackColor = true;
            this.Bmostrarpartidos.Click += new System.EventHandler(this.Bmostrarpartidos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "LISTA DE RESULTADOS";
            // 
            // Lvpartidos
            // 
            this.Lvpartidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jugador1,
            this.jugador2,
            this.puntuacion1,
            this.puntuacion2,
            this.ganador,
            this.columnHeader1});
            this.Lvpartidos.Location = new System.Drawing.Point(312, 44);
            this.Lvpartidos.Name = "Lvpartidos";
            this.Lvpartidos.Size = new System.Drawing.Size(937, 540);
            this.Lvpartidos.TabIndex = 25;
            this.Lvpartidos.UseCompatibleStateImageBehavior = false;
            this.Lvpartidos.View = System.Windows.Forms.View.Details;
            this.Lvpartidos.SelectedIndexChanged += new System.EventHandler(this.Lvpartidos_SelectedIndexChanged);
            // 
            // jugador1
            // 
            this.jugador1.Text = "jugador1";
            this.jugador1.Width = 130;
            // 
            // jugador2
            // 
            this.jugador2.Text = "jugador2";
            this.jugador2.Width = 136;
            // 
            // puntuacion1
            // 
            this.puntuacion1.Text = "puntuación jugador1";
            this.puntuacion1.Width = 179;
            // 
            // puntuacion2
            // 
            this.puntuacion2.Text = "puntuación jugador2";
            this.puntuacion2.Width = 167;
            // 
            // ganador
            // 
            this.ganador.Text = "GANADOR";
            this.ganador.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // Bmodificarres
            // 
            this.Bmodificarres.AutoSize = true;
            this.Bmodificarres.Location = new System.Drawing.Point(17, 379);
            this.Bmodificarres.Margin = new System.Windows.Forms.Padding(4);
            this.Bmodificarres.Name = "Bmodificarres";
            this.Bmodificarres.Size = new System.Drawing.Size(275, 33);
            this.Bmodificarres.TabIndex = 24;
            this.Bmodificarres.Text = "modificar resultado";
            this.Bmodificarres.UseVisualStyleBackColor = true;
            this.Bmodificarres.Click += new System.EventHandler(this.Bmodificarres_Click);
            // 
            // Tbpuntuacion2
            // 
            this.Tbpuntuacion2.Location = new System.Drawing.Point(160, 284);
            this.Tbpuntuacion2.Margin = new System.Windows.Forms.Padding(4);
            this.Tbpuntuacion2.Name = "Tbpuntuacion2";
            this.Tbpuntuacion2.Size = new System.Drawing.Size(132, 22);
            this.Tbpuntuacion2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "puntuación jugador2";
            // 
            // Tbpuntuacion1
            // 
            this.Tbpuntuacion1.Location = new System.Drawing.Point(160, 218);
            this.Tbpuntuacion1.Margin = new System.Windows.Forms.Padding(4);
            this.Tbpuntuacion1.Name = "Tbpuntuacion1";
            this.Tbpuntuacion1.Size = new System.Drawing.Size(132, 22);
            this.Tbpuntuacion1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "puntuación jugador1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULTADOS";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 678);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "dxdd";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.liga.ResumeLayout(false);
            this.liga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage liga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbeliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbfoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tbpuntos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbpartidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Beliminar;
        private System.Windows.Forms.Button añadir_jugador;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView Lvjugadores;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader points_player;
        private System.Windows.Forms.ColumnHeader match_played;
        private System.Windows.Forms.ColumnHeader foto_path;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox Tbpuntuacion2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbpuntuacion1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bmodificarres;
        private System.Windows.Forms.ListView Lvpartidos;
        private System.Windows.Forms.ColumnHeader jugador1;
        private System.Windows.Forms.ColumnHeader jugador2;
        private System.Windows.Forms.ColumnHeader puntuacion1;
        private System.Windows.Forms.ColumnHeader puntuacion2;
        private System.Windows.Forms.ColumnHeader ganador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Bmostrarpartidos;
        private System.Windows.Forms.Button Bcierre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

