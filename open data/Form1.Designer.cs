﻿namespace open_data
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepth = new System.Windows.Forms.TextBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostraFiltri_Click = new System.Windows.Forms.Button();
            this.buttonZonaFilter = new System.Windows.Forms.Button();
            this.textBoxZona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMagnitudoFilter = new System.Windows.Forms.Button();
            this.textBoxMagnitudo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chartMagnitudo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProfondita = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.profondità = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonMostraGrafici = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMagnitudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfondita)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Click
            // 
            this.button_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Click.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_Click.Location = new System.Drawing.Point(518, 48);
            this.button_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Click.Name = "button_Click";
            this.button_Click.Size = new System.Drawing.Size(107, 59);
            this.button_Click.TabIndex = 1;
            this.button_Click.Text = "mostra";
            this.button_Click.UseVisualStyleBackColor = true;
            this.button_Click.Click += new System.EventHandler(this.button_Click_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(299, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "profondità";
            // 
            // textBoxDepth
            // 
            this.textBoxDepth.Location = new System.Drawing.Point(302, 627);
            this.textBoxDepth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDepth.Name = "textBoxDepth";
            this.textBoxDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxDepth.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonFilter.Location = new System.Drawing.Point(302, 665);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "filtra";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "TERREMOTI IN ITALIA DAL 1985 AL 2020";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.ForestGreen;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 627);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // data_btn
            // 
            this.data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.data_btn.Location = new System.Drawing.Point(62, 665);
            this.data_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_btn.Name = "data_btn";
            this.data_btn.Size = new System.Drawing.Size(75, 23);
            this.data_btn.TabIndex = 8;
            this.data_btn.Text = "filtra";
            this.data_btn.UseVisualStyleBackColor = true;
            this.data_btn.Click += new System.EventHandler(this.data_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(59, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(632, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Per aprire il file \r\ne resettare il file";
            // 
            // btnMostraFiltri_Click
            // 
            this.btnMostraFiltri_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraFiltri_Click.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnMostraFiltri_Click.Location = new System.Drawing.Point(61, 521);
            this.btnMostraFiltri_Click.Name = "btnMostraFiltri_Click";
            this.btnMostraFiltri_Click.Size = new System.Drawing.Size(341, 59);
            this.btnMostraFiltri_Click.TabIndex = 14;
            this.btnMostraFiltri_Click.Text = "Filtri";
            this.btnMostraFiltri_Click.UseVisualStyleBackColor = true;
            this.btnMostraFiltri_Click.Click += new System.EventHandler(this.btnMostraFiltri_Click_Click);
            // 
            // buttonZonaFilter
            // 
            this.buttonZonaFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZonaFilter.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonZonaFilter.Location = new System.Drawing.Point(62, 786);
            this.buttonZonaFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZonaFilter.Name = "buttonZonaFilter";
            this.buttonZonaFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonZonaFilter.TabIndex = 17;
            this.buttonZonaFilter.Text = "filtra";
            this.buttonZonaFilter.UseVisualStyleBackColor = true;
            this.buttonZonaFilter.Click += new System.EventHandler(this.buttonZonaFilter_Click_1);
            // 
            // textBoxZona
            // 
            this.textBoxZona.Location = new System.Drawing.Point(62, 748);
            this.textBoxZona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxZona.Name = "textBoxZona";
            this.textBoxZona.Size = new System.Drawing.Size(100, 22);
            this.textBoxZona.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(59, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "zona";
            // 
            // buttonMagnitudoFilter
            // 
            this.buttonMagnitudoFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMagnitudoFilter.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMagnitudoFilter.Location = new System.Drawing.Point(302, 786);
            this.buttonMagnitudoFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMagnitudoFilter.Name = "buttonMagnitudoFilter";
            this.buttonMagnitudoFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonMagnitudoFilter.TabIndex = 20;
            this.buttonMagnitudoFilter.Text = "filtra";
            this.buttonMagnitudoFilter.UseVisualStyleBackColor = true;
            this.buttonMagnitudoFilter.Click += new System.EventHandler(this.buttonMagnitudoFilter_Click_1);
            // 
            // textBoxMagnitudo
            // 
            this.textBoxMagnitudo.Location = new System.Drawing.Point(302, 748);
            this.textBoxMagnitudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMagnitudo.Name = "textBoxMagnitudo";
            this.textBoxMagnitudo.Size = new System.Drawing.Size(100, 22);
            this.textBoxMagnitudo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(299, 719);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "magnitudo";
            // 
            // chartMagnitudo
            // 
            this.chartMagnitudo.BorderlineColor = System.Drawing.Color.LawnGreen;
            this.chartMagnitudo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartMagnitudo.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chartMagnitudo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMagnitudo.Legends.Add(legend1);
            this.chartMagnitudo.Location = new System.Drawing.Point(967, 84);
            this.chartMagnitudo.Name = "chartMagnitudo";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMagnitudo.Series.Add(series1);
            this.chartMagnitudo.Size = new System.Drawing.Size(619, 323);
            this.chartMagnitudo.TabIndex = 21;
            this.chartMagnitudo.Text = "chart1";
            // 
            // chartProfondita
            // 
            this.chartProfondita.BorderlineColor = System.Drawing.Color.LawnGreen;
            this.chartProfondita.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartProfondita.BorderlineWidth = 3;
            chartArea2.Name = "ChartArea1";
            this.chartProfondita.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProfondita.Legends.Add(legend2);
            this.chartProfondita.Location = new System.Drawing.Point(967, 499);
            this.chartProfondita.Name = "chartProfondita";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProfondita.Series.Add(series2);
            this.chartProfondita.Size = new System.Drawing.Size(619, 323);
            this.chartProfondita.TabIndex = 22;
            this.chartProfondita.Text = "chart2";
            // 
            // profondità
            // 
            this.profondità.AutoSize = true;
            this.profondità.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profondità.ForeColor = System.Drawing.Color.ForestGreen;
            this.profondità.Location = new System.Drawing.Point(964, 469);
            this.profondità.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profondità.Name = "profondità";
            this.profondità.Size = new System.Drawing.Size(77, 16);
            this.profondità.TabIndex = 23;
            this.profondità.Text = "profondità";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(964, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "magnitudo";
            // 
            // buttonMostraGrafici
            // 
            this.buttonMostraGrafici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostraGrafici.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonMostraGrafici.Location = new System.Drawing.Point(554, 584);
            this.buttonMostraGrafici.Name = "buttonMostraGrafici";
            this.buttonMostraGrafici.Size = new System.Drawing.Size(107, 59);
            this.buttonMostraGrafici.TabIndex = 25;
            this.buttonMostraGrafici.Text = "grafici";
            this.buttonMostraGrafici.UseVisualStyleBackColor = true;
            this.buttonMostraGrafici.Click += new System.EventHandler(this.buttonMostraGrafici_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::open_data.Properties.Resources.Immagine_2024_10_29_164639;
            this.ClientSize = new System.Drawing.Size(1628, 850);
            this.Controls.Add(this.buttonMostraGrafici);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.profondità);
            this.Controls.Add(this.chartProfondita);
            this.Controls.Add(this.chartMagnitudo);
            this.Controls.Add(this.buttonMagnitudoFilter);
            this.Controls.Add(this.textBoxMagnitudo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonZonaFilter);
            this.Controls.Add(this.textBoxZona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostraFiltri_Click);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.textBoxDepth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Click);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMagnitudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfondita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepth;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button data_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostraFiltri_Click;
        private System.Windows.Forms.Button buttonZonaFilter;
        private System.Windows.Forms.TextBox textBoxZona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMagnitudoFilter;
        private System.Windows.Forms.TextBox textBoxMagnitudo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMagnitudo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfondita;
        private System.Windows.Forms.Label profondità;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonMostraGrafici;
    }
}

