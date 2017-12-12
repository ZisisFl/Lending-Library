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
    public partial class book_delete : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\library.mdf;Integrated Security = True");
        public book_delete()
        {
            InitializeComponent();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from [Table] where bookID = '" + delete_book.Text + "' ";
                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    MessageBox.Show("Book doesn't exist");
                }
                else
                {
                    MessageBox.Show("Succesful Delete");
                }


                conn.Close();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
