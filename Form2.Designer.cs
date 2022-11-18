namespace Lecture_15_ListView
{
    partial class Form2
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
            this.lvTransactions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilterByCost = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.ckStarbucks = new System.Windows.Forms.CheckBox();
            this.ckHotTopic = new System.Windows.Forms.CheckBox();
            this.ckFredMeyer = new System.Windows.Forms.CheckBox();
            this.ckBoxLunch = new System.Windows.Forms.CheckBox();
            this.ckTarget = new System.Windows.Forms.CheckBox();
            this.ckBestBuy = new System.Windows.Forms.CheckBox();
            this.ckBurgerKing = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.cbMax = new System.Windows.Forms.ComboBox();
            this.btnFilterByStore = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTransactions
            // 
            this.lvTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTransactions.HideSelection = false;
            this.lvTransactions.Location = new System.Drawing.Point(45, 46);
            this.lvTransactions.Name = "lvTransactions";
            this.lvTransactions.Size = new System.Drawing.Size(1034, 782);
            this.lvTransactions.TabIndex = 0;
            this.lvTransactions.UseCompatibleStateImageBehavior = false;
            this.lvTransactions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Location";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 148;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 245;
            // 
            // btnFilterByCost
            // 
            this.btnFilterByCost.Location = new System.Drawing.Point(1185, 736);
            this.btnFilterByCost.Name = "btnFilterByCost";
            this.btnFilterByCost.Size = new System.Drawing.Size(202, 50);
            this.btnFilterByCost.TabIndex = 1;
            this.btnFilterByCost.Text = "Filter By Cost";
            this.btnFilterByCost.UseVisualStyleBackColor = true;
            this.btnFilterByCost.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(1626, 549);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(135, 29);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // ckStarbucks
            // 
            this.ckStarbucks.AutoSize = true;
            this.ckStarbucks.Location = new System.Drawing.Point(1124, 46);
            this.ckStarbucks.Name = "ckStarbucks";
            this.ckStarbucks.Size = new System.Drawing.Size(126, 29);
            this.ckStarbucks.TabIndex = 10;
            this.ckStarbucks.Text = "Starbucks";
            this.ckStarbucks.UseVisualStyleBackColor = true;
            // 
            // ckHotTopic
            // 
            this.ckHotTopic.AutoSize = true;
            this.ckHotTopic.Location = new System.Drawing.Point(1124, 103);
            this.ckHotTopic.Name = "ckHotTopic";
            this.ckHotTopic.Size = new System.Drawing.Size(122, 29);
            this.ckHotTopic.TabIndex = 11;
            this.ckHotTopic.Text = "Hot Topic";
            this.ckHotTopic.UseVisualStyleBackColor = true;
            // 
            // ckFredMeyer
            // 
            this.ckFredMeyer.AutoSize = true;
            this.ckFredMeyer.Location = new System.Drawing.Point(1124, 331);
            this.ckFredMeyer.Name = "ckFredMeyer";
            this.ckFredMeyer.Size = new System.Drawing.Size(138, 29);
            this.ckFredMeyer.TabIndex = 12;
            this.ckFredMeyer.Text = "Fred Meyer";
            this.ckFredMeyer.UseVisualStyleBackColor = true;
            // 
            // ckBoxLunch
            // 
            this.ckBoxLunch.AutoSize = true;
            this.ckBoxLunch.Location = new System.Drawing.Point(1124, 388);
            this.ckBoxLunch.Name = "ckBoxLunch";
            this.ckBoxLunch.Size = new System.Drawing.Size(131, 29);
            this.ckBoxLunch.TabIndex = 14;
            this.ckBoxLunch.Text = "Box Lunch";
            this.ckBoxLunch.UseVisualStyleBackColor = true;
            // 
            // ckTarget
            // 
            this.ckTarget.AutoSize = true;
            this.ckTarget.Location = new System.Drawing.Point(1124, 274);
            this.ckTarget.Name = "ckTarget";
            this.ckTarget.Size = new System.Drawing.Size(95, 29);
            this.ckTarget.TabIndex = 18;
            this.ckTarget.Text = "Target";
            this.ckTarget.UseVisualStyleBackColor = true;
            // 
            // ckBestBuy
            // 
            this.ckBestBuy.AutoSize = true;
            this.ckBestBuy.Location = new System.Drawing.Point(1124, 217);
            this.ckBestBuy.Name = "ckBestBuy";
            this.ckBestBuy.Size = new System.Drawing.Size(116, 29);
            this.ckBestBuy.TabIndex = 21;
            this.ckBestBuy.Text = "Best Buy";
            this.ckBestBuy.UseVisualStyleBackColor = true;
            // 
            // ckBurgerKing
            // 
            this.ckBurgerKing.AutoSize = true;
            this.ckBurgerKing.Location = new System.Drawing.Point(1124, 160);
            this.ckBurgerKing.Name = "ckBurgerKing";
            this.ckBurgerKing.Size = new System.Drawing.Size(141, 29);
            this.ckBurgerKing.TabIndex = 20;
            this.ckBurgerKing.Text = "Burger King";
            this.ckBurgerKing.UseVisualStyleBackColor = true;
            // 
            // cbMin
            // 
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(1124, 545);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(311, 32);
            this.cbMin.TabIndex = 22;
            // 
            // cbMax
            // 
            this.cbMax.FormattingEnabled = true;
            this.cbMax.Location = new System.Drawing.Point(1124, 637);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(311, 32);
            this.cbMax.TabIndex = 23;
            // 
            // btnFilterByStore
            // 
            this.btnFilterByStore.Location = new System.Drawing.Point(1185, 456);
            this.btnFilterByStore.Name = "btnFilterByStore";
            this.btnFilterByStore.Size = new System.Drawing.Size(191, 46);
            this.btnFilterByStore.TabIndex = 24;
            this.btnFilterByStore.Text = "Filter by Store";
            this.btnFilterByStore.UseVisualStyleBackColor = true;
            this.btnFilterByStore.Click += new System.EventHandler(this.btnFilterByStore_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1190, 805);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(197, 46);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 893);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFilterByStore);
            this.Controls.Add(this.cbMax);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.ckBestBuy);
            this.Controls.Add(this.ckBurgerKing);
            this.Controls.Add(this.ckTarget);
            this.Controls.Add(this.ckBoxLunch);
            this.Controls.Add(this.ckFredMeyer);
            this.Controls.Add(this.ckHotTopic);
            this.Controls.Add(this.ckStarbucks);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.btnFilterByCost);
            this.Controls.Add(this.lvTransactions);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTransactions;
        private System.Windows.Forms.Button btnFilterByCost;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox ckStarbucks;
        private System.Windows.Forms.CheckBox ckHotTopic;
        private System.Windows.Forms.CheckBox ckFredMeyer;
        private System.Windows.Forms.CheckBox ckBoxLunch;
        private System.Windows.Forms.CheckBox ckTarget;
        private System.Windows.Forms.CheckBox ckBestBuy;
        private System.Windows.Forms.CheckBox ckBurgerKing;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.ComboBox cbMax;
        private System.Windows.Forms.Button btnFilterByStore;
        private System.Windows.Forms.Button btnReset;
    }
}