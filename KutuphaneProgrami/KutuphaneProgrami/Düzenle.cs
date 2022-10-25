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
    public partial class Düzenle : Form
    {
        AnaForm _mainForm;
        int currentIndex;
        public Düzenle(Book book, int index, AnaForm mainForm)
        {
           
            InitializeComponent();
            _mainForm = mainForm;
            currentIndex = index;
            textBox1.Text = book.bookAuthor;
            textBox2.Text = book.bookName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatedBookAuthor = textBox1.Text;
            string updatedBookName = textBox2.Text;

            Book updatedBook = new Book(updatedBookAuthor, updatedBookName);
            _mainForm.updateListboxItem(updatedBook);
            _mainForm.Show();
            
        }
    }
}
