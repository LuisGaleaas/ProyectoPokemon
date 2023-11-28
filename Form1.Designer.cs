namespace ProyectoPokemon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtPokemon = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Habilidades = new DataGridViewTextBoxColumn();
            Rareza = new DataGridViewTextBoxColumn();
            btInsertar = new Button();
            txtNombre = new TextBox();
            txtHabilidades = new TextBox();
            txtRareza = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtbuscar = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            pictureBox5 = new PictureBox();
            btIntercambio = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            dtMazo2 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dtMazo1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtPokemon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtMazo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtMazo1).BeginInit();
            SuspendLayout();
            // 
            // dtPokemon
            // 
            dtPokemon.AllowUserToAddRows = false;
            dtPokemon.AllowUserToDeleteRows = false;
            dtPokemon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtPokemon.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Tipo, Habilidades, Rareza });
            dtPokemon.Location = new Point(18, 75);
            dtPokemon.Name = "dtPokemon";
            dtPokemon.ReadOnly = true;
            dtPokemon.RowTemplate.Height = 25;
            dtPokemon.Size = new Size(546, 233);
            dtPokemon.TabIndex = 0;
            dtPokemon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Habilidades
            // 
            Habilidades.HeaderText = "Habilidades";
            Habilidades.Name = "Habilidades";
            Habilidades.ReadOnly = true;
            // 
            // Rareza
            // 
            Rareza.HeaderText = "Rareza";
            Rareza.Name = "Rareza";
            Rareza.ReadOnly = true;
            // 
            // btInsertar
            // 
            btInsertar.BackColor = Color.WhiteSmoke;
            btInsertar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btInsertar.Location = new Point(428, 80);
            btInsertar.Name = "btInsertar";
            btInsertar.Size = new Size(136, 53);
            btInsertar.TabIndex = 1;
            btInsertar.Text = "Agregar";
            btInsertar.UseVisualStyleBackColor = false;
            btInsertar.Click += btInsertar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 25);
            txtNombre.TabIndex = 2;
            // 
            // txtHabilidades
            // 
            txtHabilidades.Location = new Point(202, 123);
            txtHabilidades.Name = "txtHabilidades";
            txtHabilidades.Size = new Size(188, 25);
            txtHabilidades.TabIndex = 4;
            // 
            // txtRareza
            // 
            txtRareza.Location = new Point(202, 163);
            txtRareza.Name = "txtRareza";
            txtRareza.Size = new Size(188, 25);
            txtRareza.TabIndex = 5;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(202, 85);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(188, 25);
            txtTipo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(69, 52);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(69, 90);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(69, 128);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Habilidades";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(69, 168);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Rareza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 38);
            label5.Name = "label5";
            label5.Size = new Size(161, 17);
            label5.TabIndex = 11;
            label5.Text = "Buscar por Nombre o Tipo";
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(229, 34);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(335, 25);
            txtbuscar.TabIndex = 12;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(18, 338);
            button1.Name = "button1";
            button1.Size = new Size(164, 33);
            button1.TabIndex = 13;
            button1.Text = "Eliminar Seleccionados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(203, 338);
            button2.Name = "button2";
            button2.Size = new Size(157, 33);
            button2.TabIndex = 14;
            button2.Text = "Enviar a mazo 1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(404, 338);
            button3.Name = "button3";
            button3.Size = new Size(160, 33);
            button3.TabIndex = 15;
            button3.Text = "Enviar a mazo 2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(btInsertar);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtRareza);
            groupBox2.Controls.Add(txtTipo);
            groupBox2.Controls.Add(txtHabilidades);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 228);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear Nueva Carta";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Pokebola_pokeball_png_0;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(18, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 25);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Pokebola_pokeball_png_0;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(18, 123);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Pokebola_pokeball_png_0;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(18, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 25);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Pokebola_pokeball_png_0;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(18, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 25);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(pictureBox5);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(dtPokemon);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtbuscar);
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 282);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 377);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Busqueda y otras acciones";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.Pokebola_pokeball_png_0;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(18, 33);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 25);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // btIntercambio
            // 
            btIntercambio.BackColor = SystemColors.ControlLightLight;
            btIntercambio.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btIntercambio.Location = new Point(651, 123);
            btIntercambio.Name = "btIntercambio";
            btIntercambio.Size = new Size(129, 65);
            btIntercambio.TabIndex = 20;
            btIntercambio.Text = "Intercambios de cartas\r\n\r\n";
            btIntercambio.UseVisualStyleBackColor = false;
            btIntercambio.Click += btIntercambio_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtMazo2);
            groupBox1.Controls.Add(dtMazo1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(795, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 645);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mazos personalizados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 307);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 5;
            label7.Text = "Mazo 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(25, 21);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 4;
            label6.Text = "Mazo 1";
            label6.Click += label6_Click;
            // 
            // dtMazo2
            // 
            dtMazo2.AllowUserToAddRows = false;
            dtMazo2.AllowUserToDeleteRows = false;
            dtMazo2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMazo2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dtMazo2.Location = new Point(25, 334);
            dtMazo2.Name = "dtMazo2";
            dtMazo2.ReadOnly = true;
            dtMazo2.RowTemplate.Height = 25;
            dtMazo2.Size = new Size(546, 233);
            dtMazo2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Id";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Tipo";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Habilidades";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Rareza";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dtMazo1
            // 
            dtMazo1.AllowUserToAddRows = false;
            dtMazo1.AllowUserToDeleteRows = false;
            dtMazo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtMazo1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dtMazo1.Location = new Point(25, 49);
            dtMazo1.Name = "dtMazo1";
            dtMazo1.ReadOnly = true;
            dtMazo1.RowTemplate.Height = 25;
            dtMazo1.Size = new Size(546, 233);
            dtMazo1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Habilidades";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Rareza";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(651, 315);
            button4.Name = "button4";
            button4.Size = new Size(129, 67);
            button4.TabIndex = 22;
            button4.Text = "Regresar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._383749;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 699);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(btIntercambio);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtPokemon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtMazo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtMazo1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtPokemon;
        private Button btInsertar;
        private TextBox txtNombre;
        private TextBox txtHabilidades;
        private TextBox txtRareza;
        private TextBox txtTipo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Habilidades;
        private DataGridViewTextBoxColumn Rareza;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtbuscar;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button btIntercambio;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private DataGridView dtMazo2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridView dtMazo1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button button4;
    }
}