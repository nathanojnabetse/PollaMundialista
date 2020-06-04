namespace Proyecto2B
{
    partial class frmPredicciones
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
            this.lbxApuestas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxApuestas
            // 
            this.lbxApuestas.FormattingEnabled = true;
            this.lbxApuestas.Location = new System.Drawing.Point(41, 53);
            this.lbxApuestas.Margin = new System.Windows.Forms.Padding(2);
            this.lbxApuestas.Name = "lbxApuestas";
            this.lbxApuestas.Size = new System.Drawing.Size(344, 433);
            this.lbxApuestas.TabIndex = 3;
            this.lbxApuestas.SelectedIndexChanged += new System.EventHandler(this.lbxApuestas_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apuestas de Partidos: ";
            // 
            // frmPredicciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 508);
            this.Controls.Add(this.lbxApuestas);
            this.Controls.Add(this.label1);
            this.Name = "frmPredicciones";
            this.Text = "frmPredicciones";
            this.Load += new System.EventHandler(this.frmPredicciones_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxApuestas;
        private System.Windows.Forms.Label label1;
    }
}