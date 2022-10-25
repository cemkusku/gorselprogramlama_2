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
    public partial class AnaForm : Form
    {
        public List<Book> addedBooks = new List<Book>();
        public AnaForm()
        {
            InitializeComponent();
        }

        private void kitapErleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle addBook = new(this);
            addBook.Show();
            this.Hide();
        }
        public void addBook(Book _book)
        {
            listBox1.Items.Add(_book.bookAuthor + " " + _book.bookName);
            addedBooks.Add(_book);
        }
        public void updateListboxItem(Book _book)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = $"Yazar: {_book.bookAuthor} - Kitap adı: {_book.bookName}";
            addedBooks[index] = _book;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Düzenle _editBookForm = new Düzenle(addedBooks[listBox1.SelectedIndex], listBox1.SelectedIndex, this);
                _editBookForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kitap seçmediniz!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( dialog == DialogResult.Yes)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                addedBooks.RemoveAt(index);
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }
    }


    public class Book
    {
        public string bookAuthor;
        public string bookName;

        public Book(string bookAuthor, string bookName)
        {
            this.bookAuthor = bookAuthor;
            this.bookName = bookName;
        }
    }
}
