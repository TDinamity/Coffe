﻿namespace Cafeteria
{
    partial class Salida_de_artículos
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
            this.btn_vender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_vender
            // 
            this.btn_vender.Location = new System.Drawing.Point(454, 366);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(139, 66);
            this.btn_vender.TabIndex = 0;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = true;
            // 
            // Salida_de_artículos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 485);
            this.Controls.Add(this.btn_vender);
            this.Name = "Salida_de_artículos";
            this.Text = "Salida_de_artículos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vender;
    }
}