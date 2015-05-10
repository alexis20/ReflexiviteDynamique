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
            MethodInfo [] metInfo = t.GetMethods();

            foreach (var item in metInfo)
            {
                if(item.IsPublic)
                    LbMethodes.Items.Add(item);
            }
		}

        public void AfficherBouton()
        {
            BtnExecuter.Enabled = true;
        }
	}
}
