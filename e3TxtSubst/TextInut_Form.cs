using System;
using System.Drawing;
using System.Windows.Forms;

namespace e3TxtSubst
{
	/// <summary>
	/// Просто диалоговая форма с текстовым полем для ввода
	/// </summary>
	public partial class TextInut_Form : Form
	{
		public TextInut_Form()
		{
			InitializeComponent();
		}
		
		public string Input { get { return txtInput.Text; } }
		
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
