using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace open_data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inizializza i componenti
        }

        private void button_Click_Click_1(object sender, EventArgs e)
        {
            // Percorso del file CSV
            string filePath = "opendata.csv"; // Assicurati che il file si trovi nella stessa cartella dell'eseguibile
            LoadCsvToDataGridView(filePath);
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Leggi la prima riga (intestazioni)
                    string headerLine = reader.ReadLine();
                    if (headerLine == null)
                    {
                        MessageBox.Show("Il file CSV è vuoto.");
                        return;
                    }

                    string[] headers = headerLine.Split(',');

                    // Aggiungi le colonne alla tabella
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }

                    // Leggi le righe successive
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line)) // Controlla righe vuote
                        {
                            string[] rows = line.Split(',');
                            if (rows.Length == headers.Length) // Controlla righe malformate
                            {
                                dataTable.Rows.Add(rows);
                            }
                        }
                    }
                }

                // Mostra la tabella nel DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento del file: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eventuale logica per la gestione del click sulle celle
        }
    }
}

