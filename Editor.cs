using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace etml_Editor
{
    public partial class Editor : Form
    {
        private string currentFilePath = null;
        private bool isModified = false;

        public Editor()
        {
            InitializeComponent();
            UpdateStatusLabel();
            editorTextBox.KeyUp += (sender, e) => UpdateStatusLabel();
        }

        #region 文件操作

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckSaveChanges())
            {
                editorTextBox.Clear();
                currentFilePath = null;
                isModified = false;
                UpdateWindowTitle();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckSaveChanges())
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "ETML文件 (*.etml;*.etm)|*.etml;*.etm|所有文件 (*.*)|*.*";
                openFileDialog.Title = "打开ETML文件";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        editorTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                        currentFilePath = openFileDialog.FileName;
                        isModified = false;
                        UpdateWindowTitle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("无法打开文件: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFilePath == null)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                try
                {
                    File.WriteAllText(currentFilePath, editorTextBox.Text);
                    isModified = false;
                    UpdateWindowTitle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法保存文件: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ETML文件 (*.etml)|*.etml|ETM文件 (*.etm)|*.etm|所有文件 (*.*)|*.*";
            saveFileDialog.Title = "保存ETML文件";
            saveFileDialog.FileName = "document.etml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, editorTextBox.Text);
                    currentFilePath = saveFileDialog.FileName;
                    isModified = false;
                    UpdateWindowTitle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法保存文件: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckSaveChanges())
            {
                Application.Exit();
            }
        }

        private bool CheckSaveChanges()
        {
            if (isModified)
            {
                DialogResult result = MessageBox.Show("是否保存当前文档的更改？", "保存更改", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                    return !isModified; // 如果仍然未保存（例如用户取消保存），则返回false
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void UpdateWindowTitle()
        {
            string title = "ETML编辑器";
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                title += " - " + Path.GetFileName(currentFilePath);
            }
            if (isModified)
            {
                title += " *";
            }
            this.Text = title;
        }

        #endregion

        #region 文本格式化

        private void boldButton_Click(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionLength > 0)
            {
                string selectedText = editorTextBox.SelectedText;
                string formattedText = "**" + selectedText + "**";
                int startPos = editorTextBox.SelectionStart;
                editorTextBox.SelectedText = formattedText;
                editorTextBox.SelectionStart = startPos;
                editorTextBox.SelectionLength = formattedText.Length;
                editorTextBox.Focus();
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionLength > 0)
            {
                string selectedText = editorTextBox.SelectedText;
                string formattedText = "$" + selectedText + "$";
                int startPos = editorTextBox.SelectionStart;
                editorTextBox.SelectedText = formattedText;
                editorTextBox.SelectionStart = startPos;
                editorTextBox.SelectionLength = formattedText.Length;
                editorTextBox.Focus();
            }
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionLength > 0)
            {
                string selectedText = editorTextBox.SelectedText;
                string formattedText = "__" + selectedText + "__";
                int startPos = editorTextBox.SelectionStart;
                editorTextBox.SelectedText = formattedText;
                editorTextBox.SelectionStart = startPos;
                editorTextBox.SelectionLength = formattedText.Length;
                editorTextBox.Focus();
            }
        }

        private void strikethroughButton_Click(object sender, EventArgs e)
        {
            if (editorTextBox.SelectionLength > 0)
            {
                string selectedText = editorTextBox.SelectedText;
                string formattedText = "~~" + selectedText + "~~";
                int startPos = editorTextBox.SelectionStart;
                editorTextBox.SelectedText = formattedText;
                editorTextBox.SelectionStart = startPos;
                editorTextBox.SelectionLength = formattedText.Length;
                editorTextBox.Focus();
            }
        }

        private void headerButton_Click(object sender, EventArgs e)
        {
            using (HeaderForm headerForm = new HeaderForm())
            {
                if (headerForm.ShowDialog() == DialogResult.OK)
                {
                    string headerMark = new string('#', headerForm.HeaderLevel);
                    string text = editorTextBox.SelectionLength > 0 ? editorTextBox.SelectedText : "标题";
                    string formattedText = headerMark + " " + text + Environment.NewLine;
                    int startPos = editorTextBox.SelectionStart;
                    editorTextBox.SelectedText = formattedText;
                    editorTextBox.SelectionStart = startPos + formattedText.Length;
                    editorTextBox.Focus();
                }
            }
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            using (ListForm listForm = new ListForm())
            {
                if (listForm.ShowDialog() == DialogResult.OK)
                {
                    string text = editorTextBox.SelectionLength > 0 ? editorTextBox.SelectedText : "列表项";
                    string listItemPrefix = "";

                    switch (listForm.ListType)
                    {
                        case ListType.Unordered:
                            listItemPrefix = "-- ";
                            break;
                        case ListType.Ordered:
                            listItemPrefix = "1- ";
                            break;
                        case ListType.Todo:
                            listItemPrefix = "?- ";
                            break;
                        case ListType.TodoDone:
                            listItemPrefix = "!- ";
                            break;
                    }

                    string formattedText = listItemPrefix + text + Environment.NewLine;
                    int startPos = editorTextBox.SelectionStart;
                    editorTextBox.SelectedText = formattedText;
                    editorTextBox.SelectionStart = startPos + formattedText.Length;
                    editorTextBox.Focus();
                }
            }
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            using (LinkForm linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == DialogResult.OK)
                {
                    string text = editorTextBox.SelectionLength > 0 ? editorTextBox.SelectedText : "链接文本";
                    string url = linkForm.Url;
                    string formattedText = string.Format("->[{0}]({1})") + text + ")(" + url + ")";
                    int startPos = editorTextBox.SelectionStart;
                    editorTextBox.SelectedText = formattedText;
                    editorTextBox.SelectionStart = startPos;
                    editorTextBox.SelectionLength = formattedText.Length;
                    editorTextBox.Focus();
                }
            }
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            using (CodeForm codeForm = new CodeForm())
            {
                if (codeForm.ShowDialog() == DialogResult.OK)
                {
                    string code = editorTextBox.SelectionLength > 0 ? editorTextBox.SelectedText : "// 代码内容";
                    string formattedText = string.Format("<code lang=\"{0}\">{1}</code>", codeForm.Language, code);
                    int startPos = editorTextBox.SelectionStart;
                    editorTextBox.SelectedText = formattedText;
                    editorTextBox.SelectionStart = startPos;
                    editorTextBox.SelectionLength = formattedText.Length;
                    editorTextBox.Focus();
                }
            }
        }

        #endregion

        #region 预览功能

        private void previewButton_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratePreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("预览生成错误: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editorTextBox_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
            UpdateWindowTitle();
        }

        private void editorTextBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel();
        }

        private void GeneratePreview()
        {
            try
            {
                string htmlContent = ConvertEtmlToHtml(editorTextBox.Text);
                previewWebBrowser.DocumentText = htmlContent;
            }
            catch (Exception ex)
            {
                throw new Exception("预览生成失败: " + ex.Message);
            }
        }

        private string ConvertEtmlToHtml(string etmlContent)
        {
            // 简化版的ETML解析器
            string html = "<!DOCTYPE html><html><head><meta charset='utf-8'><title>ETML预览</title>";
            html += "<style>body{font-family:微软雅黑,Verdana,sans-serif;margin:20px;line-height:1.6;}";
            html += "h1{font-size:2em;color:#333;}";
            html += "h2{font-size:1.8em;color:#444;}";
            html += "h3{font-size:1.6em;color:#555;}";
            html += "code{font-family:Consolas,Monaco,monospace;background:#f5f5f5;padding:2px 4px;border-radius:3px;}";
            html += "pre{background:#f5f5f5;padding:10px;border-radius:5px;overflow-x:auto;}";
            html += "blockquote{border-left:4px solid #ddd;padding-left:10px;color:#666;}";
            html += "table{border-collapse:collapse;width:100%;margin:10px 0;}";
            html += "th,td{border:1px solid #ddd;padding:8px;text-align:left;}";
            html += "th{background-color:#f2f2f2;}";
            html += "img{max-width:100%;height:auto;}";
            html += "</style></head><body>";

            // 提取样式定义
            var styleRegex = new Regex(@"<style>(.*?)</style>", RegexOptions.Singleline);
            var styleMatch = styleRegex.Match(etmlContent);
            if (styleMatch.Success)
            {
                // 这里可以解析样式定义并添加到HTML中
                string styleContent = styleMatch.Groups[1].Value;
                // 简化处理，实际应用中需要更复杂的解析
            }

            // 提取内容部分
            var contentRegex = new Regex(@"<etml>(.*?)</etml>", RegexOptions.Singleline);
            var contentMatch = contentRegex.Match(etmlContent);
            string content = contentMatch.Success ? contentMatch.Groups[1].Value : etmlContent;

            // 处理基本的ETML语法
            // 标题
            content = Regex.Replace(content, @"^(#{1,6})\s+(.*?)$", match =>
            {
                int level = match.Groups[1].Value.Length;
                return string.Format("<h{0}>{1}</h{0}><br />", level, match.Groups[2].Value);
            }, RegexOptions.Multiline);

            // 粗体
            content = Regex.Replace(content, @"\*\*(.*?)\*\*", "<strong>$1</strong>");
            content = Regex.Replace(content, @"<str>(.*?)</str>", "<strong>$1</strong>");

            // 斜体
            content = Regex.Replace(content, @"\$(.*?)\$", "<em>$1</em>");
            content = Regex.Replace(content, @"<em>(.*?)</em>", "<em>$1</em>");

            // 下划线
            content = Regex.Replace(content, @"__(.*?)__", "<u>$1</u>");
            content = Regex.Replace(content, @"<u>(.*?)</u>", "<u>$1</u>");

            // 删除线
            content = Regex.Replace(content, @"~~(.*?)~~", "<del>$1</del>");
            content = Regex.Replace(content, @"<del>(.*?)</del>", "<del>$1</del>");

            // 列表
            content = Regex.Replace(content, @"^--\s+(.*?)$", "<ul><li>$1</li></ul>", RegexOptions.Multiline);
            content = Regex.Replace(content, @"^(\d+)-\s+(.*?)$", "<ol><li>$2</li></ol>", RegexOptions.Multiline);
            content = Regex.Replace(content, @"^\?-\s+(.*?)$", "<ul><li><input type='checkbox' disabled>$1</li></ul>", RegexOptions.Multiline);
            content = Regex.Replace(content, @"^!-\s+(.*?)$", "<ul><li><input type='checkbox' disabled checked>$1</li></ul>", RegexOptions.Multiline);

            // 链接
            content = Regex.Replace(content, @"->\[(.*?)\]\((.*?)\)", "<a href='$2'>$1</a>");

            // 图片
            content = Regex.Replace(content, @"<img\s+src=['""](.*?)['""](.*?)>", match =>
            {
                string src = match.Groups[1].Value;
                string attrs = match.Groups[2].Value;
                return string.Format("<img src='{0}'{1}>", src, attrs);
            });

            // 代码块
            content = Regex.Replace(content, @"<code\s+lang=['""](.*?)['""](.*?)</code>", match =>
            {
                string lang = match.Groups[1].Value;
                string code = match.Groups[2].Value.Replace("<", "&lt;").Replace(">", "&gt;");
                return string.Format("<pre><code>{0}</code></pre><br />", code);
            }, RegexOptions.Singleline);

            // 换行
            content = content.Replace(Environment.NewLine, "<br />").Replace("\n", "<br />");

            html += content;
            html += "</body></html>";
            return html;
        }

        #endregion

        #region 辅助功能

        private void metadataButton_Click(object sender, EventArgs e)
        {
            string metadataTemplate = "<metadata>\n" +
                "  title=\"文档标题\"\n" +
                "  author=\"作者名称\"\n" +
                "  date=\"" + DateTime.Now.ToString("yyyy-MM-dd") + "\"\n" +
                "  version=\"v1.0\"\n" +
                "  description=\"文档描述\"\n" +
                "</metadata>\n\n";
            editorTextBox.SelectedText = metadataTemplate;
        }

        private void styleButton_Click(object sender, EventArgs e)
        {
            string styleTemplate = "<style>\n" +
                "  [important]=\"微软雅黑\",#FF5733,\"14\"\n" +
                "  [example]=\"等宽字体\",#333333,\"12\"\n" +
                "</style>\n\n";
            editorTextBox.SelectedText = styleTemplate;
        }

        private void UpdateStatusLabel()
        {
            int line = editorTextBox.GetLineFromCharIndex(editorTextBox.SelectionStart) + 1;
            int column = editorTextBox.SelectionStart - editorTextBox.GetFirstCharIndexOfCurrentLine() + 1;
            statusLabel.Text = string.Format("行: {0}, 列: {1}", line, column);
        }

        #endregion
    }

    #region 辅助表单类

    public class HeaderForm : Form
    {
        private NumericUpDown headerLevelNumericUpDown;
        private Button okButton;
        private Button cancelButton;

        public int HeaderLevel { get; private set; } = 1;

        public HeaderForm()
        {
            this.Text = "标题级别";
            this.Size = new Size(250, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "选择标题级别 (1-6):";
            label.Location = new Point(10, 20);
            label.Size = new Size(200, 20);
            this.Controls.Add(label);

            headerLevelNumericUpDown = new NumericUpDown();
            headerLevelNumericUpDown.Location = new Point(10, 45);
            headerLevelNumericUpDown.Size = new Size(50, 25);
            headerLevelNumericUpDown.Minimum = 1;
            headerLevelNumericUpDown.Maximum = 6;
            headerLevelNumericUpDown.Value = 1;
            this.Controls.Add(headerLevelNumericUpDown);

            okButton = new Button();
            okButton.Text = "确定";
            okButton.Location = new Point(50, 80);
            okButton.Size = new Size(70, 30);
            okButton.DialogResult = DialogResult.OK;
            okButton.Click += (sender, e) => 
            {
                HeaderLevel = (int)headerLevelNumericUpDown.Value;
                this.Close();
            };
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Text = "取消";
            cancelButton.Location = new Point(130, 80);
            cancelButton.Size = new Size(70, 30);
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }

    public enum ListType
    {
        Unordered,
        Ordered,
        Todo,
        TodoDone
    }

    public class ListForm : Form
    {
        private RadioButton unorderedRadioButton;
        private RadioButton orderedRadioButton;
        private RadioButton todoRadioButton;
        private RadioButton todoDoneRadioButton;
        private Button okButton;
        private Button cancelButton;

        public ListType ListType { get; private set; } = ListType.Unordered;

        public ListForm()
        {
            this.Text = "列表类型";
            this.Size = new Size(250, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "选择列表类型:";
            label.Location = new Point(10, 20);
            label.Size = new Size(200, 20);
            this.Controls.Add(label);

            unorderedRadioButton = new RadioButton();
            unorderedRadioButton.Text = "无序列表 (-- 项目)";
            unorderedRadioButton.Location = new Point(20, 45);
            unorderedRadioButton.Checked = true;
            this.Controls.Add(unorderedRadioButton);

            orderedRadioButton = new RadioButton();
            orderedRadioButton.Text = "有序列表 (1- 项目)";
            orderedRadioButton.Location = new Point(20, 70);
            this.Controls.Add(orderedRadioButton);

            todoRadioButton = new RadioButton();
            todoRadioButton.Text = "待办事项 (?- 项目)";
            todoRadioButton.Location = new Point(20, 95);
            this.Controls.Add(todoRadioButton);

            todoDoneRadioButton = new RadioButton();
            todoDoneRadioButton.Text = "已完成事项 (!- 项目)";
            todoDoneRadioButton.Location = new Point(20, 120);
            this.Controls.Add(todoDoneRadioButton);

            okButton = new Button();
            okButton.Text = "确定";
            okButton.Location = new Point(50, 150);
            okButton.Size = new Size(70, 30);
            okButton.DialogResult = DialogResult.OK;
            okButton.Click += (sender, e) => 
            {
                if (unorderedRadioButton.Checked)
                    ListType = ListType.Unordered;
                else if (orderedRadioButton.Checked)
                    ListType = ListType.Ordered;
                else if (todoRadioButton.Checked)
                    ListType = ListType.Todo;
                else if (todoDoneRadioButton.Checked)
                    ListType = ListType.TodoDone;
                this.Close();
            };
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Text = "取消";
            cancelButton.Location = new Point(130, 150);
            cancelButton.Size = new Size(70, 30);
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }

    public class LinkForm : Form
    {
        private TextBox urlTextBox;
        private Button okButton;
        private Button cancelButton;

        public string Url { get; private set; }

        public LinkForm()
        {
            this.Text = "插入链接";
            this.Size = new Size(400, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "输入URL地址:";
            label.Location = new Point(10, 20);
            label.Size = new Size(200, 20);
            this.Controls.Add(label);

            urlTextBox = new TextBox();
            urlTextBox.Location = new Point(10, 45);
            urlTextBox.Size = new Size(360, 25);
            urlTextBox.Text = "https://";
            this.Controls.Add(urlTextBox);

            okButton = new Button();
            okButton.Text = "确定";
            okButton.Location = new Point(150, 80);
            okButton.Size = new Size(70, 30);
            okButton.DialogResult = DialogResult.OK;
            okButton.Click += (sender, e) => 
            {
                Url = urlTextBox.Text;
                this.Close();
            };
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Text = "取消";
            cancelButton.Location = new Point(230, 80);
            cancelButton.Size = new Size(70, 30);
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }

    public class CodeForm : Form
    {
        private ComboBox languageComboBox;
        private Button okButton;
        private Button cancelButton;

        public string Language { get; private set; } = "plaintext";

        public CodeForm()
        {
            this.Text = "插入代码块";
            this.Size = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "选择编程语言:";
            label.Location = new Point(10, 20);
            label.Size = new Size(200, 20);
            this.Controls.Add(label);

            languageComboBox = new ComboBox();
            languageComboBox.Location = new Point(10, 45);
            languageComboBox.Size = new Size(260, 25);
            languageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            languageComboBox.Items.AddRange(new string[] 
            {
                "plaintext", "csharp", "javascript", "python", "java", "html", "css", 
                "sql", "xml", "json", "markdown", "etml", "typescript"
            });
            languageComboBox.SelectedIndex = 0;
            this.Controls.Add(languageComboBox);

            okButton = new Button();
            okButton.Text = "确定";
            okButton.Location = new Point(70, 80);
            okButton.Size = new Size(70, 30);
            okButton.DialogResult = DialogResult.OK;
            okButton.Click += (sender, e) => 
            {
                Language = languageComboBox.SelectedItem.ToString();
                this.Close();
            };
            this.Controls.Add(okButton);

            cancelButton = new Button();
            cancelButton.Text = "取消";
            cancelButton.Location = new Point(150, 80);
            cancelButton.Size = new Size(70, 30);
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }

    #endregion
}
