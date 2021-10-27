
namespace Assessment_1c
{
    partial class frmMain
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btn_sort_books = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_sort_books_des = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(139, 91);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(129, 34);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display My Books";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(621, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 63);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(139, 165);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(428, 121);
            this.lstDisplay.TabIndex = 3;
            // 
            // btn_sort_books
            // 
            this.btn_sort_books.Location = new System.Drawing.Point(309, 91);
            this.btn_sort_books.Name = "btn_sort_books";
            this.btn_sort_books.Size = new System.Drawing.Size(130, 34);
            this.btn_sort_books.TabIndex = 4;
            this.btn_sort_books.Text = "Sort My Books";
            this.btn_sort_books.UseVisualStyleBackColor = true;
            this.btn_sort_books.Click += new System.EventHandler(this.btn_sort_books_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Test Nested Class";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sort_books_des
            // 
            this.btn_sort_books_des.Location = new System.Drawing.Point(309, 46);
            this.btn_sort_books_des.Name = "btn_sort_books_des";
            this.btn_sort_books_des.Size = new System.Drawing.Size(130, 39);
            this.btn_sort_books_des.TabIndex = 6;
            this.btn_sort_books_des.Text = "Sort my Books Des";
            this.btn_sort_books_des.UseVisualStyleBackColor = true;
            this.btn_sort_books_des.Click += new System.EventHandler(this.btn_sort_books_des_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sort_books_des);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_sort_books);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmMain";
            this.Text = "My Book Collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btn_sort_books;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_sort_books_des;
    }
}

