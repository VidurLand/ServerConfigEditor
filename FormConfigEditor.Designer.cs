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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigEditor));
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonOpenServerConnector = new System.Windows.Forms.Button();
            this.comboBoxPath = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.TextBoxEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFile
            // 
            resources.ApplyResources(this.groupBoxFile, "groupBoxFile");
            this.groupBoxFile.Controls.Add(this.buttonSaveFile);
            this.groupBoxFile.Controls.Add(this.buttonReadFile);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.TabStop = false;
            // 
            // buttonSaveFile
            // 
            resources.ApplyResources(this.buttonSaveFile, "buttonSaveFile");
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            // 
            // buttonReadFile
            // 
            resources.ApplyResources(this.buttonReadFile, "buttonReadFile");
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.ButtonReadFile_Click);
            // 
            // groupBoxPath
            // 
            resources.ApplyResources(this.groupBoxPath, "groupBoxPath");
            this.groupBoxPath.Controls.Add(this.buttonDelete);
            this.groupBoxPath.Controls.Add(this.buttonEdit);
            this.groupBoxPath.Controls.Add(this.buttonAdd);
            this.groupBoxPath.Controls.Add(this.buttonList);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.TabStop = false;
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonList
            // 
            resources.ApplyResources(this.buttonList, "buttonList");
            this.buttonList.Name = "buttonList";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.ButtonList_Click);
            // 
            // buttonOpenServerConnector
            // 
            resources.ApplyResources(this.buttonOpenServerConnector, "buttonOpenServerConnector");
            this.buttonOpenServerConnector.Name = "buttonOpenServerConnector";
            this.buttonOpenServerConnector.UseVisualStyleBackColor = true;
            this.buttonOpenServerConnector.Click += new System.EventHandler(this.buttonOpenServerConnector_Click);
            // 
            // comboBoxPath
            // 
            resources.ApplyResources(this.comboBoxPath, "comboBoxPath");
            this.comboBoxPath.FormattingEnabled = true;
            this.comboBoxPath.Name = "comboBoxPath";
            this.comboBoxPath.Sorted = true;
            this.comboBoxPath.SelectedIndexChanged += new System.EventHandler(this.comboBoxPath_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextBoxEditor
            // 
            resources.ApplyResources(this.TextBoxEditor, "TextBoxEditor");
            this.TextBoxEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TextBoxEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.TextBoxEditor.BackBrush = null;
            this.TextBoxEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.TextBoxEditor.CharHeight = 14;
            this.TextBoxEditor.CharWidth = 8;
            this.TextBoxEditor.CommentPrefix = "--";
            this.TextBoxEditor.CurrentPenSize = 3;
            this.TextBoxEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBoxEditor.DocumentPath = null;
            this.TextBoxEditor.IsReplaceMode = false;
            this.TextBoxEditor.Language = FastColoredTextBoxNS.Language.Lua;
            this.TextBoxEditor.LeftBracket = '(';
            this.TextBoxEditor.LeftBracket2 = '{';
            this.TextBoxEditor.Name = "TextBoxEditor";
            this.TextBoxEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.TextBoxEditor.RightBracket = ')';
            this.TextBoxEditor.RightBracket2 = '}';
            this.TextBoxEditor.SelectionChangedDelayedEnabled = false;
            this.TextBoxEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextBoxEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextBoxEditor.ServiceColors")));
            this.TextBoxEditor.Zoom = 100;
            // 
            // FormConfigEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxEditor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxPath);
            this.Controls.Add(this.buttonOpenServerConnector);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxPath);
            this.Name = "FormConfigEditor";
            this.Activated += new System.EventHandler(this.FormConfigEditor_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfigEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormConfigEditor_Load);
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxEditor)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxPath;
        private System.Windows.Forms.Button buttonExit;
        private FastColoredTextBoxNS.FastColoredTextBox TextBoxEditor;
    }
}

