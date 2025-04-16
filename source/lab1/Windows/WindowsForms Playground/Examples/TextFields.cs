namespace WindowsForms_Playground.kontrolki {
    public partial class TextFields : Form {
        public TextFields() {
            InitializeComponent();
            groupBox1.Controls.Add(labelTextBoxProperties);
            labelTextBoxProperties.Text = "Text — zawartość tekstowa.\n" +
                "MaxLength — maksymalna liczba znaków.\n" +
                "Multiline — ustawienie, które pozwala na wieloliniowe wprowadzanie tekstu.\n" +
                "ReadOnly — sprawia, że kontrolka jest tylko do odczytu.\n" +
                "PasswordChar — ustawia znak używany do maskowania znaków hasła \nw kontrolce jednowierszowej\n";
            labelTextBoxProperties.AutoSize = true;
            //labelTextBoxProperties.TextAlign = ContentAlignment.TopLeft; // Ustawienie wyrównania tekstu
            //labelTextBoxProperties.Size = new Size(300, 500); // Ustalamy szerokość, która spowoduje zawijanie tekstu

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label2_Click_1(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
