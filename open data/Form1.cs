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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace open_data
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;     // Contiene tutti i dati originali
        private DataTable filteredTable; // Contiene i dati filtrati 

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click_Click_1(object sender, EventArgs e)
        {
            string filePath = "opendata1.csv";

            // Controllo se il file esiste
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Il file {filePath} non esiste.");
                return;
            }

            CaricaFile(filePath); // Carica il file CSV
        }

        private void CaricaFile(string filePath)
        {
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

                    int contarighe = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] righe = line.Split(',');

                            if (righe.Length == headers.Length)
                            {
                                dataTable.Rows.Add(righe);
                                contarighe++;
                            }
                        }
                    }

                    MessageBox.Show($"Righe caricate: {contarighe}");

                    // Inizializza filteredTable con tutti i dati
                    filteredTable = dataTable.Copy();
                    dataGridView1.DataSource = filteredTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il caricamento del file: " + ex.Message);
            }
        }


        private void FiltroProfondità(int profondità)
        {
            if (filteredTable == null || filteredTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            DataTable nuovoFiltro = filteredTable.Clone();
            int contafiltro = 0;

            foreach (DataRow righe in filteredTable.Rows)
            {
                string depthString = righe[3].ToString().Trim(); // Assumi che la profondità sia nella quarta colonna 
                if (int.TryParse(depthString, out int profonditàriga))
                {
                    if (profonditàriga == profondità)
                    {
                        nuovoFiltro.ImportRow(righe);
                        contafiltro++;
                    }
                }
            }

            if (contafiltro > 0)
            {
                filteredTable = nuovoFiltro;
                dataGridView1.DataSource = filteredTable;
                MessageBox.Show($"Trovati {contafiltro} terremoti con la profondità specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con la profondità specificata.");
            }
        }

        private void FiltroData(DateTime data)
        {
            if (filteredTable == null || filteredTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            DataTable nuovoFiltro = filteredTable.Clone();
            int contafiltro = 0;

            foreach (DataRow riga in filteredTable.Rows)
            {
                if (DateTime.TryParse(riga[0].ToString().Trim(), out DateTime dataRiga)) // Assumi che la data sia nella prima colonna
                {
                    if (dataRiga.Date == data.Date)
                    {
                        nuovoFiltro.ImportRow(riga);
                        contafiltro++;
                    }
                }
            }

            if (contafiltro > 0)
            {
                filteredTable = nuovoFiltro;
                dataGridView1.DataSource = filteredTable;
                MessageBox.Show($"Trovati {contafiltro} terremoti per la data specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato per la data specificata.");
            }
        }

        private void buttonFilter_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDepth.Text, out int profondità))
            {
                FiltroProfondità(profondità);
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per la profondità.");
            }
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            DateTime selezionadata = dateTimePicker1.Value;
            FiltroData(selezionadata);
        }
    }
}

