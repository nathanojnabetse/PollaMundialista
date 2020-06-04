namespace Proyecto2B
{
    partial class frmGruposPersonas
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
            this.lbxGrupos = new System.Windows.Forms.ListBox();
            this.btnUnirme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodGrupo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxGrupos
            // 
            this.lbxGrupos.BackColor = System.Drawing.Color.Firebrick;
            this.lbxGrupos.ForeColor = System.Drawing.Color.White;
            this.lbxGrupos.FormattingEnabled = true;
            this.lbxGrupos.Location = new System.Drawing.Point(45, 101);
            this.lbxGrupos.Name = "lbxGrupos";
            this.lbxGrupos.Size = new System.Drawing.Size(159, 95);
            this.lbxGrupos.TabIndex = 0;
            // 
            // btnUnirme
            // 
            this.btnUnirme.BackColor = System.Drawing.Color.Transparent;
            this.btnUnirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnirme.ForeColor = System.Drawing.Color.White;
            this.btnUnirme.Location = new System.Drawing.Point(91, 216);
            this.btnUnirme.Name = "btnUnirme";
            this.btnUnirme.Size = new System.Drawing.Size(75, 23);
            this.btnUnirme.TabIndex = 1;
            this.btnUnirme.Text = "Unirme";
            this.btnUnirme.UseVisualStyleBackColor = false;
            this.btnUnirme.Click += new System.EventHandler(this.btnUnirme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo del Grupo:";
            // 
            // txtCodGrupo
            // 
            this.txtCodGrupo.Location = new System.Drawing.Point(125, 27);
            this.txtCodGrupo.Name = "txtCodGrupo";
            this.txtCodGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtCodGrupo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(82, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmGruposPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto2B.Properties.Resources.mundial_de_rusia_del_fútbol_94867947;
            this.ClientSize = new System.Drawing.Size(247, 255);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnirme);
            this.Controls.Add(this.lbxGrupos);
            this.Name = "frmGruposPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGruposPersonas";
            this.Load += new System.EventHandler(this.frmGruposPersonas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxGrupos;
        private System.Windows.Forms.Button btnUnirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodGrupo;
        private System.Windows.Forms.Button btnBuscar;
    }
}