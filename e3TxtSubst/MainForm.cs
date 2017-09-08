using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using e3;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace e3TxtSubst
{
	/// <summary>
	/// MAINFORM
	/// </summary>
	
	// VIEW
	public interface IView_Main
	{
		Schema 			CurrentSelectedSchema 		{ get; }
		ListViewItem 	CurrentSelectedSchemaItem 	{ get; }
		ListViewItem 	CurrenSelectedDictItem		{ get; }
		string 			ExePath 					{ get; }
		int 			AppTimeout 					{ get; }
		
		void AddNewSchemaItem(Schema schema);
 		void RemoveSchemaItem(ListViewItem item);
		void ClearSchemasList();
		
		void AddNewDict(string curVal, string newVal);
		void RemoveDictValue(ListViewItem item);
		void ClearDict();
		void SetExePath(string exePath);
		void SetTimeout(decimal timeout);
		void ShowLog(string log);
	}
	public partial class MainForm : Form, IView_Main
	{
		public Presenter_Main Presenter;
		
		public Schema CurrentSelectedSchema 
		{ 
			get 
			{ 
				if (listPathList.SelectedItems.Count == 0)
					return null;
				else
					return listPathList.SelectedItems[0].Tag as Schema;
			}
		}
		public ListViewItem CurrentSelectedSchemaItem 
		{ 
			get 
			{ 
				if (listPathList.SelectedItems.Count == 0)
					return null;
				else
					return listPathList.SelectedItems[0];
			}
		}
		public ListViewItem CurrenSelectedDictItem
		{
			get 
			{ 
				if (listDict.SelectedItems.Count == 0)
					return null;
				else
					return listDict.SelectedItems[0];
			}
		}
		public string ExePath { get { return txtExePath.Text; } }
		public int AppTimeout { get { return Convert.ToInt16(nudTimeOut.Value); } }
		
		public MainForm()
		{
			InitializeComponent();
			Init();
			Presenter = new Presenter_Main(this, new Model_Main());
		}
		private void Init()
		{
			ColumnHeader[] arrColumnsPath = new ColumnHeader[2]
			{
				new ColumnHeader() { Name = "FileName", Text = "Имя файла", },
				new ColumnHeader() { Name = "Path", Text = "Путь к файлу",  }
			};
			listPathList.Columns.AddRange(arrColumnsPath);
			listPathList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			
			ColumnHeader[] arrColumnsDict = new ColumnHeader[2]
			{
				new ColumnHeader() { Name = "CurValue", Text = "Текущее значение", },
				new ColumnHeader() { Name = "NewValue", Text = "Новое значение",  }
			};
			listDict.Columns.AddRange(arrColumnsDict);
			listDict.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}
		
		public void AddNewSchemaItem(Schema schema)
		{
			// 0. Cоздадим и добавим новый итем в ListView
			var newItem = new ListViewItem(new[] {schema.FileName, schema.FilePath});
			newItem.Tag = schema;
			
			// 1. Добавим новый итем в ListView
			this.listPathList.Items.Add(newItem);
			listPathList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}
		public void RemoveSchemaItem(ListViewItem item)
		{
			this.listPathList.Items.Remove(item);
		}
		public void ClearSchemasList()
		{
			this.listPathList.Items.Clear();
		}
		public void AddNewDict(string curVal, string newVal)
		{
			// 0. Cоздадим и добавим новый итем в ListView
			var newItem = new ListViewItem(new[] { curVal, newVal });
			newItem.Tag = curVal; // KEY
			
			// 1. Добавим новый итем в ListView
			this.listDict.Items.Add(newItem);
		}
		public void RemoveDictValue(ListViewItem item)
		{
			listDict.Items.Remove(item);
		}
		public void ClearDict()
		{
			listDict.Items.Clear();
		}
		public void SetExePath(string exePath)
		{
			txtExePath.Text = exePath;
		}
		public void SetTimeout(decimal timeout)
		{
			nudTimeOut.Value = timeout;
		}
		public void ShowLog(string log)
		{
			txtLog.Text = log;
		}
					
		// ### PRIVATE #######################################
		// Панель работы со списком схем
		void btAddSchema_Click(object sender, EventArgs e)
		{
			Presenter.AddNewSchema();
		}		
		void btRemoveSchema_Click(object sender, EventArgs e)
		{
			Presenter.RemoveSchema();
		}		
		void BtAddAllSchemasFolderClick(object sender, EventArgs e)
		{
			Presenter.AddAllSchemasInFolder();
		}
		void BtClearSchemasClick(object sender, EventArgs e)
		{
			Presenter.ClearSchemas();
		}
				
		// Панель работы со словарем
		void btAddDictValue_Click(object sender, EventArgs e)
		{
			Presenter.AddNewDictValue();
		}		
		void BtRemoveDictValueClick(object sender, EventArgs e)
		{
			Presenter.RemoveDictValue();
		}
		void BtClearDictClick(object sender, EventArgs e)
		{
			Presenter.ClearDict();
		}
		void BtManualInputClick(object sender, EventArgs e)
		{
			Presenter.FillDictManually();
		}
		
		// Путь к исполняемому файлу e3Series
		void BtSavePathClick(object sender, EventArgs e)
		{
			Presenter.ChangeDefaultExePath();
		}
		
		// Задержка запуска исполняемого файла
		void BtSaveDefaultTimeout_Click(object sender, EventArgs e)
		{
			Presenter.ChangeDefault_AppTimeout();
		}
		
		void BtExecuteClick(object sender, EventArgs e)
		{
			Presenter.Execute();
		}
	}
	
	// MODEL
	public interface IModel_Main
	{
		ReadOnlyCollection<Schema> 	SchemasList 		{ get; }
		Dictionary<string, string> 	SubstDictionary 	{ get; }
		string 						ExePath				{ get; }
		int							AppTimeout			{ get; }
		
		Schema AddSchema(string fullPath);
		void RemoveSchema(Schema schema);
		List<Schema> AddAllSchemasInFolder(string dir);
		void ClearSchemas();
		
		void AddNewDictValue(string curVal, string newVal);
		void RemoveDictValue(string key);
		void ClearDict();
		
		void SetExePath(string exePath);
		void ChangeDefaultExePath(string newPath);
		
		void SetTimeout(int timeout);
		void ChangeDefaultTimeout(int timeout);
		
		void ExecuteAll();
	}
	public class Model_Main : IModel_Main
	{
		List<Schema> _schemasList = new List<Schema>();
		
		public ReadOnlyCollection<Schema> 	SchemasList 		{ get { return _schemasList.AsReadOnly(); } }
		public Dictionary<string, string> 	SubstDictionary 	{ get; private set; }
		public string 						ExePath				{ get; private set; }
		public int							AppTimeout			{ get; private set; } 
		
		public Model_Main()
		{
			SubstDictionary = new Dictionary<string, string>();
		}
		
		/// <summary>
		/// Добавить новую схему в коллекцию
		/// </summary>
		/// <param name="fullPath"> Полный путь к схеме </param>
		public Schema AddSchema(string fullPath)
		{
			var newSchema = new Schema(fullPath);
			_schemasList.Add(newSchema);
			return newSchema;
		}
		
		/// <summary>
		/// Удалить существующую схему из коллекции
		/// </summary>
		/// <param name="schema"> Ссылка на объект </param>
		public void RemoveSchema(Schema schema)
		{
			_schemasList.Remove(schema);
		}
		
		/// <summary>
		/// Добавить все файлы e3s в директории (и во всех вложенных директориях)
		/// </summary>
		public List<Schema> AddAllSchemasInFolder(string dir)
		{
			var ret = new List<Schema>();
			
			string[] files = Directory.GetFiles(dir, "*.e3s", SearchOption.AllDirectories);
			foreach (string fname in files)
			{
				var newSchema = this.AddSchema(fname); 	// Сформируем новый объект 
				ret.Add(newSchema);						// Добавим новую схему в коллекцию
			}
			
			return ret;
		}
		
		/// <summary>
		/// Очистить весь список схем
		/// </summary>
		public void ClearSchemas()
		{
			_schemasList.Clear();
		}
		
		/// <summary>
		/// Добавить новую пару значений в словарь замены
		/// </summary>
		public void AddNewDictValue(string curVal, string newVal)
		{
			this.SubstDictionary.Add(curVal, newVal);
		}
		
		/// <summary>
		/// Удаление пары значений из словаря по ключу
		/// </summary>
		public void RemoveDictValue(string key)
		{
			this.SubstDictionary.Remove(key);
		}
		
		/// <summary>
		/// Очистить все записи словаря
		/// </summary>
		public void ClearDict()
		{
			this.SubstDictionary.Clear();
		}
		
		/// <summary>
		/// Назначить путь к исполняемому файлу e3Series
		/// </summary>
		public void SetExePath(string exePath)
		{
			this.ExePath = exePath;
		}
		public void ChangeDefaultExePath(string newPath)
		{
			Properties.Settings.Default.ExePath = newPath;
			Properties.Settings.Default.Save();
		}
		
		/// <summary>
		/// Установить задержку (в милисекундах) для запуска исполняемого файла e3series (перед подключением к объектной модели e3)
		/// </summary>
		public void SetTimeout(int timeout)
		{
			this.AppTimeout = timeout;
		}
		public void ChangeDefaultTimeout(int timeout)
		{
			Properties.Settings.Default.ProcStartTimeout = timeout;
			Properties.Settings.Default.Save();
		}
		
		public void ExecuteAll()
		{
			e3Application app = ConnectToE3();
			
			// Обработаем все файлы по очереди
			foreach (Schema schema in SchemasList)
				schema.ReplaceText(app, this.SubstDictionary);
			
			//Закроем e3 и удалим объекты
			app.Quit();
			app = null;
			GC.Collect();
		}
		
		/// <summary>
		/// Запускает новый экземпляр E3 и возвращает ссылку на него
		/// </summary>
		private e3Application ConnectToE3()
		{
			// Объекты для работы E3
			e3Application app = null;
			e3Job job = null;
			
			//Запустим новый процесс E3
    		var newProcess = System.Diagnostics.Process.Start(this.ExePath, @"/schema");
    		newProcess.WaitForInputIdle();
        	Thread.Sleep(this.AppTimeout);
			
        	//Найдем процесс E3 в котором нет открытых проектов
			List<Process> e3Procs = Process.GetProcessesByName("E3.series").ToList();
			dynamic disp = System.Activator.CreateInstance(Type.GetTypeFromProgID("CT.Dispatcher"));
			foreach(var proc in e3Procs)
			{
				// Подключимся к процессу
				app = (e3Application)disp.GetE3ByProcessId(proc.Id);
				job = (e3Job)app.CreateJobObject();
				dynamic PrjIds = null;
				
				// Получим кол-во открытых проектов
				int prjcnt  = app.GetJobIds(ref PrjIds);
				
				// Если откртых проектов в окне нет, то можно его спокойно использовать => выйдем из цикла, 
				// оставив текущее подключение
				if (prjcnt == 0)
					break;
			}
			
			return app;
		}
	}
	
	// PRESENTER
	public class Presenter_Main
	{
		readonly IView_Main View;
		readonly IModel_Main Model;
		
		public Presenter_Main(IView_Main view, IModel_Main model)
		{
			this.View = view;
			this.Model = model;
			
			// Передадим в модель и отобразим путь к исполняемому файлу (из дефолтных настроек)
			Model.SetExePath(Properties.Settings.Default.ExePath);
			View.SetExePath(Properties.Settings.Default.ExePath);
			
			// Передадим в модель и отобразим задержку запуска исполняемого файла (из дефолтных настроек)
			Model.SetTimeout(Properties.Settings.Default.ProcStartTimeout);
			View.SetTimeout(Properties.Settings.Default.ProcStartTimeout);
		}
		
		// Работа с набором схем
		public void AddNewSchema()
		{
			// 0. Покажем пользователю форму с текстовым полем для ввода
			var ofd = new OpenFileDialog();
			ofd.Filter = "Файлы e3series (*.e3s) | *.e3s";
			ofd.Multiselect = true;
			ofd.ShowDialog();
			
			// 1. Дропнем выполнение, если пользователь не выбрал файлы
			if (ofd.FileNames.Count() == 0)
				return;
			
			// 2. Для каждого выбранного файла передадим значение в модель и создадим новый экземпляр схемы
			foreach (string fname in ofd.FileNames)
			{
				Schema newSchema = Model.AddSchema(fname);
				View.AddNewSchemaItem(newSchema);	
			}
		}
		public void RemoveSchema()
		{
			// Убедимся, что итем выделен
			if (View.CurrentSelectedSchema == null)
			{
				MessageBox.Show("Выделите запись запись в списке файлов, которую хотите удалить!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			
			Model.RemoveSchema(View.CurrentSelectedSchema); 		// Удалим схему из модели
			View.RemoveSchemaItem(View.CurrentSelectedSchemaItem);	// Удалим схему на отображении
		}
		public void AddAllSchemasInFolder()
		{
			var folderDlg = new TextInut_Form();
			folderDlg.ShowDialog();
			
			if (folderDlg.DialogResult == DialogResult.OK)
			{
				List<Schema> schemas = Model.AddAllSchemasInFolder(folderDlg.Input);
				schemas.ForEach(x => View.AddNewSchemaItem(x));
			}				
		}
		public void ClearSchemas()
		{
			View.ClearSchemasList();
			Model.ClearSchemas();
		}
		
		// Работа со словарем замены
		public void AddNewDictValue()
		{
			var dlg = new DictValuesInput_Form();
			dlg.ShowDialog();
			if (dlg.DialogResult == DialogResult.OK)
			{
				Model.AddNewDictValue(dlg.CurrentValue, dlg.NewValue);
				View.AddNewDict(dlg.CurrentValue, dlg.NewValue);
			}		
		}
		public void RemoveDictValue()
		{
			// Убедимся, что итем выделен
			if (View.CurrenSelectedDictItem == null)
			{
				MessageBox.Show("Выделите запись словаря, которую хотите удалить!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			
			// Получим выделенный итем и ключ с формы
			ListViewItem item = View.CurrenSelectedDictItem;
			string key = (item.Tag as string);
			
			Model.RemoveDictValue(key); // По ключу удалим значение из словаря
			View.RemoveDictValue(item); // Удалим итем на форме
		}
		public void ClearDict()
		{
			View.ClearDict();
			Model.ClearDict();
		}
		public void FillDictManually()
		{
			// Покажем пользователю форму
			var dlg = new DictionaryMultipleInput_Form();
			dlg.ShowDialog();
			
			if (dlg.DialogResult == DialogResult.OK)
			{
				// Если пользователь подвердлил ввод, то надо взять входную строку и распарсить ее на пары Key-Value
				string[] pairs = dlg.Input.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
				
				foreach (string str in pairs)
				{
					try
					{
						string[] kv = str.Split('|');
						Model.AddNewDictValue(kv[0], kv[1]);
						View.AddNewDict(kv[0], kv[1]);
					}
					catch
					{
						MessageBox.Show("Не удалось распарсить строку на ключ и значение словаря. Проверьте наличие разделительных символов во вводе.",
						               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		
		// Изменение пути к исполняему файлу e3Series
		public void ChangeDefaultExePath()
		{
			Model.ChangeDefaultExePath(View.ExePath);
		}
		
		// Изменение задержки запуска исполняемого файла
		public void ChangeDefault_AppTimeout()
		{
			Model.ChangeDefaultTimeout(View.AppTimeout);
		}
		
		public void Execute()
		{
			Model.ExecuteAll();
			View.ShowLog(Global.Log.Content);
		}
	}
}
