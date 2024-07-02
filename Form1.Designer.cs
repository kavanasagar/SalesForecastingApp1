using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace SalesForecastingApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Forecasting Application";
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbYear.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(97, 186);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(146, 29);
            this.cbYear.TabIndex = 1;
            this.cbYear.Text = "Select Year";
            // 
            // txtPercentage
            // 
            this.txtPercentage.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtPercentage.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentage.Location = new System.Drawing.Point(97, 245);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(195, 31);
            this.txtPercentage.TabIndex = 2;
            this.txtPercentage.Text = "Percentage Increase";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Magenta;
            this.btnCalculate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalculate.Location = new System.Drawing.Point(97, 307);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 52);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Forecast";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(317, 294);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(171, 81);
            this.dgvSales.TabIndex = 4;
            // 
            // chartSales
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSales.Legends.Add(legend4);
            this.chartSales.Location = new System.Drawing.Point(522, 116);
            this.chartSales.Name = "chartSales";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSales.Series.Add(series4);
            this.chartSales.Size = new System.Drawing.Size(237, 322);
            this.chartSales.TabIndex = 5;
            this.chartSales.Text = "chart1";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnExport.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(97, 380);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(154, 35);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export to CV";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Button btnExport;

        private void InitializeComponent1()
        {
            this.cbYear = new ComboBox();
            this.txtPercentage = new TextBox();
            this.btnCalculate = new Button();
            this.dgvSales = new DataGridView();
            this.chartSales = new Chart();
            this.btnExport = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();

            // ComboBox for Year Selection
            this.cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new Point(12, 12);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new Size(121, 21);

            // TextBox for Percentage Increase
            this.txtPercentage.Location = new Point(150, 12);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new Size(100, 20);
            //this.txtPercentage.PlaceholderText = "Percentage Increase";

            // Button for Calculate
            this.btnCalculate.Location = new Point(270, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new Size(75, 23);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.BtnCalculate_Click);

            // DataGridView for Sales Data
            this.dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new Point(12, 50);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.Size = new Size(600, 200);

            // Chart for Sales Data
            ChartArea chartArea = new ChartArea();
            Legend legend = new Legend();
            Series series = new Series();

            this.chartSales.ChartAreas.Add(chartArea);
            this.chartSales.Legends.Add(legend);
            this.chartSales.Series.Add(series);
            this.chartSales.Location = new Point(12, 270);
            this.chartSales.Name = "chartSales";
            this.chartSales.Size = new Size(600, 200);

            // Button for Export
            this.btnExport.Location = new Point(12, 480);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new Size(75, 23);
            this.btnExport.Text = "Export to CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new EventHandler(this.BtnExport_Click);

            // MainForm
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(624, 511);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Sales Forecasting Application";

            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }
    }
}

