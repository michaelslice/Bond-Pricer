using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BondPricer;
using System.Windows.Forms.DataVisualization.Charting;
/*
namespace BondPricer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add a series to represent the interest rate path
            chart1.Series.Add("Interest Rate Path");
            chart1.Series["Interest Rate Path"].ChartType = SeriesChartType.Line;

            // Add a series to represent the Monte Carlo simulation
            chart1.Series.Add("Monte Carlo Simulation");
            chart1.Series["Monte Carlo Simulation"].ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Read the values from the text boxes
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

            // Generate interest rate path using the Hull-White model
            HullWhiteModel hullWhiteModel = new HullWhiteModel();
            double[] interestRatePath = hullWhiteModel.GenerateInterestRatePath(maturityRate, paymentFrequency);

            // Perform bond pricing calculations using the interest rate path
            double bondPrice = CalculateBondPrice(faceValue, couponRate, maturityRate, paymentFrequency, interestRatePath);

            // Display the calculated bond price
            string result = "The calculated bond price is: " + bondPrice.ToString("0.00");
            MessageBox.Show(result);

            // Display the interest rate path on the chart
            for (int i = 0; i < interestRatePath.Length; i++)
            {
                chart1.Series["Interest Rate Path"].Points.AddXY(i, interestRatePath[i]);
            }

            // Perform Monte Carlo simulation
            Random random = new Random();
            int numSimulations = 100; // Number of Monte Carlo simulations
            double[] monteCarloPrices = new double[numSimulations];

            for (int i = 0; i < numSimulations; i++)
            {
                double[] simulatedInterestRatePath = hullWhiteModel.GenerateInterestRatePath(maturityRate, paymentFrequency, random);
                double monteCarloPrice = CalculateBondPrice(faceValue, couponRate, maturityRate, paymentFrequency, simulatedInterestRatePath);
                monteCarloPrices[i] = monteCarloPrice;
            }

            // Display the Monte Carlo simulation on the chart
            for (int i = 0; i < monteCarloPrices.Length; i++)
            {
                chart1.Series["Monte Carlo Simulation"].Points.AddXY(i, monteCarloPrices[i]);
            }
        }

        // Perform bond pricing calculations using the interest rate path
        private double CalculateBondPrice(double faceValue, double couponRate, double maturityRate, int paymentFrequency, double[] interestRatePath)
        {
            // Perform your bond pricing calculations based on the interest rate path
            // ...

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
            // Generate the interest rate path using the Hull-White model
            // Placeholder implementation, returns a random path
            Random random = new Random();
            int numSteps = (int)maturityRate * paymentFrequency;
            double[] interestRatePath = new double[numSteps + 1];

            for (int i = 0; i <= numSteps; i++)
            {
                interestRatePath[i] = random.NextDouble(); // Replace with your Hull-White model logic
            }

            return interestRatePath;
        }

        public double[] GenerateInterestRatePath(double maturityRate, int paymentFrequency, Random random)
        {
            // Generate the interest rate path using the Hull-White model with a specified random number generator
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
*/