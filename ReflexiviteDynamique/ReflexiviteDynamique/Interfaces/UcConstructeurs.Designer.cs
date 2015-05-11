namespace ReflexiviteDynamique
{
	partial class UcConstructeurs
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
            this.UcMethodes = new ReflexiviteDynamique.UcMethodes();
            this.BtnConstruire = new System.Windows.Forms.Button();
            this.LbConstructeurs = new System.Windows.Forms.ListBox();
            this.LblConstructeurs = new System.Windows.Forms.Label();
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // UcMethodes
            // 
            this.UcMethodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcMethodes.Location = new System.Drawing.Point(550, 3);
            this.UcMethodes.Name = "UcMethodes";
            this.TlpMain.SetRowSpan(this.UcMethodes, 3);
            this.UcMethodes.Size = new System.Drawing.Size(542, 658);
            this.UcMethodes.TabIndex = 3;
            // 
            // BtnConstruire
            // 
            this.BtnConstruire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConstruire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConstruire.Location = new System.Drawing.Point(3, 638);
            this.BtnConstruire.Name = "BtnConstruire";
            this.BtnConstruire.Size = new System.Drawing.Size(541, 23);
            this.BtnConstruire.TabIndex = 2;
            this.BtnConstruire.Text = "Construire Objet";
            this.BtnConstruire.UseVisualStyleBackColor = true;
            this.BtnConstruire.Click += new System.EventHandler(this.BtnConstruire_Click);
            // 
            // LbConstructeurs
            // 
            this.LbConstructeurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbConstructeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConstructeurs.FormattingEnabled = true;
            this.LbConstructeurs.Location = new System.Drawing.Point(3, 23);
            this.LbConstructeurs.Name = "LbConstructeurs";
            this.LbConstructeurs.Size = new System.Drawing.Size(541, 609);
            this.LbConstructeurs.TabIndex = 1;
            this.LbConstructeurs.SelectedIndexChanged += new System.EventHandler(this.LbConstructeurs_SelectedIndexChanged);
            // 
            // LblConstructeurs
            // 
            this.LblConstructeurs.AutoSize = true;
            this.LblConstructeurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblConstructeurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConstructeurs.Location = new System.Drawing.Point(3, 0);
            this.LblConstructeurs.Name = "LblConstructeurs";
            this.LblConstructeurs.Size = new System.Drawing.Size(541, 20);
            this.LblConstructeurs.TabIndex = 0;
            this.LblConstructeurs.Text = "CONSTRUCTEURS";
            this.LblConstructeurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 2;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Controls.Add(this.LblConstructeurs, 0, 0);
            this.TlpMain.Controls.Add(this.LbConstructeurs, 0, 1);
            this.TlpMain.Controls.Add(this.BtnConstruire, 0, 2);
            this.TlpMain.Controls.Add(this.UcMethodes, 1, 0);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 4;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.Size = new System.Drawing.Size(1095, 684);
            this.TlpMain.TabIndex = 0;
            // 
            // UcConstructeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpMain);
            this.Name = "UcConstructeurs";
            this.Size = new System.Drawing.Size(1095, 684);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private UcMethodes UcMethodes;
        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblConstructeurs;
        private System.Windows.Forms.ListBox LbConstructeurs;
        private System.Windows.Forms.Button BtnConstruire;
    }
}
