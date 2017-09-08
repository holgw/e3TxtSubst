using System;
using System.Drawing;
using System.Windows.Forms;

namespace e3TxtSubst
{
	/// <summary>
	/// Форма для группового ввода записей словаря (ввиде одной строки для последующего парсинга)
	/// </summary>
	public partial class DictionaryMultipleInput_Form : Form
	{
		public DictionaryMultipleInput_Form()
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
