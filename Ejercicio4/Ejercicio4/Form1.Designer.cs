namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.BGenerador = new System.Windows.Forms.Button();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.BPares = new System.Windows.Forms.Button();
            this.BImpares = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            this.LListaNum = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(43, 78);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(43, 137);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            // 
            // BGenerador
            // 
            this.BGenerador.Location = new System.Drawing.Point(110, 188);
            this.BGenerador.Name = "BGenerador";
            this.BGenerador.Size = new System.Drawing.Size(101, 23);
            this.BGenerador.TabIndex = 2;
            this.BGenerador.Text = "Generar Funcion";
            this.BGenerador.UseVisualStyleBackColor = true;
            this.BGenerador.Click += new System.EventHandler(this.BGenerador_Click);
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(97, 78);
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(143, 20);
            this.TDesde.TabIndex = 3;
            this.TDesde.TextChanged += new System.EventHandler(this.TDesde_TextChanged);
            this.TDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDesde_KeyPress_1);
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(97, 137);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(143, 20);
            this.THasta.TabIndex = 4;
            this.THasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.THasta_KeyPress_1);
            // 
            // BPares
            // 
            this.BPares.Location = new System.Drawing.Point(110, 247);
            this.BPares.Name = "BPares";
            this.BPares.Size = new System.Drawing.Size(101, 23);
            this.BPares.TabIndex = 5;
            this.BPares.Text = "Generar Pares";
            this.BPares.UseVisualStyleBackColor = true;
            this.BPares.Click += new System.EventHandler(this.BPares_Click);
            // 
            // BImpares
            // 
            this.BImpares.Location = new System.Drawing.Point(110, 310);
            this.BImpares.Name = "BImpares";
            this.BImpares.Size = new System.Drawing.Size(101, 23);
            this.BImpares.TabIndex = 6;
            this.BImpares.Text = "Generar Impares";
            this.BImpares.UseVisualStyleBackColor = true;
            this.BImpares.Click += new System.EventHandler(this.BImpares_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(110, 372);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(101, 23);
            this.BPrimos.TabIndex = 7;
            this.BPrimos.Text = "Generar Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // LListaNum
            // 
            this.LListaNum.FormattingEnabled = true;
            this.LListaNum.Location = new System.Drawing.Point(279, 77);
            this.LListaNum.Name = "LListaNum";
            this.LListaNum.Size = new System.Drawing.Size(189, 160);
            this.LListaNum.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(493, 77);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(295, 251);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LListaNum);
            this.Controls.Add(this.BPrimos);
            this.Controls.Add(this.BImpares);
            this.Controls.Add(this.BPares);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.BGenerador);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Button BGenerador;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.Button BPares;
        private System.Windows.Forms.Button BImpares;
        private System.Windows.Forms.Button BPrimos;
        private System.Windows.Forms.ListBox LListaNum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

