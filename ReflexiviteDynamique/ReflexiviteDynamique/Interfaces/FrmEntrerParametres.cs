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
				FlpMain.Controls.Add(GetFlowLayoutPanel(pi));
			}
		}


		private FlowLayoutPanel GetFlowLayoutPanel(ParameterInfo pi)
		{
			var p = pi.ParameterType.Name;

			FlowLayoutPanel flp = new FlowLayoutPanel();
			flp.AutoSize = true;
			flp.Controls.Add(GetLabel(pi));

			switch (pi.ParameterType.Name)
			{
				case "Int32":
					break;
			}

			return flp;
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
			txt.Font = new System.Drawing.Font(txt.Font, System.Drawing.FontStyle.Bold);
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
			chk.FlatStyle = FlatStyle.Flat;
			return chk;
		}
	}
}
