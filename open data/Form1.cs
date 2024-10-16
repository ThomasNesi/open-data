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

        // Metodo per caricare il file CSV nel DataTable e visualizzarlo nel DataGridView
        private void CaricaFile(string filePath)
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

                    // Contatore di righe
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
                                contarighe++; // Incrementa il contatore di righe
                            }
                        }
                    }

                    // Visualizza quante righe sono state caricate
                    MessageBox.Show($"Righe caricate: {contarighe}");
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
        private void FiltroProfondità(int profondità)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            // Crea un nuovo DataTable per memorizzare i risultati filtrati
            DataTable tabellafiltro = dataTable.Clone(); // Clona la struttura del DataTable originale

            int contafiltro = 0; // Contatore di righe filtrate

            // Scorri ogni riga del DataTable originale
            foreach (DataRow row in dataTable.Rows)
            {
                string depthString = row[3].ToString().Trim(); // Assumi che la profondità sia nella quarta colonna 
                if (int.TryParse(depthString, out int profonditàriga))
                {
                    if (profonditàriga == profondità)
                    {
                        tabellafiltro.ImportRow(row);
                        contafiltro++; // Incrementa il contatore se la riga viene filtrata
                    }
                }
            }

            // Se sono state trovate righe corrispondenti, le mostriamo nel DataGridView
            if (contafiltro > 0)
            {
                dataGridView1.DataSource = tabellafiltro;
                MessageBox.Show($"Trovati {contafiltro} terremoti con la profondità specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con la profondità specificata.");
            }
        }

        // Metodo filtro dati in base alla data selezionata
        private void FiltroData(DateTime data)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            // Crea un nuovo DataTable per memorizzare i risultati filtrati
            DataTable tabellafiltro = dataTable.Clone(); // Clona la struttura del DataTable originale

            int contafiltro = 0; // Contatore di righe filtrate

            // Scorri ogni riga del DataTable originale
            foreach (DataRow riga in dataTable.Rows)
            {
                if (DateTime.TryParse(riga[0].ToString().Trim(), out DateTime dataRiga)) // Assumi che la data sia nella prima colonna
                {
                    if (dataRiga.Date == data.Date) // Confronta solo la parte della data
                    {
                        tabellafiltro.ImportRow(riga);
                        contafiltro++; // Incrementa il contatore se la riga viene filtrata
                    }
                }
            }

            // Se sono state trovate righe corrispondenti, le mostriamo nel DataGridView
            if (contafiltro > 0)
            {
                dataGridView1.DataSource = tabellafiltro;
                MessageBox.Show($"Trovati {contafiltro} terremoti per la data specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato per la data specificata.");
            }
        }

        // Metodo per filtrare i dati in base alla magnitudo inserita
        private void FiltroMagnitudo(double magnitudo)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile da filtrare.");
                return;
            }

            // Crea un nuovo DataTable per memorizzare i risultati filtrati
            DataTable tabellafiltro = dataTable.Clone(); // Clona la struttura del DataTable originale

            int contafiltro = 0; // Contatore di righe filtrate

            // Scorri ogni riga del DataTable originale
            foreach (DataRow row in dataTable.Rows)
            {
                string magnitudoString = row[1].ToString().Trim(); // Assumi che la magnitudo sia nella seconda colonna
                if (double.TryParse(magnitudoString, out double magnitudoRiga))
                {
                    if (magnitudoRiga == magnitudo)
                    {
                        tabellafiltro.ImportRow(row);
                        contafiltro++; // Incrementa il contatore se la riga viene filtrata
                    }
                }
            }

            // Se sono state trovate righe corrispondenti, le mostriamo nel DataGridView
            if (contafiltro > 0)
            {
                dataGridView1.DataSource = tabellafiltro;
                MessageBox.Show($"Trovati {contafiltro} terremoti con la magnitudo specificata.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con la magnitudo specificata.");
            }
        }

        private void buttonFilter_Click_1(object sender, EventArgs e)
        {
            // Filtraggio per profondità
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
            // Filtraggio per data
            DateTime selezionadata = dateTimePicker1.Value;
            FiltroData(selezionadata);
        }

        private void magnitudo_btn_Click(object sender, EventArgs e)
        {
            // Filtraggio per magnitudo
            if (double.TryParse(magnitudo_box.Text, out double magnitudo))
            {
                FiltroMagnitudo(magnitudo);
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per la magnitudo.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

