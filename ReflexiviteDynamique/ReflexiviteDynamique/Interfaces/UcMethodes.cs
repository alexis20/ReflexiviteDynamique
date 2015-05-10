using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class UcMethodes : UserControl
	{
		public UcMethodes()
		{
			InitializeComponent();
		}


		public void Init()
		{
            LbMethodes.DataSource = null;
            BtnExecuter.Enabled = false;
        }


		public void Display(Type t)
		{
			LbMethodes.DataSource = t.GetMethods(BindingFlags.Instance | BindingFlags.Public);
		}

        public void AfficherBouton()
        {
            BtnExecuter.Enabled = true;
        }
	}
}
