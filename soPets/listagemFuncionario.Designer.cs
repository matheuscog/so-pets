﻿namespace soPets
{
	partial class listagemFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listagemFuncionario));
			this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFuncionarios
			// 
			this.dgvFuncionarios.AllowUserToAddRows = false;
			this.dgvFuncionarios.AllowUserToDeleteRows = false;
			this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFuncionarios.Location = new System.Drawing.Point(0, 0);
			this.dgvFuncionarios.Name = "dgvFuncionarios";
			this.dgvFuncionarios.ReadOnly = true;
			this.dgvFuncionarios.Size = new System.Drawing.Size(765, 522);
			this.dgvFuncionarios.TabIndex = 1;
			// 
			// listagemFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(765, 522);
			this.Controls.Add(this.dgvFuncionarios);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "listagemFuncionario";
			this.Text = "listagemFuncionario";
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFuncionarios;
	}
}