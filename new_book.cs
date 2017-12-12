using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lending_Library
{
    public partial class new_book : Form
    {
        int current_book;
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\library.mdf;Integrated Security = True");
        public new_book()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Table](book_title, book_author, book_category, available) values(N'" + book_title.Text + "', N'" + book_author.Text + "', N'" + book_category.Text + "','1');";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select bookID from [Table] where bookID = (select max(bookID) FROM [Table])";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    current_book = dr.GetInt32(0);
                }
                conn.Close();

                MessageBox.Show("Succesfully added book with ID: " + current_book);
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
