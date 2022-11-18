namespace Lecture_15_ListView
{
    partial class Form1
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
            this.btnExampleForm = new System.Windows.Forms.Button();
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.cbMax = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExampleForm
            // 
            this.btnExampleForm.Location = new System.Drawing.Point(1047, 12);
            this.btnExampleForm.Name = "btnExampleForm";
            this.btnExampleForm.Size = new System.Drawing.Size(146, 40);
            this.btnExampleForm.TabIndex = 0;
            this.btnExampleForm.Text = "Example Form";
            this.btnExampleForm.UseVisualStyleBackColor = true;
            this.btnExampleForm.Click += new System.EventHandler(this.btnExampleForm_Click);
            // 
            // lvTransactions
            // 
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTransactions.HideSelection = false;
            this.lvTransactions.Location = new System.Drawing.Point(34, 21);
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.Size = new System.Drawing.Size(775, 643);
            this.lvTransactions.TabIndex = 1;
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 252;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 214;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time";
            this.columnHeader4.Width = 214;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(917, 616);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 48);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbMin
            // 
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(871, 193);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(277, 32);
            this.cbMin.TabIndex = 3;
            // 
            // cbMax
            // 
            this.cbMax.FormattingEnabled = true;
            this.cbMax.Location = new System.Drawing.Point(871, 288);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(277, 32);
            this.cbMax.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(917, 389);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(165, 48);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter By Price";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 708);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbMax);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lvTransactions);
            this.Controls.Add(this.btnExampleForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExampleForm;
        private System.Windows.Forms.ListView lvTransactions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.ComboBox cbMax;
        private System.Windows.Forms.Button btnFilter;
    }
}

