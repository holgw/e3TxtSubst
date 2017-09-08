/*
 * Сделано в SharpDevelop.
 * Пользователь: OHozhatelev
 * Дата: 28.07.17
 * Время: 7:56
 */
using System;
using System.Windows.Forms;

namespace e3TxtSubst
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
