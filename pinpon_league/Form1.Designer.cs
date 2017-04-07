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
            this.refresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Lvjugadores = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points_player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.match_played = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foto_path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.añadir_jugador = new System.Windows.Forms.Button();
            this.Tbfoto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Tbpuntos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbpartidos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbnombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 660);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.Lvjugadores);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.añadir_jugador);
            this.tabPage1.Controls.Add(this.Tbfoto);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.Tbpuntos);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Tbpartidos);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Tbnombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1295, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "jugadores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Location = new System.Drawing.Point(182, 217);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(108, 34);
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
            this.foto_path});
            this.Lvjugadores.Location = new System.Drawing.Point(321, 49);
            this.Lvjugadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lvjugadores.Name = "Lvjugadores";
            this.Lvjugadores.Size = new System.Drawing.Size(961, 542);
            this.Lvjugadores.TabIndex = 24;
            this.Lvjugadores.UseCompatibleStateImageBehavior = false;
            this.Lvjugadores.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "nombre";
            this.name.Width = 221;
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
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(17, 592);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 33);
            this.button3.TabIndex = 23;
            this.button3.Text = "modificar jugador";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(27, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 33);
            this.button2.TabIndex = 22;
            this.button2.Text = "eliminar jugador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // añadir_jugador
            // 
            this.añadir_jugador.AutoSize = true;
            this.añadir_jugador.Location = new System.Drawing.Point(27, 217);
            this.añadir_jugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.añadir_jugador.Name = "añadir_jugador";
            this.añadir_jugador.Size = new System.Drawing.Size(107, 34);
            this.añadir_jugador.TabIndex = 21;
            this.añadir_jugador.Text = "crear  jugador";
            this.añadir_jugador.UseVisualStyleBackColor = true;
            this.añadir_jugador.Click += new System.EventHandler(this.añadir_jugador_Click);
            // 
            // Tbfoto
            // 
            this.Tbfoto.Location = new System.Drawing.Point(152, 167);
            this.Tbfoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbfoto.Name = "Tbfoto";
            this.Tbfoto.Size = new System.Drawing.Size(132, 22);
            this.Tbfoto.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "foto";
            // 
            // Tbpuntos
            // 
            this.Tbpuntos.Location = new System.Drawing.Point(152, 122);
            this.Tbpuntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbpuntos.Name = "Tbpuntos";
            this.Tbpuntos.Size = new System.Drawing.Size(132, 22);
            this.Tbpuntos.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "puntos";
            // 
            // Tbpartidos
            // 
            this.Tbpartidos.Location = new System.Drawing.Point(152, 85);
            this.Tbpartidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbpartidos.Name = "Tbpartidos";
            this.Tbpartidos.Size = new System.Drawing.Size(132, 22);
            this.Tbpartidos.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "cantidad partidos";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 550);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 554);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "puntos";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(152, 503);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 507);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "cantidad partidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 459);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "MODIFICAR";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(152, 459);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 311);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = " ELIMINAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AÑADIR JUGADOR";
            // 
            // Tbnombre
            // 
            this.Tbnombre.AccessibleName = "Tbnombre";
            this.Tbnombre.Location = new System.Drawing.Point(152, 46);
            this.Tbnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbnombre.Name = "Tbnombre";
            this.Tbnombre.Size = new System.Drawing.Size(132, 22);
            this.Tbnombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1295, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 678);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "dxdd";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Tbfoto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tbpuntos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbpartidos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button añadir_jugador;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView Lvjugadores;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader points_player;
        private System.Windows.Forms.ColumnHeader match_played;
        private System.Windows.Forms.ColumnHeader foto_path;
        private System.Windows.Forms.Button refresh;
    }
}

