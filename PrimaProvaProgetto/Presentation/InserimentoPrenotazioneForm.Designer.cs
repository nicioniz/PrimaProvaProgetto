namespace PrimaProvaProgetto.Presentation
{
    partial class InserimentoPrenotazioneForm
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
            this._buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxNome = new System.Windows.Forms.TextBox();
            this._textBoxNumeroTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._numericUpDownNumeroPosti = new System.Windows.Forms.NumericUpDown();
            this._buttonAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownNumeroPosti)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonOK
            // 
            this._buttonOK.Location = new System.Drawing.Point(89, 96);
            this._buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(50, 19);
            this._buttonOK.TabIndex = 0;
            this._buttonOK.Text = "&OK";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textBoxNome
            // 
            this._textBoxNome.Location = new System.Drawing.Point(105, 13);
            this._textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxNome.Name = "_textBoxNome";
            this._textBoxNome.Size = new System.Drawing.Size(96, 20);
            this._textBoxNome.TabIndex = 2;
            // 
            // _textBoxNumeroTel
            // 
            this._textBoxNumeroTel.Location = new System.Drawing.Point(105, 34);
            this._textBoxNumeroTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._textBoxNumeroTel.Name = "_textBoxNumeroTel";
            this._textBoxNumeroTel.Size = new System.Drawing.Size(96, 20);
            this._textBoxNumeroTel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero telefono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero posti";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _numericUpDownNumeroPosti
            // 
            this._numericUpDownNumeroPosti.Location = new System.Drawing.Point(105, 55);
            this._numericUpDownNumeroPosti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._numericUpDownNumeroPosti.Name = "_numericUpDownNumeroPosti";
            this._numericUpDownNumeroPosti.Size = new System.Drawing.Size(95, 20);
            this._numericUpDownNumeroPosti.TabIndex = 6;
            this._numericUpDownNumeroPosti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _buttonAnnulla
            // 
            this._buttonAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonAnnulla.Location = new System.Drawing.Point(150, 96);
            this._buttonAnnulla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonAnnulla.Name = "_buttonAnnulla";
            this._buttonAnnulla.Size = new System.Drawing.Size(50, 19);
            this._buttonAnnulla.TabIndex = 7;
            this._buttonAnnulla.Text = "&Annulla";
            this._buttonAnnulla.UseVisualStyleBackColor = true;
            this._buttonAnnulla.Click += new System.EventHandler(this._buttonAnnulla_Click);
            // 
            // InserimentoPrenotazioneForm
            // 
            this.AcceptButton = this._buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonAnnulla;
            this.ClientSize = new System.Drawing.Size(221, 133);
            this.Controls.Add(this._buttonAnnulla);
            this.Controls.Add(this._numericUpDownNumeroPosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._textBoxNumeroTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._buttonOK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InserimentoPrenotazioneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserimento Prenotazione";
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownNumeroPosti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxNome;
        private System.Windows.Forms.TextBox _textBoxNumeroTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numericUpDownNumeroPosti;
        private System.Windows.Forms.Button _buttonAnnulla;
    }
}