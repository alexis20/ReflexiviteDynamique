using System;
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
				BtnExecuter.Enabled = mi.GetParameters().Length == 0;	// On ne veut que les méthodes n'ayant aucun paramètre
			}
		}


		private void BtnExecuter_Click(object sender, EventArgs e)
		{
			mi.Invoke(instance, null);
		}
	}
}
