namespace Ejercicio40Enum.Windows
{
    partial class frmOpBasicas
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
            btnSalir = new Button();
            btnCancelar = new Button();
            btnSuma = new Button();
            txtNumero2 = new TextBox();
            txtNumero1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnResta = new Button();
            btnProducto = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Image = Properties.Resources.logout_rounded_24px;
            btnSalir.Location = new Point(472, 256);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 49);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(316, 29);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 49);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSuma
            // 
            btnSuma.Image = Properties.Resources.plus_24px;
            btnSuma.Location = new Point(37, 104);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 49);
            btnSuma.TabIndex = 3;
            btnSuma.Text = "Suma";
            btnSuma.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(149, 58);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 1;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(149, 29);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese otro número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese un número:";
            // 
            // btnResta
            // 
            btnResta.Image = Properties.Resources.minus_24px;
            btnResta.Location = new Point(118, 104);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 49);
            btnResta.TabIndex = 3;
            btnResta.Text = "Resta";
            btnResta.TextImageRelation = TextImageRelation.ImageAboveText;
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnProducto
            // 
            btnProducto.Image = Properties.Resources.multiply2_24px;
            btnProducto.Location = new Point(199, 104);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(75, 49);
            btnProducto.TabIndex = 3;
            btnProducto.Text = "Producto";
            btnProducto.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnDividir
            // 
            btnDividir.Image = Properties.Resources.divide2_24px;
            btnDividir.Location = new Point(280, 104);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 49);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // frmOpBasicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 314);
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnDividir);
            Controls.Add(btnProducto);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOpBasicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operaciones Básicas";
            FormClosing += frmOpBasicas_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnCancelar;
        private Button btnSuma;
        private TextBox txtNumero2;
        private TextBox txtNumero1;
        private Label label2;
        private Label label1;
        private Button btnResta;
        private Button btnProducto;
        private Button btnDividir;
    }
}