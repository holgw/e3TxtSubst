using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using e3;

namespace e3TxtSubst
{
	/// <summary>
	/// Объектная модель
	/// </summary>
	public static class Global
	{
		public static Log Log = new Log();
	}
		
	public class Schema
	{
		public string 	FullFileName 	{ get; private set; } // Полный путь к файлу схемы
		public bool 	IsProcessed		{ get; private set; } // [Флаг] Файл обработан
		
		public string FilePath 	{ get { return Path.GetDirectoryName(this.FullFileName);} }
		public string FileName 	{ get { return Path.GetFileName(this.FullFileName);} }
		
		public Schema(string fullPath)
		{
			// 0. Убедимся, что файл существует
			if (File.Exists(fullPath) == false)
				throw new Exception("Файл не существует");
			
			// 1. Убедимся, что файл имеет расширение e3s
			string ext = Path.GetExtension(fullPath); 
			if (ext != ".e3s")
				throw new Exception("Некорректный формат файла: " + ext);
			
			// 2. Пропишем полный путь к схеме
			this.FullFileName = fullPath;
		}
		
		/// <summary>
		/// Загрузка из файла схемы всех необходимых объектов - текстовых и символьных объектов
		/// </summary>
		public void ReplaceText(e3Application app, Dictionary<string, string> substDict)
		{
			// 0. Инициализируем все необходимые объекты для работы с проектом
			e3Job job = (e3Job)app.CreateJobObject();
			e3Sheet sht = (e3Sheet)job.CreateSheetObject();
			e3Text txt = (e3Text)job.CreateTextObject();
			e3Symbol sym = (e3Symbol)job.CreateSymbolObject();
			
			// 1. Откроем проект
			Global.Log.Write("################################################");
			Global.Log.Write("Приступаем к обработке файла: " + this.FullFileName);			
			int openRes = job.Open(this.FullFileName);
			Global.Log.Write("Файл открыт: " + (openRes != 0).ToString());
			
			// 1.1 Выкинем исключение, если файл не удалось открыть
			if (openRes == 0)
				throw new Exception("Не удалось открыть файл: " + this.FullFileName);
			
			// 2. Пройдемся перебором по всем листам проекта
			dynamic ShtIds = null;
			int nshts = job.GetSheetIds(ref ShtIds);
			Global.Log.Write("Кол-во листов: " + nshts);
			
			foreach(var sid in ShtIds)
			{				
				// 2.1 Дропнем пустые id листа
				if (sid == null)
					continue;
				
				// 2.2 Подключимся к листу
				sht.SetId(sid);
			
				// 2.3 Получим все текстовые объекты на текущем листе и пройдемся по ним перебором
				dynamic TxtIds = null;
				int ntxt = sht.GetGraphIds(ref TxtIds);
				foreach(var tid in TxtIds)
				{						
					/* 2.3.1 Подключимся к текстовому объекту, получим его текстовое значение и пробуем
					 * произвести замену подстрок по словарю (если таковые там будут присутствовать) */
					txt.SetId(tid);
					
					string oldVal = txt.GetText(); // Зафиксируем старое значение					
					
					// 2.3.2 ПРоверим, содержит ли данная надпись символы для замены
					bool exec = false; // Флаг необходимости обработки данной надписи
					foreach (string key in substDict.Keys)
					{
						if (oldVal.Contains(key))
							exec = true;
					}

					if (exec)
					{
						string newVal = oldVal.ParallelReplace(substDict);	// Сформируем новое значение
						txt.SetText(newVal);								// Передадим новое значение в проект
						
						Global.Log.Write("Было: " + oldVal);
						Global.Log.Write("Стало: " + newVal);
					}
				}
				
				// 2.4 Аналогичным образом пройдемся по символам с текстом
				dynamic SymIds = null;
				int nsym = sht.GetSymbolIds(ref SymIds);
				foreach(var syid in SymIds)
				{					
					sym.SetId(syid);
					dynamic SymTxtIds = null;
					sym.GetTextIds(ref SymTxtIds);
					foreach(var sytid in SymTxtIds)
					{
						txt.SetId(sytid);
						
						string oldVal = txt.GetText(); // Зафиксируем старое значение					
						
						// 2.3.2 ПРоверим, содержит ли данная надпись символы для замены
						bool exec = false; // Флаг необходимости обработки данной надписи
						foreach (string key in substDict.Keys)
						{
							if (oldVal.Contains(key))
								exec = true;
						}
	
						if (exec)
						{
							string newVal = oldVal.ParallelReplace(substDict);	// Сформируем новое значение
							txt.SetText(newVal);								// Передадим новое значение в проект
							
							Global.Log.Write("Было: " + oldVal);
							Global.Log.Write("Стало: " + newVal);
						}
					}
				}
			}
			
			// 3. Пометим схему как обработанную
			this.IsProcessed = true;
			Global.Log.Write("################################################" + Environment.NewLine);

			// 4. Заключительные операции: сохранить, закрыть затереть объекты
			job.Save();
			job.Close();
			txt = null;
			sht = null;
			job = null;			
			app = null;				
		}
	}
	
	public class Log
	{
		public string Content { get; private set; }
		
		public void Write(string str)
		{
			this.Content += Environment.NewLine + str;
		}
		
		public void Clear()
		{
			this.Content = "";
		}
	}
	
	public static class Extensions
	{
		/// <summary>
		/// Алгоритм замены подстроки в строке. Отличается от REplace тем, что замена производится параллельно - подстрока 
		/// имплементированная конкретной итеацией не будет обрабатываться в следующей итерации
		/// </summary>
		/// <param name="source"> Исходная строка </param>
		/// <param name="dict"> Словарь замены </param>
		public static string ParallelReplace(this string source, Dictionary<string,string> dict)
		{		
			// TODO: научить алгоритм находить наиболее подходящую строку в словаре:
			// Пример: BCD > CD для строки ABCD
			
			// TODO: Распространить действие алгоритма на значения атрибутов (по опции)
			
			// TODO: Добавить поиск текста по значению среди надписей, символов и атрибутов
			
			if (dict.Count == 0)
				return source;
			
			var splits = source.Split(new string[] { dict.Keys.ElementAt(0) }, StringSplitOptions.None).ToList();
			
			// Сформируем новый словарь без первого значения
			var newDict = new Dictionary<string,string>();
			for (int i = 1; i < dict.Count; i++) 
			{
				newDict.Add(dict.Keys.ElementAt(i), dict.Values.ElementAt(i));
			}
			
			string ret = "";
			
			if (dict.Count == 1)
				ret = source.Replace(dict.Keys.ElementAt(0), dict.Values.ElementAt(0));
			else
			{
				for (int i = 0; i < splits.Count; i++) 
				{
					ret += splits[i].ParallelReplace(newDict);
					if (i < splits.Count - 1)
						ret += dict.Values.ElementAt(0);
				}	
			}
							
			return ret;
		}		
	}
}
