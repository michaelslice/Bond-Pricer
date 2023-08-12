
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;


namespace BondPricer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.MaximumSize = new System.Drawing.Size(100000, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Face Value:";

            // 
            // textBox1 code for bond face value 
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2 
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coupon Rate:";
            // 
            // textBox2 code for bond coupon rate 
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maturity Date:";
            // 
            // textBox3 code for maturity rate 
            // 
            this.textBox3.Location = new System.Drawing.Point(479, 410);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment Frequency:\r\n\r\n";
            // 
            // textBox4 code for payment frequency 
            // 
            this.textBox4.Location = new System.Drawing.Point(719, 410);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button1 button for bond pricing 
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Caclulate Bond Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(15, 76);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            series2.IsVisibleInLegend = false;
            this.chart1.Size = new System.Drawing.Size(800, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = " Corporate Bond-Pricer";
            //
            // label 6 code for bond price after maturity
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private const int RandomSeed = 12345;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}



namespace BondPricer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add a series to represent the interest rate path
            Series interestRateSeries = chart1.Series.Add("Interest Rate Path");
            interestRateSeries.ChartType = SeriesChartType.Line;
            interestRateSeries.IsVisibleInLegend = false;

            // Series for the Monte Carlo simulation
            chart1.Series.Add("Monte Carlo Simulation");
            chart1.Series["Monte Carlo Simulation"].ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Take in input for the boxes
            double faceValue = Convert.ToDouble(textBox1.Text);
            double couponRate = Convert.ToDouble(textBox2.Text);
            double maturityRate = Convert.ToDouble(textBox3.Text);
            int paymentFrequency = Convert.ToInt32(textBox4.Text);

            // Clear the text box fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Clear the existing data from the chart
            chart1.Series["Interest Rate Path"].Points.Clear();
            chart1.Series["Monte Carlo Simulation"].Points.Clear();


            Random random = new Random(RandomSeed);

            // Generate interest rate path using the Hull-White model with the fixed seed
            HullWhiteModel hullWhiteModel = new HullWhiteModel();
            double[] interestRatePath = hullWhiteModel.GenerateInterestRatePath(maturityRate, paymentFrequency, random);


            // Perform bond pricing calculations using the interest rate path
            double bondPrice = CalculateBondPrice(faceValue, couponRate, maturityRate, paymentFrequency, interestRatePath);

            // Display the calculated bond price in the label
            this.label6.Text = "The bond price at maturity is: " + bondPrice.ToString("0.00");

            // Calculate the total number of time periods
            int totalPeriods = (int)(maturityRate * paymentFrequency);



            // Connect the first and last points of the mean reversion line
            chart1.Series["Interest Rate Path"].Points.AddXY(0, interestRatePath[0]);
            chart1.Series["Interest Rate Path"].Points.AddXY(maturityRate, interestRatePath[totalPeriods]);


            // Perform Monte Carlo simulation
            
            int numSimulations = 100; // Number of Monte Carlo simulations
            double[] monteCarloPrices = new double[numSimulations];
            for (int i = 0; i < numSimulations; i++)
           
            
            {
                double[] simulatedInterestRatePath = hullWhiteModel.GenerateInterestRatePath(maturityRate, paymentFrequency, random);
                double monteCarloPrice = CalculateBondPrice(faceValue, couponRate, maturityRate, paymentFrequency, simulatedInterestRatePath);
                monteCarloPrices[i] = monteCarloPrice;
            }

            // Display all Monte Carlo simulations on the chart
                for (int i = 0; i < numSimulations; i++)
                {
                    // Add the face value as the first data point for each simulation
                    chart1.Series["Monte Carlo Simulation"].Points.AddXY(0, faceValue);

                    for (int j = 0; j < monteCarloPrices.Length; j++)
                    {
                        double time = (j + 1) / (double)paymentFrequency;
                        chart1.Series["Monte Carlo Simulation"].Points.AddXY(time, monteCarloPrices[j]);
                    }
            }
        }

        // Perform bond pricing calculations using the interest rate path
        private double CalculateBondPrice(double faceValue, double couponRate, double maturityRate, int paymentFrequency, double[] interestRatePath)
        {

            // Placeholder implementation, calculating bond price as sum of present values of cash flows
            double bondPrice = 0.0;
            double discountFactor;
            int numSteps = interestRatePath.Length - 1;

            for (int i = 0; i < numSteps; i++)
            {
                double t = (i + 1) / (double)paymentFrequency;
                discountFactor = Math.Exp(-interestRatePath[i] * t);
                bondPrice += couponRate * faceValue / paymentFrequency * discountFactor;
            }

            bondPrice += faceValue / paymentFrequency * Math.Exp(-interestRatePath[numSteps] * maturityRate);

            return bondPrice;
        }
    }

    public class HullWhiteModel
    {
        public double[] GenerateInterestRatePath(double maturityRate, int paymentFrequency)
        {
            // Placeholder implementation, returns a random path
            Random random = new Random();
            int numSteps = (int)maturityRate * paymentFrequency;
            double[] interestRatePath = new double[numSteps + 1];

            for (int i = 0; i <= numSteps; i++)
            {
                interestRatePath[i] = random.NextDouble();
            }

            return interestRatePath;
        }

        public double[] GenerateInterestRatePath(double maturityRate, int paymentFrequency, Random random)
        {   
            // Placeholder implementation, returns a random path
            int numSteps = (int)maturityRate * paymentFrequency;
            double[] interestRatePath = new double[numSteps + 1];

            for (int i = 0; i <= numSteps; i++)
            {
                interestRatePath[i] = random.NextDouble(); // Replace with your Hull-White model logic
            }




            return interestRatePath;
        }
    }
}