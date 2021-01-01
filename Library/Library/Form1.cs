using Library.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            dynamic result1 = BookController.GetAllBook2(id);
            if (result1 != null)
            {
                dataGridView1.DataSource = result1;
            }
            else
            {
                MessageBox.Show("No Books found");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var book = new
            {
                Id = Convert.ToInt32(textBox2.Text),
                Name = textBox3.Text,
                Author = textBox4.Text,
                Edition =textBox5.Text
            };
            var result = BookController.AddFood(book);
            if (result)
            {
                MessageBox.Show("Book Added");
            }
            else
            {
                MessageBox.Show("Book Couldnt't Added");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result2 = BookController.GetAllBook1();
            dataGridView2.DataSource = result2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
