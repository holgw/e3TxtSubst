/*
 * Сделано в SharpDevelop.
 * Пользователь: OHozhatelev
 * Дата: 28.07.17
 * Время: 7:56
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace e3TxtSubst
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btClearSchemas = new System.Windows.Forms.Button();
			this.listPathList = new System.Windows.Forms.ListView();
			this.btAddAllSchemasFolder = new System.Windows.Forms.Button();
			this.btAddSchema = new System.Windows.Forms.Button();
			this.btRemoveSchema = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btManualInput = new System.Windows.Forms.Button();
			this.listDict = new System.Windows.Forms.ListView();
			this.btClearDict = new System.Windows.Forms.Button();
			this.btAddDictValue = new System.Windows.Forms.Button();
			this.btRemoveDictValue = new System.Windows.Forms.Button();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
			this.btSaveDefaultTimeout = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btSavePath = new System.Windows.Forms.Button();
			this.txtExePath = new System.Windows.Forms.TextBox();
			this.btExecute = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(6, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(838, 307);
			this.splitContainer1.SplitterDistance = 414;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btClearSchemas);
			this.groupBox1.Controls.Add(this.listPathList);
			this.groupBox1.Controls.Add(this.btAddAllSchemasFolder);
			this.groupBox1.Controls.Add(this.btAddSchema);
			this.groupBox1.Controls.Add(this.btRemoveSchema);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(414, 307);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "1. Список файлов";
			// 
			// btClearSchemas
			// 
			this.btClearSchemas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btClearSchemas.Image = ((System.Drawing.Image)(resources.GetObject("btClearSchemas.Image")));
			this.btClearSchemas.Location = new System.Drawing.Point(377, 115);
			this.btClearSchemas.Margin = new System.Windows.Forms.Padding(2);
			this.btClearSchemas.Name = "btClearSchemas";
			this.btClearSchemas.Size = new System.Drawing.Size(32, 32);
			this.btClearSchemas.TabIndex = 5;
			this.btClearSchemas.UseVisualStyleBackColor = true;
			this.btClearSchemas.Click += new System.EventHandler(this.BtClearSchemasClick);
			// 
			// listPathList
			// 
			this.listPathList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listPathList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listPathList.FullRowSelect = true;
			this.listPathList.GridLines = true;
			this.listPathList.Location = new System.Drawing.Point(6, 19);
			this.listPathList.Name = "listPathList";
			this.listPathList.Size = new System.Drawing.Size(366, 282);
			this.listPathList.TabIndex = 4;
			this.listPathList.UseCompatibleStateImageBehavior = false;
			this.listPathList.View = System.Windows.Forms.View.Details;
			// 
			// btAddAllSchemasFolder
			// 
			this.btAddAllSchemasFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddAllSchemasFolder.Image = ((System.Drawing.Image)(resources.GetObject("btAddAllSchemasFolder.Image")));
			this.btAddAllSchemasFolder.Location = new System.Drawing.Point(377, 83);
			this.btAddAllSchemasFolder.Margin = new System.Windows.Forms.Padding(2);
			this.btAddAllSchemasFolder.Name = "btAddAllSchemasFolder";
			this.btAddAllSchemasFolder.Size = new System.Drawing.Size(32, 32);
			this.btAddAllSchemasFolder.TabIndex = 3;
			this.btAddAllSchemasFolder.UseVisualStyleBackColor = true;
			this.btAddAllSchemasFolder.Click += new System.EventHandler(this.BtAddAllSchemasFolderClick);
			// 
			// btAddSchema
			// 
			this.btAddSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddSchema.Image = ((System.Drawing.Image)(resources.GetObject("btAddSchema.Image")));
			this.btAddSchema.Location = new System.Drawing.Point(377, 19);
			this.btAddSchema.Margin = new System.Windows.Forms.Padding(2);
			this.btAddSchema.Name = "btAddSchema";
			this.btAddSchema.Size = new System.Drawing.Size(32, 32);
			this.btAddSchema.TabIndex = 1;
			this.btAddSchema.UseVisualStyleBackColor = true;
			this.btAddSchema.Click += new System.EventHandler(this.btAddSchema_Click);
			// 
			// btRemoveSchema
			// 
			this.btRemoveSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btRemoveSchema.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveSchema.Image")));
			this.btRemoveSchema.Location = new System.Drawing.Point(377, 51);
			this.btRemoveSchema.Margin = new System.Windows.Forms.Padding(2);
			this.btRemoveSchema.Name = "btRemoveSchema";
			this.btRemoveSchema.Size = new System.Drawing.Size(32, 32);
			this.btRemoveSchema.TabIndex = 2;
			this.btRemoveSchema.UseVisualStyleBackColor = true;
			this.btRemoveSchema.Click += new System.EventHandler(this.btRemoveSchema_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btManualInput);
			this.groupBox2.Controls.Add(this.listDict);
			this.groupBox2.Controls.Add(this.btClearDict);
			this.groupBox2.Controls.Add(this.btAddDictValue);
			this.groupBox2.Controls.Add(this.btRemoveDictValue);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(418, 307);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "2. Словарь замены";
			// 
			// btManualInput
			// 
			this.btManualInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btManualInput.Image = ((System.Drawing.Image)(resources.GetObject("btManualInput.Image")));
			this.btManualInput.Location = new System.Drawing.Point(381, 115);
			this.btManualInput.Margin = new System.Windows.Forms.Padding(2);
			this.btManualInput.Name = "btManualInput";
			this.btManualInput.Size = new System.Drawing.Size(32, 32);
			this.btManualInput.TabIndex = 5;
			this.btManualInput.UseVisualStyleBackColor = true;
			this.btManualInput.Click += new System.EventHandler(this.BtManualInputClick);
			// 
			// listDict
			// 
			this.listDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listDict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listDict.FullRowSelect = true;
			this.listDict.GridLines = true;
			this.listDict.Location = new System.Drawing.Point(6, 19);
			this.listDict.Name = "listDict";
			this.listDict.Size = new System.Drawing.Size(370, 282);
			this.listDict.TabIndex = 4;
			this.listDict.UseCompatibleStateImageBehavior = false;
			this.listDict.View = System.Windows.Forms.View.Details;
			// 
			// btClearDict
			// 
			this.btClearDict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btClearDict.Image = ((System.Drawing.Image)(resources.GetObject("btClearDict.Image")));
			this.btClearDict.Location = new System.Drawing.Point(381, 83);
			this.btClearDict.Margin = new System.Windows.Forms.Padding(2);
			this.btClearDict.Name = "btClearDict";
			this.btClearDict.Size = new System.Drawing.Size(32, 32);
			this.btClearDict.TabIndex = 3;
			this.btClearDict.UseVisualStyleBackColor = true;
			this.btClearDict.Click += new System.EventHandler(this.BtClearDictClick);
			// 
			// btAddDictValue
			// 
			this.btAddDictValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddDictValue.Image = ((System.Drawing.Image)(resources.GetObject("btAddDictValue.Image")));
			this.btAddDictValue.Location = new System.Drawing.Point(381, 19);
			this.btAddDictValue.Margin = new System.Windows.Forms.Padding(2);
			this.btAddDictValue.Name = "btAddDictValue";
			this.btAddDictValue.Size = new System.Drawing.Size(32, 32);
			this.btAddDictValue.TabIndex = 1;
			this.btAddDictValue.UseVisualStyleBackColor = true;
			this.btAddDictValue.Click += new System.EventHandler(this.btAddDictValue_Click);
			// 
			// btRemoveDictValue
			// 
			this.btRemoveDictValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btRemoveDictValue.Image = ((System.Drawing.Image)(resources.GetObject("btRemoveDictValue.Image")));
			this.btRemoveDictValue.Location = new System.Drawing.Point(381, 51);
			this.btRemoveDictValue.Margin = new System.Windows.Forms.Padding(2);
			this.btRemoveDictValue.Name = "btRemoveDictValue";
			this.btRemoveDictValue.Size = new System.Drawing.Size(32, 32);
			this.btRemoveDictValue.TabIndex = 2;
			this.btRemoveDictValue.UseVisualStyleBackColor = true;
			this.btRemoveDictValue.Click += new System.EventHandler(this.BtRemoveDictValueClick);
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
			this.splitContainer2.Panel1.Controls.Add(this.groupBox4);
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			this.splitContainer2.Panel1.Controls.Add(this.btExecute);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer2.Size = new System.Drawing.Size(854, 546);
			this.splitContainer2.SplitterDistance = 371;
			this.splitContainer2.TabIndex = 2;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.nudTimeOut);
			this.groupBox5.Controls.Add(this.btSaveDefaultTimeout);
			this.groupBox5.Location = new System.Drawing.Point(511, 316);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(197, 48);
			this.groupBox5.TabIndex = 8;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "4. Таймаут запуска E3.series.exe";
			// 
			// nudTimeOut
			// 
			this.nudTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.nudTimeOut.Increment = new decimal(new int[] {
									100,
									0,
									0,
									0});
			this.nudTimeOut.Location = new System.Drawing.Point(6, 19);
			this.nudTimeOut.Maximum = new decimal(new int[] {
									100000,
									0,
									0,
									0});
			this.nudTimeOut.Name = "nudTimeOut";
			this.nudTimeOut.Size = new System.Drawing.Size(150, 20);
			this.nudTimeOut.TabIndex = 9;
			// 
			// btSaveDefaultTimeout
			// 
			this.btSaveDefaultTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSaveDefaultTimeout.Image = ((System.Drawing.Image)(resources.GetObject("btSaveDefaultTimeout.Image")));
			this.btSaveDefaultTimeout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btSaveDefaultTimeout.Location = new System.Drawing.Point(161, 11);
			this.btSaveDefaultTimeout.Margin = new System.Windows.Forms.Padding(2);
			this.btSaveDefaultTimeout.Name = "btSaveDefaultTimeout";
			this.btSaveDefaultTimeout.Size = new System.Drawing.Size(31, 32);
			this.btSaveDefaultTimeout.TabIndex = 8;
			this.btSaveDefaultTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btSaveDefaultTimeout.UseVisualStyleBackColor = true;
			this.btSaveDefaultTimeout.Click += new System.EventHandler(this.BtSaveDefaultTimeout_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.btSavePath);
			this.groupBox4.Controls.Add(this.txtExePath);
			this.groupBox4.Location = new System.Drawing.Point(6, 316);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(499, 48);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "3. Путь к E3.series.exe";
			// 
			// btSavePath
			// 
			this.btSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSavePath.Image = ((System.Drawing.Image)(resources.GetObject("btSavePath.Image")));
			this.btSavePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btSavePath.Location = new System.Drawing.Point(463, 11);
			this.btSavePath.Margin = new System.Windows.Forms.Padding(2);
			this.btSavePath.Name = "btSavePath";
			this.btSavePath.Size = new System.Drawing.Size(31, 32);
			this.btSavePath.TabIndex = 8;
			this.btSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btSavePath.UseVisualStyleBackColor = true;
			this.btSavePath.Click += new System.EventHandler(this.BtSavePathClick);
			// 
			// txtExePath
			// 
			this.txtExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtExePath.Location = new System.Drawing.Point(6, 19);
			this.txtExePath.Name = "txtExePath";
			this.txtExePath.Size = new System.Drawing.Size(452, 20);
			this.txtExePath.TabIndex = 7;
			// 
			// btExecute
			// 
			this.btExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btExecute.Image = ((System.Drawing.Image)(resources.GetObject("btExecute.Image")));
			this.btExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btExecute.Location = new System.Drawing.Point(713, 316);
			this.btExecute.Margin = new System.Windows.Forms.Padding(2);
			this.btExecute.Name = "btExecute";
			this.btExecute.Size = new System.Drawing.Size(131, 48);
			this.btExecute.TabIndex = 6;
			this.btExecute.Text = "Начать обработку";
			this.btExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btExecute.UseVisualStyleBackColor = true;
			this.btExecute.Click += new System.EventHandler(this.BtExecuteClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.txtLog);
			this.groupBox3.Location = new System.Drawing.Point(6, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox3.Size = new System.Drawing.Size(838, 161);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Вывод";
			// 
			// txtLog
			// 
			this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Location = new System.Drawing.Point(6, 19);
			this.txtLog.Margin = new System.Windows.Forms.Padding(6);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(826, 136);
			this.txtLog.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 546);
			this.Controls.Add(this.splitContainer2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "E3.Text Exchange";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btManualInput;
		private System.Windows.Forms.Button btSaveDefaultTimeout;
		private System.Windows.Forms.NumericUpDown nudTimeOut;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btSavePath;
		private System.Windows.Forms.TextBox txtExePath;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btExecute;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button btRemoveDictValue;
		private System.Windows.Forms.Button btAddDictValue;
		private System.Windows.Forms.Button btClearDict;
		private System.Windows.Forms.ListView listDict;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btClearSchemas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView listPathList;
		private System.Windows.Forms.Button btAddSchema;
		private System.Windows.Forms.Button btRemoveSchema;
		private System.Windows.Forms.Button btAddAllSchemasFolder;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}
