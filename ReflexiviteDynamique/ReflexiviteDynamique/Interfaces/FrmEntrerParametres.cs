using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ReflexiviteDynamique.Interfaces
{
	public partial class FrmEntrerParametres : Form
	{
		public object[] ParametersInfo;


		public FrmEntrerParametres()
		{
			InitializeComponent();
		}


		public FrmEntrerParametres(ParameterInfo[] parameters)
		{
			InitializeComponent();

			ParametersInfo = parameters;

			foreach (var pi in parameters)
				FlpMain.Controls.Add(GetFlowLayoutPanel(pi));

			Height = FlpMain.Height + FlpBottom.Height;
		}


		private void BtnOk_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < ParametersInfo.Length; ++i)
			{
				ParameterInfo pi = (ParameterInfo)ParametersInfo[i];
				Control[] ctrl = Controls.Find(pi.Name, true);

				if (ctrl[0] is CheckBox)
				{

				}
				else if (ctrl[0] is DateTimePicker)
				{

				}
				else
				{

				}
			}

			DialogResult = DialogResult.OK;
		}


		private FlowLayoutPanel GetFlowLayoutPanel(ParameterInfo pi)
		{
			FlowLayoutPanel flp = new FlowLayoutPanel();
			flp.AutoSize = true;
			flp.Controls.Add(GetLabel(pi));

			switch (pi.ParameterType.Name)
			{
				case "Boolean":
					flp.Controls.Add(GetCheckBox(pi));
					break;
				case "DateTime":
					flp.Controls.Add(GetDateTimePicker(pi));
					break;
				default:
					flp.Controls.Add(GetTextBox(pi));
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


		private TextBox GetTextBox(ParameterInfo pi)
		{
			TextBox txt = new TextBox();
			txt.Font = new System.Drawing.Font(txt.Font, System.Drawing.FontStyle.Bold);
			txt.Name = pi.Name;
			return txt;
		}


		private DateTimePicker GetDateTimePicker(ParameterInfo pi)
		{
			DateTimePicker dtp = new DateTimePicker();
			dtp.Format = DateTimePickerFormat.Short;
			dtp.Width = 93;
			dtp.Name = pi.Name;
			return dtp;
		}


		private CheckBox GetCheckBox(ParameterInfo pi)
		{
			CheckBox chk = new CheckBox();
			chk.FlatStyle = FlatStyle.Flat;
			chk.Padding = new Padding(0, 0, 0, 3);
			chk.Name = pi.Name;
			return chk;
		}
	}
}
