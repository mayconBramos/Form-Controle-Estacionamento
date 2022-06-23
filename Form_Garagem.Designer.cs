namespace Form_Desafio_Garagem
{
    partial class Form_Garagem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbx_Placa = new System.Windows.Forms.TextBox();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.data_Principal = new System.Windows.Forms.DateTimePicker();
            this.hora_Principal = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGrid_Garagem = new System.Windows.Forms.DataGridView();
            this.coluna_Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Hora_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_Saida = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Hora_Saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brn_Entrada = new System.Windows.Forms.Button();
            this.btn_Saida = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NumUp_Valor_Hora = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Garagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Saida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_Valor_Hora)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Placa
            // 
            this.tbx_Placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Placa.Location = new System.Drawing.Point(252, 89);
            this.tbx_Placa.Name = "tbx_Placa";
            this.tbx_Placa.Size = new System.Drawing.Size(203, 29);
            this.tbx_Placa.TabIndex = 0;
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.Location = new System.Drawing.Point(320, 62);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(61, 24);
            this.lbl_Placa.TabIndex = 1;
            this.lbl_Placa.Text = "Placa";
            // 
            // data_Principal
            // 
            this.data_Principal.Enabled = false;
            this.data_Principal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_Principal.Location = new System.Drawing.Point(138, 94);
            this.data_Principal.Name = "data_Principal";
            this.data_Principal.Size = new System.Drawing.Size(83, 20);
            this.data_Principal.TabIndex = 2;
            // 
            // hora_Principal
            // 
            this.hora_Principal.Enabled = false;
            this.hora_Principal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hora_Principal.Location = new System.Drawing.Point(480, 94);
            this.hora_Principal.Name = "hora_Principal";
            this.hora_Principal.Size = new System.Drawing.Size(74, 20);
            this.hora_Principal.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(267, 24);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "GARAGEM";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(342, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(375, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "SAIDA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGrid_Garagem
            // 
            this.dataGrid_Garagem.AllowUserToAddRows = false;
            this.dataGrid_Garagem.AllowUserToResizeColumns = false;
            this.dataGrid_Garagem.AllowUserToResizeRows = false;
            this.dataGrid_Garagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Garagem.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGrid_Garagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Garagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Garagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Garagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna_Placa,
            this.coluna_Data,
            this.coluna_Hora_Entrada});
            this.dataGrid_Garagem.Location = new System.Drawing.Point(12, 244);
            this.dataGrid_Garagem.Name = "dataGrid_Garagem";
            this.dataGrid_Garagem.RowHeadersVisible = false;
            this.dataGrid_Garagem.Size = new System.Drawing.Size(267, 184);
            this.dataGrid_Garagem.TabIndex = 10;
            // 
            // coluna_Placa
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coluna_Placa.DefaultCellStyle = dataGridViewCellStyle1;
            this.coluna_Placa.FillWeight = 104.3147F;
            this.coluna_Placa.HeaderText = "Placa";
            this.coluna_Placa.Name = "coluna_Placa";
            // 
            // coluna_Data
            // 
            this.coluna_Data.FillWeight = 91.37056F;
            this.coluna_Data.HeaderText = "Data";
            this.coluna_Data.Name = "coluna_Data";
            this.coluna_Data.ReadOnly = true;
            // 
            // coluna_Hora_Entrada
            // 
            this.coluna_Hora_Entrada.FillWeight = 104.3147F;
            this.coluna_Hora_Entrada.HeaderText = "Hora Entrada";
            this.coluna_Hora_Entrada.Name = "coluna_Hora_Entrada";
            this.coluna_Hora_Entrada.ReadOnly = true;
            // 
            // dataGrid_Saida
            // 
            this.dataGrid_Saida.AllowUserToAddRows = false;
            this.dataGrid_Saida.AllowUserToResizeColumns = false;
            this.dataGrid_Saida.AllowUserToResizeRows = false;
            this.dataGrid_Saida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Saida.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGrid_Saida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Saida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Saida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Saida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Coluna_Hora_Saida,
            this.coluna_Permanencia,
            this.coluna_Valor});
            this.dataGrid_Saida.Location = new System.Drawing.Point(342, 244);
            this.dataGrid_Saida.Name = "dataGrid_Saida";
            this.dataGrid_Saida.RowHeadersVisible = false;
            this.dataGrid_Saida.Size = new System.Drawing.Size(375, 184);
            this.dataGrid_Saida.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 91.37056F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 104.3147F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora Entrada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Coluna_Hora_Saida
            // 
            this.Coluna_Hora_Saida.HeaderText = "Hora Saida";
            this.Coluna_Hora_Saida.Name = "Coluna_Hora_Saida";
            this.Coluna_Hora_Saida.ReadOnly = true;
            // 
            // coluna_Permanencia
            // 
            this.coluna_Permanencia.HeaderText = "Permanência (Min)";
            this.coluna_Permanencia.Name = "coluna_Permanencia";
            this.coluna_Permanencia.ReadOnly = true;
            // 
            // coluna_Valor
            // 
            this.coluna_Valor.HeaderText = "Valor Pago";
            this.coluna_Valor.Name = "coluna_Valor";
            this.coluna_Valor.ReadOnly = true;
            // 
            // brn_Entrada
            // 
            this.brn_Entrada.Location = new System.Drawing.Point(252, 135);
            this.brn_Entrada.Name = "brn_Entrada";
            this.brn_Entrada.Size = new System.Drawing.Size(84, 41);
            this.brn_Entrada.TabIndex = 12;
            this.brn_Entrada.Text = "Entrada";
            this.brn_Entrada.UseVisualStyleBackColor = true;
            this.brn_Entrada.Click += new System.EventHandler(this.brn_Entrada_Click);
            // 
            // btn_Saida
            // 
            this.btn_Saida.Location = new System.Drawing.Point(371, 135);
            this.btn_Saida.Name = "btn_Saida";
            this.btn_Saida.Size = new System.Drawing.Size(84, 41);
            this.btn_Saida.TabIndex = 13;
            this.btn_Saida.Text = "Saida";
            this.btn_Saida.UseVisualStyleBackColor = true;
            this.btn_Saida.Click += new System.EventHandler(this.btn_Saida_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NumUp_Valor_Hora
            // 
            this.NumUp_Valor_Hora.Location = new System.Drawing.Point(12, 30);
            this.NumUp_Valor_Hora.Name = "NumUp_Valor_Hora";
            this.NumUp_Valor_Hora.Size = new System.Drawing.Size(57, 20);
            this.NumUp_Valor_Hora.TabIndex = 14;
            this.NumUp_Valor_Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUp_Valor_Hora.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor Hora";
            // 
            // Form_Garagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumUp_Valor_Hora);
            this.Controls.Add(this.btn_Saida);
            this.Controls.Add(this.brn_Entrada);
            this.Controls.Add(this.dataGrid_Saida);
            this.Controls.Add(this.dataGrid_Garagem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hora_Principal);
            this.Controls.Add(this.data_Principal);
            this.Controls.Add(this.lbl_Placa);
            this.Controls.Add(this.tbx_Placa);
            this.Name = "Form_Garagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de fluxo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Garagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Saida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_Valor_Hora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Placa;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.DateTimePicker data_Principal;
        private System.Windows.Forms.DateTimePicker hora_Principal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGrid_Garagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Hora_Entrada;
        private System.Windows.Forms.DataGridView dataGrid_Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Hora_Saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Permanencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Valor;
        private System.Windows.Forms.Button brn_Entrada;
        private System.Windows.Forms.Button btn_Saida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown NumUp_Valor_Hora;
        private System.Windows.Forms.Label label1;
    }
}

