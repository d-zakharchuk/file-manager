using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager1
{
    public partial class FileManager : Form
    {
        private void CreateReport(CReportBuilder report) // Director. Director creates product by using Builder's interface.
        {
            report.CreateHeader(ref ReportSTRTXT);
            report.CreateBody();
            report.CreateFooter(ref ReportSTRTXT);
        }

        public void GenerateReport()//Product
        {
            CTextReportBuilder Report=null;
            CreateReport(Report);       
            Report.Print(ref ReportSTRTXT, ref ReportSTRHTML);
        }
        public
        string path1 = @"C:\";  // "C:\\";
        string path2 = @"C:\";  // "C:\\";
        bool FileCreation;
        protected static List<string> copyFolders = new List<string>();
        protected static List<string> copyFiles = new List<string>();
        protected static bool copy; //true - copy, false - cut
        DateTime LocalDateTime;
        public static string ReportSTRTXT;
        public static string ReportSTRHTML;
        public FileManager()
        {
            InitializeComponent();
            Refresh(listView1, ref path1, address1);
            Refresh(listView2, ref path2, address2);
            PanelsPerformance.InitializeTree(treeView1);
            PanelsPerformance.InitializeTree(treeView2);
        }

        private void FMFormLoad()
        {
            CheckingLanguageShortcut();
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            CTextReportBuilder ReportT = new CTextReportBuilder();
            ReportT.CreateHeader(ref ReportSTRTXT);
            ReportH.CreateHeader(ref ReportSTRHTML);
        }

        private void CheckingLanguageShortcut()
        {
            if (englishToolStripMenuItem.Checked == true)
            {
                englishToolStripMenuItem.ShortcutKeys = (Keys.None);
                englishToolStripMenuItem.ShortcutKeyDisplayString = "";
                ukrainianToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
                ukrainianToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.L);
            }
            else
            {
                ukrainianToolStripMenuItem.ShortcutKeys = (Keys.None);
                ukrainianToolStripMenuItem.ShortcutKeyDisplayString = "";
                englishToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
                englishToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.L);
            }
        }

        private void ChangeLanguage()
        {
            if (englishToolStripMenuItem.Checked == false)
            {
                ukrainianToolStripMenuItem.Checked = false;
                englishToolStripMenuItem.Checked = true;
                FileManager.ActiveForm.Text = "File Manager";
                fileToolStripMenuItem.Text = "File";
                exitToolStripMenuItem.Text = "Exit";
                languageToolStripMenuItem.Text = "Language";
                helpToolStripMenuItem.Text = "Help";
                aboutToolStripMenuItem.Text = "About";
                LevelUpButton1.Text = "Level up";
                LevelUpButton2.Text = "Level up";
                NewFolderButton1.Text = "New Folder";
                NewFolderButton2.Text = "New Folder";
                NewFileButton1.Text = "New File";
                NewFileButton2.Text = "New File";
                RefreshButton1.Text = "Refresh";
                RefreshButton2.Text = "Refresh";
                lvp.HelpInfoText = "File Manager supported functionality:\n" +
    "- Navigating through the file system\n" +
"- Files moving, copying, deleting\n" +
"- Copying all TXT from the current folder\n" +
"- Copying HTML files\n" +
"- Creating new folders and files\n" +
"- Editing text files in a built-in editor\n" +
"Editor functionality:\n" +
"    - Word Wrapping\n" +
"    - Changing Text Font Preferences\n" +
"    - Filtering words with the only 1 appearance\n" +
"    - Modifing text case like in sentences\n\n" +
"- Changing interface language : English or Ukrainian\n" +
"- Monitoring actions, performed during program session;\n" +
"- Saving report in both TXT and HTML formats.";
                lvp.DirectoryNotFoundText = "Directory not found";
                lvp.LocalDiskText = "Local Disk";
                lvp.CDROMDriveText = "CD-ROM Drive";
                lvp.RemovableDiskText = "Removable Disk";
                lvp.NetworkDiskText = "Network Disk";
                lvp.FloppyDriveText = "Floppy Drive";
                lvp.ErrorText = "ERROR";
                lvp.AccessDeniedText = "Access denied";
                lvp.IncorrectPathText = "Incorrect path";
                lvp.OperationCompletedText = "Completed";
                lvp.InfoTitleText = "Info";
                lvp.NoHTMLSelectedText = "No HTML file selected";
                lvp.UnableToOpenFileText = "Unable to open the file";
                lvp.FolderAlreadyExistsText = "Folder already exists!";
                lvp.FileAlreadyExistsText = "File already exists!";
                lvp.EmptyNameErrorText = "Name cannot be empty!";
                lvp.OpenText = "Open";
                lvp.CutText = "Cut";
                lvp.CopyText = "Copy";
                lvp.PasteText = "Paste";
                lvp.DeleteText = "Delete";
                lvp.CopyTXTText = "Copy TXT";
                lvp.CopyHTMLText = "Copy HTML";
                lvp.SaveText = "Save";
                lvp.SaveAsText = "Save As";
                lvp.PrintText = "Print";
                lvp.UndoText = "Undo";
                lvp.SelectAllText = "Select all";
                lvp.ExtraOptionsText = "Extra Options";
                lvp.Only1RepeatText = "Find only once words";
                lvp.ModifyCaseText = "Modify case";
                lvp.FontText = "Font";
                lvp.WordWrapText = "Word Wrap";
                lvp.FileText = "File";
                lvp.EditText = "Edit";
                lvp.FormatText = "Format";
                lvp.TextEditorNameText = "Text Editor ";
                lvp.ReportHeaderText = "File Manager Report ";
                lvp.ReportFooterText = "Thank You! ";
                lvp.ReportLanguageChanged = "Мову змінено на англійську. File manager is now displaying in English.";
                lvp.ReportDirChanged = "Path changed.";
                lvp. ReportDirChangedTo = "The following directory has been opened:";
                lvp. ReportChanges = "Changes.";
                lvp.ReportFileOpened = "The following file has been opened:";
                lvp.ReportDirCreated = "The following directory has been created:";
                lvp.ReportFileCreated = "The following file has been created:";
                lvp.ConfirmDelete = "Are you sure to delete?";
                lvp.ReportFileDeleted = "The following file has been deleted:";
                lvp.ReportDirDeleted = "The folowing directory has been deleted";
                lvp.ReportCut = "has been cut to:";
                lvp.ReportCopied = "has been copied to:";
                lvp.DirectoryText = "Directory";
                lvp.ReportAccessDenied = "Access denied to:";
                lvp.ReportDirectoryNotFound = "The following directory was not found:";
                lvp.ReportIncorrectPath = "The following path is incorrect:";
                lvp.DriveNotReadyText = "Drive is not ready";
                lvp.ReportFolderAlreadyExists = "The following folder already exists:";
                lvp.ReportFileAlreadyExists = "The following file already exists:";
                lvp.ReportUnableToOpen = "Unable to open the file:";
                lvp.IsNotHTMLText = "Is not HTML!";
                lvp.TryingCopyToSubsFolder = "Your destination folder is a subfolder of a source folder";
            }
            else if (ukrainianToolStripMenuItem.Checked == false)
            {
                englishToolStripMenuItem.Checked = false;
                ukrainianToolStripMenuItem.Checked = true;
                FileManager.ActiveForm.Text = "Файловий менеджер";
                fileToolStripMenuItem.Text = "Файл";
                exitToolStripMenuItem.Text = "Вихід";
                languageToolStripMenuItem.Text = "Мова";
                helpToolStripMenuItem.Text = "Допомога";
                aboutToolStripMenuItem.Text = "Про програму";
                LevelUpButton1.Text = "На рівень вгору";
                LevelUpButton2.Text = "На рівень вгору";
                NewFolderButton1.Text = "Створити папку";
                NewFolderButton2.Text = "Створити папку";
                NewFileButton1.Text = "Створити файл";
                NewFileButton2.Text = "Створити файл";
                RefreshButton1.Text = "Оновити";
                RefreshButton2.Text = "Оновити";
                lvp.HelpInfoText = "Функціонал Файлового Менеджера:\n" +
            "- Навігація файловою системою\n" +
"- Переміщення, копіювання, видалення файлів\n" +
"- Копіювання всіх TXT-файлів з поточної теки\n" +
"- Копіювання HTML-файлів\n" +
"- Створення нових тек та файлів\n" +
"- Редагування текстових файлів у вбудованому редакторі\n" +
"Функціонал редактора:\n" +
"    - Перенесення слів\n" +
"    - Зміна налаштувань шрифту\n" +
"    - Фільтрування слів, які зустрічаються лише 1 раз\n" +
"    - Змінення регістру тексту, як у реченнях\n\n" +
"- Зміна мови інтерфесу: Англійська або Українська\n" +
"- Відстежування дій протягом роботи програми;\n" +
"- Збереження звіту в TXT та HTML форматах.";

                lvp.DirectoryNotFoundText = "Теку не знайдено";
                lvp.LocalDiskText = "Локальний диск";
                lvp.CDROMDriveText = "Компакт-диск";
                lvp.RemovableDiskText = "Знімний диск";
                lvp.NetworkDiskText = "Мережевий диск";
                lvp.FloppyDriveText = "Гнучкий диск";
                lvp.ErrorText = "ПОМИЛКА";
                lvp.AccessDeniedText = "Відмовлено в доступі";
                lvp.IncorrectPathText = "Не вдається знайти вказаний шлях";
                lvp.OperationCompletedText = "Завершено";
                lvp.InfoTitleText = "Інфо";
                lvp.NoHTMLSelectedText = "HTML-файл не вибрано";
                lvp.UnableToOpenFileText = "Не вдалося відкрити файл";
                lvp.FolderAlreadyExistsText = "Тека вже існує!";
                lvp.FileAlreadyExistsText = "Файл вже існує!";
                lvp.EmptyNameErrorText = "ім'я не може бути порожнім!";
                lvp.OpenText = "Відкрити";
                lvp.CutText = "Вирізати";
                lvp.CopyText = "Копіювати";
                lvp.PasteText = "Вставити";
                lvp.DeleteText = "Видалити";
                lvp.CopyTXTText = "Копіювати TXT";
                lvp.CopyHTMLText = "Копіювати HTML";
                lvp.SaveText = "Зберегти";
                lvp.SaveAsText = "Зберегти як";
                lvp.PrintText = "Друк";
                lvp.UndoText = "Відмінити";
                lvp.SelectAllText = "Виділити все";
                lvp.ExtraOptionsText = "Екстра-Опції";
                lvp.Only1RepeatText = "Зустрічаються лише раз";
                lvp.ModifyCaseText = "Змінити регістр";
                lvp.FontText = "Шрифт";
                lvp.WordWrapText = "Перенесення слів";
                lvp.EditText = "Правлення";
                lvp.FileText = "Файл";
                lvp.FormatText = "Формат";
                lvp.TextEditorNameText = "Текстовий редактор ";
                lvp.ReportHeaderText = "Звіт про роботу файлового менеджера ";
                lvp.ReportFooterText = "Дякую! ";
                lvp.ReportLanguageChanged = "Language has been changed to Ukrainian. Файловий менеджер тепер відображається українською.";
                lvp.ReportDirChanged = "Перехід.";
                lvp.ReportDirChangedTo = "Відкрито директорію:";
                lvp.ReportChanges = "Зміни.";
                lvp.ReportFileOpened = "Відкрито файл:";
                lvp.ReportDirCreated = "Створено директорію:";
                lvp.ReportFileCreated = "Створено файл:";
                lvp.ConfirmDelete = "Справді видалити?";
                lvp.ReportFileDeleted = "Видалено файл:";
                lvp.ReportDirDeleted = "Видалено директорію:";
                lvp.ReportCut = "переміщено до:";
                lvp.ReportCopied = "скопійовано до:";
                lvp.DirectoryText = "Директорію";
                lvp.ReportAccessDenied = "Відмовлено у доступі до:";
                lvp.ReportDirectoryNotFound = "Теку не знайдено:";
                lvp.ReportIncorrectPath = "Шлях є неправильним:";
                lvp.DriveNotReadyText = "Пристрій не готовий:";
                lvp.ReportFolderAlreadyExists = "Тека вже існує:";
                lvp.ReportFileAlreadyExists = "Файл вже існує:";
                lvp.ReportUnableToOpen = "Неможливо відкрити файл:";
                lvp.IsNotHTMLText = "Не є HTML!";
                lvp.TryingCopyToSubsFolder = "Кінцева тека є підкаталогом вихідної теки";
            }
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            CTextReportBuilder ReportT = new CTextReportBuilder();
            ReportT.ChangedLanguage(ref ReportSTRTXT, lvp.ReportLanguageChanged);
            ReportH.ChangedLanguage(ref ReportSTRHTML, lvp.ReportLanguageChanged);
            PanelsPerformance.InitializeTree(treeView1);
            PanelsPerformance.InitializeTree(treeView2);
        }

        private void ChangePanelsSize()
        {
            address1.Width = splitContainer3.SplitterDistance - 106;
            toolStrip1.Width = splitContainer3.SplitterDistance - 1;
            address2.Width = ActiveForm.Width - 875 + 406 + 300 - splitContainer3.SplitterDistance;
            toolStrip2.Width = ActiveForm.Width - 875 + 405 + 406 - splitContainer3.SplitterDistance;
        }

        private void TreeViewClick(TreeView sender, ListView ListView, ref string path, ToolStripTextBox address, TreeNodeMouseClickEventArgs e)
        {
            path = e.Node.Name;
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            CTextReportBuilder ReportT = new CTextReportBuilder();
            ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
            ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
            Refresh(ListView, ref path, address);
        }

        private void TreeViewKeyDown(TreeView sender, ListView ListView, ref string path, ToolStripTextBox address, KeyEventArgs eKey)
        {
            if (eKey.KeyCode == Keys.Enter)
            {
                TreeNode tn = sender.SelectedNode;
                int x = tn.Bounds.X;
                int y = tn.Bounds.Y;
                TreeNodeMouseClickEventArgs treeNodeMouseClickEventArgs = new TreeNodeMouseClickEventArgs(tn, MouseButtons.Left, 1, x, y);
                TreeViewClick(sender, ListView, ref path, address, treeNodeMouseClickEventArgs);
            }
        }

        private void ListViewDoubleClick(ListView sender, ref string path, ToolStripTextBox address)
        {
            if (sender.SelectedItems.Count > 0)
            {
                if (sender.SelectedItems[0].ImageIndex == 0)     //Перехід в наступну теку
                {
                    try { GoToFolder(sender, ref path, sender.SelectedItems[0].Text, address); }
                    catch
                    {
                        CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                        CTextReportBuilder ReportT = new CTextReportBuilder();
                        ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportAccessDenied, path);
                        ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportAccessDenied, path);
                        MessageBox.Show(lvp.AccessDeniedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //відкриття файлу
                {
                    string s = path + '\\' + sender.SelectedItems[0].Text;
                    try { WorkingWithFiles.OpenFile(sender, s); }
                    catch
                    {
                        CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                        CTextReportBuilder ReportT = new CTextReportBuilder();
                        ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportAccessDenied, path);
                        ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportAccessDenied, path);
                        MessageBox.Show(lvp.AccessDeniedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FolderOrFileToCreate()
        {
            if (FileCreation)
            {
                if (englishToolStripMenuItem.Checked == true)
                {
                    lvp.Form2NameText = "New File";
                    lvp.EnterNameForm2Text = "Enter the name of a new file";
                }
                else if (ukrainianToolStripMenuItem.Checked == true)
                {
                    lvp.Form2NameText = "Новий файл";
                    lvp.EnterNameForm2Text = "Введіть назву нового файлу";
                }
            }
            else
            {
                if (englishToolStripMenuItem.Checked == true)
                {
                    lvp.Form2NameText = "New Folder";
                    lvp.EnterNameForm2Text = "Enter the name of a new folder";
                }
                else if (ukrainianToolStripMenuItem.Checked == true)
                {
                    lvp.Form2NameText = "Нова тека";
                    lvp.EnterNameForm2Text = "Введіть назву нової теки";
                }
            }
        }

        private void NewFolderClick(ListView ListView, ref string path, ToolStripTextBox address)
        {
            //Відкриття форми для створення нової теки
            NewFolder f2 = new NewFolder();
            f2.Owner = FileManager.ActiveForm;
            FolderOrFileToCreate();
            f2.ShowDialog();
            if (f2.folderName != "" && !FileCreation)
                WorkingWithFiles.CreateDir(path, f2.folderName);
            else if (f2.folderName != "" && FileCreation)
                WorkingWithFiles.CreateFile(path, f2.folderName);
            Refresh(listView1, ref path1, address1);
            Refresh(listView2, ref path2, address2);
            f2.Dispose();
        }

        private void LevelUp(ListView sender, ref string path, ToolStripTextBox address)
        {
            while (path.LastIndexOf('\\') == path.Length - 1) path = path.Substring(0, path.LastIndexOf('\\'));
            if (path.LastIndexOf('\\') == -1) { path += '\\'; return; }
            else
            {
                path = path.Substring(0, path.LastIndexOf('\\')) + '\\';
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
                Refresh(sender, ref path, address);
            }
        }

        private void addressKeyDown(ListView ListView, ref string path, ToolStripTextBox address, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string s;
                s = address.Text;
                if (!ChangeDir(ListView, ref path, s, address))
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportIncorrectPath, path);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportIncorrectPath, path);
                    address.Text = path;
                    MessageBox.Show(lvp.IncorrectPathText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ChangeDir(ListView sender, ref string path, string newPath, ToolStripTextBox address)
        {
            if (newPath.LastIndexOf('\\') == -1) return false;
            if (Directory.Exists(newPath))
            {
                path = newPath;
                Refresh(sender, ref path, address);
                return true;
            }
            return false;
        }

        private void GoToFolder(ListView sender, ref string path, string fName, ToolStripTextBox address)
        {
            if (path.LastIndexOf('\\') != path.Length - 1) path += '\\';
            path += fName;
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            CTextReportBuilder ReportT = new CTextReportBuilder();
            ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
            ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportDirChanged, lvp.ReportDirChangedTo, path);
            Refresh(sender, ref path, address);
        }

        private void OpenItem()
        {
            if (listView1.SelectedItems.Count > 0) listView1_MouseDoubleClick(listView1, null);
            if (listView2.SelectedItems.Count > 0) listView2_MouseDoubleClick(FileManager.ActiveForm, null);
        }

        private void CutItem()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                WorkingWithFiles.AddToBuffer(listView1, path1, false);
                foreach (int n in listView1.SelectedIndices)
                {
                    listView1.Items[n].ForeColor = Color.Gray;
                }
            }
            if (listView2.SelectedItems.Count > 0)
                WorkingWithFiles.AddToBuffer(listView2, path2, false);
            foreach (int n in listView2.SelectedIndices)
            {
                listView2.Items[n].ForeColor = Color.Gray;
            }
        }

        private void CopyItem()
        {
            if (listView1.SelectedItems.Count > 0) WorkingWithFiles.AddToBuffer(listView1, path1, true);
            if (listView2.SelectedItems.Count > 0) WorkingWithFiles.AddToBuffer(listView2, path2, true);
        }

        private void PasteItem()
        {
            if (splitContainer3.ActiveControl.Name == splitContainer1.Name)
            {
                try { WorkingWithFiles.Paste(path1); }
                catch
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ErrorText);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ErrorText);
                    MessageBox.Show(lvp.ErrorText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Refresh(listView1, ref path1, address1);
                Refresh(listView2, ref path2, address2);
            }
            else
            {
                try
                {
                    WorkingWithFiles.Paste(path2);
                    MessageBox.Show(lvp.OperationCompletedText, lvp.InfoTitleText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ErrorText);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ErrorText);
                    MessageBox.Show(lvp.ErrorText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Refresh(listView1, ref path1, address1);
                Refresh(listView2, ref path2, address2);
            }
        }

        private void DeleteItem()
        {
            if (listView1.SelectedItems.Count > 0) WorkingWithFiles.Delete(listView1, path1);
            if (listView2.SelectedItems.Count > 0) WorkingWithFiles.Delete(listView2, path2);
            Refresh(listView1, ref path1, address1);
            Refresh(listView2, ref path2, address2);
        }

        private void CopyTXTTool()
        {
            string[] files;
            if (splitContainer3.ActiveControl.Name == splitContainer1.Name)
                files = Directory.GetFiles(path1, "*.txt");
            else files = Directory.GetFiles(path2, "*.txt");
            copyFiles.Clear();
            copyFolders.Clear();
            copy = true;
            foreach (string s in files)
                copyFiles.Add(s);
        }

        private void CopyHTMLTool()
        {
            if (listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0)
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.NoHTMLSelectedText);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.NoHTMLSelectedText);
                MessageBox.Show(lvp.NoHTMLSelectedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            copyFiles.Clear();
            copyFolders.Clear();
            string s = "";
            if (listView1.SelectedItems.Count > 0)
            {
                s = path1 + '\\' + listView1.SelectedItems[0].Text;
            }
            else
            {
                s = path2 + '\\' + listView2.SelectedItems[0].Text;
            }
            string s2;
            s2 = s.Substring(s.LastIndexOf('.') + 1);
            if (s2 != "htm")
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.IsNotHTMLText);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.IsNotHTMLText);
                MessageBox.Show(lvp.IsNotHTMLText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            copyFiles.Add(s);
            s = s.Substring(0, s.LastIndexOf('.')) + "_files";
            copyFolders.Add(s);
            copy = true;
        }

        private void Refresh(ListView sender, ref string path, ToolStripTextBox address)
        {
            try
            {
                string[] files = Directory.GetFiles(path);
                string[] directories = Directory.GetDirectories(path);
                address.Text = path;
                sender.SmallImageList = imageList1;
                sender.Items.Clear();
                {
                    string dirName = "";
                    for (int i = 0; i < directories.Length; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        dirName = directories[i].Substring(directories[i].LastIndexOf('\\') + 1);
                        lvi.Text = dirName;
                        lvi.ImageIndex = 0;
                        sender.Items.Add(lvi);
                    }
                    string fileName = "";
                    for (int i = 0; i < files.Length; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        fileName = files[i].Substring(files[i].LastIndexOf('\\') + 1);
                        lvi.Text = fileName;
                        lvi.ImageIndex = 1;
                        sender.Items.Add(lvi);
                    }
                    sender.View = View.List;
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportAccessDenied, path);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportAccessDenied, path);
                MessageBox.Show(lvp.AccessDeniedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                path = address.Text;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportDirectoryNotFound, path);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportDirectoryNotFound, path);
                MessageBox.Show(lvp.DirectoryNotFoundText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                path = address.Text;
            }
            catch (System.IO.IOException)
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.DriveNotReadyText, path);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.DriveNotReadyText, path);
                MessageBox.Show(lvp.DriveNotReadyText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayHelpInfo()
        {
            MessageBox.Show(lvp.HelpInfoText, helpToolStripMenuItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayAboutInfo()
        {
            MessageBox.Show(lvp.AboutInfoText, aboutToolStripMenuItem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage();
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ChangePanelsSize();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewDoubleClick(listView1, ref path1, address1);
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewDoubleClick(listView2, ref path2, address2);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeViewClick(treeView1, listView1, ref path1, address1, e);
        }

        private void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeViewClick(treeView2, listView2, ref path2, address2, e);
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            TreeViewKeyDown(treeView1, listView1, ref path1, address1, e);
        }

        private void treeView2_KeyDown(object sender, KeyEventArgs e)
        {
            TreeViewKeyDown(treeView2, listView2, ref path2, address2, e);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedImageIndex = e.Node.ImageIndex;
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView2.SelectedImageIndex = e.Node.ImageIndex;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            PanelsPerformance.TreeViewBeforeExpand(treeView1, e);
        }

        private void treeView2_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            PanelsPerformance.TreeViewBeforeExpand(treeView2, e);
        }

        private void LevelUpButton1_Click(object sender, EventArgs e)
        {
            LevelUp(listView1, ref path1, address1);
        }

        private void LevelUpButton2_Click(object sender, EventArgs e)
        {
            LevelUp(listView2, ref path2, address2);
        }

        private void NewFolderButton1_Click(object sender, EventArgs e)
        {
            FileCreation = false;
            NewFolderClick(listView1, ref path1, address1);
        }

        private void NewFolderButton2_Click(object sender, EventArgs e)
        {
            FileCreation = false;
            NewFolderClick(listView2, ref path2, address2);
        }

        private void NewFileButton1_Click(object sender, EventArgs e)
        {
            FileCreation = true;
            NewFolderClick(listView1, ref path1, address1);
        }

        private void NewFileButton2_Click(object sender, EventArgs e)
        {
            FileCreation = true;
            NewFolderClick(listView2, ref path2, address2);
        }

        private void address1_KeyDown(object sender, KeyEventArgs e)
        {
            addressKeyDown(listView1, ref path1, address1, e);
        }

        private void address2_KeyDown(object sender, KeyEventArgs e)
        {
            addressKeyDown(listView2, ref path2, address2, e);
        }

        private void RefreshButton1_Click(object sender, EventArgs e)
        {
            Refresh(listView1, ref path1, address1);
        }

        private void RefreshButton2_Click(object sender, EventArgs e)
        {
            Refresh(listView2, ref path2, address2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenItem();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutItem();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteItem();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void copyTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyTXTTool();
        }

        private void copyHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyHTMLTool();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            FMFormLoad();
        }

        private void englishToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckingLanguageShortcut();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView1_MouseDoubleClick(this, null);
            }
        }

        private void listView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listView2_MouseDoubleClick(this, null);
            }
        }

        public class CReportBuilder : FileManager // Builder
        {
            ~CReportBuilder() { }
            public virtual void CreateHeader(ref string ReportSTR) { }
            public virtual void ChangedLanguage(ref string ReportSTR, string EventType) { }
            public virtual void ReportEvent(ref string ReportSTR, string EventType, string EventMessage) { }
            public virtual void ReportEvent(ref string ReportSTR, string EventType, string EventMessage, string path) { }
            public virtual void PathEvent(ref string ReportSTR, string EventType, string EventMessage1, string pathOld, string EventMessage2, string pathNew) { }
            public virtual void CreateBody() { }
            public virtual void CreateFooter(ref string ReportSTR) { }
            public virtual void Print(ref string ReportSTRTXT, ref string ReportSTRHTML)
            {
                string FilePath;
                FilePath = ("File Manager Report" + "" + ".txt").ToString();
                StreamWriter ReportToFileTXT = new StreamWriter(FilePath, true, Encoding.GetEncoding(1251));
                ReportToFileTXT.WriteLine(ReportSTRTXT);
                ReportToFileTXT.Close();
                FilePath = ("File Manager Report" + "" + ".html").ToString();
                StreamWriter ReportToFileHTML = new StreamWriter(FilePath, true, Encoding.GetEncoding(1251));
                ReportToFileHTML.WriteLine(ReportSTRHTML);
                ReportToFileHTML.Close();
            }
        };

        public class CTextReportBuilder : CReportBuilder // ConcreteBuilder1
        {
            ~CTextReportBuilder() { }
            public override void CreateHeader(ref string ReportSTR)
            {
                LocalDateTime = DateTime.Now;
                ReportSTR = lvp.ReportHeaderText + LocalDateTime.ToString() + "\n";
            }

            public override void ChangedLanguage(ref string ReportSTR, string EventType)
            {
                ReportSTR += DateTime.Now + " " + EventType + "\n";
            }

            public override void ReportEvent(ref string ReportSTR, string EventType, string EventMessage)
            {
                ReportSTR += DateTime.Now + " " + EventType + " " + EventMessage + "\n";
            }

            public override void ReportEvent(ref string ReportSTR, string EventType, string EventMessage, string path)
            {
                ReportSTR += DateTime.Now + " " + EventType + " " + EventMessage + " " + path + "\n";
            }

            public override void PathEvent(ref string ReportSTR, string EventType, string EventMessage1, string pathOld, string EventMessage2, string pathNew)
            {
                ReportSTR += DateTime.Now + " " + EventType + " " + EventMessage1 + " "+ pathOld + " " + EventMessage2 + pathNew + "\n";
            }

            public new void CreateBody()
            {

            }
            public override void CreateFooter(ref string ReportSTR)
            {
                LocalDateTime = DateTime.Now;
                ReportSTR += lvp.ReportFooterText + LocalDateTime.ToString() + "\n";
            }
        };

        public class CHTMLReportBuilder : CReportBuilder // ConcreteBuilder2
        {

            ~CHTMLReportBuilder() { }
            public override void CreateHeader(ref string ReportSTR)
            {
                LocalDateTime = DateTime.Now;
                ReportSTR = "<HTML><BODY>\n<H1>"+lvp.ReportHeaderText + LocalDateTime.ToString() + "</H1>\n";
            }

            public override void ChangedLanguage(ref string ReportSTR, string EventType)
            {
                ReportSTR +="<p>"+ DateTime.Now + " " + EventType + "</p>\n";
            }

            public override void ReportEvent(ref string ReportSTR, string EventType, string EventMessage)
            {
                ReportSTR +="<p>"+ DateTime.Now + " " + EventType + " " + EventMessage + "</p>\n";
            }

            public override void ReportEvent(ref string ReportSTR, string EventType, string EventMessage, string path)
            {
                ReportSTR +="<p>"+ DateTime.Now + " " + EventType + " " + EventMessage + " " + path + "</p>\n";
            }

            public override void PathEvent(ref string ReportSTR, string EventType, string EventMessage1, string pathOld, string EventMessage2, string pathNew)
            {
                ReportSTR +="<p>"+ DateTime.Now + " " + EventType + " " + EventMessage1 + " " + pathOld + " " + EventMessage2 + pathNew + "/<p>\n";
            }

            public new void CreateBody()
            {

            }
            public override void  CreateFooter(ref string ReportSTR)
            {
                LocalDateTime = DateTime.Now;
                ReportSTR += "<p><i>" + lvp.ReportFooterText + LocalDateTime.ToString() + "</i></p>\n</body></html>\n";
            }
        };

        private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            CTextReportBuilder ReportT = new CTextReportBuilder();
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            ReportT.CreateFooter(ref ReportSTRTXT);
            ReportH.CreateFooter(ref ReportSTRHTML);
            ReportT.Print(ref ReportSTRTXT, ref ReportSTRHTML);
            Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHelpInfo();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAboutInfo();
        }
    }

    partial class lvp // lvp - language variables pack
                      //Клас, що зберігає змінні, потрібні для перекладу інтерфейсу файлового менеджера
    {
        public static string DirectoryNotFoundText = "Directory not found",
        HelpInfoText="File Manager supported functionality:\n"+
            "- Navigating through the file system\n"+
"- Files moving, copying, deleting\n"+
"- Copying all TXT from the current folder\n"+
"- Copying HTML files\n"+
"- Creating new folders and files\n"+
"- Editing text files in a built-in editor\n"+
"Editor functionality:\n"+
"    - Word Wrapping\n"+
"    - Changing Text Font Preferences\n"+
"    - Filtering words with the only 1 appearance\n"+
"    - Modifing text case like in sentences\n\n"+
"- Changing interface language : English or Ukrainian\n"+
"- Monitoring actions, performed during program session;\n"+
"- Saving report in both TXT and HTML formats.",
        AboutInfoText= "© D. Zakharchuk, 2016",
        LocalDiskText = "Local Disk",
        CDROMDriveText = "CD-ROM Drive",
        RemovableDiskText = "Removable Disk",
        NetworkDiskText = "Network Disk",
        FloppyDriveText = "Floppy Drive",
        ErrorText = "ERROR",
        IncorrectPathText = "Incorrect path",
        AccessDeniedText = "Access denied!",
        OperationCompletedText = "Completed",
        NoHTMLSelectedText = "No HTML file selected",
        InfoTitleText = "Info",
        UnableToOpenFileText = "Unable to open the file",
        FolderAlreadyExistsText = "Folder already exists!",
        FileAlreadyExistsText = "File already exists!",
        EmptyNameErrorText = "Name cannot be empty!",
        OpenText = "Open",
        CutText = "Cut",
        CopyText = "Copy",
        PasteText = "Paste",
        DeleteText = "Delete",
        CopyTXTText = "Copy TXT",
        CopyHTMLText = "Copy HTML",
        SaveText = "Save",
        SaveAsText = "Save As",
        PrintText = "Print",
        UndoText = "Undo",
        SelectAllText = "Select all",
        ExtraOptionsText = "Extra Options",
        Only1RepeatText = "Find only once words",
        ModifyCaseText = "Modify case",
        FontText = "Font",
        WordWrapText = "Word Wrap",
        FileText = "File",
        EditText = "Edit",
        FormatText = "Format",
        TextEditorNameText = "Text Editor ",
        Form2NameText,
        EnterNameForm2Text,
        ReportHeaderText = "File Manager Report ",
        ReportFooterText = "Thank You! ",
        ReportLanguageChanged = "Мову змінено на англійську. File manager is now displaying in English.",
        ReportDirChanged = "Path changed. ",
        ReportDirChangedTo = "The following directory has been opened:",
        ReportChanges = "Changes.",
        ReportFileOpened = "The following file has been opened:",
        ReportDirCreated = "The following directory has been created:",
        ReportFileCreated = "The following file has been created:",
        ConfirmDelete = "Are you sure to delete?",
        ReportFileDeleted = "The following file has been deleted:",
        ReportDirDeleted = "The folowing directory has been deleted",
        DirectoryText = "Directory",
        ReportCut = "has been cut to:",
        ReportCopied = "has been copied to:",
        ReportAccessDenied = "Access denied to:",
        ReportDirectoryNotFound = "The following directory was not found:",
        ReportIncorrectPath = "The following path is incorrect:",
        DriveNotReadyText = "Drive is not ready",
        ReportFolderAlreadyExists = "The following folder already exists:",
        ReportFileAlreadyExists = "The following file already exists:",
        ReportUnableToOpen = "Unable to open the file:",
        IsNotHTMLText = "Is not HTML!",
        TryingCopyToSubsFolder = "Your destination folder is a subfolder of a source folder";
    }

    partial class PanelsPerformance
    {
        internal static void InitializeTree(TreeView sender)
        {
            sender.Nodes.Clear();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int n = 0;
            foreach (DriveInfo d in allDrives)
            {
                try
                {
                    int DriveTypeIndex = 0;
                    TreeNode tn = new TreeNode();
                    tn.Name = d.Name;
                    tn.Text = d.DriveType + " ";
                    if (tn.Text == "Fixed ")
                        DriveTypeIndex = 0;

                    if (tn.Text == "CDRom ")
                        DriveTypeIndex = 3;

                    if (tn.Text == "Removable ")
                        DriveTypeIndex = 4;

                    if (tn.Text == "Network ")
                        DriveTypeIndex = 5;

                    if (d.IsReady == true)
                    {
                        if (d.VolumeLabel == "")
                        {
                            if (tn.Text == "Fixed ")
                                tn.Text = lvp.LocalDiskText + " (" + d.Name + ")";

                            if (tn.Text == "CDRom ")
                                tn.Text = lvp.CDROMDriveText + " (" + d.Name + ")";

                            if (tn.Text == "Removable ")
                                tn.Text = lvp.RemovableDiskText + " (" + d.Name + ")";

                            if (tn.Text == "Network ")
                                tn.Text = lvp.NetworkDiskText + " (" + d.Name + ")";

                            if ((d.Name == "A:\\") && (d.TotalSize < 3000000))
                            {
                                DriveTypeIndex = 2;
                                tn.Text = lvp.FloppyDriveText + " (" + d.Name + ")";
                            }
                        }
                        else
                        {
                            if ((d.Name == "A:\\") && (d.TotalSize < 3000000))
                                DriveTypeIndex = 2;
                            tn.Text = d.VolumeLabel + " (" + d.Name + ")";
                        }
                    }
                    else
                    {
                        if (tn.Text == "Fixed ")
                            tn.Text = lvp.LocalDiskText + " (" + d.Name + ")";

                        if (tn.Text == "CDRom ")
                            tn.Text = lvp.CDROMDriveText + " (" + d.Name + ")";

                        if (tn.Text == "Removable ")
                            tn.Text = lvp.RemovableDiskText + " (" + d.Name + ")";

                        if (tn.Text == "Network ")
                            tn.Text = lvp.NetworkDiskText + " (" + d.Name + ")";

                        if (d.Name == "A:\\")
                        {
                            DriveTypeIndex = 2;
                            tn.Text = lvp.FloppyDriveText + " (" + d.Name + ")";
                        }
                    }
                    sender.Nodes.Add(tn.Name, tn.Text, DriveTypeIndex);
                    string t = "";
                    string[] str2 = Directory.GetDirectories(d.Name);
                    foreach (string s2 in str2)
                    {
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        ((TreeNode)sender.Nodes[n]).Nodes.Add(s2, t, 1);
                    }
                }
                catch { }
                n++;
            }
        }

        internal static void TreeViewBeforeExpand(TreeView sender, TreeViewCancelEventArgs e)
        {
            TreeNodeCollection daughter = e.Node.Nodes;
            foreach (TreeNode tn in daughter)
            {
                tn.Nodes.Clear();
                try
                {
                    string s = tn.Name;
                    string[] str2 = Directory.GetDirectories(s);
                    string t;
                    foreach (string s2 in str2)
                    {
                        t = s2.Substring(s2.LastIndexOf('\\') + 1);
                        tn.Nodes.Add(s2, t, 1);
                    }
                }
                catch { }
            }
        }
    }

    partial class WorkingWithFiles:FileManager
    {
        internal static void OpenFile(ListView sender, string path)
        {
            string s = path.Substring(path.LastIndexOf(".") + 1);
            if(File.Exists(path))
            { 
            if (s != "txt")
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportUnableToOpen, path);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportUnableToOpen, path);
                    MessageBox.Show(lvp.UnableToOpenFileText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.ReportFileOpened, path);
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.ReportFileOpened, path);
                    TextEditor tE1 = new TextEditor(path);
                    tE1.Show();
                }
            }
            else MessageBox.Show(lvp.UnableToOpenFileText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void CreateDir(string path, string fName)
        {
            try
            {
                if (!Directory.Exists(path + '\\' + fName))
                {
                    Directory.CreateDirectory(path + '\\' + fName);
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.ReportDirCreated, path + '\\' + fName);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.ReportDirCreated, path + '\\' + fName);
                }
                else
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportFolderAlreadyExists, path);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportFolderAlreadyExists, path);
                    MessageBox.Show(lvp.FolderAlreadyExistsText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportAccessDenied, path);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportAccessDenied, path);
                MessageBox.Show(lvp.AccessDeniedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void CreateFile(string path, string fileName)
        {
            try
            {
                if (!File.Exists(path + '\\' + fileName))
                {
                    File.Create(path + '\\' + fileName);
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.ReportFileCreated, path + '\\' + fileName);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.ReportFileCreated, path + '\\' + fileName);
                }
                else
                {
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();
                    ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportFileAlreadyExists, path);
                    ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportFileAlreadyExists, path);
                    MessageBox.Show(lvp.FileAlreadyExistsText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                CTextReportBuilder ReportT = new CTextReportBuilder();
                ReportT.ReportEvent(ref ReportSTRTXT, lvp.ErrorText, lvp.ReportAccessDenied, path);
                ReportH.ReportEvent(ref ReportSTRHTML, lvp.ErrorText, lvp.ReportAccessDenied, path);
                MessageBox.Show(lvp.AccessDeniedText, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static void Delete(ListView sender, string path)
        {
            if (sender.SelectedItems.Count > 0)
            {
                if((MessageBox.Show(lvp.ConfirmDelete, lvp.InfoTitleText, MessageBoxButtons.YesNo, MessageBoxIcon.Question))==DialogResult.Yes)
                {
                    path += '\\';
                    CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
                    CTextReportBuilder ReportT = new CTextReportBuilder();       
                    foreach (int n in sender.SelectedIndices)
                    {
                        if (sender.Items[n].ImageIndex == 0)
                        {
                            ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.ReportDirDeleted, path + sender.Items[n].Text);
                            ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.ReportDirDeleted, path + sender.Items[n].Text);
                            Directory.Delete(path + sender.Items[n].Text, true); //видалення всієї теки, а також всього, що всередені неї
                        }
                        else // файл
                        {
                            ReportH.ReportEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.ReportFileDeleted, path + sender.Items[n].Text);
                            ReportT.ReportEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.ReportFileDeleted, path + sender.Items[n].Text);
                            File.Delete(path + sender.Items[n].Text);
                        }
                    }
                }
            }
        }

        internal static void AddToBuffer(ListView sender, string path, bool flag)
        {
            if (sender.SelectedItems.Count > 0)
            {
                copyFolders.Clear();
                copyFiles.Clear();
                copy = flag;
                path += '\\';
                foreach (int n in sender.SelectedIndices)
                {
                    if (sender.Items[n].ImageIndex == 0) // тека
                        copyFolders.Add(path + sender.Items[n].Text);
                    else // файл
                        copyFiles.Add(path + sender.Items[n].Text);
                }
            }
        }

        internal static void CopyFile(string from, string to, bool overwrite)
        {
            {
                int i;
                for (i = from.Length; from[i - 1] == '\\'; i--) ;
                from = from.Substring(0, i);
            }
            string fileName = from.Substring(from.LastIndexOf('\\'));
            File.Copy(from, to + '\\' + fileName, overwrite);
        }

        internal static void CopyFolder(string from, string to)
        {// copyFolder("D:\1\2","C:\") result "C:\2"
            {
                int i;
                for (i = from.Length; from[i - 1] == '\\'; i--) ;
                from = from.Substring(0, i);
            }

            string fName = from.Substring(from.LastIndexOf('\\') + 1);
            to += '\\' + fName;
            if (!Directory.Exists(to))
                Directory.CreateDirectory(to);
            string[] files = Directory.GetFiles(from);
            foreach (string s in files)
                CopyFile(s, to, true);
            string[] folders = Directory.GetDirectories(from);
            foreach (string s in folders)
                CopyFolder(s, to);
        }

        internal static void Paste(string path)
        {
            {
                string t = "";
                t += path[0];
                for (int i = 1; i < path.Length; i++)
                    if (path[i] != '\\' || path[i - 1] != '\\') t += path[i];
                path = t;
            }
            foreach (string s in copyFolders)
            {// перевірка на копіювання в цю ж саму теку
                string t = "";
                t += s[0];
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] != '\\' || s[i - 1] != '\\') t += s[i];
                }
                if (path.Contains(t))
                {       
                    MessageBox.Show(lvp.TryingCopyToSubsFolder +" " +path, lvp.ErrorText, MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            foreach (string s in copyFiles) // копіювання файлів
                CopyFile(s, path, true);
            foreach (string s in copyFolders)
                CopyFolder(s, path);
            CHTMLReportBuilder ReportH = new CHTMLReportBuilder();
            CTextReportBuilder ReportT = new CTextReportBuilder();
            if (!copy)
            {//при переміщенні видаляємо зі старої локації
                foreach (string s in copyFiles)
                {
                    File.Delete(s);
                    ReportT.PathEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.FileText, s, lvp.ReportCut, path);
                    ReportH.PathEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.FileText, s, lvp.ReportCut, path);
                }
                    foreach (string s in copyFolders)
                {
                    Directory.Delete(s, true); //видалення теки разом з її вмістом
                    ReportT.PathEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.DirectoryText, s, lvp.ReportCut, path);
                    ReportH.PathEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.DirectoryText, s, lvp.ReportCut, path);
                }
            }
            else if(copy)
            {
                foreach (string s in copyFiles)
                {

                    ReportT.PathEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.FileText, s, lvp.ReportCopied, path);
                    ReportH.PathEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.FileText, s, lvp.ReportCopied, path);
                }
                foreach (string s in copyFolders)
                {
                    ReportT.PathEvent(ref ReportSTRTXT, lvp.ReportChanges, lvp.DirectoryText, s, lvp.ReportCopied, path);
                    ReportH.PathEvent(ref ReportSTRHTML, lvp.ReportChanges, lvp.DirectoryText, s, lvp.ReportCopied, path);
                }
            }
            copyFiles.Clear(); copyFolders.Clear(); copy = false;
        }
    }
}
