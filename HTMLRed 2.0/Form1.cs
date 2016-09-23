using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace HTMLRed_2._0
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }
        bool Theme = false;
        RichTextBox NewRichTextBox;
        int TabPaseCount = 0;
        TabPage CurrentTab;
        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabPaseCount < 1)
            {
                TabPage NewTab = new TabPage("Новый Проект");
                if (Theme)
                {

                    NewRichTextBox = new RichTextBox(); //Создаем новый richbox

                    NewRichTextBox.BackColor = Color.DimGray;

                }
                else
                {
                    NewRichTextBox = new RichTextBox(); //Создаем новый richbox
                    NewRichTextBox.BackColor = Color.White;
                }
                NewTab.Controls.Add(NewRichTextBox); //Добавляем этот richbox в newteb
                ProjectWindow.TabPages.Add(NewTab); //Создаем новую вкладку в tabcontrol  
                NewRichTextBox.Dock = DockStyle.Fill;
                NewRichTextBox.AcceptsTab = true;//На полный экран приложения
                TabPaseCount++;
            }
            else
            {
                MessageBox.Show("Нельзя добавлять более 1 проекта");
            }
        }

        private RichTextBox GetRichTextBox()
        {
            RichTextBox NewRichTextBox = null;
            TabPage NewTab = ProjectWindow.SelectedTab;
            if (NewTab != null)
            {
                NewRichTextBox = NewTab.Controls[0] as RichTextBox;
            }
            return NewRichTextBox;
        }

        private void BasicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult NewCloseDialog = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (NewCloseDialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (NewCloseDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream NewOpenProjectStream;
            OpenFileDialog open1 = new OpenFileDialog();
            if (open1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((NewOpenProjectStream = open1.OpenFile()) != null)
                {
                    string strname = open1.FileName;
                    string filtext = File.ReadAllText(strname);
                    GetRichTextBox().Text = filtext;
                    ProjectWindow.SelectedTab.Text = Path.GetFileName(open1.FileName);
                }
            }
        }

        private void FindText_Click(object sender, EventArgs e) //Поиск текта
        {
            try
            {
                int index = 0;
                String temp = GetRichTextBox().Text;
                GetRichTextBox().Text = temp;
                while (index < GetRichTextBox().Text.LastIndexOf(TextToFind.Text))
                {
                    GetRichTextBox().Find(TextToFind.Text, index, GetRichTextBox().TextLength, RichTextBoxFinds.None);
                    GetRichTextBox().SelectionBackColor = Color.Green;
                    index = GetRichTextBox().Text.IndexOf(TextToFind.Text, index) + 1;
                }
            }
            catch { ErrorNotice(); } //ошибка

        }

        private void ChangeStyleTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog FontDialog = new FontDialog();
                FontDialog.ShowColor = true;
                if (FontDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(GetRichTextBox().Text))
                {
                    GetRichTextBox().SelectAll();
                    GetRichTextBox().SelectionColor = FontDialog.Color;
                    GetRichTextBox().SelectionFont = FontDialog.Font;

                }
            }
            catch { ErrorNotice(); } //ошибка
        }

        private void SaveProjectHowToolStripMenuItem_Click(object sender, EventArgs e) //сохранение
        {
            SaveProject();
        }
        private void SaveProject()
        {
            try
            {
                SaveFileDialog SaveFileHow = new SaveFileDialog();
                if (SaveFileHow.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(SaveFileHow.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(GetRichTextBox().Text);
                        ProjectWindow.SelectedTab.Text = Path.GetFileName(SaveFileHow.FileName);
                    }
                }
            }
            catch { ErrorNotice(); } //ошибка!
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Undo();
            }
            catch
            {
                ErrorNotice();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Redo();
            }
            catch
            {
                ErrorNotice();
            }
        }

        private void StartProject_Click(object sender, EventArgs e)
        {
            try
            {
                WebBrowser StartProject = new WebBrowser(GetRichTextBox().Text);
                StartProject.ShowDialog();
            }
            catch
            {
                ErrorNotice(); //ошибка
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Undo();
            }
            catch { ErrorNotice(); }
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GetRichTextBox().Redo();
            }
            catch { ErrorNotice(); }
        }

        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox.BackColor = Color.DimGray;
                NewRichTextBox.ForeColor = Color.White;
                menuStrip1.ForeColor = Color.White;
                menuStrip1.BackColor = Color.DarkGray;
                undo.BackColor = Color.DarkGray;
                undo.ForeColor = Color.White;
                BackColor = Color.DarkGray;
                Theme = true;
            }
            catch
            {
                menuStrip1.ForeColor = Color.White;
                menuStrip1.BackColor = Color.DarkGray;
                undo.BackColor = Color.DarkGray;
                undo.ForeColor = Color.White;
                BackColor = Color.DarkGray;
                Theme = true;
            }
        }

        private void ErrorNotice()
        {
            MessageBox.Show("Вы не создали проект!");
        }


        private void WhiteThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewRichTextBox.BackColor = Color.White;
                NewRichTextBox.ForeColor = Color.Black;
                menuStrip1.ForeColor = Color.Black;
                menuStrip1.BackColor = Color.White;
                undo.BackColor = Color.White;
                undo.ForeColor = Color.Black;
                BackColor = Color.White;
                Theme = false;
            }
            catch
            {
                menuStrip1.ForeColor = Color.Black;
                menuStrip1.BackColor = Color.White;
                undo.BackColor = Color.White;
                undo.ForeColor = Color.Black;
                BackColor = Color.White;
                Theme = false;
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings FormSettings = new Settings();
            FormSettings.ShowDialog();
        }

        private void CreateShablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                NewRichTextBox.Text = "<html>\n    <head>\n\n    </head>\n    <body>\n\n    </body>\n</html>\n";
            }
            catch { ErrorNotice(); }
        }

        private void CloseProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentTab = ProjectWindow.SelectedTab;
                DialogResult NewCloseDialog = MessageBox.Show("Сохранить проект перед его закрытием?", "Сохранение", MessageBoxButtons.YesNo);
                if (NewCloseDialog == DialogResult.Yes)
                {
                    SaveProject();
                    ProjectWindow.TabPages.Remove(CurrentTab);
                }
                else if (NewCloseDialog == DialogResult.No)
                {
                    ProjectWindow.TabPages.Remove(CurrentTab);
                }
            }
            catch { ErrorNotice(); }
        }
    }
}  

