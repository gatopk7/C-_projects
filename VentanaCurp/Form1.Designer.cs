namespace VentanaCurp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNom1 = new System.Windows.Forms.TextBox();
            this.txtNom2 = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.dtpNac = new System.Windows.Forms.DateTimePicker();
            this.btnCURP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido1
            // 
            resources.ApplyResources(this.txtApellido1, "txtApellido1");
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.TextChanged += new System.EventHandler(this.txtApellido1_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtApellido2
            // 
            resources.ApplyResources(this.txtApellido2, "txtApellido2");
            this.txtApellido2.Name = "txtApellido2";
            // 
            // txtNom1
            // 
            resources.ApplyResources(this.txtNom1, "txtNom1");
            this.txtNom1.Name = "txtNom1";
            // 
            // txtNom2
            // 
            resources.ApplyResources(this.txtNom2, "txtNom2");
            this.txtNom2.Name = "txtNom2";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            resources.GetString("cbxEstado.Items"),
            resources.GetString("cbxEstado.Items1"),
            resources.GetString("cbxEstado.Items2"),
            resources.GetString("cbxEstado.Items3"),
            resources.GetString("cbxEstado.Items4"),
            resources.GetString("cbxEstado.Items5")});
            resources.ApplyResources(this.cbxEstado, "cbxEstado");
            this.cbxEstado.Name = "cbxEstado";
            // 
            // rdbHombre
            // 
            resources.ApplyResources(this.rdbHombre, "rdbHombre");
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.TabStop = true;
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            resources.ApplyResources(this.rdbMujer, "rdbMujer");
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.TabStop = true;
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // dtpNac
            // 
            resources.ApplyResources(this.dtpNac, "dtpNac");
            this.dtpNac.Name = "dtpNac";
            this.dtpNac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCURP
            // 
            resources.ApplyResources(this.btnCURP, "btnCURP");
            this.btnCURP.Name = "btnCURP";
            this.btnCURP.UseVisualStyleBackColor = true;
            this.btnCURP.Click += new System.EventHandler(this.btnCURP_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rdbHombre);
            this.gbxSexo.Controls.Add(this.rdbMujer);
            resources.ApplyResources(this.gbxSexo, "gbxSexo");
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCurp
            // 
            resources.ApplyResources(this.lblCurp, "lblCurp");
            this.lblCurp.Name = "lblCurp";
            // 
            // txtInfo
            // 
            resources.ApplyResources(this.txtInfo, "txtInfo");
            this.txtInfo.Name = "txtInfo";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblCurp);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnCURP);
            this.Controls.Add(this.dtpNac);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom2);
            this.Controls.Add(this.txtNom1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNom1;
        private System.Windows.Forms.TextBox txtNom2;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.DateTimePicker dtpNac;
        private System.Windows.Forms.Button btnCURP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.Label txtInfo;
    }
}

