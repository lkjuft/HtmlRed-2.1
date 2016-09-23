namespace HTMLRed_2._0
{
    partial class BasicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveProjectHowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStyleTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateShablonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TextToFind = new System.Windows.Forms.ToolStripTextBox();
            this.FindText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StartProject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ProjectWindow = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.undo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ViewToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProjectToolStripMenuItem,
            this.SaveProjectHowToolStripMenuItem,
            this.OpenProjectToolStripMenuItem,
            this.CloseProjectToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // NewProjectToolStripMenuItem
            // 
            this.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem";
            this.NewProjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NewProjectToolStripMenuItem.Text = "Новый проект";
            this.NewProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // SaveProjectHowToolStripMenuItem
            // 
            this.SaveProjectHowToolStripMenuItem.Name = "SaveProjectHowToolStripMenuItem";
            this.SaveProjectHowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveProjectHowToolStripMenuItem.Text = "Сохранить как...";
            this.SaveProjectHowToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectHowToolStripMenuItem_Click);
            // 
            // OpenProjectToolStripMenuItem
            // 
            this.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            this.OpenProjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenProjectToolStripMenuItem.Text = "Открыть проект";
            this.OpenProjectToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectToolStripMenuItem_Click);
            // 
            // CloseProjectToolStripMenuItem
            // 
            this.CloseProjectToolStripMenuItem.Name = "CloseProjectToolStripMenuItem";
            this.CloseProjectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CloseProjectToolStripMenuItem.Text = "Закрыть проект";
            this.CloseProjectToolStripMenuItem.Click += new System.EventHandler(this.CloseProjectToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeStyleTextToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem,
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.CreateShablonToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.EditToolStripMenuItem.Text = "Правка";
            // 
            // ChangeStyleTextToolStripMenuItem
            // 
            this.ChangeStyleTextToolStripMenuItem.Name = "ChangeStyleTextToolStripMenuItem";
            this.ChangeStyleTextToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ChangeStyleTextToolStripMenuItem.Text = "Изменить шрифт";
            this.ChangeStyleTextToolStripMenuItem.Click += new System.EventHandler(this.ChangeStyleTextToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.UndoToolStripMenuItem.Text = "Назад";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.RedoToolStripMenuItem.Text = "Вперед";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // CreateShablonToolStripMenuItem
            // 
            this.CreateShablonToolStripMenuItem.Name = "CreateShablonToolStripMenuItem";
            this.CreateShablonToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.CreateShablonToolStripMenuItem.Text = "Создать шаблон";
            this.CreateShablonToolStripMenuItem.Click += new System.EventHandler(this.CreateShablonToolStripMenuItem_Click);
            // 
            // ViewToolStripMenuItem
            // 
            this.ViewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhiteThemeToolStripMenuItem,
            this.DarkThemeToolStripMenuItem});
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            this.ViewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ViewToolStripMenuItem.Text = "Вид";
            // 
            // WhiteThemeToolStripMenuItem
            // 
            this.WhiteThemeToolStripMenuItem.Name = "WhiteThemeToolStripMenuItem";
            this.WhiteThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.WhiteThemeToolStripMenuItem.Text = "Светлая тема";
            this.WhiteThemeToolStripMenuItem.Click += new System.EventHandler(this.WhiteThemeToolStripMenuItem_Click);
            // 
            // DarkThemeToolStripMenuItem
            // 
            this.DarkThemeToolStripMenuItem.Name = "DarkThemeToolStripMenuItem";
            this.DarkThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DarkThemeToolStripMenuItem.Text = "Темная тема";
            this.DarkThemeToolStripMenuItem.Click += new System.EventHandler(this.DarkThemeToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // undo
            // 
            this.undo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TextToFind,
            this.FindText,
            this.toolStripSeparator2,
            this.StartProject,
            this.toolStripSeparator3});
            this.undo.Location = new System.Drawing.Point(0, 24);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(1170, 25);
            this.undo.TabIndex = 2;
            this.undo.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Вперед";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Найти";
            // 
            // TextToFind
            // 
            this.TextToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextToFind.Name = "TextToFind";
            this.TextToFind.Size = new System.Drawing.Size(100, 25);
            // 
            // FindText
            // 
            this.FindText.BackColor = System.Drawing.Color.Transparent;
            this.FindText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FindText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FindText.Name = "FindText";
            this.FindText.Size = new System.Drawing.Size(46, 22);
            this.FindText.Text = "Поиск";
            this.FindText.Click += new System.EventHandler(this.FindText_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // StartProject
            // 
            this.StartProject.Image = global::HTMLRed_2._0.Properties.Resources.images;
            this.StartProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartProject.Name = "StartProject";
            this.StartProject.Size = new System.Drawing.Size(66, 22);
            this.StartProject.Text = "Начать";
            this.StartProject.Click += new System.EventHandler(this.StartProject_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ProjectWindow
            // 
            this.ProjectWindow.Location = new System.Drawing.Point(0, 52);
            this.ProjectWindow.Name = "ProjectWindow";
            this.ProjectWindow.SelectedIndex = 0;
            this.ProjectWindow.Size = new System.Drawing.Size(1170, 568);
            this.ProjectWindow.TabIndex = 3;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 620);
            this.Controls.Add(this.ProjectWindow);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BasicForm";
            this.Text = "HTMLRED 2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.undo.ResumeLayout(false);
            this.undo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip undo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TextToFind;
        private System.Windows.Forms.ToolStripButton FindText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton StartProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem SaveProjectHowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeStyleTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WhiteThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.TabControl ProjectWindow;
        private System.Windows.Forms.ToolStripMenuItem CreateShablonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewProjectToolStripMenuItem;
    }
}

