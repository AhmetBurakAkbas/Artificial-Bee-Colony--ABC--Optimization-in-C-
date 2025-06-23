using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABC_Ahmet_Burak_Akbas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                chartFx.Series["fx"].Points.Clear();
                chartX1X2.Series["x1"].Points.Clear();
                chartX1X2.Series["x2"].Points.Clear();
                txtLog.Text = "";
                lblResult.Text = "";

                if (!int.TryParse(txtColonySize.Text, out int colonySize) ||
                    !int.TryParse(txtDimension.Text, out int dimension) ||
                    !int.TryParse(txtLimit.Text, out int limit) ||
                    !int.TryParse(txtIterations.Text, out int iterations))
                {
                    MessageBox.Show("Lütfen geçerli sayısal değerler giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double lowerBound = -5;
                double upperBound = 5;

                ABCAlgorithm abc = new ABCAlgorithm(colonySize, dimension, limit, iterations, lowerBound, upperBound);
                abc.Run();

                lblResult.Text = $"En iyi değer: {abc.BestFitness:F4}\n";
                for (int i = 0; i < dimension; i++)
                    lblResult.Text += $"x{i + 1}: {abc.BestSolution[i]:F4}\n";

                for (int i = 0; i < abc.Convergence.Count; i++)
                {
                    double x1 = abc.BestPositions[i][0];
                    double x2 = (dimension > 1) ? abc.BestPositions[i][1] : 0.0;
                    double fx = ObjectiveFunction.Evaluate(abc.BestPositions[i]);
                    double fit = 1.0 / (1.0 + fx);

                    txtLog.AppendText($"x1: {x1:F4} | x2: {x2:F4} | fx: {fx:F4} | fit: {fit:F4}\r\n");
                    chartFx.Series["fx"].Points.AddXY(i + 1, fx);
                    chartX1X2.Series["x1"].Points.AddXY(i + 1, x1);
                    chartX1X2.Series["x2"].Points.AddXY(i + 1, x2);
                }


                chartFx.Invalidate();
                chartX1X2.Invalidate();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}