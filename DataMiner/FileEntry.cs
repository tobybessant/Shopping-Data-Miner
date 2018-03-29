using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataMiner
{
    //this class defines the FileEntry objects that are added to recordList.
    class FileEntry
    {
        //these fields match up to the field names on the .csv file so each line is moved into an object with properties that match that of the origional file.
        private string invoiceNum;
        private string stockCode;
        private string itemDescription;
        private string quantity;
        private string invoiceDate;
        private string unitPrice;
        private string customerID;

        public string InvoiceNum
        {
            get { return invoiceNum; }
            set { invoiceNum = value; }
        }
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        public string UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
    }
}
