namespace Proyecto2B
{
    partial class frmGrupos
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
            this.btnverGrupo = new System.Windows.Forms.Button();
            this.lbxGrupos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnverGrupo
            // 
            this.btnverGrupo.BackColor = System.Drawing.Color.Transparent;
            this.btnverGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverGrupo.ForeColor = System.Drawing.Color.White;
            this.btnverGrupo.Location = new System.Drawing.Point(60, 203);
            this.btnverGrupo.Name = "btnverGrupo";
            this.btnverGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnverGrupo.TabIndex = 8;
            this.btnverGrupo.Text = "Ver Grupo";
            this.btnverGrupo.UseVisualStyleBackColor = false;
            this.btnverGrupo.Click += new System.EventHandler(this.btnverGrupo_Click);
            // 
            // lbxGrupos
            // 
            this.lbxGrupos.BackColor = System.Drawing.Color.Firebrick;
            this.lbxGrupos.ForeColor = System.Drawing.Color.White;
            this.lbxGrupos.FormattingEnabled = true;
            this.lbxGrupos.Location = new System.Drawing.Point(13, 12);
            this.lbxGrupos.Name = "lbxGrupos";
            this.lbxGrupos.Size = new System.Drawing.Size(181, 186);
            this.lbxGrupos.TabIndex = 7;
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto2B.Properties.Resources.mundial_de_rusia_del_fútbol_94867947;
            this.ClientSize = new System.Drawing.Size(206, 231);
            this.Controls.Add(this.btnverGrupo);
            this.Controls.Add(this.lbxGrupos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmGrupos";
            this.Load += new System.EventHandler(this.frmGrupos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnverGrupo;
        private System.Windows.Forms.ListBox lbxGrupos;
    }
}