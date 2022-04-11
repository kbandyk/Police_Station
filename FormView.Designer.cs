
namespace KacperBandyk_Komisariat
{
    partial class FormView
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
            this.buttonView = new System.Windows.Forms.Button();
            this.listBoxViewData = new System.Windows.Forms.ListBox();
            this.pictureBoxViewImage = new System.Windows.Forms.PictureBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonWriteToFile = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxRemoveElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonGunPercent = new System.Windows.Forms.Button();
            this.textBoxGunPercent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(54, 21);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(138, 27);
            this.buttonView.TabIndex = 0;
            this.buttonView.Text = "Wyświetl wydarzenia";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            this.buttonView.MouseLeave += new System.EventHandler(this.buttonView_MouseLeave);
            this.buttonView.MouseHover += new System.EventHandler(this.buttonView_MouseHover);
            // 
            // listBoxViewData
            // 
            this.listBoxViewData.FormattingEnabled = true;
            this.listBoxViewData.Location = new System.Drawing.Point(28, 87);
            this.listBoxViewData.Name = "listBoxViewData";
            this.listBoxViewData.Size = new System.Drawing.Size(195, 277);
            this.listBoxViewData.TabIndex = 1;
            // 
            // pictureBoxViewImage
            // 
            this.pictureBoxViewImage.Location = new System.Drawing.Point(256, 101);
            this.pictureBoxViewImage.Name = "pictureBoxViewImage";
            this.pictureBoxViewImage.Size = new System.Drawing.Size(496, 241);
            this.pictureBoxViewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxViewImage.TabIndex = 2;
            this.pictureBoxViewImage.TabStop = false;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(319, 348);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(133, 32);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "Poprzedni";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(524, 348);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(133, 32);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Następny";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonWriteToFile
            // 
            this.buttonWriteToFile.Location = new System.Drawing.Point(352, 21);
            this.buttonWriteToFile.Name = "buttonWriteToFile";
            this.buttonWriteToFile.Size = new System.Drawing.Size(138, 27);
            this.buttonWriteToFile.TabIndex = 5;
            this.buttonWriteToFile.Text = "Zapisz listę do pliku";
            this.buttonWriteToFile.UseVisualStyleBackColor = true;
            this.buttonWriteToFile.Click += new System.EventHandler(this.buttonWriteToFile_Click);
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(543, 21);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(138, 27);
            this.buttonReadFromFile.TabIndex = 6;
            this.buttonReadFromFile.Text = "Odczytaj listę z pliku";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(352, 75);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(255, 20);
            this.textBoxPath.TabIndex = 7;
            this.textBoxPath.Text = "C://Photos//";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Podaj ścieżkę zapisu do pliku:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(54, 411);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(138, 27);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Usuń element z listy";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            this.buttonRemove.MouseLeave += new System.EventHandler(this.buttonRemove_MouseLeave);
            this.buttonRemove.MouseHover += new System.EventHandler(this.buttonRemove_MouseHover);
            // 
            // textBoxRemoveElement
            // 
            this.textBoxRemoveElement.Location = new System.Drawing.Point(54, 385);
            this.textBoxRemoveElement.Name = "textBoxRemoveElement";
            this.textBoxRemoveElement.Size = new System.Drawing.Size(138, 20);
            this.textBoxRemoveElement.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wpisz numer elementu do usuniecia:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 513);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // buttonGunPercent
            // 
            this.buttonGunPercent.Location = new System.Drawing.Point(307, 400);
            this.buttonGunPercent.Name = "buttonGunPercent";
            this.buttonGunPercent.Size = new System.Drawing.Size(155, 27);
            this.buttonGunPercent.TabIndex = 13;
            this.buttonGunPercent.Text = "% użycia broni podczas akcji";
            this.buttonGunPercent.UseVisualStyleBackColor = true;
            this.buttonGunPercent.Click += new System.EventHandler(this.buttonGunPercent_Click);
            // 
            // textBoxGunPercent
            // 
            this.textBoxGunPercent.Location = new System.Drawing.Point(337, 433);
            this.textBoxGunPercent.Name = "textBoxGunPercent";
            this.textBoxGunPercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxGunPercent.TabIndex = 14;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.textBoxGunPercent);
            this.Controls.Add(this.buttonGunPercent);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRemoveElement);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonReadFromFile);
            this.Controls.Add(this.buttonWriteToFile);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureBoxViewImage);
            this.Controls.Add(this.listBoxViewData);
            this.Controls.Add(this.buttonView);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.ListBox listBoxViewData;
        private System.Windows.Forms.PictureBox pictureBoxViewImage;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonWriteToFile;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxRemoveElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonGunPercent;
        private System.Windows.Forms.TextBox textBoxGunPercent;
    }
}