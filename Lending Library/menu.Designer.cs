namespace Lending_Library
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.new_book = new System.Windows.Forms.Button();
            this.delete_book = new System.Windows.Forms.Button();
            this.book_list = new System.Windows.Forms.Button();
            this.book_enchain = new System.Windows.Forms.Button();
            this.book_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_book
            // 
            this.new_book.Location = new System.Drawing.Point(39, 46);
            this.new_book.Name = "new_book";
            this.new_book.Size = new System.Drawing.Size(75, 34);
            this.new_book.TabIndex = 1;
            this.new_book.Text = "Add Book";
            this.new_book.UseVisualStyleBackColor = true;
            this.new_book.Click += new System.EventHandler(this.new_book_Click);
            // 
            // delete_book
            // 
            this.delete_book.Location = new System.Drawing.Point(167, 46);
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(75, 34);
            this.delete_book.TabIndex = 2;
            this.delete_book.Text = "Delete Book";
            this.delete_book.UseVisualStyleBackColor = true;
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click);
            // 
            // book_list
            // 
            this.book_list.Location = new System.Drawing.Point(104, 124);
            this.book_list.Name = "book_list";
            this.book_list.Size = new System.Drawing.Size(75, 34);
            this.book_list.TabIndex = 3;
            this.book_list.Text = "Book List";
            this.book_list.UseVisualStyleBackColor = true;
            this.book_list.Click += new System.EventHandler(this.book_list_Click);
            // 
            // book_enchain
            // 
            this.book_enchain.Location = new System.Drawing.Point(39, 195);
            this.book_enchain.Name = "book_enchain";
            this.book_enchain.Size = new System.Drawing.Size(75, 34);
            this.book_enchain.TabIndex = 4;
            this.book_enchain.Text = "Book Reception";
            this.book_enchain.UseVisualStyleBackColor = true;
            this.book_enchain.Click += new System.EventHandler(this.book_enchain_Click);
            // 
            // book_return
            // 
            this.book_return.Location = new System.Drawing.Point(167, 195);
            this.book_return.Name = "book_return";
            this.book_return.Size = new System.Drawing.Size(75, 34);
            this.book_return.TabIndex = 5;
            this.book_return.Text = "Book Return";
            this.book_return.UseVisualStyleBackColor = true;
            this.book_return.Click += new System.EventHandler(this.book_return_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.book_return);
            this.Controls.Add(this.book_enchain);
            this.Controls.Add(this.book_list);
            this.Controls.Add(this.delete_book);
            this.Controls.Add(this.new_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Lending Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_book;
        private System.Windows.Forms.Button delete_book;
        private System.Windows.Forms.Button book_list;
        private System.Windows.Forms.Button book_enchain;
        private System.Windows.Forms.Button book_return;
    }
}