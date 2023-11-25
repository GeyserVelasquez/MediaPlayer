namespace PlayerUI
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tituloForm2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            visorDeArchivos = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agruparArchivos = new System.Windows.Forms.Button();
            this.ordenarArchivos = new System.Windows.Forms.Button();
            this.EliminarArchivo = new System.Windows.Forms.Button();
            this.explorarArchivos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(visorDeArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloForm2
            // 
            this.tituloForm2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloForm2.AutoSize = true;
            this.tituloForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloForm2.ForeColor = System.Drawing.Color.White;
            this.tituloForm2.Location = new System.Drawing.Point(258, 7);
            this.tituloForm2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloForm2.Name = "tituloForm2";
            this.tituloForm2.Size = new System.Drawing.Size(204, 54);
            this.tituloForm2.TabIndex = 0;
            this.tituloForm2.Text = "Archivos";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 30);
            this.textBox1.TabIndex = 1;
            // 
            // visorDeArchivos
            // 
            visorDeArchivos.AllowUserToAddRows = false;
            visorDeArchivos.AllowUserToDeleteRows = false;
            visorDeArchivos.AllowUserToResizeColumns = false;
            visorDeArchivos.AllowUserToResizeRows = false;
            visorDeArchivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            visorDeArchivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            visorDeArchivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            visorDeArchivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            visorDeArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            visorDeArchivos.ColumnHeadersHeight = 20;
            visorDeArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            visorDeArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.artista,
            this.album,
            this.anno});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            visorDeArchivos.DefaultCellStyle = dataGridViewCellStyle2;
            visorDeArchivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            visorDeArchivos.EnableHeadersVisualStyles = false;
            visorDeArchivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(111)))), ((int)(((byte)(240)))));
            visorDeArchivos.Location = new System.Drawing.Point(9, 113);
            visorDeArchivos.Margin = new System.Windows.Forms.Padding(0);
            visorDeArchivos.Name = "visorDeArchivos";
            visorDeArchivos.ReadOnly = true;
            visorDeArchivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(120)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            visorDeArchivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            visorDeArchivos.RowHeadersVisible = false;
            visorDeArchivos.RowHeadersWidth = 20;
            visorDeArchivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            visorDeArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            visorDeArchivos.Size = new System.Drawing.Size(502, 301);
            visorDeArchivos.TabIndex = 2;
            visorDeArchivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(visorDeArchivos_CellClick);
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.title.Frozen = true;
            this.title.HeaderText = "Titulo";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 167;
            // 
            // artista
            // 
            this.artista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.artista.Frozen = true;
            this.artista.HeaderText = "Artista";
            this.artista.Name = "artista";
            this.artista.ReadOnly = true;
            this.artista.Width = 166;
            // 
            // album
            // 
            this.album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.album.Frozen = true;
            this.album.HeaderText = "Album";
            this.album.Name = "album";
            this.album.ReadOnly = true;
            this.album.Width = 167;
            // 
            // anno
            // 
            this.anno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anno.Frozen = true;
            this.anno.HeaderText = "Año";
            this.anno.Name = "anno";
            this.anno.ReadOnly = true;
            // 
            // agruparArchivos
            // 
            this.agruparArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agruparArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.agruparArchivos.FlatAppearance.BorderSize = 0;
            this.agruparArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agruparArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agruparArchivos.ForeColor = System.Drawing.Color.LightGray;
            this.agruparArchivos.Location = new System.Drawing.Point(520, 325);
            this.agruparArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.agruparArchivos.Name = "agruparArchivos";
            this.agruparArchivos.Size = new System.Drawing.Size(154, 35);
            this.agruparArchivos.TabIndex = 3;
            this.agruparArchivos.Text = "Agrupar Archivos";
            this.agruparArchivos.UseVisualStyleBackColor = false;
            // 
            // ordenarArchivos
            // 
            this.ordenarArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenarArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ordenarArchivos.FlatAppearance.BorderSize = 0;
            this.ordenarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordenarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarArchivos.ForeColor = System.Drawing.Color.LightGray;
            this.ordenarArchivos.Location = new System.Drawing.Point(520, 268);
            this.ordenarArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.ordenarArchivos.Name = "ordenarArchivos";
            this.ordenarArchivos.Size = new System.Drawing.Size(154, 35);
            this.ordenarArchivos.TabIndex = 4;
            this.ordenarArchivos.Text = "Ordenar Archivos";
            this.ordenarArchivos.UseVisualStyleBackColor = false;
            // 
            // EliminarArchivo
            // 
            this.EliminarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.EliminarArchivo.FlatAppearance.BorderSize = 0;
            this.EliminarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarArchivo.ForeColor = System.Drawing.Color.LightGray;
            this.EliminarArchivo.Location = new System.Drawing.Point(520, 211);
            this.EliminarArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarArchivo.Name = "EliminarArchivo";
            this.EliminarArchivo.Size = new System.Drawing.Size(154, 35);
            this.EliminarArchivo.TabIndex = 5;
            this.EliminarArchivo.Text = "Eliminar Archivo";
            this.EliminarArchivo.UseVisualStyleBackColor = false;
            // 
            // explorarArchivos
            // 
            this.explorarArchivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.explorarArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.explorarArchivos.FlatAppearance.BorderSize = 0;
            this.explorarArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explorarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorarArchivos.ForeColor = System.Drawing.Color.LightGray;
            this.explorarArchivos.Location = new System.Drawing.Point(520, 155);
            this.explorarArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.explorarArchivos.Name = "explorarArchivos";
            this.explorarArchivos.Size = new System.Drawing.Size(154, 35);
            this.explorarArchivos.TabIndex = 6;
            this.explorarArchivos.Text = "Añadir Archivo";
            this.explorarArchivos.UseVisualStyleBackColor = false;
            this.explorarArchivos.Click += new System.EventHandler(this.explorarArchivos_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(682, 423);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.explorarArchivos);
            this.Controls.Add(this.EliminarArchivo);
            this.Controls.Add(this.ordenarArchivos);
            this.Controls.Add(this.agruparArchivos);
            this.Controls.Add(visorDeArchivos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tituloForm2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(visorDeArchivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloForm2;
        private System.Windows.Forms.TextBox textBox1;
        public static System.Windows.Forms.DataGridView visorDeArchivos;
        private System.Windows.Forms.Button agruparArchivos;
        private System.Windows.Forms.Button ordenarArchivos;
        private System.Windows.Forms.Button EliminarArchivo;
        private System.Windows.Forms.Button explorarArchivos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn artista;
        private System.Windows.Forms.DataGridViewTextBoxColumn album;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
    }
}