using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TP
{
    public partial class Form1 : Form
    {
        // Membuat variabel bertipe string untuk menampung text input
        private String textInput;
        public Form1()
        {
            InitializeComponent();
        }


        // menerima text input dari textBox2 dan menambahkan kata "Halo di bagian depan"

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Halo " + textInput;
            textBox1.Show();
        }

        // menerima input kalimat string dari user dan menyimpannya dalam variabel textInput
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textInput = textBox2.Text;
        }

        // menampilkan kembali hasil penambahan string pada textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
