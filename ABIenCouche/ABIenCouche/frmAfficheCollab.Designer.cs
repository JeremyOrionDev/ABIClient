﻿namespace ABIenCouche
{
    partial class frmAfficheCollab
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
            this.dgContrats = new System.Windows.Forms.DataGridView();
            this.btnSupprimerContrat = new System.Windows.Forms.Button();
            this.btnAjouterContrat = new System.Windows.Forms.Button();
            this.panelContrat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).BeginInit();
            this.panelContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgContrats
            // 
            this.dgContrats.AllowUserToAddRows = false;
            this.dgContrats.AllowUserToDeleteRows = false;
            this.dgContrats.AllowUserToResizeColumns = false;
            this.dgContrats.AllowUserToResizeRows = false;
            this.dgContrats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgContrats.Location = new System.Drawing.Point(12, 17);
            this.dgContrats.MultiSelect = false;
            this.dgContrats.Name = "dgContrats";
            this.dgContrats.ReadOnly = true;
            this.dgContrats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgContrats.RowTemplate.Height = 24;
            this.dgContrats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContrats.ShowEditingIcon = false;
            this.dgContrats.Size = new System.Drawing.Size(470, 299);
            this.dgContrats.TabIndex = 22;
            // 
            // btnSupprimerContrat
            // 
            this.btnSupprimerContrat.AutoSize = true;
            this.btnSupprimerContrat.Location = new System.Drawing.Point(132, 330);
            this.btnSupprimerContrat.Name = "btnSupprimerContrat";
            this.btnSupprimerContrat.Size = new System.Drawing.Size(131, 27);
            this.btnSupprimerContrat.TabIndex = 24;
            this.btnSupprimerContrat.Text = "Supprimer contrat";
            this.btnSupprimerContrat.UseVisualStyleBackColor = true;
            // 
            // btnAjouterContrat
            // 
            this.btnAjouterContrat.AutoSize = true;
            this.btnAjouterContrat.Location = new System.Drawing.Point(13, 330);
            this.btnAjouterContrat.Name = "btnAjouterContrat";
            this.btnAjouterContrat.Size = new System.Drawing.Size(113, 27);
            this.btnAjouterContrat.TabIndex = 23;
            this.btnAjouterContrat.Text = "Ajouter Contrat";
            this.btnAjouterContrat.UseVisualStyleBackColor = true;
            // 
            // panelContrat
            // 
            this.panelContrat.Controls.Add(this.dgContrats);
            this.panelContrat.Controls.Add(this.btnSupprimerContrat);
            this.panelContrat.Controls.Add(this.btnAjouterContrat);
            this.panelContrat.Location = new System.Drawing.Point(362, 12);
            this.panelContrat.Name = "panelContrat";
            this.panelContrat.Size = new System.Drawing.Size(496, 373);
            this.panelContrat.TabIndex = 25;
            // 
            // frmAfficheCollab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(861, 587);
            this.Controls.Add(this.panelContrat);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAfficheCollab";
            this.Text = "frmAfficheCollab";
            this.Controls.SetChildIndex(this.panelContrat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).EndInit();
            this.panelContrat.ResumeLayout(false);
            this.panelContrat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnAjouterContrat;
        internal System.Windows.Forms.Panel panelContrat;
        internal System.Windows.Forms.DataGridView dgContrats;
        internal System.Windows.Forms.Button btnSupprimerContrat;
    }
}