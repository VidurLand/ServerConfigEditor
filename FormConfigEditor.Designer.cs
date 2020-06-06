namespace ServerConfigEditor
{
    partial class FormConfigEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonOpenServerConnector = new System.Windows.Forms.Button();
            this.TextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.comboBoxPath = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFile.Controls.Add(this.buttonSaveFile);
            this.groupBoxFile.Controls.Add(this.buttonReadFile);
            this.groupBoxFile.Location = new System.Drawing.Point(572, 89);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(200, 97);
            this.groupBoxFile.TabIndex = 0;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Файл";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile.Location = new System.Drawing.Point(8, 55);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(184, 30);
            this.buttonSaveFile.TabIndex = 1;
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReadFile.Location = new System.Drawing.Point(8, 19);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(184, 30);
            this.buttonReadFile.TabIndex = 0;
            this.buttonReadFile.Text = "Прочитать";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.ButtonReadFile_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPath.Controls.Add(this.buttonDelete);
            this.groupBoxPath.Controls.Add(this.buttonEdit);
            this.groupBoxPath.Controls.Add(this.buttonAdd);
            this.groupBoxPath.Controls.Add(this.buttonList);
            this.groupBoxPath.Location = new System.Drawing.Point(572, 193);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(200, 180);
            this.groupBoxPath.TabIndex = 1;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Пути";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 139);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(184, 30);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(8, 99);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(184, 30);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(8, 59);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(184, 30);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonList
            // 
            this.buttonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonList.Location = new System.Drawing.Point(8, 19);
            this.buttonList.Margin = new System.Windows.Forms.Padding(5);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(184, 30);
            this.buttonList.TabIndex = 0;
            this.buttonList.Text = "Список";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // buttonOpenServerConnector
            // 
            this.buttonOpenServerConnector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenServerConnector.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenServerConnector.Location = new System.Drawing.Point(582, 22);
            this.buttonOpenServerConnector.Name = "buttonOpenServerConnector";
            this.buttonOpenServerConnector.Size = new System.Drawing.Size(184, 30);
            this.buttonOpenServerConnector.TabIndex = 2;
            this.buttonOpenServerConnector.Text = "Connect Param";
            this.buttonOpenServerConnector.UseVisualStyleBackColor = true;
            this.buttonOpenServerConnector.Click += new System.EventHandler(this.buttonOpenServerConnector_Click);
            // 
            // TextBoxEditor
            // 
            this.TextBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEditor.Location = new System.Drawing.Point(12, 144);
            this.TextBoxEditor.Name = "TextBoxEditor";
            this.TextBoxEditor.Size = new System.Drawing.Size(554, 305);
            this.TextBoxEditor.TabIndex = 3;
            this.TextBoxEditor.Text = "";
            // 
            // comboBoxPath
            // 
            this.comboBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPath.FormattingEnabled = true;
            this.comboBoxPath.Location = new System.Drawing.Point(12, 110);
            this.comboBoxPath.Name = "comboBoxPath";
            this.comboBoxPath.Size = new System.Drawing.Size(554, 28);
            this.comboBoxPath.Sorted = true;
            this.comboBoxPath.TabIndex = 4;
            this.comboBoxPath.SelectedIndexChanged += new System.EventHandler(this.comboBoxPath_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(582, 425);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(182, 30);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // FormConfigEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxPath);
            this.Controls.Add(this.TextBoxEditor);
            this.Controls.Add(this.buttonOpenServerConnector);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxPath);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormConfigEditor";
            this.Text = "ConfigEditor";
            this.Activated += new System.EventHandler(this.FormConfigEditor_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormConfigEditor_Load);
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.Button buttonOpenServerConnector;
        private System.Windows.Forms.RichTextBox TextBoxEditor;
        private System.Windows.Forms.ComboBox comboBoxPath;
        private System.Windows.Forms.Button buttonExit;
    }
}

