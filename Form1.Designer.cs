namespace Examen1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            openFileDialogAbrir = new OpenFileDialog();
            Curp = new DataGridViewTextBoxColumn();
            Promedio = new DataGridViewTextBoxColumn();
            SEXO = new DataGridViewTextBoxColumn();
            EDAD = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Curp, Promedio, SEXO, EDAD });
            dataGridView1.Location = new Point(3, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(798, 249);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(10, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.FileName = "openFileDialogAbrir";
            openFileDialogAbrir.Filter = "Archivo CSV|*.csv";
            // 
            // Curp
            // 
            Curp.HeaderText = "CURP";
            Curp.Name = "Curp";
            // 
            // Promedio
            // 
            Promedio.HeaderText = "PROMEDIO";
            Promedio.Name = "Promedio";
            // 
            // SEXO
            // 
            SEXO.HeaderText = "SEXO";
            SEXO.Name = "SEXO";
            // 
            // EDAD
            // 
            EDAD.HeaderText = "EDAD";
            EDAD.Name = "EDAD";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private OpenFileDialog openFileDialogAbrir;
        private DataGridViewTextBoxColumn Curp;
        private DataGridViewTextBoxColumn Promedio;
        private DataGridViewTextBoxColumn SEXO;
        private DataGridViewTextBoxColumn EDAD;
    }
}
