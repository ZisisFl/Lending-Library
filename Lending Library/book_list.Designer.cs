namespace Lending_Library
{
    partial class book_list
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_list));
            this.booklist = new System.Windows.Forms.ListView();
            this.bookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_lend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // booklist
            // 
            this.booklist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookID,
            this.book_title,
            this.book_author,
            this.book_category,
            this.available,
            this.name,
            this.surname,
            this.telephone,
            this.date_lend,
            this.date_return});
            this.booklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booklist.Location = new System.Drawing.Point(4, 7);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(924, 551);
            this.booklist.TabIndex = 1;
            this.booklist.UseCompatibleStateImageBehavior = false;
            this.booklist.View = System.Windows.Forms.View.Details;
            // 
            // bookID
            // 
            this.bookID.Text = "Book ID";
            // 
            // book_title
            // 
            this.book_title.Text = "Title";
            this.book_title.Width = 87;
            // 
            // book_author
            // 
            this.book_author.Text = "Author";
            this.book_author.Width = 91;
            // 
            // book_category
            // 
            this.book_category.Text = "Category";
            this.book_category.Width = 77;
            // 
            // available
            // 
            this.available.Text = "Availabillity";
            this.available.Width = 102;
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // surname
            // 
            this.surname.Text = "Surname";
            this.surname.Width = 71;
            // 
            // telephone
            // 
            this.telephone.Text = "Tel Number";
            this.telephone.Width = 80;
            // 
            // date_lend
            // 
            this.date_lend.Text = "Reception Date";
            this.date_lend.Width = 126;
            // 
            // date_return
            // 
            this.date_return.Text = "Return Date";
            this.date_return.Width = 120;
            // 
            // book_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 565);
            this.Controls.Add(this.booklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "book_list";
            this.Text = "Book List";
            this.Load += new System.EventHandler(this.book_list_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView booklist;
        private System.Windows.Forms.ColumnHeader bookID;
        private System.Windows.Forms.ColumnHeader book_title;
        private System.Windows.Forms.ColumnHeader book_author;
        private System.Windows.Forms.ColumnHeader book_category;
        private System.Windows.Forms.ColumnHeader available;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader date_lend;
        private System.Windows.Forms.ColumnHeader date_return;
    }
}