﻿namespace PrimaProvaProgetto.Presentation
{
    partial class FirstWindowForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._avviaTotemButton = new System.Windows.Forms.Button();
            this._sceltaLayoutButton = new System.Windows.Forms.Button();
            this._sceltaMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._avviaTotemButton);
            this.panel1.Controls.Add(this._sceltaLayoutButton);
            this.panel1.Controls.Add(this._sceltaMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 137);
            this.panel1.TabIndex = 0;
            // 
            // _avviaTotemButton
            // 
            this._avviaTotemButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._avviaTotemButton.Enabled = false;
            this._avviaTotemButton.Location = new System.Drawing.Point(22, 73);
            this._avviaTotemButton.Margin = new System.Windows.Forms.Padding(2);
            this._avviaTotemButton.Name = "_avviaTotemButton";
            this._avviaTotemButton.Size = new System.Drawing.Size(158, 40);
            this._avviaTotemButton.TabIndex = 3;
            this._avviaTotemButton.Text = "Avvio Totem Clienti";
            this._avviaTotemButton.UseVisualStyleBackColor = true;
            // 
            // _sceltaLayoutButton
            // 
            this._sceltaLayoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sceltaLayoutButton.Location = new System.Drawing.Point(119, 19);
            this._sceltaLayoutButton.Margin = new System.Windows.Forms.Padding(2);
            this._sceltaLayoutButton.Name = "_sceltaLayoutButton";
            this._sceltaLayoutButton.Size = new System.Drawing.Size(61, 40);
            this._sceltaLayoutButton.TabIndex = 2;
            this._sceltaLayoutButton.Text = "Scelta layout";
            this._sceltaLayoutButton.UseVisualStyleBackColor = true;
            // 
            // _sceltaMenuButton
            // 
            this._sceltaMenuButton.Location = new System.Drawing.Point(22, 19);
            this._sceltaMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this._sceltaMenuButton.Name = "_sceltaMenuButton";
            this._sceltaMenuButton.Size = new System.Drawing.Size(61, 40);
            this._sceltaMenuButton.TabIndex = 1;
            this._sceltaMenuButton.Text = "Scelta menù";
            this._sceltaMenuButton.UseVisualStyleBackColor = true;
            // 
            // FirstWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 137);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FirstWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avvio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _avviaTotemButton;
        private System.Windows.Forms.Button _sceltaLayoutButton;
        private System.Windows.Forms.Button _sceltaMenuButton;
    }
}