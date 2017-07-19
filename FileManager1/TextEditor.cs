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
    public partial class TextEditor : Form
    {
        string path = "";
        public TextEditor()
        {
            InitializeComponent();
            fileToolStripMenuItem.Text = lvp.FileText;
            editToolStripMenuItem.Text = lvp.EditText;
            formatToolStripMenuItem.Text = lvp.FormatText;
        }

        public TextEditor(string s)
        {//завантаження редактора разом з текстовим файлом
            InitializeComponent();
            LoadFile(s);
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadFile(openFileDialog1.FileName);
        }

        private void LoadFile(string newPath)
        {
            richTextBox1.Clear(); path = "";
            if (!File.Exists(newPath))
            {
                MessageBox.Show("File doesn't exist!");
                return;
            }
            string s = newPath.Substring(newPath.LastIndexOf('.') + 1);
            if (s != "txt")
            {
                newPath += " isn't txt file!";
                MessageBox.Show(newPath, "ERROR");
                return;
            }
            else
            {
                path = newPath;
                StreamReader streamReader = new StreamReader(newPath); //Відкриття файлу для читання
                string str = ""; //У цю змінну будемо записувати текст з файлу
                str = streamReader.ReadLine();
                while (!streamReader.EndOfStream) //Цикл продовжується до кінця файлу
                {
                    str += "\n" + streamReader.ReadLine(); //У змінну порядково записуємо вміст файлу
                }
                richTextBox1.Text = str;
                streamReader.Close();
            }
        }

        private void SaveFile()
        {
            StreamWriter write_text = new StreamWriter(path, false, Encoding.GetEncoding(1251));  //Класс для перезаписи в файл
            write_text.WriteLine(richTextBox1.Text); //Запис вміст у файл з тектового поля richTextBox1
            write_text.Close(); // Закриття файлу
        }

        private void UpdateCursorPositionInfo()
        {
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);
            line++; column++;
            LineStatusLabel.Text = "ln " + line.ToString() +", col " + column.ToString();
        }

        private void ApplyFont()
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog1.Font;
                this.richTextBox1.Font = font;
            }
        }

        private void WordWrapping()
        {
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }

            else
                if (wordWrapToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
        }

        private void FindOnlyOnceWords()
        {
            string pathT = path + "~~.txt";
            StreamWriter write_text = new StreamWriter(pathT, false, Encoding.GetEncoding(1251));
            Dictionary<string, int> map = new Dictionary<string, int>();
            string str = richTextBox1.Text;
            int i = 0; int l = str.Length;
            while (i < l)
            {// Розбиття тексту на слова; у map записується кількість входжень
                while (i < l && (str[i] == ' ' || str[i] == '\n')) i++;
                if (i < l)
                {
                    string s = "";
                    int i1 = 0;
                    while (i + i1 < l && (str[i + i1] != ' ' && str[i + i1] != '\n')) i1++;
                    s = str.Substring(i, i1);
                    if (!map.ContainsKey(s)) map.Add(s, 1);
                    else map[s] = 2;
                    i += i1 + 1;
                }
            }

            foreach (KeyValuePair<string, int> s in map)
            {
                if (s.Value == 1) write_text.WriteLine(s.Key);
            }
            write_text.Close();
            var tE2 = new TextEditor(pathT);
            tE2.ShowDialog();
            tE2.Dispose();
            File.Delete(pathT);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordWrapping();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateCursorPositionInfo();
        }

        private void onlyOnceWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindOnlyOnceWords();
        }

        private void LoadTextEditor()
        {
            this.Text = lvp.TextEditorNameText+path;
            fileToolStripMenuItem.Text = lvp.FileText;
            editToolStripMenuItem.Text = lvp.EditText;
            formatToolStripMenuItem.Text = lvp.FormatText;
            openToolStripMenuItem.Text = lvp.OpenText;
            saveToolStripMenuItem.Text = lvp.SaveText;
            saveAsToolStripMenuItem.Text = lvp.SaveAsText;
            printToolStripMenuItem.Text = lvp.PrintText;
            undoToolStripMenuItem.Text = lvp.UndoText;
            cutToolStripMenuItem.Text = lvp.CutText;
            copyToolStripMenuItem.Text = lvp.CopyText;
            pasteToolStripMenuItem.Text = lvp.PasteText;
            selectAllToolStripMenuItem.Text = lvp.SelectAllText;
            extraOptionsToolStripMenuItem.Text = lvp.ExtraOptionsText;
            only1RepeatToolStripMenuItem.Text = lvp.Only1RepeatText;
            modifyCaseToolStripMenuItem.Text = lvp.ModifyCaseText;
            fontToolStripMenuItem.Text = lvp.FontText;
            wordWrapToolStripMenuItem.Text = lvp.WordWrapText;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            LoadTextEditor();
        }
        
        public void ModCase()
        {
            var sourcestring = richTextBox1.Text;
            var lowerCase = sourcestring.ToLower();//to lower case
            //Дивимось місце заміни літери:
            var r = new System.Text.RegularExpressions.Regex(@"(^[a-z])|[?!.\n]\s+(.)|((^[\n]|[?!.\n](.)))", System.Text.RegularExpressions.RegexOptions.ExplicitCapture);
            // Потрібне місце заміняємо на UpperCase
            var result = r.Replace(lowerCase, s => s.Value.ToUpper());
            richTextBox1.Text = result;
        }

        private void SaveAsFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)

            if (saveFileDialog1.FileName != "")
                {
                    path = saveFileDialog1.FileName;
                    TextEditor.ActiveForm.Text= lvp.TextEditorNameText + path;
                    StreamWriter write_text = new StreamWriter(saveFileDialog1.OpenFile());  //Класс для перезаписи в файл
                    write_text.WriteLine(richTextBox1.Text); //Запис вміст у файл з тектового поля richTextBox1
                    write_text.Close(); // Закриття файлу
                }

            }

        private void modifyCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ModCase();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }
    }
}
