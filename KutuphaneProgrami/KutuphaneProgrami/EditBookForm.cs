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
    public partial class EditBookForm : Form
    {
        MainForm _mainForm;
        int currentIndex;
        public EditBookForm(Kitap book, int index, MainForm mainForm)
        {
           
            InitializeComponent();
            _mainForm = mainForm;
            currentIndex = index;
            textBox1.Text = book.yazarAdı;
            textBox2.Text = book.kitapAdı;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updatedBookAuthor = textBox1.Text;
            string updatedBookName = textBox2.Text;

            Kitap updatedBook = new Kitap(updatedBookAuthor, updatedBookName);
            _mainForm.updateListboxItem(updatedBook);
            _mainForm.Show();
            
        }
    }
}
