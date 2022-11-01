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
    public partial class AddBookScreen : Form
    {
        MainScreen mainScreen;

        bool isEditMode;

        public AddBookScreen(MainScreen ms, List<AuthorClass> authors)
        {
            InitializeComponent();
            addComboboxItems(authors);
            mainScreen = ms;
            isEditMode = false;
            button1.Text = "Ekle";
        }

        public AddBookScreen(MainScreen ms, Book book, List<AuthorClass> authors)
        {
            InitializeComponent();

            mainScreen = ms;
            isEditMode = true;
            button1.Text = "Düzenle";
            addComboboxItems(authors);

            textBox1.Text = book.ISSN;
            textBox2.Text = book.Name;
            comboBox1.Text = book.Author;
        }

        public void addComboboxItems(List<AuthorClass> authors)
        {
            foreach (var aut in authors)
            {
                comboBox1.Items.Add(aut.ToString());
            }
        }

        public void editItem(string item)
        {
            comboBox1.SelectedItem = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ISSN = textBox1.Text;
            book.Name = textBox2.Text;
            book.Author = comboBox1.Text;

            if (isEditMode == false)
            {
                mainScreen.addBook(book);
            }
            else
            {
                mainScreen.updateBook(book);
            }

            mainScreen.Show();
            this.Close();
        }
        
        private void AddBookScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAuthor edit = new EditAuthor(this, mainScreen.authors[comboBox1.SelectedIndex], mainScreen);
            edit.Show();
            this.Hide();
        }
    }
}
