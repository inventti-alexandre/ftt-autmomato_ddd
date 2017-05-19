using Automato.App.Entities;
using Automato.App.Enumerators;
using Automato.App.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Automato.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly AutomataRepository AutomataRepository;
        private Automata Automata;
        private ImportType CurrentTypeImport;

        public Form1(AutomataRepository automataRepository)
        {
            AutomataRepository = automataRepository;
            InitializeComponent();
        }

        private void btAutomataImport_Click(object sender, EventArgs e)
        {
            CurrentTypeImport = ImportType.automata_txt;
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
            switch (CurrentTypeImport)
            {
                case ImportType.automata_txt:
                    ImportAutomata(ImportFileDialog.FileName);
                    break;
                case ImportType.words_in:
                    break;
                default:
                    break;
            }
            try
            {
                Automata = AutomataRepository.GetAutomataFromFile(ImportFileDialog.FileName);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ImportAutomata(string file)
    }
}