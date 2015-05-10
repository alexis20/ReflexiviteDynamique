using System;
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
				BtnConstruire.Enabled = ci.GetParameters().Length == 0;		// On ne veut que le constructeur par défaut
			}
		}


		private void BtnConstruire_Click(object sender, EventArgs e)
		{
			UcMethodes.Display(type, ci.Invoke(ci.GetParameters()));
		}
	}
}
