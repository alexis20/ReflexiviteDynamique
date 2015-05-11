namespace ReflexiviteDynamique
{
	partial class UcMethodes
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
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.LblMethodes = new System.Windows.Forms.Label();
            this.LbMethodes = new System.Windows.Forms.ListBox();
            this.BtnExecuter = new System.Windows.Forms.Button();
            this.lbReponse = new System.Windows.Forms.Label();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 1;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TlpMain.Controls.Add(this.LblMethodes, 0, 0);
            this.TlpMain.Controls.Add(this.LbMethodes, 0, 1);
            this.TlpMain.Controls.Add(this.BtnExecuter, 0, 2);
            this.TlpMain.Controls.Add(this.lbReponse, 0, 3);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 4;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.Size = new System.Drawing.Size(701, 567);
            this.TlpMain.TabIndex = 1;
            // 
            // LblMethodes
            // 
            this.LblMethodes.AutoSize = true;
            this.LblMethodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMethodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMethodes.Location = new System.Drawing.Point(3, 0);
            this.LblMethodes.Name = "LblMethodes";
            this.LblMethodes.Size = new System.Drawing.Size(695, 20);
            this.LblMethodes.TabIndex = 0;
            this.LblMethodes.Text = "MÉTHODES";
            this.LblMethodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbMethodes
            // 
            this.LbMethodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbMethodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMethodes.FormattingEnabled = true;
            this.LbMethodes.Location = new System.Drawing.Point(3, 23);
            this.LbMethodes.Name = "LbMethodes";
            this.LbMethodes.Size = new System.Drawing.Size(695, 492);
            this.LbMethodes.TabIndex = 1;
            this.LbMethodes.SelectedIndexChanged += new System.EventHandler(this.LbMethodes_SelectedIndexChanged);
            // 
            // BtnExecuter
            // 
            this.BtnExecuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExecuter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExecuter.Location = new System.Drawing.Point(3, 521);
            this.BtnExecuter.Name = "BtnExecuter";
            this.BtnExecuter.Size = new System.Drawing.Size(695, 23);
            this.BtnExecuter.TabIndex = 2;
            this.BtnExecuter.Text = "Exécuter";
            this.BtnExecuter.UseVisualStyleBackColor = true;
            this.BtnExecuter.Click += new System.EventHandler(this.BtnExecuter_Click);
            // 
            // lbReponse
            // 
            this.lbReponse.AutoSize = true;
            this.lbReponse.Location = new System.Drawing.Point(3, 547);
            this.lbReponse.Name = "lbReponse";
            this.lbReponse.Size = new System.Drawing.Size(0, 13);
            this.lbReponse.TabIndex = 3;
            // 
            // UcMethodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TlpMain);
            this.Name = "UcMethodes";
            this.Size = new System.Drawing.Size(701, 567);
            this.TlpMain.ResumeLayout(false);
            this.TlpMain.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.Label LblMethodes;
		private System.Windows.Forms.ListBox LbMethodes;
		private System.Windows.Forms.Button BtnExecuter;
        private System.Windows.Forms.Label lbReponse;
    }
}
