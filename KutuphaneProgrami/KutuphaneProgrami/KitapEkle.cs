using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProgrami
{
    public partial class KitapEkle : Form
    {
        AnaForm _mainForm;
        public KitapEkle(AnaForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookAuthor = textBox1.Text;
            string bookName = textBox2.Text;

            Book book = new Book(bookAuthor, bookName);
            _mainForm.addBook(book);

            _mainForm.Show();
            this.Hide();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
