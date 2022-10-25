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
    public partial class MainForm : Form
    {
        public List<Kitap> eklenenKitaplar = new List<Kitap>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new(this);
            kitapEkle.Show();
            this.Hide();
        }
        public void addBook(Kitap _kitap)
        {
            listBox1.Items.Add(_kitap.yazarAdı + " " + _kitap.kitapAdı);
            eklenenKitaplar.Add(_kitap);
        }
        public void updateListboxItem(Kitap _kitap)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items[index] = $"Yazar: {_kitap.yazarAdı} - Kitap adı: {_kitap.kitapAdı}";
            eklenenKitaplar[index] = _kitap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EditBookForm _editBookForm = new EditBookForm(eklenenKitaplar[listBox1.SelectedIndex], listBox1.SelectedIndex, this);
                _editBookForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kitap Seçimi Yapmadınız!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( dialog == DialogResult.Yes)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                eklenenKitaplar.RemoveAt(index);
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


    public class Kitap
    {
        public string yazarAdı;
        public string kitapAdı;

        public Kitap(string yazarAdı, string kitapAdı)
        {
            this.yazarAdı = yazarAdı;
            this.kitapAdı = kitapAdı;
        }
    }
}
