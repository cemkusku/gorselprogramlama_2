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
    public partial class AddAuthor : Form
    {
        MainScreen mainScreen;

        public AddAuthor(MainScreen main)
        {
            InitializeComponent();
            mainScreen = main;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AuthorClass author = new AuthorClass(textBox3.Text, textBox1.Text, textBox2.Text);

            if (author._adi=="" && author._soyadi=="")
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.","Hata Mesajı",MessageBoxButtons.OK);
            }
            else
            {
                mainScreen.addAuthor(author);
                mainScreen.Show();
                this.Close();
            }      
        }
        

        private void addAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
           mainScreen.Show();
        }
    }
}
