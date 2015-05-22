﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique
{
	public partial class FrmReflexiviteDynamique : Form
	{
		private const string NAMESPACE = "ReflexiviteDynamique.Classes";


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
					.Where(t => t.IsClass && t.Namespace == NAMESPACE)
					.ToList();
		}


		private Type GetType(string name)
		{
			return Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(u => u.IsClass && u.Namespace == NAMESPACE && u.Name == name);
		}


		private void CbClasses_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(CbClasses.SelectedItem.ToString()))
				UcConstructeurs.Display(GetType(CbClasses.SelectedItem.ToString()));
		}
	}
}
