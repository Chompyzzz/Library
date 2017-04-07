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


        private void Form1_Load(object sender, EventArgs e)
        {
            Seeder.GenerateBook(BooksListbox);

            Seeder.GenerateUser(UsersListbox);


        }

       

        private void DescribeUser_Click(object sender, EventArgs e)
        {
            User u = UsersListbox.SelectedItem as User;
            Txt.Text = u.describe();
            if (u == null)
            {
                MessageBox.Show("Bisogna selezionare un utente", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DescribeBook_Click(object sender, EventArgs e)
        {
            Book b = BooksListbox.SelectedItem as Book;
            Txt.Text = b.describe();
            if (b == null)
            {
                MessageBox.Show("Bisogna selezionare un libro", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Lend_Click(object sender, EventArgs e)
        {
            Book b = BooksListbox.SelectedItem as Book;
            User u = UsersListbox.SelectedItem as User;

            if (u == null || b == null)
            {
                MessageBox.Show("Bisogna selezionare almeno un libro ed un utente", "Errore!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           

            try
            {
                Txt.Text = b.presta(u) + u.describeBooks(b);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

    

}
