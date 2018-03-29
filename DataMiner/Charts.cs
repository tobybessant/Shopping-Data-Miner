using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DataMiner
{
    //This class deals with most of the logic and arithmetic in the program
    class Charts
    {
        //method that calculates how many invoices there are per month
        public static void RecordsPerMonth (string[] data)
        {
            {
                char[] deliminator = { '/' }; 
                string[] dateArray;
                double price = Convert.ToDouble(data[5]); //captures both the price and units from data[] (original array of strings)
                double units = Convert.ToDouble(data[3]);

                dateArray = data[4].Split(deliminator); //splits data[4] (index containing the date/time) again by a '/' to capture the month of each invoice.

                if (dateArray[1] == "01") //this if statement determines what month the invoice is from and updates variables appropriately. 
                {
                    DataMinerForm.totalJan++;
                }
                else if (dateArray[1] == "02")
                {
                    DataMinerForm.totalFeb++;
                }
                else if (dateArray[1] == "03")
                {
                    DataMinerForm.totalMar++;
                }
                else if (dateArray[1] == "04")
                {
                    DataMinerForm.totalApr++;
                }
                else if (dateArray[1] == "05")
                {
                    DataMinerForm.totalMay++;
                }
                else if (dateArray[1] == "06")
                {
                    DataMinerForm.totalJun++;
                }
                else if (dateArray[1] == "07")
                {
                    DataMinerForm.totalJul++;
                }
                else if (dateArray[1] == "08")
                {
                    DataMinerForm.totalAug++;
                }
                else if (dateArray[1] == "09")
                {
                    DataMinerForm.totalSep++;
                }
                else if (dateArray[1] == "10")
                {
                    DataMinerForm.totalOct++;
                }
                else if (dateArray[1] == "11")
                {
                    DataMinerForm.totalNov++;
                }
                else if (dateArray[1] == "12")
                {
                    DataMinerForm.totalDec++;
                }

            }
        }

        //method that calculates how many items sold there were per month
        public static void ItemsSold(string[] data)
        {
            char[] deliminator = { '/' };
            string[] dateArray;

            dateArray = data[4].Split(deliminator); //splits data[4] (index containing the date/time) again by a '/' to capture the month of each invoice.

            int numberSold = 0; //needs to be re-initialised so that the number of items on each invoice doesnt add up before being sorted by month.

            if (dateArray[1] == "01") //this if statement determines what month the invoice is from and updates variables appropriately.
            {
                
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldJan += numberSold;
            }
            else if (dateArray[1] == "02")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldFeb += numberSold;
            }
            else if (dateArray[1] == "03")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldMar += numberSold;
            }
            else if (dateArray[1] == "04")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldApr += numberSold;
            }
            else if (dateArray[1] == "05")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldMay += numberSold;
            }
            else if (dateArray[1] == "06")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldJun += numberSold;
            }
            else if (dateArray[1] == "07")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldJul += numberSold;
            }
            else if (dateArray[1] == "08")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldAug += numberSold;
            }
            else if (dateArray[1] == "09")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldSep += numberSold;
            }
            else if (dateArray[1] == "10")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldOct += numberSold;
            }
            else if (dateArray[1] == "11")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldNov += numberSold;
            }
            else if (dateArray[1] == "12")
            {
                numberSold = Convert.ToInt32(data[3]);
                DataMinerForm.totalSoldDec += numberSold;
            }
        }

        //method that calculates the value of items sold each month
        public static void ProcessMonthlyTotal(string[] data)
        {
            char[] deliminator = { '/' };
            string[] dateArray;
            double price = Convert.ToDouble(data[5]);
            double units = Convert.ToDouble(data[3]);

            dateArray = data[4].Split(deliminator); //splits data[4] (index containing the date/time) again by a '/' to capture the month of each invoice.

            if (dateArray[1] == "01") //this if statement determines what month the invoice is from and updates variables appropriately.
            {
                DataMinerForm.totalPriceJan += (units * price);
            }
            else if (dateArray[1] == "02")
            {
                DataMinerForm.totalPriceFeb += (units * price);
            }
            else if (dateArray[1] == "03")
            {
                DataMinerForm.totalPriceMar += (units * price);
            }
            else if (dateArray[1] == "04")
            {
                DataMinerForm.totalPriceApr += (units * price);
            }
            else if (dateArray[1] == "05")
            {
                DataMinerForm.totalPriceMay += (units * price);
            }
            else if (dateArray[1] == "06")
            {
                DataMinerForm.totalPriceJun += (units * price);
            }
            else if (dateArray[1] == "07")
            {
                DataMinerForm.totalPriceJul += (units * price);
            }
            else if (dateArray[1] == "08")
            {
                DataMinerForm.totalPriceAug += (units * price);
            }
            else if (dateArray[1] == "09")
            {
                DataMinerForm.totalPriceSep += (units * price);
            }
            else if (dateArray[1] == "10")
            {
                DataMinerForm.totalPriceOct += (units * price);
            }
            else if (dateArray[1] == "11")
            {
                DataMinerForm.totalPriceNov += (units * price);
            }
            else if (dateArray[1] == "12")
            {
                DataMinerForm.totalPriceDec += (units * price);
            }

        }

        //method used to clear/reset variables if btnOpenFile is pressed whilst a file is already loaded
        public static void ClearVariables()
        {
            DataMinerForm.totalSoldJan = 0;
            DataMinerForm.totalSoldFeb = 0;
            DataMinerForm.totalSoldMar = 0;
            DataMinerForm.totalSoldApr = 0;
            DataMinerForm.totalSoldMay = 0;
            DataMinerForm.totalSoldJun = 0;
            DataMinerForm.totalSoldJul = 0;
            DataMinerForm.totalSoldAug = 0;
            DataMinerForm.totalSoldSep = 0;
            DataMinerForm.totalSoldOct = 0;
            DataMinerForm.totalSoldNov = 0;
            DataMinerForm.totalSoldDec = 0;

            DataMinerForm.totalJan = 0;
            DataMinerForm.totalFeb = 0;
            DataMinerForm.totalMar = 0;
            DataMinerForm.totalApr = 0;
            DataMinerForm.totalMay = 0;
            DataMinerForm.totalJun = 0;
            DataMinerForm.totalJul = 0;
            DataMinerForm.totalAug = 0;
            DataMinerForm.totalSep = 0;
            DataMinerForm.totalOct = 0;
            DataMinerForm.totalNov = 0;
            DataMinerForm.totalDec = 0;

            DataMinerForm.totalPriceJan = 0;
            DataMinerForm.totalPriceFeb = 0;
            DataMinerForm.totalPriceMar = 0;
            DataMinerForm.totalPriceApr = 0;
            DataMinerForm.totalPriceMay = 0;
            DataMinerForm.totalPriceJun = 0;
            DataMinerForm.totalPriceJul = 0;
            DataMinerForm.totalPriceAug = 0;
            DataMinerForm.totalPriceSep = 0;
            DataMinerForm.totalPriceOct = 0;
            DataMinerForm.totalPriceNov = 0;
            DataMinerForm.totalPriceDec = 0;

    }
      
    }
}
