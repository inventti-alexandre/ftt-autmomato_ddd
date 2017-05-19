using Automato.App.Domain.Entities;
using Automato.App.Domain.Services;
using Automato.App.Enumerators;
using Automato.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Automato.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly AutomataService AutomataService;
        private readonly WordService WordService;
        private readonly ResultService ResultService;
        private Automata Automata = new Automata();
        private List<string> Words = new List<string>();
        private ImportType CurrentTypeImport;
        private string outFileName;

        public Form1(
            AutomataService automataService,
            WordService wordService,
            ResultService resultService)
        {
            AutomataService = automataService;
            WordService = wordService;
            ResultService = resultService;
            InitializeComponent();
            RefreshViewState();
        }

        private void btAutomataImport_Click(object sender, EventArgs e)
        {
            CurrentTypeImport = ImportType.automata_txt;
            ConfigureFileImportDialog("txt files (*.txt)|*.txt");
            ImportFileDialog.ShowDialog();
        }

        private void btWordsImport_Click(object sender, EventArgs e)
        {
            CurrentTypeImport = ImportType.words_in;
            ConfigureFileImportDialog("in files (*.in)|*.in");
            ImportFileDialog.ShowDialog();
        }

        private void btExecuteAutomata_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            foreach (var word in Words)
                result.AddLine(String.Format("{0} - {1}", word, Automata.Accepts(word)));
            try
            {
                ResultService.ExportToFile(result, outFileName);
                MessageBox.Show(string.Format("Arquivo salvo com sucesso: {0}", outFileName));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }            
        }

        private void ConfigureFileImportDialog(string filter)
        {
            ImportFileDialog.Filter = filter;
            ImportFileDialog.RestoreDirectory = true;
        }

        private void ImportFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                switch (CurrentTypeImport)
                {
                    case ImportType.automata_txt:
                        Automata = AutomataService.GetFromFile(ImportFileDialog.FileName);
                        break;
                    case ImportType.words_in:
                        Words = WordService.GetFromFile(ImportFileDialog.FileName);
                        outFileName = GetOutFileName(ImportFileDialog.FileName);                      
                        break;
                    default:
                        throw new NotSupportedException("ImportAction não deifnida.");
                }

                MessageBox.Show(string.Format("Arquivo importado com sucesso!"));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
            RefreshViewState();
        }

        private string GetOutFileName(string inFileName)
        {
            var filePath =  Path.GetDirectoryName(inFileName);
            var fileName = Path.GetFileNameWithoutExtension(inFileName);
            var fileExtension = "out";
            return String.Format("{0}\\{1}.{2}", filePath, fileName, fileExtension);
        }

        private void RefreshViewState()
        {
            btAutomataImport.Enabled = true;
            btWordsImport.Enabled = !Automata.IsEmpty();
            btExecuteAutomata.Enabled = !Automata.IsEmpty() && !(Words.Count == 0);
        }
    }
}