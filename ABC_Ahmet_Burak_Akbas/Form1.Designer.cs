namespace ABC_Ahmet_Burak_Akbas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtColonySize = new System.Windows.Forms.TextBox();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.chartFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartX1X2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX1X2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtColonySize
            // 
            this.txtColonySize.Location = new System.Drawing.Point(12, 86);
            this.txtColonySize.Name = "txtColonySize";
            this.txtColonySize.Size = new System.Drawing.Size(132, 22);
            this.txtColonySize.TabIndex = 0;
            this.txtColonySize.Text = "10";
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(12, 134);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(132, 22);
            this.txtDimension.TabIndex = 1;
            this.txtDimension.Text = "2";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(12, 182);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(132, 22);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.Text = "5";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(12, 230);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(132, 22);
            this.txtIterations.TabIndex = 3;
            this.txtIterations.Text = "10";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 310);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 43);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Başlat";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(9, 371);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(244, 120);
            this.lblResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Colony Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dimension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Limit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Iterations:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(803, 343);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(304, 265);
            this.txtLog.TabIndex = 11;
            // 
            // chartFx
            // 
            chartArea1.AxisX.Title = "Iteration";
            chartArea1.AxisY.Title = "Fx";
            chartArea1.Name = "ChartArea1";
            this.chartFx.ChartAreas.Add(chartArea1);
            this.chartFx.Location = new System.Drawing.Point(234, 59);
            this.chartFx.Name = "chartFx";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "fx";
            this.chartFx.Series.Add(series1);
            this.chartFx.Size = new System.Drawing.Size(398, 241);
            this.chartFx.TabIndex = 12;
            this.chartFx.Text = "chartFx";
            // 
            // chartX1X2
            // 
            chartArea2.AxisX.Title = "Iteration";
            chartArea2.AxisY.Title = "X1 / X2";
            chartArea2.Name = "ChartArea1";
            this.chartX1X2.ChartAreas.Add(chartArea2);
            this.chartX1X2.Location = new System.Drawing.Point(694, 59);
            this.chartX1X2.Name = "chartX1X2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "x1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "x2";
            this.chartX1X2.Series.Add(series2);
            this.chartX1X2.Series.Add(series3);
            this.chartX1X2.Size = new System.Drawing.Size(413, 241);
            this.chartX1X2.TabIndex = 13;
            this.chartX1X2.Text = "chartX1X2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ABC_Ahmet_Burak_Akbas.Properties.Resources.Ekran_görüntüsü_2025_05_17_191845;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1361, 731);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.txtColonySize);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chartFx);
            this.Controls.Add(this.chartX1X2);
            this.Name = "Form1";
            this.Text = "ABC Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.chartFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX1X2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColonySize;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX1X2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

