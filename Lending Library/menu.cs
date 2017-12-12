using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending_Library
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void new_book_Click(object sender, EventArgs e)
        {
            new_book f = new new_book();
            f.Show();
        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            book_delete f = new book_delete();
            f.Show();
        }

        private void book_list_Click(object sender, EventArgs e)
        {
            book_list f = new book_list();
            f.Show();
        }

        private void book_enchain_Click(object sender, EventArgs e)
        {
            lend_book f = new lend_book();
            f.Show();
        }

        private void book_return_Click(object sender, EventArgs e)
        {
            return_book f = new return_book();
            f.Show();
        }
    }
}
