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
    public partial class lend_book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\library.mdf;Integrated Security = True");
        public lend_book()
        {
            InitializeComponent();
        }

        private void lend_button_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update [Table] set available = '0', name = N'" + firstname.Text + "' , surname = N'" + surname.Text + "', telephone = '" + tel_number.Text + "', date_lend = '" + date_lend.Text + "', date_return = '" + date_return.Text + "'  where bookID = '" + book_id.Text + "' ";
                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    MessageBox.Show("Book doesn't exist");
                }
                else
                {
                    MessageBox.Show("Succesful reception");
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
