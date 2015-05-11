using System;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique.Interfaces
{
	public partial class FrmEntrerParametres : Form
	{
		public FrmEntrerParametres()
		{
			InitializeComponent();
		}


		public FrmEntrerParametres(ParameterInfo[] parameters)
		{
			InitializeComponent();

			foreach (var pi in parameters)
			{
				
			}
		}


		private void GetLabel(ParameterInfo pi)
		{

		}


		private void GetTextBox()
		{

		}


		private void GetDateTimePicker()
		{

		}


		private void GetCheckBox()
		{

		}
	}
}
