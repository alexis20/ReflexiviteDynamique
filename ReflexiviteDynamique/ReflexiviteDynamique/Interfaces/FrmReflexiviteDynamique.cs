﻿using System;
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
		}


		private void FrmReflexiviteDynamique_Load(object sender, EventArgs e)
		{
			var t = GetClasses();

			foreach (var item in t)
			{
				CbClasses.Items.Add(item.Name);
			}
		}


		static List<Type> GetClasses()
		{
			return Assembly.GetExecutingAssembly().GetTypes()
					.Where(t => t.IsClass && t.Namespace == "ReflexiviteDynamique.Classes")
					.ToList();
		}


		private void CbClasses_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
