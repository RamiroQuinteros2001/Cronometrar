
namespace Cronometrar
{
    partial class Cronometro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometro));
            this.Pausar = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.pantalla = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pausar
            // 
            resources.ApplyResources(this.Pausar, "Pausar");
            this.Pausar.Name = "Pausar";
            this.Pausar.UseVisualStyleBackColor = true;
            this.Pausar.Click += new System.EventHandler(this.Pausar_Click);
            // 
            // Reiniciar
            // 
            resources.ApplyResources(this.Reiniciar, "Reiniciar");
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Iniciar
            // 
            resources.ApplyResources(this.Iniciar, "Iniciar");
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.Iniciar_Click);
            // 
            // Tiempo
            // 
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.pantalla, "pantalla");
            this.pantalla.Name = "pantalla";
            // 
            // Cronometro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.Pausar);
            this.Name = "Cronometro";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.TextBox pantalla;
    }
}

