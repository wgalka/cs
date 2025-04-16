namespace WindowsForms_Playground.kontrolki {
    public partial class NotepadExample : Form {
        public NotepadExample() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Setting default properties for RichTextBox
            editorTextWindow.Font = new System.Drawing.Font("Arial", 10);
        }

        // Bold Button Click Event
        private void boldButton_Click(object sender, EventArgs e) {
            if (editorTextWindow.SelectionFont != null) {
                System.Drawing.Font currentFont = editorTextWindow.SelectionFont;
                // Font style to ENUM. Każda cyfra może być zapisana w systemie binarnym. Wtedy możliwe jest
                // zrobienie operacji binarnych które właczą kilka style na raz.
                System.Drawing.FontStyle newFontStyle = currentFont.Style ^ System.Drawing.FontStyle.Bold;
                editorTextWindow.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // Italic Button Click Event
        private void italicButton_Click(object sender, EventArgs e) {
            if (editorTextWindow.SelectionFont != null) {
                System.Drawing.Font currentFont = editorTextWindow.SelectionFont;
                System.Drawing.FontStyle newFontStyle = currentFont.Style ^ System.Drawing.FontStyle.Italic;
                editorTextWindow.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // Underline Button Click Event
        private void underlineButton_Click(object sender, EventArgs e) {
            if (editorTextWindow.SelectionFont != null) {
                System.Drawing.Font currentFont = editorTextWindow.SelectionFont;
                System.Drawing.FontStyle newFontStyle = currentFont.Style ^ System.Drawing.FontStyle.Underline;
                editorTextWindow.SelectionFont = new System.Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        // Change Font Size
        private void fontSizeComboBox_TextChanged(object sender, EventArgs e) {
            try {
                float fontSize = float.Parse(fontSizeComboBox.Text.ToString());
                fontSizeComboBox.BackColor = Color.White;
                editorTextWindow.SelectionFont = new System.Drawing.Font(editorTextWindow.SelectionFont.FontFamily, fontSize);
            } catch {
                fontSizeComboBox.BackColor = Color.Coral;
                MessageBox.Show("Podano nieprawidłowy rozmiar czcionki!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*|RTF Files (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = openFileDialog.FileName;
                if (filePath.EndsWith(".rtf")) {
                    editorTextWindow.LoadFile(filePath, RichTextBoxStreamType.RichText);
                } else {
                    editorTextWindow.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        // Save File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                editorTextWindow.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }

        // To TXT
        private void saveToTXT(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TXT (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                editorTextWindow.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }


        // To RTF
        private void saveToRTF(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RTF (*.rtf)|*.rtf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                editorTextWindow.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
        }

        // Exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
