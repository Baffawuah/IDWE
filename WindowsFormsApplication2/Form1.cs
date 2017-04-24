using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string readOut = "";
        string[] dataChain;
        ArrayList dataList = new ArrayList();
        public double globC = 0;
        double solution = 0;

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class dataPt
        {
            double x, y, measure, timeInt;

            public dataPt(double Nx, double Ny, double NtimeInt, double Nmeasure)
            {
                this.x = Nx;
                this.y = Ny;
                this.measure = Nmeasure;
                this.timeInt = NtimeInt;
            }

            public String ToString()
            {
                return this.x + "   " + this.y + "   " + this.measure + "   " + this.timeInt;
            }
            
            public double getX()
            {
                return this.x;
            }

            public double getY()
            {
                return this.y;
            }
            public double getTime()
            {
                return this.timeInt;
            }
            public double getMeasure()
            {
                return this.measure;
            }


        }

        public class dataArray
        {
            public ArrayList list = new ArrayList();

            public void add(dataPt entry)
            {
                list.Add(entry);
            }

            public void add(double Nx, double Ny, double NtimeInt, double Nmeasure)
            {
                dataPt temp = new dataPt(Nx, Ny, NtimeInt, Nmeasure);
                add(temp);
            }

            public void delete(dataPt entry)
            {
                // foreach()
            }
        }


        private void openPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            openFileDialog1.Title = "Open the Captured Packets";
            openFileDialog1.ShowDialog();

            //Check to see if a filename was given

            if (openFileDialog1.FileName != "")

                try
                {
                    {
                        readOut = System.IO.File.ReadAllText(openFileDialog1.FileName);
                        //textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                        dataChain = readOut.Split(new String[] { "\r\n", "\n" }, StringSplitOptions.None);

                        //Read out Code
                        string[] link; //dataChain[0].Split(null);



                        for (int i = 0; i < dataChain.Length - 1; i++)
                        {
                            link = dataChain[i].Split(null);
                            //textBox1.AppendText(link[0] + "         " + link[1] + "         " + link[2] + "         "+ link[3] + "\r\n");
                            dataPt Temp = new dataPt(Convert.ToDouble(link[0]), Convert.ToDouble(link[1]), Convert.ToDouble(link[2]), Convert.ToDouble(link[3]));

                            dataList.Add(Temp);
                            //ptDisplay.Items.Add(Temp.ToString());

                        }
                    }
                    ptDisplay.Items.Add(" Data Loading: Finished");
                    button2.Enabled = true;
                    globC = findC(dataList);
                    dataPt temp = (dataPt)dataList[dataList.Count - 1];
                    ptDisplay.Items.Add("--------------------------------------");
                    ptDisplay.Items.Add("The Maximum X value of this list is: " + findMaxX(dataList));
                    ptDisplay.Items.Add("The Minimum X value of this list is: " + findMinX(dataList));
                    ptDisplay.Items.Add("The Maximum Y value of this list is: " + findMaxY(dataList));
                    ptDisplay.Items.Add("the Minimum Y value of this list is: " + findMinY(dataList));
                    ptDisplay.Items.Add("The C for this List is " + findC(dataList));
                    //ptDisplay.Items.Add("A sample distance for the Test Data is " + findD((dataPt)dataList[0],(dataPt)dataList[1],globC));
                    //ptDisplay.Items.Add("The Value for the test data is " + IDWE(-80,26,359,2));
                    errTag.Text = "";
                }
                catch
                {
                    errTag.Text = "The file format you attempted to load is incorrect";
                    errTag.ForeColor = Color.Red;
                }


        }

        public ArrayList constructList(double v)
        {
            ArrayList parsedList = new ArrayList();
            int comp1 = (int)(v-2);
            int comp2;

            for(int i = 0; i < dataList.Count; i++)
            {
                comp2 =  (int)((dataPt)dataList[i]).getX();
                if (comp1 == comp2)
                {
                    parsedList.Add((dataPt)dataList[i]);
                }
            }




            return parsedList;
        }


        public double IDWE(double x, double y, double t, double P, ArrayList points)
        {
            double Answer = 0;
            dataPt holder = new dataPt(x,y,t,0);
            double d1 = 0;
            double d2 = 0;
            double w = 0;
            double top = 0;
            double bottom = 0;


            for(int i = 0; i <points.Count; i++)
            {
                d1 = findD( (dataPt) points[i] , holder , globC );
                d2 = findD( (dataPt) points[i] , holder , globC );
                w = ((dataPt)points[i]).getMeasure();

                top += w / (Math.Pow(d1,P));
                bottom += 1 / (Math.Pow(d2,P));



            }

            Answer = top / bottom;

            return Answer;
        }




        //Lesser functions that add up to form the larger one to make the code more modular
        //Check math sequence:

        public double findD(dataPt x1, dataPt x, double C)
        {
            double d = 0;

            d = Math.Sqrt(  (Math.Pow((x1.getX()- x.getX()),2.0)) + (Math.Pow((x1.getY() - x.getY()), 2)) + ( Math.Pow(globC,2.0) * (Math.Pow((x1.getTime() - x.getTime()), 2.0)))  );

            return d;
        }

   





        // Currently Under construction
        public double findC(ArrayList listing)
        {
            double C;
            double maxX = findMaxX(listing);
            double minX = findMinX(listing);
            double maxY = findMaxY(listing);
            double minY = findMinY(listing);

            C = (1.0 / 364.0)*(((maxX-minX)+(maxY-minY))/2);

            return C;
        }


        //Currently Under construction
        //Needs to be tested [X]
        public double findMaxX(ArrayList listing)
        {
           double max = 0;
            max = ((dataPt)listing[0]).getX();
            for(int i = 0; i < listing.Count; i++)
            {
                if(max < ((dataPt)listing[i]).getX())
                {
                    max = ((dataPt)listing[i]).getX();
                }
            }
            return max;
        }
        //Currently Under Construction
        //Needs to be tested [X]
        public double findMinX(ArrayList listing)
        {
            double min = 0;

            min = ((dataPt)listing[0]).getX();

            for (int i = 0; i < listing.Count; i++)
            {
                if (min > ((dataPt)listing[i]).getX())
                {
                    min = ((dataPt)listing[i]).getX();
                }
            }
            return min;
        }

        //CONVERSION TO Y VERSION OF MAX FUNCTIONS
        public double findMaxY(ArrayList listing)
        {
            double max = 0;
            max = ((dataPt)listing[0]).getY();
            for (int i = 0; i < listing.Count; i++)
            {
                if (max < ((dataPt)listing[i]).getY())
                {
                    max = ((dataPt)listing[i]).getY();
                }
            }
            return max;
        }
        //Currently Under Construction
        //Needs to be tested [X]
        public double findMinY(ArrayList listing)
        {
            double min = 0;

            min = ((dataPt)listing[0]).getY();

            for (int i = 0; i < listing.Count; i++)
            {
                if (min > ((dataPt)listing[i]).getY())
                {
                    min = ((dataPt)listing[i]).getY();
                }
            }
            return min;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clrDisplay_Click(object sender, EventArgs e)
        {
            ptDisplay.Items.Clear();
            errTag.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           try
            {
                ArrayList contextualList = constructList(Convert.ToDouble(xBox.Text));
                if (contextualList.Count == 0)
                {
                    solution = IDWE(Convert.ToDouble(xBox.Text), Convert.ToDouble(yBox.Text), Convert.ToDouble(tBox.Text), Convert.ToDouble(pBox.Text), dataList);
                }
                else
                {
                    solution = IDWE(Convert.ToDouble(xBox.Text), Convert.ToDouble(yBox.Text), Convert.ToDouble(tBox.Text), Convert.ToDouble(pBox.Text), contextualList);
                }
                ptDisplay.Items.Add("---------------------------------------------- ");
                ptDisplay.Items.Add("The Interpolation of the Points/Values you gave is :  " + solution);
                errTag.Text = "";
           }
            catch
            {
                errTag.Text = "Formating error, fields incorrect format!";
                errTag.ForeColor = Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
