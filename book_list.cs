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
    public partial class book_list : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\library.mdf;Integrated Security = True");
        public book_list()
        {
            InitializeComponent();
        }

        private void book_list_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Table] order by book_title ASC";

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["bookID"].ToString());
                    item.SubItems.Add(dr["book_title"].ToString());
                    item.SubItems.Add(dr["book_author"].ToString());
                    item.SubItems.Add(dr["book_category"].ToString());
                    item.SubItems.Add(dr["available"].ToString());
                    item.SubItems.Add(dr["name"].ToString());
                    item.SubItems.Add(dr["surname"].ToString());
                    item.SubItems.Add(dr["telephone"].ToString());
                    item.SubItems.Add(dr["date_lend"].ToString());
                    item.SubItems.Add(dr["date_return"].ToString());

                    booklist.Items.Add(item);
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
