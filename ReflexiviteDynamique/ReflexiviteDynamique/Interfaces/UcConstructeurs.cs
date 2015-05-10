using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class UcConstructeurs : UserControl
	{
		public event EventHandler ObjetConstruit;
		private ConstructorInfo ci = null;

		public UcConstructeurs()
		{
			InitializeComponent();
		}


		public void Init()
		{
			LbConstructeurs.DataSource = null;
			BtnConstruire.Enabled = false;
		}


		public void Display(Type t)
		{
			LbConstructeurs.DataSource = t.GetConstructors();
		}


		private void LbConstructeurs_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LbConstructeurs.SelectedItems.Count > 0)
			{
				ci = (ConstructorInfo)LbConstructeurs.SelectedItem;
				BtnConstruire.Enabled = ci.GetParameters().Length == 0;		// On ne veut que le constructeur par défaut
			}
		}


		private void BtnConstruire_Click(object sender, EventArgs e)
		{
			ci.Invoke(ci.GetParameters());

			if (ObjetConstruit != null)
				ObjetConstruit(this, e);
		}
	}
}
