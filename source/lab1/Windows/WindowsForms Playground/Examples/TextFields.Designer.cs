namespace WindowsForms_Playground.kontrolki {
    partial class TextFields {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            labelTextBoxProperties = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(397, 144);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 31);
            textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(1198, 531);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 31);
            maskedTextBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1015, 531);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 5;
            label1.Text = "klasa MaskedTextBox";
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(labelTextBoxProperties);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 656);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "klasa TextBox";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelTextBoxProperties
            // 
            labelTextBoxProperties.AutoSize = true;
            labelTextBoxProperties.Location = new Point(6, 74);
            labelTextBoxProperties.Name = "labelTextBoxProperties";
            labelTextBoxProperties.Size = new Size(112, 25);
            labelTextBoxProperties.TabIndex = 3;
            labelTextBoxProperties.Text = "lorem ipsum";
            labelTextBoxProperties.Click += label2_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(406, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(409, 656);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "klasa RichTextBox";
            // 
            // TextFields
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 884);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "TextFields";
            Text = "Pola tekstowe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private Label labelTextBoxProperties;

        public void Initialize() {
            labelTextBoxProperties.Text = "Text — zawartość tekstowa.\n" +
                "MaxLength — maksymalna liczba znaków.\n" +
                "Multiline — ustawienie, które pozwala na wieloliniowe wprowadzanie tekstu.\n" +
                "ReadOnly — sprawia, że kontrolka jest tylko do odczytu.\n" +
                "PasswordChar — ustawia znak używany do maskowania znaków hasła w kontrolce jednowierszowej\n";
        }
        private GroupBox groupBox2;
    }
}