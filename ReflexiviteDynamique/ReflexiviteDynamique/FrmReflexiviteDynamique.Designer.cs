namespace ReflexiviteDynamique
{
	partial class FrmReflexiviteDynamique
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
			this.PnlMain = new System.Windows.Forms.Panel();
			this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.PnlClasse = new System.Windows.Forms.Panel();
			this.LblClasse = new System.Windows.Forms.Label();
			this.PnlMain.SuspendLayout();
			this.TlpMain.SuspendLayout();
			this.PnlClasse.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlMain
			// 
			this.PnlMain.BackColor = System.Drawing.Color.White;
			this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PnlMain.Controls.Add(this.TlpMain);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(10, 10);
			this.PnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Padding = new System.Windows.Forms.Padding(10);
			this.PnlMain.Size = new System.Drawing.Size(863, 483);
			this.PnlMain.TabIndex = 0;
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 2;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpMain.Controls.Add(this.PnlClasse, 0, 0);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(10, 10);
			this.TlpMain.Margin = new System.Windows.Forms.Padding(0);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 2;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Size = new System.Drawing.Size(841, 461);
			this.TlpMain.TabIndex = 0;
			// 
			// PnlClasse
			// 
			this.PnlClasse.Controls.Add(this.LblClasse);
			this.PnlClasse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlClasse.Location = new System.Drawing.Point(0, 0);
			this.PnlClasse.Margin = new System.Windows.Forms.Padding(0);
			this.PnlClasse.Name = "PnlClasse";
			this.PnlClasse.Size = new System.Drawing.Size(420, 22);
			this.PnlClasse.TabIndex = 0;
			// 
			// LblClasse
			// 
			this.LblClasse.AutoSize = true;
			this.LblClasse.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblClasse.Location = new System.Drawing.Point(0, 0);
			this.LblClasse.Name = "LblClasse";
			this.LblClasse.Size = new System.Drawing.Size(41, 13);
			this.LblClasse.TabIndex = 0;
			this.LblClasse.Text = "Classe:";
			this.LblClasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmReflexiviteDynamique
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 503);
			this.Controls.Add(this.PnlMain);
			this.Name = "FrmReflexiviteDynamique";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "Réflexivité Dynamique";
			this.PnlMain.ResumeLayout(false);
			this.TlpMain.ResumeLayout(false);
			this.PnlClasse.ResumeLayout(false);
			this.PnlClasse.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.Panel PnlClasse;
		private System.Windows.Forms.Label LblClasse;
	}
}

