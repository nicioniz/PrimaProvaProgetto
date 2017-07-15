namespace PrimaProvaProgetto.Presentation
{
    partial class PietanzaControl
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
            this.components = new System.ComponentModel.Container();
            this._nomeLabel = new System.Windows.Forms.Label();
            this._disponibileCheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _nomeLabel
            // 
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Location = new System.Drawing.Point(18, 16);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(0, 20);
            this._nomeLabel.TabIndex = 0;
            // 
            // _disponibileCheckBox
            // 
            this._disponibileCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._disponibileCheckBox.AutoSize = true;
            this._disponibileCheckBox.Location = new System.Drawing.Point(223, 15);
            this._disponibileCheckBox.Name = "_disponibileCheckBox";
            this._disponibileCheckBox.Size = new System.Drawing.Size(22, 21);
            this._disponibileCheckBox.TabIndex = 1;
            this._disponibileCheckBox.UseVisualStyleBackColor = true;
            this._disponibileCheckBox.CheckedChanged += new System.EventHandler(this._disponibileCheckBox_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._modificaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 34);
            // 
            // _modificaToolStripMenuItem
            // 
            this._modificaToolStripMenuItem.Name = "_modificaToolStripMenuItem";
            this._modificaToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this._modificaToolStripMenuItem.Text = "&Modifica";
            // 
            // PietanzaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._disponibileCheckBox);
            this.Controls.Add(this._nomeLabel);
            this.Name = "PietanzaControl";
            this.Size = new System.Drawing.Size(264, 51);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.CheckBox _disponibileCheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _modificaToolStripMenuItem;
    }
}
