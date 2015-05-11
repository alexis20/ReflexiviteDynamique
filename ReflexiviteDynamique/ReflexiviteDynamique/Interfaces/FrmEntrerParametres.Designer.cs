﻿namespace ReflexiviteDynamique.Interfaces
{
	partial class FrmEntrerParametres
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
			this.FlpBottom = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnAnnuler = new System.Windows.Forms.Button();
			this.BtnOk = new System.Windows.Forms.Button();
			this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.FlpBottom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// FlpBottom
			// 
			this.FlpBottom.Controls.Add(this.BtnAnnuler);
			this.FlpBottom.Controls.Add(this.BtnOk);
			this.FlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FlpBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.FlpBottom.Location = new System.Drawing.Point(10, 391);
			this.FlpBottom.Name = "FlpBottom";
			this.FlpBottom.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.FlpBottom.Size = new System.Drawing.Size(528, 38);
			this.FlpBottom.TabIndex = 1;
			// 
			// BtnAnnuler
			// 
			this.BtnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAnnuler.Location = new System.Drawing.Point(450, 13);
			this.BtnAnnuler.Name = "BtnAnnuler";
			this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
			this.BtnAnnuler.TabIndex = 0;
			this.BtnAnnuler.Text = "Annuler";
			this.BtnAnnuler.UseVisualStyleBackColor = true;
			// 
			// BtnOk
			// 
			this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnOk.Location = new System.Drawing.Point(369, 13);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "Ok";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// FlpMain
			// 
			this.FlpMain.AutoSize = true;
			this.FlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FlpMain.Location = new System.Drawing.Point(10, 10);
			this.FlpMain.Name = "FlpMain";
			this.FlpMain.Size = new System.Drawing.Size(528, 381);
			this.FlpMain.TabIndex = 2;
			// 
			// ErrorProvider
			// 
			this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.ErrorProvider.ContainerControl = this;
			// 
			// FrmEntrerParametres
			// 
			this.AcceptButton = this.BtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CancelButton = this.BtnAnnuler;
			this.ClientSize = new System.Drawing.Size(548, 439);
			this.Controls.Add(this.FlpMain);
			this.Controls.Add(this.FlpBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(200, 150);
			this.Name = "FrmEntrerParametres";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Entrer les paramètres";
			this.FlpBottom.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel FlpBottom;
		private System.Windows.Forms.Button BtnAnnuler;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.FlowLayoutPanel FlpMain;
		private System.Windows.Forms.ErrorProvider ErrorProvider;
	}
}