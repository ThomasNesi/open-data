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
        private DataTable dataTable; // Variabile per memorizzare i dati caricati

        public Form1()
        {
            InitializeComponent();
        }

        // Metodo chiamato quando si clicca sul pulsante di caricamento
        private void button_Click_Click_1(object sender, EventArgs e)
        {
            string filePath = "opendata1.csv"; // Assicurati che il file si trovi nella giusta cartella

            // Controlla se il file esiste
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Il file {filePath} non esiste.");
                return;
            }

            LoadCsvToDataGridView(filePath); // Carica il file CSV
        }

        // Metodo per caricare il file CSV nel DataTable e visualizzarlo nel DataGridView
        private void LoadCsvToDataGridView(string filePath)
        {
            // Inizializza il DataTable
            dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine();
                    if (headerLine == null)
                    {
                        MessageBox.Show("Il file CSV è vuoto.");
                        return;
                    }

                    string[] headers = headerLine.Split(',');

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }

                    // Contatore di righe per il debug
                    int rowCount = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] rows = line.Split(',');

                            if (rows.Length == headers.Length)
                            {
                                dataTable.Rows.Add(rows);
                                rowCount++; // Incrementa il contatore di righe
                            }
                        }
                    }

                    // Debug: Visualizza quante righe sono state caricate
                    MessageBox.Show($"Righe caricate: {rowCount}");
                }

                // Mostra i dati caricati nel DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento del file: " + ex.Message);
            }
        }

        // Metodo per filtrare i dati in base alla profondità inserita
        private void FilterByDepth(decimal depth)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            // Crea un nuovo DataTable per memorizzare i risultati filtrati
            DataTable filteredTable = dataTable.Clone(); // Clona la struttura del DataTable originale

            int filteredCount = 0; // Contatore di righe filtrate

            // Scorri manualmente ogni riga del DataTable originale
            foreach (DataRow row in dataTable.Rows)
            {
                string depthString = row[3].ToString().Trim(); // Assumi che la profondità sia nella quarta colonna (indice 3)
                if (decimal.TryParse(depthString, out decimal rowDepth))
                {
                    if (rowDepth == depth)
                    {
                        filteredTable.ImportRow(row);
                        filteredCount++; // Incrementa il contatore se la riga viene filtrata
                    }
                }
            }

            // Se sono state trovate righe corrispondenti, le mostriamo nel DataGridView
            if (filteredCount > 0)
            {
                dataGridView1.DataSource = filteredTable;
                MessageBox.Show($"Trovati {filteredCount} terremoti con la profondità specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con la profondità specificata.");
            }
        }

        // Metodo chiamato quando si clicca sul pulsante di filtro
       
        private void buttonFilter_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxDepth.Text, out decimal depth))
            {
                FilterByDepth(depth); // Applica il filtro per la profondità
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per la profondità.");
            }
        }
    }
}

