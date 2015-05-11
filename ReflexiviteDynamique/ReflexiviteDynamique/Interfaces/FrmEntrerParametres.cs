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


		private Label GetLabel(ParameterInfo pi)
		{
			Label lbl = new Label();
			lbl.Text = pi.Name + ":";
			lbl.AutoSize = true;
			return lbl;
		}


		private TextBox GetTextBox()
		{
			TextBox txt = new TextBox();
			return txt;
		}


		private DateTimePicker GetDateTimePicker()
		{
			DateTimePicker dtp = new DateTimePicker();
			return dtp;
		}


		private CheckBox GetCheckBox()
		{
			CheckBox chk = new CheckBox();
			return chk;
		}
	}
}
