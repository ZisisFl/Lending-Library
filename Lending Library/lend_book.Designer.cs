namespace Lending_Library
{
    partial class lend_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lend_book));
            this.label1 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_lend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_return = new System.Windows.Forms.TextBox();
            this.lend_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID:";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(12, 36);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(100, 20);
            this.book_id.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(12, 89);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Surname:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(12, 146);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telephone Number:";
            // 
            // tel_number
            // 
            this.tel_number.Location = new System.Drawing.Point(146, 36);
            this.tel_number.Name = "tel_number";
            this.tel_number.Size = new System.Drawing.Size(100, 20);
            this.tel_number.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date of Reception";
            // 
            // date_lend
            // 
            this.date_lend.Location = new System.Drawing.Point(146, 93);
            this.date_lend.Name = "date_lend";
            this.date_lend.Size = new System.Drawing.Size(100, 20);
            this.date_lend.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date of Return";
            // 
            // date_return
            // 
            this.date_return.Location = new System.Drawing.Point(146, 146);
            this.date_return.Name = "date_return";
            this.date_return.Size = new System.Drawing.Size(100, 20);
            this.date_return.TabIndex = 25;
            // 
            // lend_button
            // 
            this.lend_button.Location = new System.Drawing.Point(12, 199);
            this.lend_button.Name = "lend_button";
            this.lend_button.Size = new System.Drawing.Size(89, 25);
            this.lend_button.TabIndex = 27;
            this.lend_button.Text = "Done";
            this.lend_button.UseVisualStyleBackColor = true;
            this.lend_button.Click += new System.EventHandler(this.lend_button_Click);
            // 
            // lend_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 251);
            this.Controls.Add(this.lend_button);
            this.Controls.Add(this.date_return);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_lend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tel_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lend_book";
            this.Text = "Book Lend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date_lend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox date_return;
        private System.Windows.Forms.Button lend_button;
    }
}