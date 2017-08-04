namespace PrimaProvaProgetto.Presentation
{
    partial class ClientiForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._allergeniFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._categorieFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._labelAllergeniSelezionati = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this._menuDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._menuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(976, 661);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._allergeniFlowLayoutPanel);
            this.splitContainer2.Panel1.Controls.Add(this._categorieFlowLayoutPanel);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this._labelAllergeniSelezionati);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(334, 661);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // _allergeniFlowLayoutPanel
            // 
            this._allergeniFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._allergeniFlowLayoutPanel.AutoSize = true;
            this._allergeniFlowLayoutPanel.Location = new System.Drawing.Point(13, 168);
            this._allergeniFlowLayoutPanel.Name = "_allergeniFlowLayoutPanel";
            this._allergeniFlowLayoutPanel.Size = new System.Drawing.Size(309, 80);
            this._allergeniFlowLayoutPanel.TabIndex = 11;
            // 
            // _categorieFlowLayoutPanel
            // 
            this._categorieFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._categorieFlowLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this._categorieFlowLayoutPanel.Location = new System.Drawing.Point(13, 42);
            this._categorieFlowLayoutPanel.Name = "_categorieFlowLayoutPanel";
            this._categorieFlowLayoutPanel.Size = new System.Drawing.Size(309, 84);
            this._categorieFlowLayoutPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categorie";
            // 
            // _labelAllergeniSelezionati
            // 
            this._labelAllergeniSelezionati.AutoSize = true;
            this._labelAllergeniSelezionati.Location = new System.Drawing.Point(19, 145);
            this._labelAllergeniSelezionati.Name = "_labelAllergeniSelezionati";
            this._labelAllergeniSelezionati.Size = new System.Drawing.Size(70, 20);
            this._labelAllergeniSelezionati.TabIndex = 8;
            this._labelAllergeniSelezionati.Text = "Allergeni";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this._menuDataGridView);
            this.splitContainer3.Size = new System.Drawing.Size(334, 391);
            this.splitContainer3.SplitterDistance = 38;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menù";
            // 
            // _menuDataGridView
            // 
            this._menuDataGridView.AllowUserToAddRows = false;
            this._menuDataGridView.AllowUserToDeleteRows = false;
            this._menuDataGridView.AllowUserToResizeColumns = false;
            this._menuDataGridView.AllowUserToResizeRows = false;
            this._menuDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._menuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._menuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._menuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._menuDataGridView.Location = new System.Drawing.Point(0, 0);
            this._menuDataGridView.MultiSelect = false;
            this._menuDataGridView.Name = "_menuDataGridView";
            this._menuDataGridView.ReadOnly = true;
            this._menuDataGridView.RowTemplate.Height = 28;
            this._menuDataGridView.ShowEditingIcon = false;
            this._menuDataGridView.Size = new System.Drawing.Size(334, 349);
            this._menuDataGridView.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 241);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ancora da aggiungere la visualizzazione dei tempi di attesa per i clienti";
            // 
            // ClientiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 661);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ClientiForm";
            this.Text = "ClientiForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._menuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel _allergeniFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel _categorieFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _labelAllergeniSelezionati;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _menuDataGridView;
        private System.Windows.Forms.Label label3;
    }
}