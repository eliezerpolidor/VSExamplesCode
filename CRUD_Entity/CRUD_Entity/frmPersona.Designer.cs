
namespace CRUD_Entity
{
    partial class frmPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNombres = new System.Windows.Forms.TextBox();
            this.textoTelefono = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono:";
            // 
            // textoNombres
            // 
            this.textoNombres.Location = new System.Drawing.Point(17, 30);
            this.textoNombres.Name = "textoNombres";
            this.textoNombres.Size = new System.Drawing.Size(266, 20);
            this.textoNombres.TabIndex = 2;
            // 
            // textoTelefono
            // 
            this.textoTelefono.Location = new System.Drawing.Point(16, 80);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(267, 20);
            this.textoTelefono.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoTelefono);
            this.Controls.Add(this.textoNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPersona";
            this.Text = "frmPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNombres;
        private System.Windows.Forms.TextBox textoTelefono;
        private System.Windows.Forms.Button button1;
    }
}