namespace Lending_Library
{
    partial class return_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(return_book));
            this.label1 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book ID:";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(12, 40);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(100, 20);
            this.book_id.TabIndex = 3;
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(12, 81);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(89, 25);
            this.return_button.TabIndex = 4;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 147);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "return_book";
            this.Text = "Book Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Button return_button;
    }
}