
namespace KacperBandyk_Komisariat
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.buttonEvent = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonOperator = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(30, 63);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(145, 303);
            this.listBoxEvent.TabIndex = 0;
            // 
            // buttonEvent
            // 
            this.buttonEvent.Location = new System.Drawing.Point(30, 29);
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.Size = new System.Drawing.Size(145, 28);
            this.buttonEvent.TabIndex = 1;
            this.buttonEvent.Text = "Wypisz dane osoby";
            this.buttonEvent.UseVisualStyleBackColor = true;
            this.buttonEvent.Click += new System.EventHandler(this.buttonEvent_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(235, 29);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(125, 24);
            this.buttonAction.TabIndex = 2;
            this.buttonAction.Text = "Akcja";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonTraining
            // 
            this.buttonTraining.Location = new System.Drawing.Point(366, 29);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(125, 24);
            this.buttonTraining.TabIndex = 3;
            this.buttonTraining.Text = "Szkolenie";
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.Click += new System.EventHandler(this.buttonTraining_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(497, 29);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(125, 24);
            this.buttonView.TabIndex = 6;
            this.buttonView.Text = "Przeglądaj";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonOperator
            // 
            this.buttonOperator.Location = new System.Drawing.Point(628, 29);
            this.buttonOperator.Name = "buttonOperator";
            this.buttonOperator.Size = new System.Drawing.Size(125, 24);
            this.buttonOperator.TabIndex = 7;
            this.buttonOperator.Text = "Operatory";
            this.buttonOperator.UseVisualStyleBackColor = true;
            this.buttonOperator.Click += new System.EventHandler(this.buttonOperator_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(235, 74);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(125, 24);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Sortowanie";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonOperator);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonTraining);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.buttonEvent);
            this.Controls.Add(this.listBoxEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonTraining;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonOperator;
        private System.Windows.Forms.Button buttonSort;
    }
}

