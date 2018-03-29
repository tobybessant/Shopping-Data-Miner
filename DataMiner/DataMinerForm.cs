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
    //this class is the main class that reads the file, and draws graphs/axis to the panel.
    public partial class DataMinerForm : Form
    {
        //fields to store filename and directory name
        private string fileName;
        private string directoryName;

        //field to store a variable which dictates what graph to show
        private int whatGraph = 0;

        //variables which store the total number of items sold for each month
        static public int totalSoldJan = 0;
        static public int totalSoldFeb = 0;
        static public int totalSoldMar = 0;
        static public int totalSoldApr = 0;
        static public int totalSoldMay = 0;
        static public int totalSoldJun = 0;
        static public int totalSoldJul = 0;
        static public int totalSoldAug = 0;
        static public int totalSoldSep = 0;
        static public int totalSoldOct = 0;
        static public int totalSoldNov = 0;
        static public int totalSoldDec = 0;

        //variables whcih store the total number of invoices for each month
        static public int totalJan = 0;
        static public int totalFeb = 0;
        static public int totalMar = 0;
        static public int totalApr = 0;
        static public int totalMay = 0;
        static public int totalJun = 0;
        static public int totalJul = 0;
        static public int totalAug = 0;
        static public int totalSep = 0;
        static public int totalOct = 0;
        static public int totalNov = 0;
        static public int totalDec = 0;

        //variables which store the total value of items sold for each month
        static public double totalPriceJan = 0;
        static public double totalPriceFeb = 0;
        static public double totalPriceMar = 0;
        static public double totalPriceApr = 0;
        static public double totalPriceMay = 0;
        static public double totalPriceJun = 0;
        static public double totalPriceJul = 0;
        static public double totalPriceAug = 0;
        static public double totalPriceSep = 0;
        static public double totalPriceOct = 0;
        static public double totalPriceNov = 0;
        static public double totalPriceDec = 0;

        //fields which will store the values of half the panel height and width
        static public int halfPanelW;
        static public int halfPanelH;

        //field which will decide if a file has already been opened or not
        bool fileOpen = false;

        //list that stores the FileEntry object list called recordList
        
        private List<FileEntry> recordList = new List<FileEntry>();


        public DataMinerForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                fileName = openFileDialog.FileName;

                directoryName = openFileDialog.InitialDirectory;

                if (fileOpen == false)
                {
                    LoadFile();
                    fileOpen = true;
                }
                else
                {
                    Charts.ClearVariables();

                    recordList.Clear();

                    LoadFile();
                }
            }
        }

        //This method reads in the file and calls other methods which do the arithmetic, as well as adding each line as an object to recordList
        private void LoadFile()
        {
            rtbMain.Clear();
            string lineFromFile;

            char[] deliminator = { ',' };
            string[] lineFromFileSplit;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        lineFromFile = reader.ReadLine();

                        lineFromFileSplit = lineFromFile.Split(deliminator);

                        Charts.ProcessMonthlyTotal(lineFromFileSplit);

                        Charts.RecordsPerMonth(lineFromFileSplit);

                        Charts.ItemsSold(lineFromFileSplit);

                        addToList(lineFromFileSplit);                                           

                    }
                    whatGraph = 1;
                    drawTotalBarChart();
      
                    lblTotalEntries.Text = Convert.ToString(recordList.Count + 1);                   
                } 

            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading from file", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method that takes each index of the split string and assigns it to a new FileEntry object, and adding it to recordList
        private void addToList(string[] data)
        {
            string[] lineFromFileSplit = data;

            recordList.Add(new FileEntry()
            {
                InvoiceNum = lineFromFileSplit[0],
                StockCode = lineFromFileSplit[1],
                ItemDescription = lineFromFileSplit[2],
                Quantity = lineFromFileSplit[3],
                InvoiceDate = lineFromFileSplit[4],
                UnitPrice = lineFromFileSplit[5],
                CustomerID = lineFromFileSplit[6],
            });
        }                          

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            //re-draws the axis everytime the panel is resized.
            drawAxis();

            //redraws whichever graph is selected each time the panel is re-sized
            if (whatGraph == 1)
            {
                drawTotalBarChart();
            }
            else if (whatGraph == 2)
            {
                drawAmountSoldBarChart();
            }
            else if (whatGraph == 3)
            {
                drawRevenueBarChart();
            }


        }

        //method that draws the axis, labels, and markers
        private void drawAxis()
        {
            //following lines of code set up the various brushes, fonts, sizes, colours for each element of the axis.
            Pen axisPen;
            Brush rectBrush;
            Brush textBrush;
            Font Xfont;
            Font Yfont;
            int axisSize;

            Color axisColour = Color.Black;
            Color rectColour = Color.Blue;
            axisSize = 1;

            axisPen = new Pen(axisColour, axisSize);
            rectBrush = new SolidBrush(rectColour);
            textBrush = new SolidBrush(axisColour);
            Yfont = new Font("Arial", 7);
            Xfont = new Font("Arial", 10);

            //assigns the fields to half the panel Height/Width respectively.
            halfPanelW = panelGraph.Width / 2;
            halfPanelH = panelGraph.Height / 2;

            //startX and startY are assigned to be slightly less than half the panels Height/Width
            int startX = halfPanelW / 2 -150;
            int startY = halfPanelH / 2 - 100;

            using (Graphics panelGraphics = panelGraph.CreateGraphics())
            {
                panelGraphics.Clear(Color.White);
                //draw y-axis...
                panelGraphics.DrawLine(axisPen, startX, startY, startX , startY + 400);
                //draw x-axis...
                panelGraphics.DrawLine(axisPen, startX, startY + 400, startX + 700, startY + 400);
                //draw '400' marker...
                panelGraphics.DrawLine(axisPen, startX, startY, startX - 5, startY);
                //draw '200' marker...
                panelGraphics.DrawLine(axisPen, startX, startY+ 200, startX - 5, startY + 200);
                //draw '0' marker...
                panelGraphics.DrawLine(axisPen, startX, startY + 400, startX - 5, startY + 400);

                //draw marker values...
                panelGraphics.DrawString("400", Yfont, textBrush, startX - 25, startY -5);
                panelGraphics.DrawString("200", Yfont, textBrush, startX - 25, startY + 195);
                panelGraphics.DrawString("0", Yfont, textBrush, startX - 15, startY + 395);
                
                //loop through the months and print them onto the panel...
                int plus50 = 55;
                char[] months = new char[12] { 'J', 'F', 'M', 'A', 'M', 'J', 'J', 'A', 'S', 'O', 'N', 'D' };

                for (int i = 0; i <= months.Length - 1; i++)
                {
                    panelGraphics.DrawString(Convert.ToString(months[i]), Xfont, textBrush, startX + plus50, startY + 400);
                    plus50 += 50;
                }

            }
            axisPen.Dispose();
            rectBrush.Dispose();
        }

        //method that draws the chart displaying the total amount of items sold each month
        private void drawAmountSoldBarChart()
        {
            //following lines of code set up the various brushes, fonts, sizes, colours for each element of the chart.

            Font numFont;
            Brush rectBrush;
            Brush textBrush;


            Color rectColour = Color.Blue;
            rectBrush = new SolidBrush(rectColour);
            numFont = new Font("Arial", 7);
            textBrush = new SolidBrush(Color.Black);

            //moves the values into an array that can be looped through to draw out the bars.
            int[] numberToUse = new int[12] { totalSoldJan, totalSoldFeb, totalSoldFeb, totalSoldApr, totalSoldMay, totalSoldJun, totalSoldJul, totalSoldAug, totalSoldSep, totalSoldOct, totalSoldNov, totalSoldDec };

            int startX = halfPanelW / 2 - 100; //only minus 100 here so the bar starts 50 pixels after the axis itself.
            int startY;

            using (Graphics panelGraphics = panelGraph.CreateGraphics())
            {
                panelGraphics.Clear(Color.White);
                drawAxis();
                //the following loop draws out each bar.
                for (int i = 0; i < numberToUse.Length; i++)
                {
                    int numToSubtract = Convert.ToInt32(numberToUse[i]);

                    int barH = numToSubtract;

                    int barW = 25;

                    startY = (halfPanelH / 2 + 300) - numToSubtract;
          
                    panelGraphics.FillRectangle(rectBrush, startX, startY, barW, barH);//draws out the bar

                    //this if statement decides where to place the value on the panel (above/below the bar, if it needs to be recentered)
                    if (numberToUse[i] > 400) 
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 1, (halfPanelH/2 + 320));
                    }
                    else if (numberToUse[i] > 99)
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 2, startY - 10);
                    }
                    else
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 5, startY - 10);
                    }

                    //moves the next bar along by 50 pixels.
                    startX += 50;
                }
            }
        }

        //method that draws the total value of items sold per month
        private void drawRevenueBarChart()
        {
            //following lines of code set up the various brushes, fonts, sizes, colours for each element of the chart.
            Font numFont;
            Brush rectBrush;
            Brush textBrush;

            Color rectColour = Color.Blue;
            rectBrush = new SolidBrush(rectColour);
            numFont = new Font("Arial", 7);
            textBrush = new SolidBrush(Color.Black);
            //puts the variables into an array, explicitly casting them into integers so they can be displayed onto the panel
            int[] numberToUse = new int[12] { (int)totalPriceJan, (int)totalPriceFeb, (int)totalPriceFeb, (int)totalPriceApr, (int)totalPriceMay, (int)totalPriceJun, (int)totalPriceJul, (int)totalPriceAug, (int)totalPriceSep, (int)totalPriceOct, (int)totalPriceNov, (int)totalPriceDec };

            int startX = halfPanelW / 2 - 100;
            int startY;
            using (Graphics panelGraphics = panelGraph.CreateGraphics())

            {
                panelGraphics.Clear(Color.White);
                drawAxis();

                for (int i = 0; i < numberToUse.Length; i++)
                { 
                    int numToSubtract = Convert.ToInt32(numberToUse[i]);

                    int barH = numToSubtract;

                    int barW = 25;

                    startY = (halfPanelH / 2 + 300) - numToSubtract;

                    panelGraphics.FillRectangle(rectBrush, startX, startY, barW, barH);
                    if (numberToUse[i] > 400)
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 1, (halfPanelH / 2 + 320));
                    }
                    else if (numberToUse[i] > 99)
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 2, startY - 10);
                    }
                    else
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 5, startY - 10);
                    }

                    startX += 50;
                }
            }

        }

        //method that draws the total number of invoices per month
        private void drawTotalBarChart()
        {
            Font numFont;
            Brush rectBrush;
            Brush textBrush;


            Color rectColour = Color.Blue;
            rectBrush = new SolidBrush(rectColour);
            numFont = new Font("Arial", 7);
            textBrush = new SolidBrush(Color.Black);

            int[] numberToUse = new int[12] { totalJan, totalFeb, totalFeb, totalApr, totalMay, totalJun, totalJul, totalAug, totalSep, totalOct, totalNov, totalDec };

            int startX = halfPanelW / 2 - 100;
            int startY;

            using (Graphics panelGraphics = panelGraph.CreateGraphics())
            {
                panelGraphics.Clear(Color.White);
                drawAxis();
                for (int i = 0; i < numberToUse.Length; i++)
                {
                    Debug.WriteLine("\n LIST ITEM:\t{0}", numberToUse[i]);
                    int numToSubtract = Convert.ToInt32(numberToUse[i]);

                    //need to use same coords as the X axis to start barH...
                    
                    int barH = numToSubtract;
                        
                    int barW = 25;

                    startY = (halfPanelH / 2 + 300) - numToSubtract;

                    panelGraphics.FillRectangle(rectBrush, startX, startY, barW, barH);

                    if (numberToUse[i] > 400)
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 1, (halfPanelH / 2 + 320));
                    }
                    else if (numberToUse[i] > 99)
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 2, startY - 10);
                    }
                    else
                    {
                        panelGraphics.DrawString(Convert.ToString(numberToUse[i]), numFont, textBrush, startX + 5, startY - 10);
                    }


                    startX += 50;
                }
            }

        }

        private void radTotalQuantity_CheckedChanged(object sender, EventArgs e)
        {
            //updates the variable based on what radio button is checked.
            if(radInvoicesGenerated.Checked)
            {
                drawTotalBarChart();
                whatGraph = 1;
            }
            else if(radTotalQuantity.Checked)
            {
                drawAmountSoldBarChart();
                whatGraph = 2;
            }
            else if (radTotalValue.Checked)
            {
                drawRevenueBarChart();
                whatGraph = 3;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           int userSearch = Convert.ToInt32(txtSearchRecords.Text); //stores users search term

            rtbMain.Clear();
            
            //loops through the recordList earching for any matches to the users number. If a match is found, it will append it to the rich text box.
            foreach (FileEntry i in recordList)
            {
                //checks to see what radio buttom is checked before searching.
                if (radCustomer.Checked)
                {
                    if (Convert.ToInt32(i.CustomerID) == userSearch)
                    {
                        rtbMain.AppendText("\n Invoice Number:" + i.InvoiceNum + "\n Stock Code:" + i.StockCode + "\n Item Description:" + i.ItemDescription + "\n Quantity:" + i.Quantity + "\n Invoice Number:" + i.InvoiceNum + "\n Invoice Date:" + i.InvoiceDate + "\n Unit Price:" + i.UnitPrice + "\n Customer ID:" + i.CustomerID + "\n\n");
                    }
                }
                else if (radInvoice.Checked)
                {
                    if (Convert.ToInt32(i.InvoiceNum) == userSearch)
                    {                   
                        rtbMain.AppendText("\n Invoice Number:" + i.InvoiceNum + "\n Stock Code:" + i.StockCode + "\n Item Description:" + i.ItemDescription + "\n Quantity:" + i.Quantity + "\n Invoice Number:" + i.InvoiceNum + "\n Invoice Date:" + i.InvoiceDate + "\n Unit Price:" + i.UnitPrice + "\n Customer ID:" + i.CustomerID + "\n\n");
                    }
                }
            }
            //if the rich text box is empty after the above if statement, no match was found. This adds text to tell the user that.
            if (rtbMain.Text == "")
            {
                rtbMain.AppendText("No match found.");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }

}   


