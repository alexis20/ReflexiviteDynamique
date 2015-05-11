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
			this.FlpClasse = new System.Windows.Forms.FlowLayoutPanel();
			this.LblClasse = new System.Windows.Forms.Label();
			this.CbClasses = new System.Windows.Forms.ComboBox();
			this.UcConstructeurs = new ReflexiviteDynamique.UcConstructeurs();
			this.PnlMain.SuspendLayout();
			this.TlpMain.SuspendLayout();
			this.FlpClasse.SuspendLayout();
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
			this.PnlMain.Size = new System.Drawing.Size(864, 492);
			this.PnlMain.TabIndex = 0;
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 1;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpMain.Controls.Add(this.FlpClasse, 0, 0);
			this.TlpMain.Controls.Add(this.UcConstructeurs, 0, 1);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(10, 10);
			this.TlpMain.Margin = new System.Windows.Forms.Padding(0);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 2;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Size = new System.Drawing.Size(842, 470);
			this.TlpMain.TabIndex = 0;
			// 
			// FlpClasse
			// 
			this.FlpClasse.Controls.Add(this.LblClasse);
			this.FlpClasse.Controls.Add(this.CbClasses);
			this.FlpClasse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpClasse.Location = new System.Drawing.Point(0, 0);
			this.FlpClasse.Margin = new System.Windows.Forms.Padding(0);
			this.FlpClasse.Name = "FlpClasse";
			this.FlpClasse.Size = new System.Drawing.Size(842, 22);
			this.FlpClasse.TabIndex = 0;
			// 
			// LblClasse
			// 
			this.LblClasse.Location = new System.Drawing.Point(3, 0);
			this.LblClasse.Name = "LblClasse";
			this.LblClasse.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.LblClasse.Size = new System.Drawing.Size(46, 23);
			this.LblClasse.TabIndex = 0;
			this.LblClasse.Text = "Classe:";
			// 
			// CbClasses
			// 
			this.CbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CbClasses.FormattingEnabled = true;
			this.CbClasses.Location = new System.Drawing.Point(52, 0);
			this.CbClasses.Margin = new System.Windows.Forms.Padding(0);
			this.CbClasses.Name = "CbClasses";
			this.CbClasses.Size = new System.Drawing.Size(368, 21);
			this.CbClasses.TabIndex = 1;
			this.CbClasses.SelectedIndexChanged += new System.EventHandler(this.CbClasses_SelectedIndexChanged);
			// 
			// UcConstructeurs
			// 
			this.UcConstructeurs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcConstructeurs.Location = new System.Drawing.Point(3, 25);
			this.UcConstructeurs.Name = "UcConstructeurs";
			this.UcConstructeurs.Size = new System.Drawing.Size(836, 442);
			this.UcConstructeurs.TabIndex = 1;
			// 
			// FrmReflexiviteDynamique
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 512);
			this.Controls.Add(this.PnlMain);
			this.Name = "FrmReflexiviteDynamique";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Réflexivité Dynamique";
			this.Load += new System.EventHandler(this.FrmReflexiviteDynamique_Load);
			this.PnlMain.ResumeLayout(false);
			this.TlpMain.ResumeLayout(false);
			this.FlpClasse.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PnlMain;
		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.FlowLayoutPanel FlpClasse;
		private System.Windows.Forms.Label LblClasse;
		private System.Windows.Forms.ComboBox CbClasses;
		private UcConstructeurs UcConstructeurs;
	}
}

