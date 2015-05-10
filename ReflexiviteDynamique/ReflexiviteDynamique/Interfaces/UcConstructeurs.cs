﻿using System;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class UcConstructeurs : UserControl
	{
		public UcConstructeurs()
		{
			InitializeComponent();
		}


		public void Init()
		{
			LbConstructeurs.DataSource = null;
			BtnConstruire.Visible = false;
		}


		public void Display(Type t)
		{
			LbConstructeurs.DataSource = t.GetConstructors();
		}


		private void LbConstructeurs_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnConstruire.Visible = LbConstructeurs.SelectedItems.Count > 0;
		}
	}
}
