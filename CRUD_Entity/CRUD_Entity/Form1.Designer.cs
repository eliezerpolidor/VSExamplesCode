﻿
namespace CRUD_Entity
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
            this.BotoCrear = new System.Windows.Forms.Button();
            this.DataGridViewPersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // BotoCrear
            // 
            this.BotoCrear.Location = new System.Drawing.Point(12, 25);
            this.BotoCrear.Name = "BotoCrear";
            this.BotoCrear.Size = new System.Drawing.Size(151, 40);
            this.BotoCrear.TabIndex = 0;
            this.BotoCrear.Text = "Crear Nuevo";
            this.BotoCrear.UseVisualStyleBackColor = true;
            this.BotoCrear.Click += new System.EventHandler(this.BotoCrear_Click);
            // 
            // DataGridViewPersona
            // 
            this.DataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPersona.Location = new System.Drawing.Point(12, 97);
            this.DataGridViewPersona.Name = "DataGridViewPersona";
            this.DataGridViewPersona.Size = new System.Drawing.Size(728, 331);
            this.DataGridViewPersona.TabIndex = 1;
            this.DataGridViewPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPersona_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewPersona);
            this.Controls.Add(this.BotoCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotoCrear;
        private System.Windows.Forms.DataGridView DataGridViewPersona;
    }
}

