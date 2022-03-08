
using System;

namespace Practik_4
{
    partial class Form2
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
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1.Location = new System.Drawing.Point(40, 22);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(85, 30);
            this.player1.TabIndex = 0;
            this.player1.Text = "player1";
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2.Location = new System.Drawing.Point(637, 22);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(85, 30);
            this.player2.TabIndex = 1;
            this.player2.Text = "player2";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(331, 404);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 34);
            this.button10.TabIndex = 3;
            this.button10.Text = "Заново";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label player1;
        public System.Windows.Forms.Label player2;
        private System.Windows.Forms.Button button10;
    }
}