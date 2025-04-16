using System.ComponentModel;
using System.Data;
using WindowsForms_Playground.data;
using WindowsForms_Playground.Data;

namespace WindowsForms_Playground.kontrolki {
    public partial class TableViewExample : Form {
        ProductDAO productDao;
        private int pageSize;
        private int currentPage = 1;

        public TableViewExample() {
            InitializeComponent();
            productDao = new ProductDAO();
            pageSize = CalculateRowsPerPage();
            toolStripTextBox2.Text = pageSize.ToString();
            toolStripComboBox1.Items.AddRange(dataGridView1.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText).ToArray());
            LoadPage();
        }

        private int CalculateRowsPerPage() {
            int availableHeight = dataGridView1.ClientSize.Height;
            int headerHeight = dataGridView1.ColumnHeadersHeight;
            int rowHeight = dataGridView1.RowTemplate.Height;

            int rowsPerPage = (availableHeight - headerHeight - 2 * rowHeight) / rowHeight;

            return Math.Max(rowsPerPage, 1);
        }



        private void LoadPage() {

            var pageData = productDao.GetSortedPage("Id", true, currentPage, pageSize);
            dataGridView1.DataSource = new BindingList<Product>(pageData);


            btnPrevPage.Enabled = currentPage > 1;
            btnNextPage.Enabled = currentPage * pageSize < productDao.GetActiveCount();
            textBox1.Text = currentPage.ToString();
        }

        private void btnPrevPage_Click(object sender, EventArgs e) {
            if (currentPage > 1) {
                currentPage--;
                LoadPage();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e) {
            if ((currentPage * pageSize) < productDao.GetActiveCount()) {
                currentPage++;
                LoadPage();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e) {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                currentPage = int.Parse(textBox1.Text);
            } catch (Exception ex) {
                MessageBox.Show("Wrong page number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPage();
        }

        private void changeRowsPerPage(object sender, EventArgs e) {
            try {
                pageSize = int.Parse(toolStripTextBox2.Text);
            } catch (Exception ex) {
                MessageBox.Show("Rows per page should be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            toolStripTextBox2.Text = pageSize.ToString();
            LoadPage();
        }
    }

}
