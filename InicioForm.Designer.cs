namespace ProyectoPokemon
{
    partial class InicioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            btnIrAForm1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIrAForm1
            // 
            btnIrAForm1.BackColor = Color.White;
            btnIrAForm1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnIrAForm1.Location = new Point(151, 162);
            btnIrAForm1.Name = "btnIrAForm1";
            btnIrAForm1.Size = new Size(151, 86);
            btnIrAForm1.TabIndex = 0;
            btnIrAForm1.Text = "Iniciar Juego";
            btnIrAForm1.UseVisualStyleBackColor = false;
            btnIrAForm1.Click += btnIrAForm1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(40, 107);
            label1.Name = "label1";
            label1.Size = new Size(445, 37);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos a la \"PokeDex\"";
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 517);
            Controls.Add(label1);
            Controls.Add(btnIrAForm1);
            Name = "InicioForm";
            Text = "InicioForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIrAForm1;
        private Label label1;
    }
}