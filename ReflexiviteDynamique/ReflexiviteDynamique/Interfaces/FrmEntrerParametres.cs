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

			Height = FlpMain.Height + FlpBottom.Height;
		}


		private FlowLayoutPanel GetFlowLayoutPanel(ParameterInfo pi)
		{
			FlowLayoutPanel flp = new FlowLayoutPanel();
			flp.AutoSize = true;
			flp.Controls.Add(GetLabel(pi));

			switch (pi.ParameterType.Name)
			{
				case "Boolean":
					flp.Controls.Add(GetCheckBox());
					break;
				case "DateTime":
					flp.Controls.Add(GetDateTimePicker());
					break;
				default:
					flp.Controls.Add(GetTextBox());
					break;
			}

			return flp;
		}


		private Label GetLabel(ParameterInfo pi)
		{
			Label lbl = new Label();
			lbl.Text = pi.Name + ":";
			lbl.AutoSize = true;
			lbl.Padding = new Padding(0, 5, 0, 0);
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
			dtp.Format = DateTimePickerFormat.Short;
			dtp.Width = 93;
			return dtp;
		}


		private CheckBox GetCheckBox()
		{
			CheckBox chk = new CheckBox();
			chk.FlatStyle = FlatStyle.Flat;
			chk.Padding = new Padding(0, 0, 0, 3);
			return chk;
		}
	}
}
