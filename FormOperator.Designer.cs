
namespace KacperBandyk_Komisariat
{
    partial class FormOperator
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
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonNotEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNotEqual = new System.Windows.Forms.TextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxEqual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEquals
            // 
            this.buttonEquals.Location = new System.Drawing.Point(37, 63);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(125, 26);
            this.buttonEquals.TabIndex = 0;
            this.buttonEquals.Text = "Operator \"==\"";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonNotEqual
            // 
            this.buttonNotEqual.Location = new System.Drawing.Point(194, 63);
            this.buttonNotEqual.Name = "buttonNotEqual";
            this.buttonNotEqual.Size = new System.Drawing.Size(125, 26);
            this.buttonNotEqual.TabIndex = 1;
            this.buttonNotEqual.Text = "Operator \"!=\"";
            this.buttonNotEqual.UseVisualStyleBackColor = true;
            this.buttonNotEqual.Click += new System.EventHandler(this.buttonNotEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(343, 63);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 26);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Operator \"+\"";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNotEqual
            // 
            this.textBoxNotEqual.Location = new System.Drawing.Point(194, 115);
            this.textBoxNotEqual.Name = "textBoxNotEqual";
            this.textBoxNotEqual.Size = new System.Drawing.Size(125, 20);
            this.textBoxNotEqual.TabIndex = 4;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(343, 115);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(125, 20);
            this.textBoxAdd.TabIndex = 5;
            // 
            // textBoxEqual
            // 
            this.textBoxEqual.Location = new System.Drawing.Point(37, 115);
            this.textBoxEqual.Name = "textBoxEqual";
            this.textBoxEqual.Size = new System.Drawing.Size(125, 20);
            this.textBoxEqual.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Przeciązanie opretorów na przykładzie Training.idType";
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEqual);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.textBoxNotEqual);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonNotEqual);
            this.Controls.Add(this.buttonEquals);
            this.Name = "FormOperator";
            this.Text = "FormOperator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonNotEqual;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNotEqual;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxEqual;
        private System.Windows.Forms.Label label1;
    }
}