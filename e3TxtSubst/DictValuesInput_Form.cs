using System;
using System.Drawing;
using System.Windows.Forms;

namespace e3TxtSubst
{
	/// <summary>
	/// Форма для ввода значений словаря замены
	/// </summary>
	public partial class DictValuesInput_Form : Form
	{
		public DictValuesInput_Form()
		{
			InitializeComponent();
		}
		
		public string CurrentValue { get { return txtCurValue.Text; } }
		public string NewValue { get { return txtNewValue.Text; } }
		
		void BtOkClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}		
		void BtCancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
