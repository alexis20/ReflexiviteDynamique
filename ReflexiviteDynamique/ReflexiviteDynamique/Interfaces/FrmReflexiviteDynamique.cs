using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class FrmReflexiviteDynamique : Form
	{
		private Type type = null;


		public FrmReflexiviteDynamique()
		{
			InitializeComponent();
		}


		private void FrmReflexiviteDynamique_Load(object sender, EventArgs e)
		{
			var t = GetClasses();

			foreach (var item in t)
			{
				CbClasses.Items.Add(item.Name);
			}

			UcConstructeurs.Init();
		}


		List<Type> GetClasses()
		{
			return Assembly.GetExecutingAssembly().GetTypes()
					.Where(t => t.IsClass && t.Namespace == "ReflexiviteDynamique.Classes")
					.ToList();
		}


		private Type GetType(string t)
		{
			return Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(u => u.IsClass && u.Namespace == "ReflexiviteDynamique.Classes" && u.Name == t);
		}


		private void CbClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(CbClasses.SelectedItem.ToString()))
			{
				type = GetType(CbClasses.SelectedItem.ToString());
				UcConstructeurs.Display(type);
			}
		}


		private void UcConstructeurs_ObjetConstruit(object sender, EventArgs e)
		{
			UcMethodes.Display(type);
		}
	}
}
