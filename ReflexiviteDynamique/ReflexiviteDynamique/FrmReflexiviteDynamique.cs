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
		public FrmReflexiviteDynamique()
		{
			InitializeComponent();
            LoadComboBox();
		}

        private void LoadComboBox()
        {
            var t = GetClasses();

            foreach (var item in t)
            {
                CbClasses.Items.Add(item);
            }
        }

        static List<Type> GetClasses()
        {
            var ClassList = from t in Assembly.GetExecutingAssembly().GetTypes() where t.IsClass && t.Namespace == "ReflexiviteDynamique" select t;
            return ClassList.ToList();
        }

        private void CbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
