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
    public partial class return_book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\library.mdf;Integrated Security = True");
        public return_book()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Table] set available = '1', name = '" + null + "' , surname = '" + null + "', telephone = '" + null + "', date_lend = '" + null + "', date_return = '" + null + "'  where bookID = '" + book_id.Text + "' ";

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    MessageBox.Show("Book doesn't exist");
                }
                else
                {
                    MessageBox.Show("Succesfull Return");
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
