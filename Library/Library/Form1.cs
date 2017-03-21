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


            Seeder.GenerateBook(BooksListbox );

            Seeder.GenerateUser(UsersListbox);         

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DescribeUser_Click(object sender, EventArgs e)
        {
            Txt.Text = UsersListbox.SelectedValue.ToString();

        }

        private void DescribeBook_Click(object sender, EventArgs e)
        {
            Txt.Text = BooksListbox.SelectedItem.ToString();
           // Txt.Text = BooksListbox.SelectedValue.ToString();
        }

        


    }

    

}
