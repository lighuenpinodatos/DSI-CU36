namespace DSI_CU36
{
    partial class generarListaRecursos
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tipo = new System.Windows.Forms.ColumnHeader();
            this.Numero = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Marca = new System.Windows.Forms.ColumnHeader();
            this.Modelo = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar RT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tipo,
            this.Numero,
            this.Nombre,
            this.Marca,
            this.Modelo});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(2, -3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 459);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 130;
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            this.Numero.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 130;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 130;
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            this.Modelo.Width = 130;
            // 
            // generarListaRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "generarListaRecursos";
            this.Text = "Mantenimiento correctivo";
            this.Load += new System.EventHandler(this.generarListaRecursos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private ListView listView1;
        private ColumnHeader Tipo;
        private ColumnHeader Numero;
        private ColumnHeader Nombre;
        private ColumnHeader Marca;
        private ColumnHeader Modelo;
    }
}