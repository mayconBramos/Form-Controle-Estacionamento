namespace Form_Desafio_Garagem
{
    partial class Form_Saida
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
            this.tbx_Valor_Pago = new System.Windows.Forms.TextBox();
            this.tbx_Placa1 = new System.Windows.Forms.TextBox();
            this.tbx_Permanencia = new System.Windows.Forms.TextBox();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.lbl_Permanencia = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Valor_Pago
            // 
            this.tbx_Valor_Pago.Enabled = false;
            this.tbx_Valor_Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Valor_Pago.Location = new System.Drawing.Point(59, 211);
            this.tbx_Valor_Pago.Name = "tbx_Valor_Pago";
            this.tbx_Valor_Pago.Size = new System.Drawing.Size(157, 26);
            this.tbx_Valor_Pago.TabIndex = 0;
            this.tbx_Valor_Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Placa1
            // 
            this.tbx_Placa1.Enabled = false;
            this.tbx_Placa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Placa1.Location = new System.Drawing.Point(59, 54);
            this.tbx_Placa1.Name = "tbx_Placa1";
            this.tbx_Placa1.Size = new System.Drawing.Size(157, 26);
            this.tbx_Placa1.TabIndex = 1;
            this.tbx_Placa1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_Permanencia
            // 
            this.tbx_Permanencia.Enabled = false;
            this.tbx_Permanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Permanencia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_Permanencia.Location = new System.Drawing.Point(59, 133);
            this.tbx_Permanencia.Name = "tbx_Permanencia";
            this.tbx_Permanencia.Size = new System.Drawing.Size(157, 26);
            this.tbx_Permanencia.TabIndex = 2;
            this.tbx_Permanencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.Location = new System.Drawing.Point(111, 27);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(67, 24);
            this.lbl_Placa.TabIndex = 3;
            this.lbl_Placa.Text = "Placa:";
            // 
            // lbl_Permanencia
            // 
            this.lbl_Permanencia.AutoSize = true;
            this.lbl_Permanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Permanencia.Location = new System.Drawing.Point(81, 110);
            this.lbl_Permanencia.Name = "lbl_Permanencia";
            this.lbl_Permanencia.Size = new System.Drawing.Size(113, 20);
            this.lbl_Permanencia.TabIndex = 4;
            this.lbl_Permanencia.Text = "Permanência";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor.Location = new System.Drawing.Point(111, 188);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(51, 20);
            this.lbl_Valor.TabIndex = 5;
            this.lbl_Valor.Text = "Valor";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(101, 252);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(77, 30);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.Location = new System.Drawing.Point(166, 139);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(36, 15);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "(Min)";
            // 
            // Form_Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Permanencia);
            this.Controls.Add(this.lbl_Placa);
            this.Controls.Add(this.tbx_Permanencia);
            this.Controls.Add(this.tbx_Placa1);
            this.Controls.Add(this.tbx_Valor_Pago);
            this.Name = "Form_Saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Saida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Valor_Pago;
        private System.Windows.Forms.TextBox tbx_Placa1;
        private System.Windows.Forms.TextBox tbx_Permanencia;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.Label lbl_Permanencia;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_min;
    }
}