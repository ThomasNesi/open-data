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
            label4.Visible = false;
            label1.Visible = false;
            dateTimePicker1.Visible = false;
            textBoxDepth.Visible = false;
            data_btn.Visible = false;
            buttonFilter.Visible = false;
            label3.Visible = false;
            buttonZonaFilter.Visible = false;
            textBoxZona.Visible = false;
            label5.Visible = false;
            textBoxMagnitudo.Visible = false;
            buttonMagnitudoFilter.Visible = false;
            dataGridView1.Visible = false;
            buttonMostraGrafici.Visible = false;
            graficoprofondità_btn.Visible = false;
            label8.Visible = false;
            profondità.Visible = false;
            chartMagnitudo.Visible = false;
            chartProfondita.Visible = false;
        }

        private void btnMostraFiltri_Click_Click(object sender, EventArgs e)
        {
            // Se il pannello dei filtri è visibile, lo nasconde, altrimenti lo mostra
            label4.Visible = !label4.Visible;
            label1.Visible = !label1.Visible;
            dateTimePicker1.Visible = !dateTimePicker1.Visible;
            textBoxDepth.Visible = !textBoxDepth.Visible;   
            data_btn.Visible = !data_btn.Visible;
            buttonFilter.Visible = !buttonFilter.Visible;
            label3.Visible = !label3.Visible;
            buttonZonaFilter.Visible= !buttonZonaFilter.Visible;
            textBoxZona.Visible= !textBoxZona.Visible;
            label5.Visible= !label5.Visible;
            textBoxMagnitudo.Visible= !textBoxMagnitudo.Visible;
            buttonMagnitudoFilter.Visible= !buttonMagnitudoFilter.Visible;
            buttonMostraGrafici.Visible = !buttonMostraGrafici.Visible;
            graficoprofondità_btn.Visible = !graficoprofondità_btn.Visible;


            // Cambia il testo del pulsante in base allo stato di visibilità del pannello
            if (label4.Visible)
            {
                btnMostraFiltri_Click.Text = "Nascondi Filtri";
            }
            else
            {
                btnMostraFiltri_Click.Text = "Mostra Filtri";
            }
        }

        private void button_Click_Click_1(object sender, EventArgs e)
        {
            string filePath = "opendata1.csv";
            dataGridView1.Visible = true;

            // Controllo se il file esiste
            if (!File.Exists(filePath))
            {
                MessageBox.Show($"Il file {filePath} non esiste.");
                return;
            }

            CaricaFile(filePath); // Carica il file CSV
            chartMagnitudo.Visible = false;
            chartProfondita.Visible = false; 
            label8.Visible = false;
            profondità.Visible = false;
        }

        private void CaricaFile(string filePath)
        {
            dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string primalinea = reader.ReadLine();
                    if (primalinea == null)
                    {
                        MessageBox.Show("Il file è vuoto.");
                        return;
                    }

                    string[] headers = primalinea.Split(',');

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }

                    int contarighe = 0;

                    while (!reader.EndOfStream)
                    {
                        string linea = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] righe = linea.Split(',');

                            if (righe.Length == headers.Length)
                            {
                                dataTable.Rows.Add(righe);
                                contarighe++;
                            }
                        }
                    }

                    MessageBox.Show($"Terremoti trovati: {contarighe}");

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
                MessageBox.Show($"Trovati {contafiltro} terremoti con questa profondità.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con questa profondità.");
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
                MessageBox.Show($"Trovati {contafiltro} terremoti in questa data.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato in questa data.");
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
                MessageBox.Show("Inserisci un valore valido per la profondità.");
            }
            textBoxDepth.Clear();
        }

        private void data_btn_Click(object sender, EventArgs e)
        {
            DateTime selezionadata = dateTimePicker1.Value;
            FiltroData(selezionadata);
        }

        private void FiltroZona(string parolaChiave)
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
                string zona = riga[2].ToString().Trim(); // Assumendo che la zona sia nella terza colonna

                if (zona.IndexOf(parolaChiave, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    nuovoFiltro.ImportRow(riga);
                    contafiltro++;
                }
            }

            if (contafiltro > 0)
            {
                filteredTable = nuovoFiltro;
                dataGridView1.DataSource = filteredTable;
                MessageBox.Show($"Trovati {contafiltro} terremoti.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato per questa zona.");
            }
        }

        private void buttonZonaFilter_Click_1(object sender, EventArgs e)
        {
            string parolaChiave = textBoxZona.Text.Trim();

            if (!string.IsNullOrEmpty(parolaChiave))
            {
                FiltroZona(parolaChiave);
            }
            else
            {
                MessageBox.Show("Inserisci una parola per la zona.");
            }
            textBoxZona.Clear();
        }

        // Funzione di filtro magnitudo
        private void FiltroMagnitudo(double magnitudoTarget)
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
                string magnitudoString = riga[1].ToString().Trim(); // Magnitudo nella seconda colonna

                string numeroStringa = new string(magnitudoString.Where(char.IsDigit).ToArray());

                if (double.TryParse(numeroStringa, out double magnitudoRiga))
                {
                    if (magnitudoRiga == magnitudoTarget)
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
                MessageBox.Show($"Trovati {contafiltro} terremoti con questo magnitudo.");
            }
            else
            {
                MessageBox.Show("Nessun terremoto trovato con questo magnitudo.");
            }
        }

        // Gestore per il pulsante di filtro
        private void buttonMagnitudoFilter_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxMagnitudo.Text, out double magnitudo))
            {
                FiltroMagnitudo(magnitudo);
            }
            else
            {
                MessageBox.Show("Inserisci un valore valido per la magnitudo.");
            }
            textBoxMagnitudo.Clear();
        }

        // Funzione per visualizzare i grafici
        private void MostraGraficoMagnitudo()
        {
            if (filteredTable == null || filteredTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile per visualizzare i grafici.");
                return;
            }

            chartMagnitudo.Series.Clear();

            Series serieMagnitudo = new Series("Magnitudo")
            {
                ChartType = SeriesChartType.Column
            };

            int indice = 1;

            foreach (DataRow riga in filteredTable.Rows)
            {
                string magnitudoString = riga[1].ToString().Trim();
                string magnitudoNumerico = new string(magnitudoString.Where(char.IsDigit).ToArray());

                if (double.TryParse(magnitudoNumerico, out double magnitudo))
                {
                    serieMagnitudo.Points.AddXY(indice, magnitudo);
                }

                indice++;
            }

            chartMagnitudo.Series.Add(serieMagnitudo);

            chartMagnitudo.ChartAreas[0].AxisX.Title = "Indice Terremoto";
            chartMagnitudo.ChartAreas[0].AxisY.Title = "Magnitudo";

            chartMagnitudo.Visible = false;
        }

        private void MostraGraficoProfondità()
        {
            if (filteredTable == null || filteredTable.Rows.Count == 0)
            {
                MessageBox.Show("Nessun dato disponibile per visualizzare i grafici.");
                return;
            }

            chartProfondita.Series.Clear();

            Series serieProfondita = new Series("Profondità")
            {
                ChartType = SeriesChartType.Column
            };

            int indice = 1;

            foreach (DataRow riga in filteredTable.Rows)
            {
                if (double.TryParse(riga[3].ToString().Trim(), out double profondita))
                {
                    serieProfondita.Points.AddXY(indice, profondita);
                }

                indice++;
            }
            chartProfondita.Series.Add(serieProfondita);

            chartProfondita.ChartAreas[0].AxisX.Title = "Indice Terremoto";
            chartProfondita.ChartAreas[0].AxisY.Title = "Profondità (km)";

            chartProfondita.Visible = false;
        }

        // Gestore per il pulsante per visualizzare i grafici
        private void buttonMostraGrafici_Click_1(object sender, EventArgs e)
        {
            MostraGraficoMagnitudo();
            chartMagnitudo.Visible = true;
            label8.Visible = true;
        }

        private void graficoprofondità_btn_Click(object sender, EventArgs e)
        {
            MostraGraficoProfondità();
            chartProfondita.Visible = true;
            profondità.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

