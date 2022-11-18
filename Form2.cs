using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Lecture_15_ListView
{
    public partial class Form2 : Form
    {
        List<Transaction> _transactions = new List<Transaction>();

        public Form2()
        {
            InitializeComponent();
            FillComboBoxes();
            GenerateTransactions(2000);
            DisplayTransactions(_transactions);
        } // Form2()

        private void button1_Click(object sender, EventArgs e)
        {
            double min = double.Parse(cbMin.Text);
            double max = double.Parse(cbMax.Text);

            DisplayTransactions(FilterByCost(min, max));
        } // button1_Click()

        public void DisplayTransactions(List<Transaction> transactions)
        {
            lvTransactions.Items.Clear();
            foreach (Transaction transaction in transactions)
            {

                string[] trans =
                {
                transaction.Item,
                transaction.Location,
                transaction.Price.ToString("c"),
                transaction.TransactionTime.ToShortDateString()
                };
 

                ListViewItem lvi = new ListViewItem(trans);
                lvTransactions.Items.Add(lvi);
            }


            lvTransactions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }// DisplayTransactions()

        List<Transaction> FilterByStore(string store)
        {
            List<Transaction> temp = new List<Transaction>();

            foreach (Transaction t in _transactions)
            {
                if(t.Location == store)
                {
                    temp.Add(t);
                }
            }

            return temp;
        } // FilterByStore()

        List<Transaction> FilterByCost(double min, double max)
        {
            List<Transaction> temp = new List<Transaction>();

            foreach (Transaction t in _transactions)
            {
                if (t.Price >= min && t.Price <= max)
                {
                    temp.Add(t);
                }
            }

            return temp;
        }

        void FillComboBoxes()
        {
            for (int i = 1; i <= 100; i++)
            {
                cbMin.Items.Add(i);
                cbMax.Items.Add(i);
            }
        } // FillComboBoxes()


        void GenerateTransactions(int populationSize)
    {
        string[] items = { "Food", "Clothing", "Electronics", "Books", "Drink", "Movie", "Toys" };
        string[] locations = { "Hot Topic", "Box Lunch", "Burger King", "Best Buy", "Starbucks", "Target", "Fred Meyer" };
        Random rand = new Random();

            for (int i = 0; i < populationSize; i++)
            {
                int itemIndex = rand.Next(items.Length);
                string item = items[itemIndex];

                int locationIndex = rand.Next(locations.Length);
                string location = locations[locationIndex];

                DateTime date = DateTime.Now.Subtract(TimeSpan.FromDays(rand.Next(10)));
                double price = rand.Next(1, 100) + rand.NextDouble();

                Transaction t = new Transaction(item, location, price, date);

                _transactions.Add(t);

            }
        } // GenerateTransactions()

        private void btnFilterByStore_Click(object sender, EventArgs e)
        {
            List<Transaction> _newTransaction;

            if(ckBestBuy.Checked)
            {
                _newTransaction = FilterByStore("Best Buy");
            }
            else if (ckBoxLunch.Checked)
            {
                _newTransaction = FilterByStore("Box Lunch");
            }
            else if (ckBurgerKing.Checked)
            {
                _newTransaction = FilterByStore("Burger King");
            }
            else if (ckFredMeyer.Checked)
            {
                _newTransaction = FilterByStore("Fred Meyer");
            }
            else if (ckHotTopic.Checked)
            {
                _newTransaction = FilterByStore("Hot Topic");
            }
            else if (ckStarbucks.Checked)
            {
                _newTransaction = FilterByStore("Starbucks");
            }
            else
            {
                _newTransaction = FilterByStore("Target");
            }

            DisplayTransactions(_newTransaction);

            //CheckBox[] checkBoxes =
            //{
            //    ckBestBuy,
            //    ckBoxLunch,
            //    ckBurgerKing,
            //    ckFredMeyer,
            //    ckHotTopic,
            //    ckStarbucks,
            //    ckTarget
            //};

            //foreach (CheckBox item in checkBoxes)
            //{
            //    if(item.Checked)
            //    {
            //        DisplayTransactions(FilterByStore(item.Text));


            //    }
            //}

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayTransactions(_transactions);
        }
    } // class

} // namespace
