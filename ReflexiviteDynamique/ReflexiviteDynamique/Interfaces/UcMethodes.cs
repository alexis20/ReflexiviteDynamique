using System;
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
            LbMethodes.DataSource = t.GetMethods();
		}

        public void AfficherBouton()
        {
            BtnExecuter.Enabled = true;
        }
	}
}
