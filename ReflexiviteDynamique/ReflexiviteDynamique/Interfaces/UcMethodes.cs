﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class UcMethodes : UserControl
	{
		private MethodInfo mi = null;
		private object instance = null;
	

		public UcMethodes()
		{
			InitializeComponent();
		}


		public void Init()
		{
			LbMethodes.DataSource = null;
			BtnExecuter.Enabled = false;
		}


		public void Display<T>(Type t, T classe)
		{
			instance = classe;
			LbMethodes.DataSource = t.GetMethods(BindingFlags.Instance | BindingFlags.Public);
		}


		private void LbMethodes_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnExecuter.Enabled = false;

			if (LbMethodes.SelectedItems.Count > 0)
			{
				mi = (MethodInfo)LbMethodes.SelectedItem;
                BtnExecuter.Enabled = true;

                if (mi.GetParameters().Length == 0)
                    BtnExecuter.Text = "Exécuter";
                else
                    BtnExecuter.Text = "Entrez les paramètres pour exécuter";
            }
		}


		private void BtnExecuter_Click(object sender, EventArgs e)
		{
            if (mi.GetParameters().Length == 0)
            {
                var reponse = mi.Invoke(instance, null);
                if(reponse != null)
                    MessageBox.Show(reponse.ToString());
                else
                    MessageBox.Show("Fonction réussie");
            }
            else
            {
                Interfaces.FrmEntrerParametres form = new Interfaces.FrmEntrerParametres(mi.GetParameters());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var reponse = mi.Invoke(instance, form.objets);
                    if (reponse != null)
                        MessageBox.Show(reponse.ToString());
                    else
                        MessageBox.Show("Fonction réussie");

                }
            }
		}
	}
}
