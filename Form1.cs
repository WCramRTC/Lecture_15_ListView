using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_15_ListView
{
    public partial class Form1 : Form
    {
        // Global List
        List<Transaction> _transactions = new List<Transaction>();

        public Form1()
        {
            InitializeComponent();
            FillComboBox();
            GenerateTransactions(10000);
            DisplayTransactions(_transactions);

            

            // Generates one transaction and adds to list



        } // Form1()

        // Create a Linear Search that Returns a list of transactions between a time period
        public List<Transaction> FilterByCost(double min, double max)
        {
            // Create an empty transaction list
            List<Transaction> temp = new List<Transaction>();

            foreach (Transaction transaction in _transactions)
            {
                // If price is above min price and price is below max price
                if(transaction.Price >= min && transaction.Price <= max)
                {
                    // Add to our temp list
                    temp.Add(transaction);
                }
            }

            // Return populated list
            return temp;
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            int min = int.Parse(cbMin.Text);
            int max = int.Parse(cbMax.Text);

            List<Transaction> filteredList = FilterByCost(min, max);

            DisplayTransactions(filteredList);

        } // btnFilter_Click


        // ListView
        // Display Box that provides rows and columns similar to an excel spread sheet
        public void FormatTransaction(Transaction transaction)
        {
            // First step - Create a string array
            string[] item =
            {
                transaction.Item, // Represent Item
                transaction.Location, // Location
                transaction.Price.ToString("c"), // Price
                transaction.TransactionTime.ToShortDateString() // Time
            };

            // Second Step - Create a List View Item
            // Pass in our string array, into our constructor
            ListViewItem lvi = new ListViewItem(item);

            // Third Step - Add ListViewItem , lvi, to our List View Items List
            lvTransactions.Items.Add(lvi);
        }

        public void FillComboBox()
        {
            // Loop from 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                cbMin.Items.Add(i);
                cbMax.Items.Add(i);
            }

            // Starts cbMin at index 0
            cbMin.SelectedIndex = 0;
            // Starts cbMax = last index
            cbMax.SelectedIndex = cbMax.Items.Count - 1;

        } // FillComboBox()

        // Display Transactions
        public void DisplayTransactions(List<Transaction> transactions)
        {
            // Clears our list view to preventing doubling up information
            lvTransactions.Items.Clear();

            foreach (Transaction transaction in transactions)
            {
                FormatTransaction(transaction);
            }

            // Use to auto reseize columns
            lvTransactions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        } // DisplayTransactions


        // Procedurally Generated Preload
        public void GenerateTransactions(int numOfTransaction)
        {
            // Random object
            Random rand = new Random();
            // Items
            string[] items = { "Toys", "Food", "Drink", "Electronics", "Car", "Books", "Clothes" };
            // Stores
            string[] stores = { "Target", "Fred Meyer", "Best Buy", "Walmart", "Costco", "Macys", "Popeyes" };


            for (int i = 0; i < numOfTransaction; i++)
            {
                int itemIndex = rand.Next(items.Length); // 0 - 6
                                                         // Item were passing in
                string item = items[itemIndex];

                int storeIndex = rand.Next(stores.Length);
                // Store were passing in
                string store = stores[storeIndex];
                // Price
                double dollarAmt = rand.Next(1, 101); // Range 1 dollar to 100 dollars
                double centAmt = rand.NextDouble(); // Random cent amount
                                                    // Price were passing in
                double price = dollarAmt + centAmt;

                // Date

                // Date were passing in
                // Use time span object to subtract days in simple math
                int randomDay = rand.Next(8);
                DateTime now = DateTime.Now.Subtract(TimeSpan.FromDays(randomDay));

                // Goal is to have our code populate the constructor of a transaction
                Transaction transaction = new Transaction(item, store, price, now);

                // Add the transaction to our list
                _transactions.Add(transaction);
            }

        } // GenerateTransactions

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Display Entire list of transactions
            DisplayTransactions(_transactions);
        } // btnReset_Click


        private void btnExampleForm_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        } // btnExampleForm_Click()

 
    } // class

} // namespace
