﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class UcConstructeurs : UserControl
	{
		private ConstructorInfo ci = null;
		private Type type = null;


		public UcConstructeurs()
		{
			InitializeComponent();
		}


		public void Init()
		{
			LbConstructeurs.DataSource = null;
			BtnConstruire.Enabled = false;

			UcMethodes.Init();
		}


		public void Display(Type t)
		{
			type = t;
			LbConstructeurs.DataSource = t.GetConstructors();
		}


		private void LbConstructeurs_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnConstruire.Enabled = false;	

			if (LbConstructeurs.SelectedItems.Count > 0)
			{
				ci = (ConstructorInfo)LbConstructeurs.SelectedItem;
				BtnConstruire.Enabled = true;

                if (ci.GetParameters().Length == 0)
                    BtnConstruire.Text = "Construire Objet";
                else
                    BtnConstruire.Text = "Entrez les paramètres pour construire l'objet";
			}
		}


		private void BtnConstruire_Click(object sender, EventArgs e)
		{
            if (ci.GetParameters().Length == 0)
            {
                UcMethodes.Display(type, ci.Invoke(ci.GetParameters()));
                MessageBox.Show("L'objet a été construit");
            }
            else
            {
                Interfaces.FrmEntrerParametres form = new Interfaces.FrmEntrerParametres(ci.GetParameters());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UcMethodes.Display(type, ci.Invoke(form.objets));
                    MessageBox.Show("L'objet a été construit");
                }

            }
		}
	}
}
