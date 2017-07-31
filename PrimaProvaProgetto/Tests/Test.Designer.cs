namespace PrimaProvaProgetto.Tests
{
    partial class Test
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
            this.moneyModifier1 = new PrimaProvaProgetto.Presentation.MoneyModifier();
            this.SuspendLayout();
            // 
            // moneyModifier1
            // 
            this.moneyModifier1.AutoSize = true;
            this.moneyModifier1.Location = new System.Drawing.Point(212, 147);
            this.moneyModifier1.Name = "moneyModifier1";
            this.moneyModifier1.Size = new System.Drawing.Size(123, 28);
            this.moneyModifier1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 471);
            this.Controls.Add(this.moneyModifier1);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Presentation.MoneyModifier moneyModifier1;
    }
}