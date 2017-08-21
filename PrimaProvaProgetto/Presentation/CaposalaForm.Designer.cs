namespace PrimaProvaProgetto.Presentation
{
    partial class CaposalaForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._prenotazioniPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._tavoliPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._prenotazioniListView = new System.Windows.Forms.ListView();
            this._tavoliListView = new System.Windows.Forms.ListView();
            this._tavoliContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.occupaTavoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liberaTavoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._prenotazioniContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificaPrenotazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaPrenotazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._insertPrenotazioneMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inserisciNuovaPrenotazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this._prenotazioniPanel.SuspendLayout();
            this._tavoliPanel.SuspendLayout();
            this._tavoliContextMenuStrip.SuspendLayout();
            this._prenotazioniContextMenuStrip.SuspendLayout();
            this._insertPrenotazioneMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._prenotazioniPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._tavoliPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._prenotazioniListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._tavoliListView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 971);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _prenotazioniPanel
            // 
            this._prenotazioniPanel.BackColor = System.Drawing.Color.DarkOrange;
            this._prenotazioniPanel.Controls.Add(this.label1);
            this._prenotazioniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prenotazioniPanel.Location = new System.Drawing.Point(6, 7);
            this._prenotazioniPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._prenotazioniPanel.Name = "_prenotazioniPanel";
            this._prenotazioniPanel.Size = new System.Drawing.Size(667, 125);
            this._prenotazioniPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenotazioni";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tavoliPanel
            // 
            this._tavoliPanel.BackColor = System.Drawing.Color.Gold;
            this._tavoliPanel.Controls.Add(this.label2);
            this._tavoliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tavoliPanel.Location = new System.Drawing.Point(683, 7);
            this._tavoliPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tavoliPanel.Name = "_tavoliPanel";
            this._tavoliPanel.Size = new System.Drawing.Size(667, 125);
            this._tavoliPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 84);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stato Tavoli";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _prenotazioniListView
            // 
            this._prenotazioniListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prenotazioniListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prenotazioniListView.Location = new System.Drawing.Point(6, 144);
            this._prenotazioniListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._prenotazioniListView.Name = "_prenotazioniListView";
            this._prenotazioniListView.ShowItemToolTips = true;
            this._prenotazioniListView.Size = new System.Drawing.Size(667, 820);
            this._prenotazioniListView.TabIndex = 2;
            this._prenotazioniListView.UseCompatibleStateImageBehavior = false;
            this._prenotazioniListView.View = System.Windows.Forms.View.List;
            // 
            // _tavoliListView
            // 
            this._tavoliListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tavoliListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tavoliListView.Location = new System.Drawing.Point(683, 144);
            this._tavoliListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._tavoliListView.Name = "_tavoliListView";
            this._tavoliListView.Size = new System.Drawing.Size(667, 820);
            this._tavoliListView.TabIndex = 3;
            this._tavoliListView.UseCompatibleStateImageBehavior = false;
            this._tavoliListView.View = System.Windows.Forms.View.List;
            // 
            // _tavoliContextMenuStrip
            // 
            this._tavoliContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._tavoliContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.occupaTavoloToolStripMenuItem,
            this.liberaTavoloToolStripMenuItem});
            this._tavoliContextMenuStrip.Name = "contextMenuStrip1";
            this._tavoliContextMenuStrip.Size = new System.Drawing.Size(201, 64);
            this._tavoliContextMenuStrip.Text = "Menù";
            // 
            // occupaTavoloToolStripMenuItem
            // 
            this.occupaTavoloToolStripMenuItem.Name = "occupaTavoloToolStripMenuItem";
            this.occupaTavoloToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.occupaTavoloToolStripMenuItem.Text = "Occupa Tavolo";
            // 
            // liberaTavoloToolStripMenuItem
            // 
            this.liberaTavoloToolStripMenuItem.Name = "liberaTavoloToolStripMenuItem";
            this.liberaTavoloToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.liberaTavoloToolStripMenuItem.Text = "Libera Tavolo";
            // 
            // _prenotazioniContextMenuStrip
            // 
            this._prenotazioniContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._prenotazioniContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaPrenotazioneToolStripMenuItem,
            this.eliminaPrenotazioneToolStripMenuItem});
            this._prenotazioniContextMenuStrip.Name = "_prenotazioniContextMenuStrip";
            this._prenotazioniContextMenuStrip.Size = new System.Drawing.Size(262, 64);
            // 
            // modificaPrenotazioneToolStripMenuItem
            // 
            this.modificaPrenotazioneToolStripMenuItem.Name = "modificaPrenotazioneToolStripMenuItem";
            this.modificaPrenotazioneToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.modificaPrenotazioneToolStripMenuItem.Text = "Modifica Prenotazione";
            // 
            // eliminaPrenotazioneToolStripMenuItem
            // 
            this.eliminaPrenotazioneToolStripMenuItem.Name = "eliminaPrenotazioneToolStripMenuItem";
            this.eliminaPrenotazioneToolStripMenuItem.Size = new System.Drawing.Size(261, 30);
            this.eliminaPrenotazioneToolStripMenuItem.Text = "Elimina Prenotazione";
            // 
            // _insertPrenotazioneMenu
            // 
            this._insertPrenotazioneMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._insertPrenotazioneMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciNuovaPrenotazioneToolStripMenuItem});
            this._insertPrenotazioneMenu.Name = "_insertPrenotazioneMenu";
            this._insertPrenotazioneMenu.Size = new System.Drawing.Size(312, 34);
            // 
            // inserisciNuovaPrenotazioneToolStripMenuItem
            // 
            this.inserisciNuovaPrenotazioneToolStripMenuItem.Name = "inserisciNuovaPrenotazioneToolStripMenuItem";
            this.inserisciNuovaPrenotazioneToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.inserisciNuovaPrenotazioneToolStripMenuItem.Text = "Inserisci Nuova Prenotazione";
            // 
            // CaposalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 971);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(600, 75);
            this.Name = "CaposalaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CaposalaForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this._prenotazioniPanel.ResumeLayout(false);
            this._prenotazioniPanel.PerformLayout();
            this._tavoliPanel.ResumeLayout(false);
            this._tavoliPanel.PerformLayout();
            this._tavoliContextMenuStrip.ResumeLayout(false);
            this._prenotazioniContextMenuStrip.ResumeLayout(false);
            this._insertPrenotazioneMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _prenotazioniPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _tavoliPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView _prenotazioniListView;
        private System.Windows.Forms.ListView _tavoliListView;
        private System.Windows.Forms.ContextMenuStrip _tavoliContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem occupaTavoloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liberaTavoloToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _prenotazioniContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modificaPrenotazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaPrenotazioneToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _insertPrenotazioneMenu;
        private System.Windows.Forms.ToolStripMenuItem inserisciNuovaPrenotazioneToolStripMenuItem;
    }
}