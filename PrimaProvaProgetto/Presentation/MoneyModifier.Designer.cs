namespace PrimaProvaProgetto.Presentation
{
    partial class MoneyModifier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _numericUpDown
            // 
            this._numericUpDown.DecimalPlaces = 2;
            this._numericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._numericUpDown.Location = new System.Drawing.Point(0, 0);
            this._numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(123, 26);
            this._numericUpDown.TabIndex = 0;
            this._numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MoneyModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._numericUpDown);
            this.Name = "MoneyModifier";
            this.Size = new System.Drawing.Size(123, 28);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numericUpDown;
    }
}
