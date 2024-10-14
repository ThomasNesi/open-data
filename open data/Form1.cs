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
            string filePath = "opendata.csv";
            LoadCsvToDataGridView(filePath);
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            // Crea una tabella per i dati
            DataTable dataTable = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Leggi la prima riga (intestazioni)
                string[] headers = reader.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header); // Aggiungi le colonne alla tabella
                }
                while (!reader.EndOfStream)
                {
                    // Leggi le righe successive (dati)
                    string[] rows = reader.ReadLine().Split(',');
                    dataTable.Rows.Add(rows); // Aggiungi le righe alla tabella
                }
            }
            dataGridView1.DataSource = dataTable; // Mostra la tabella nel DataGridView
        }
    }
}

