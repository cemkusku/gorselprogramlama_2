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
        MainForm _mainForm;
        public KitapEkle(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazarAdı = textBox1.Text;
            string kitapAdı = textBox2.Text;

            Kitap book = new Kitap(yazarAdı, kitapAdı);
            _mainForm.addBook(book);
            _mainForm.Show();
            this.Hide();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
