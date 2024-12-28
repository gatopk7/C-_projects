namespace Componentes
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
            this.cbxRojo = new System.Windows.Forms.CheckBox();
            this.cbxVerde = new System.Windows.Forms.CheckBox();
            this.cbxAzul = new System.Windows.Forms.CheckBox();
            this.pnlCheckbox = new System.Windows.Forms.Panel();
            this.nudRojo = new System.Windows.Forms.NumericUpDown();
            this.nudVerde = new System.Windows.Forms.NumericUpDown();
            this.nudAzul = new System.Windows.Forms.NumericUpDown();
            this.pnlNud = new System.Windows.Forms.Panel();
            this.rbMexico = new System.Windows.Forms.RadioButton();
            this.rbEua = new System.Windows.Forms.RadioButton();
            this.rbCanada = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPaises = new System.Windows.Forms.ComboBox();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.cbxCuidades = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRojo
            // 
            this.cbxRojo.AutoSize = true;
            this.cbxRojo.Location = new System.Drawing.Point(29, 36);
            this.cbxRojo.Name = "cbxRojo";
            this.cbxRojo.Size = new System.Drawing.Size(48, 17);
            this.cbxRojo.TabIndex = 0;
            this.cbxRojo.Text = "Rojo";
            this.cbxRojo.UseVisualStyleBackColor = true;
            this.cbxRojo.CheckedChanged += new System.EventHandler(this.cbxRojo_CheckedChanged);
            // 
            // cbxVerde
            // 
            this.cbxVerde.AutoSize = true;
            this.cbxVerde.Location = new System.Drawing.Point(29, 59);
            this.cbxVerde.Name = "cbxVerde";
            this.cbxVerde.Size = new System.Drawing.Size(54, 17);
            this.cbxVerde.TabIndex = 1;
            this.cbxVerde.Text = "Verde";
            this.cbxVerde.UseVisualStyleBackColor = true;
            this.cbxVerde.CheckedChanged += new System.EventHandler(this.cbxVerde_CheckedChanged);
            // 
            // cbxAzul
            // 
            this.cbxAzul.AutoSize = true;
            this.cbxAzul.Location = new System.Drawing.Point(29, 82);
            this.cbxAzul.Name = "cbxAzul";
            this.cbxAzul.Size = new System.Drawing.Size(46, 17);
            this.cbxAzul.TabIndex = 2;
            this.cbxAzul.Text = "Azul";
            this.cbxAzul.UseVisualStyleBackColor = true;
            this.cbxAzul.CheckedChanged += new System.EventHandler(this.cbxAzul_CheckedChanged);
            // 
            // pnlCheckbox
            // 
            this.pnlCheckbox.BackColor = System.Drawing.Color.Black;
            this.pnlCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckbox.Location = new System.Drawing.Point(115, 36);
            this.pnlCheckbox.Name = "pnlCheckbox";
            this.pnlCheckbox.Size = new System.Drawing.Size(101, 63);
            this.pnlCheckbox.TabIndex = 3;
            // 
            // nudRojo
            // 
            this.nudRojo.Location = new System.Drawing.Point(96, 124);
            this.nudRojo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRojo.Name = "nudRojo";
            this.nudRojo.Size = new System.Drawing.Size(120, 20);
            this.nudRojo.TabIndex = 0;
            this.nudRojo.ValueChanged += new System.EventHandler(this.nudRojo_ValueChanged);
            // 
            // nudVerde
            // 
            this.nudVerde.Location = new System.Drawing.Point(96, 150);
            this.nudVerde.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudVerde.Name = "nudVerde";
            this.nudVerde.Size = new System.Drawing.Size(120, 20);
            this.nudVerde.TabIndex = 4;
            this.nudVerde.ValueChanged += new System.EventHandler(this.nudVerde_ValueChanged);
            // 
            // nudAzul
            // 
            this.nudAzul.Location = new System.Drawing.Point(96, 176);
            this.nudAzul.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAzul.Name = "nudAzul";
            this.nudAzul.Size = new System.Drawing.Size(120, 20);
            this.nudAzul.TabIndex = 5;
            this.nudAzul.ValueChanged += new System.EventHandler(this.nudAzul_ValueChanged);
            // 
            // pnlNud
            // 
            this.pnlNud.BackColor = System.Drawing.Color.Black;
            this.pnlNud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNud.Location = new System.Drawing.Point(241, 124);
            this.pnlNud.Name = "pnlNud";
            this.pnlNud.Size = new System.Drawing.Size(101, 72);
            this.pnlNud.TabIndex = 4;
            // 
            // rbMexico
            // 
            this.rbMexico.AutoSize = true;
            this.rbMexico.Location = new System.Drawing.Point(29, 229);
            this.rbMexico.Name = "rbMexico";
            this.rbMexico.Size = new System.Drawing.Size(59, 17);
            this.rbMexico.TabIndex = 6;
            this.rbMexico.TabStop = true;
            this.rbMexico.Text = "México";
            this.rbMexico.UseVisualStyleBackColor = true;
            this.rbMexico.CheckedChanged += new System.EventHandler(this.rbMexico_CheckedChanged);
            // 
            // rbEua
            // 
            this.rbEua.AutoSize = true;
            this.rbEua.Location = new System.Drawing.Point(29, 252);
            this.rbEua.Name = "rbEua";
            this.rbEua.Size = new System.Drawing.Size(47, 17);
            this.rbEua.TabIndex = 8;
            this.rbEua.TabStop = true;
            this.rbEua.Text = "EUA";
            this.rbEua.UseVisualStyleBackColor = true;
            this.rbEua.CheckedChanged += new System.EventHandler(this.rbEua_CheckedChanged);
            // 
            // rbCanada
            // 
            this.rbCanada.AutoSize = true;
            this.rbCanada.Location = new System.Drawing.Point(29, 275);
            this.rbCanada.Name = "rbCanada";
            this.rbCanada.Size = new System.Drawing.Size(62, 17);
            this.rbCanada.TabIndex = 9;
            this.rbCanada.TabStop = true;
            this.rbCanada.Text = "Canada";
            this.rbCanada.UseVisualStyleBackColor = true;
            this.rbCanada.CheckedChanged += new System.EventHandler(this.rbCanada_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Azul";
            // 
            // cbxPaises
            // 
            this.cbxPaises.FormattingEnabled = true;
            this.cbxPaises.Items.AddRange(new object[] {
            "MÉXICO",
            "EUA",
            "CANADA"});
            this.cbxPaises.Location = new System.Drawing.Point(273, 32);
            this.cbxPaises.Name = "cbxPaises";
            this.cbxPaises.Size = new System.Drawing.Size(121, 21);
            this.cbxPaises.TabIndex = 13;
            this.cbxPaises.SelectedIndexChanged += new System.EventHandler(this.cbxPaises_SelectedIndexChanged);
            // 
            // cbxEstados
            // 
            this.cbxEstados.Enabled = false;
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(400, 32);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(121, 21);
            this.cbxEstados.TabIndex = 14;
            this.cbxEstados.SelectedIndexChanged += new System.EventHandler(this.cbxEstados_SelectedIndexChanged);
            // 
            // cbxCuidades
            // 
            this.cbxCuidades.FormattingEnabled = true;
            this.cbxCuidades.Location = new System.Drawing.Point(527, 32);
            this.cbxCuidades.Name = "cbxCuidades";
            this.cbxCuidades.Size = new System.Drawing.Size(121, 21);
            this.cbxCuidades.TabIndex = 15;
            this.cbxCuidades.Visible = false;
            this.cbxCuidades.SelectedIndexChanged += new System.EventHandler(this.cbxCuidades_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(270, 82);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(0, 13);
            this.txt.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(115, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.cbxCuidades);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.cbxPaises);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCanada);
            this.Controls.Add(this.rbEua);
            this.Controls.Add(this.rbMexico);
            this.Controls.Add(this.pnlNud);
            this.Controls.Add(this.nudAzul);
            this.Controls.Add(this.nudVerde);
            this.Controls.Add(this.nudRojo);
            this.Controls.Add(this.pnlCheckbox);
            this.Controls.Add(this.cbxAzul);
            this.Controls.Add(this.cbxVerde);
            this.Controls.Add(this.cbxRojo);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxRojo;
        private System.Windows.Forms.CheckBox cbxVerde;
        private System.Windows.Forms.CheckBox cbxAzul;
        private System.Windows.Forms.Panel pnlCheckbox;
        private System.Windows.Forms.NumericUpDown nudRojo;
        private System.Windows.Forms.NumericUpDown nudVerde;
        private System.Windows.Forms.NumericUpDown nudAzul;
        private System.Windows.Forms.Panel pnlNud;
        private System.Windows.Forms.RadioButton rbMexico;
        private System.Windows.Forms.RadioButton rbEua;
        private System.Windows.Forms.RadioButton rbCanada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPaises;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.ComboBox cbxCuidades;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

