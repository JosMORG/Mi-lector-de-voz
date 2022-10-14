namespace Mi_lector_de_voz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hablar = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.abrir = new System.Windows.Forms.Button();
            this.terminar = new System.Windows.Forms.Button();
            this.pausar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.hablar);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.abrir);
            this.panel1.Controls.Add(this.terminar);
            this.panel1.Controls.Add(this.pausar);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 114);
            this.panel1.TabIndex = 0;
            // 
            // hablar
            // 
            this.hablar.BackColor = System.Drawing.Color.Transparent;
            this.hablar.BackgroundImage = global::Mi_lector_de_voz.Properties.Resources.conversacion;
            this.hablar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hablar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hablar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.hablar.Location = new System.Drawing.Point(422, 13);
            this.hablar.Name = "hablar";
            this.hablar.Size = new System.Drawing.Size(82, 75);
            this.hablar.TabIndex = 5;
            this.hablar.UseVisualStyleBackColor = false;
            this.hablar.Click += new System.EventHandler(this.button5_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImage = global::Mi_lector_de_voz.Properties.Resources.boton_de_play;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.play.Location = new System.Drawing.Point(14, 13);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(82, 75);
            this.play.TabIndex = 4;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // abrir
            // 
            this.abrir.BackColor = System.Drawing.Color.Transparent;
            this.abrir.BackgroundImage = global::Mi_lector_de_voz.Properties.Resources.bandeja_de_entrada;
            this.abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrir.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.abrir.Location = new System.Drawing.Point(318, 13);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(80, 75);
            this.abrir.TabIndex = 3;
            this.abrir.UseVisualStyleBackColor = false;
            this.abrir.Click += new System.EventHandler(this.button3_Click);
            // 
            // terminar
            // 
            this.terminar.BackColor = System.Drawing.Color.Transparent;
            this.terminar.BackgroundImage = global::Mi_lector_de_voz.Properties.Resources.boton_detener;
            this.terminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.terminar.Location = new System.Drawing.Point(213, 13);
            this.terminar.Name = "terminar";
            this.terminar.Size = new System.Drawing.Size(80, 75);
            this.terminar.TabIndex = 2;
            this.terminar.UseVisualStyleBackColor = false;
            this.terminar.Click += new System.EventHandler(this.terminar_Click);
            // 
            // pausar
            // 
            this.pausar.BackColor = System.Drawing.Color.Transparent;
            this.pausar.BackgroundImage = global::Mi_lector_de_voz.Properties.Resources.boton_de_pausa_de_video;
            this.pausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pausar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.pausar.Location = new System.Drawing.Point(115, 13);
            this.pausar.Name = "pausar";
            this.pausar.Size = new System.Drawing.Size(79, 75);
            this.pausar.TabIndex = 1;
            this.pausar.UseVisualStyleBackColor = false;
            this.pausar.Click += new System.EventHandler(this.pausar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 280);
            this.label1.TabIndex = 1;
            this.label1.Text = "lector de texto avanzado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pausar;
        private System.Windows.Forms.Button hablar;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Button terminar;
        private System.Windows.Forms.Label label1;
    }
}

