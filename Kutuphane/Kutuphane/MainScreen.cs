using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class MainScreen : Form
    {
        public List<AuthorClass> authors = new List<AuthorClass>();
        
        public MainScreen()
        {
            InitializeComponent();
            AuthorClass a = new AuthorClass("1231231", "AAA", "BBB");
            authors.Add(a);
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddBookScreen abs = new AddBookScreen(this, authors);
            this.Hide();
            abs.Show();
        }

        public void addAuthor(AuthorClass author)
        {
            authors.Add(author);
        }

        public void addBook(Book book)
        {
            listBox1.Items.Add(book);
        }

        public void updateBook(Book book)
        {
            listBox1.Items[listBox1.SelectedIndex] = book;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İlgili kitabı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBookScreen abs = new AddBookScreen(this, authors);
            this.Hide();
            abs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAuthor ada = new AddAuthor(this);
            this.Hide();
            ada.Show();
        }
    }
}
