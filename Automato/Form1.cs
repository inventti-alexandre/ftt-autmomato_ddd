using Automato.Enumerable;
using Automato.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Automato
{
    public partial class Form1 : Form
    {
        private ImportType? currentImportType = null;
        private Automata Automata;
        private List<string> Words = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportAutomata_Click(object sender, EventArgs e)
        {
            currentImportType = ImportType.automata_txt;
            ConfigureFileImportDialog("txt files (*.txt)|*.txt");
            ImportFileDialog.ShowDialog();
        }

        private void ConfigureFileImportDialog(string filter)
        {
            ImportFileDialog.Filter = filter;
            ImportFileDialog.RestoreDirectory = true;
        }

        private void ImportFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            List<string> data = new List<string>();

            try
            {
                OpenFileDialog fileDialog = (OpenFileDialog)sender;
                data = File.ReadLines(fileDialog.FileName).ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            switch (currentImportType)
            {
                case ImportType.automata_txt:
                    ImportAutomata(data);
                    break;
                case ImportType.words_in:
                    ImportWords(data);
                    break;
                default:
                    MessageBox.Show("Tipo de importação inválida!");
                    break;
            }

            Words = File.ReadLines("words.in").ToList();
            foreach (var word in Words)
            {
                MessageBox.Show(String.Format("Palavra: {0} - {1}", word, Automata.Accepts(word)));
            }
        }

        private void ImportAutomata(IEnumerable<string> automata)
        {
            try
            {
                automata.MinLength(1, "O Arquivo com os automatos está vazio ou fora do formato esperado.");

                Automata = new Automata(
                    automata.ElementAt(1).Split(','),
                    automata.ElementAt(2).Split(','),
                    automata.ElementAt(3),
                    automata.ElementAt(4).Split(',')
                );

                List<string> transitions = automata.Skip(5).ToList();
                foreach (var transition in transitions)
                {
                    if (transition.Contains("####"))
                        break;
                    else
                        Automata.AddTransition(transition.Split(','));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ImportWords(IEnumerable<string> words)
        {

        }
    }
}