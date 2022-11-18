using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_15_ListView
{
    public class Transaction
    {

        string _item;
        string _location;
        double _price;
        DateTime _transactionTime;

        public Transaction(string item, string location, double price, DateTime transactionTime)
        {
            _item = item;
            _location = location;
            _price = price;
            _transactionTime = transactionTime;
        }

        public string Item { get => _item; set => _item = value; }
        public string Location { get => _location; set => _location = value; }
        public double Price { get => _price; set => _price = value; }
        public DateTime TransactionTime { get => _transactionTime; set => _transactionTime = value; }
    } // class

} // namespace
