namespace Proyecto2B
{
    partial class frmGruposPertencientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnverGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxGrupos
            // 
            this.lbxGrupos.BackColor = System.Drawing.Color.Firebrick;
            this.lbxGrupos.ForeColor = System.Drawing.Color.White;
            this.lbxGrupos.FormattingEnabled = true;
            this.lbxGrupos.Location = new System.Drawing.Point(12, 29);
            this.lbxGrupos.Name = "lbxGrupos";
            this.lbxGrupos.Size = new System.Drawing.Size(181, 186);
            this.lbxGrupos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnverGrupo
            // 
            this.btnverGrupo.Location = new System.Drawing.Point(21, 221);
            this.btnverGrupo.Name = "btnverGrupo";
            this.btnverGrupo.Size = new System.Drawing.Size(159, 23);
            this.btnverGrupo.TabIndex = 8;
            this.btnverGrupo.Text = "Ver  Información del Grupo ";
            this.btnverGrupo.UseVisualStyleBackColor = true;
            this.btnverGrupo.Click += new System.EventHandler(this.btnverGrupo_Click_1);
            // 
            // frmGruposPertencientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto2B.Properties.Resources.mundial_de_rusia_del_fútbol_94867947;
            this.ClientSize = new System.Drawing.Size(211, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnverGrupo);
            this.Controls.Add(this.lbxGrupos);
            this.Name = "frmGruposPertencientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGruposPertencientes";
            this.Load += new System.EventHandler(this.frmGruposPertencientes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxGrupos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnverGrupo;
    }
}