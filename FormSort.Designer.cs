
namespace KacperBandyk_Komisariat
{
    partial class FormSort
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
            this.listBoxSort = new System.Windows.Forms.ListBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonSortAndWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.Location = new System.Drawing.Point(46, 55);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(245, 290);
            this.listBoxSort.TabIndex = 0;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(335, 127);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(133, 28);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "Wypisz";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonSortAndWrite
            // 
            this.buttonSortAndWrite.Location = new System.Drawing.Point(335, 181);
            this.buttonSortAndWrite.Name = "buttonSortAndWrite";
            this.buttonSortAndWrite.Size = new System.Drawing.Size(133, 28);
            this.buttonSortAndWrite.TabIndex = 2;
            this.buttonSortAndWrite.Text = "Sortuj i wypisz";
            this.buttonSortAndWrite.UseVisualStyleBackColor = true;
            this.buttonSortAndWrite.Click += new System.EventHandler(this.buttonSortAndWrite_Click);
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSortAndWrite);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.listBoxSort);
            this.Name = "FormSort";
            this.Text = "FormSort";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonSortAndWrite;
    }
}