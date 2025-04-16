using System.Windows.Forms;

namespace WindowsForms_Playground.kontrolki {
    partial class NotepadExample {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private RichTextBox editorTextWindow;
        private ToolStrip editorToolsMenu;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
        private ToolStripComboBox fontSizeComboBox;
        private MenuStrip windowMenuBar;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem openMenuItem;

        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveAsRTFMenuItem;
        private ToolStripMenuItem saveAsTXTMenuItem;

        private ToolStripMenuItem exitMenuItem;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            editorTextWindow = new RichTextBox();
            editorToolsMenu = new ToolStrip();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            underlineButton = new ToolStripButton();
            fontSizeComboBox = new ToolStripComboBox();
            windowMenuBar = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            saveAsRTFMenuItem = new ToolStripMenuItem();
            saveAsTXTMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            editorToolsMenu.SuspendLayout();
            windowMenuBar.SuspendLayout();
            SuspendLayout();
            // 
            // editorTextWindow
            // 
            editorTextWindow.Dock = DockStyle.Fill;
            editorTextWindow.Location = new Point(0, 67);
            editorTextWindow.Name = "editorTextWindow";
            editorTextWindow.Size = new Size(800, 383);
            editorTextWindow.TabIndex = 0;
            editorTextWindow.Text = "";
            // 
            // editorToolsMenu
            // 
            editorToolsMenu.ImageScalingSize = new Size(24, 24);
            editorToolsMenu.Items.AddRange(new ToolStripItem[] { boldButton, italicButton, underlineButton, fontSizeComboBox, toolStripSeparator1 });
            editorToolsMenu.Location = new Point(0, 33);
            editorToolsMenu.Name = "editorToolsMenu";
            editorToolsMenu.Size = new Size(800, 34);
            editorToolsMenu.TabIndex = 1;
            // 
            // boldButton
            // 
            boldButton.CheckOnClick = true;
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(34, 29);
            boldButton.Text = "B";
            boldButton.Click += boldButton_Click;
            // 
            // italicButton
            // 
            italicButton.CheckOnClick = true;
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(34, 29);
            italicButton.Text = "I";
            italicButton.Click += italicButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.CheckOnClick = true;
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(34, 29);
            underlineButton.Text = "U";
            underlineButton.Click += underlineButton_Click;
            // 
            // fontSizeComboBox
            // 
            fontSizeComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16", "18", "20", "22", "24" });
            fontSizeComboBox.Name = "fontSizeComboBox";
            fontSizeComboBox.Size = new Size(121, 34);
            fontSizeComboBox.Text = "12";
            fontSizeComboBox.TextChanged += fontSizeComboBox_TextChanged;
            // 
            // windowMenuBar
            // 
            windowMenuBar.ImageScalingSize = new Size(24, 24);
            windowMenuBar.Items.AddRange(new ToolStripItem[] { fileMenuItem });
            windowMenuBar.Location = new Point(0, 0);
            windowMenuBar.Name = "windowMenuBar";
            windowMenuBar.Size = new Size(800, 33);
            windowMenuBar.TabIndex = 2;
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(54, 29);
            fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(270, 34);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsRTFMenuItem, saveAsTXTMenuItem });
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(270, 34);
            saveMenuItem.Text = "Save";
            saveMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsRTFMenuItem
            // 
            saveAsRTFMenuItem.Name = "saveAsRTFMenuItem";
            saveAsRTFMenuItem.Size = new Size(270, 34);
            saveAsRTFMenuItem.Text = "Zapisz jako RTF";
            saveAsRTFMenuItem.Click += saveToRTF;
            // 
            // saveAsTXTMenuItem
            // 
            saveAsTXTMenuItem.Name = "saveAsTXTMenuItem";
            saveAsTXTMenuItem.Size = new Size(270, 34);
            saveAsTXTMenuItem.Text = "Zapisz jako TXT";
            saveAsTXTMenuItem.Click += saveToTXT;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(270, 34);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 34);
            // 
            // NotepadExample
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(editorTextWindow);
            Controls.Add(editorToolsMenu);
            Controls.Add(windowMenuBar);
            MainMenuStrip = windowMenuBar;
            Name = "NotepadExample";
            Text = "Notepad with RichTextBox";
            Load += Form1_Load;
            editorToolsMenu.ResumeLayout(false);
            editorToolsMenu.PerformLayout();
            windowMenuBar.ResumeLayout(false);
            windowMenuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private ToolStripSeparator toolStripSeparator1;
    }
}