/*
 * Сделано в SharpDevelop.
 * Пользователь: Вадим
 * Дата: 19.06.2014
 * Время: 21:32
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Windows.Forms;

namespace Survival_on_island
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
		//	Application.Run(new Enter());
            //    Application.Run(new CreatePers(null));
            Application.Run(new Island());
		}
		
	}
}
