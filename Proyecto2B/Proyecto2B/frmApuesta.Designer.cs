namespace Proyecto2B
{
    partial class frmApuesta
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
            this.cbxPuntos2 = new System.Windows.Forms.ComboBox();
            this.cbxPuntos1 = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxPuntos2
            // 
            this.cbxPuntos2.FormattingEnabled = true;
            this.cbxPuntos2.Location = new System.Drawing.Point(198, 69);
            this.cbxPuntos2.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPuntos2.Name = "cbxPuntos2";
            this.cbxPuntos2.Size = new System.Drawing.Size(38, 21);
            this.cbxPuntos2.TabIndex = 7;
            // 
            // cbxPuntos1
            // 
            this.cbxPuntos1.FormattingEnabled = true;
            this.cbxPuntos1.Location = new System.Drawing.Point(65, 69);
            this.cbxPuntos1.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPuntos1.Name = "cbxPuntos1";
            this.cbxPuntos1.Size = new System.Drawing.Size(38, 21);
            this.cbxPuntos1.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Location = new System.Drawing.Point(128, 124);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 22);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Predicción";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // frmApuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto2B.Properties.Resources.blue_wc_2018_background;
            this.ClientSize = new System.Drawing.Size(305, 175);
            this.Controls.Add(this.cbxPuntos2);
            this.Controls.Add(this.cbxPuntos1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmApuesta";
            this.Text = "frmApuesta";
            this.Load += new System.EventHandler(this.frmApuesta_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPuntos2;
        private System.Windows.Forms.ComboBox cbxPuntos1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
    }
}