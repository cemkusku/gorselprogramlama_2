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
    public partial class EditAuthor : Form
    {
        AddBookScreen addBookScreen;
        AuthorClass author;
        MainScreen main;
        public EditAuthor(AddBookScreen gelenAddBookScreen, AuthorClass gelenAuthor, MainScreen mainScreen)
        {
            InitializeComponent();
            addBookScreen = gelenAddBookScreen;
            author = gelenAuthor;
            main = mainScreen;

            textBox1.Text = gelenAuthor._adi;
            textBox2.Text = gelenAuthor._soyadi;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var item in main.authors)
            {
                if (item._id == author._id)
                {
                    item._adi = author._adi;
                    item._soyadi = author._soyadi;
                    addBookScreen.editItem(author._adi + " " + author._soyadi);
                }
                else
                {
                    break;
                }
            }
            addBookScreen.Show();
            this.Hide();
        }
    }
}
