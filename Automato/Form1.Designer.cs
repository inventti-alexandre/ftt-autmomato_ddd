namespace Automato
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnImportAutomata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "ImportFileDialog";
            this.ImportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportFileDialog_FileOk);
            // 
            // btnImportAutomata
            // 
            this.btnImportAutomata.Location = new System.Drawing.Point(34, 111);
            this.btnImportAutomata.Name = "btnImportAutomata";
            this.btnImportAutomata.Size = new System.Drawing.Size(212, 39);
            this.btnImportAutomata.TabIndex = 0;
            this.btnImportAutomata.Text = "Importar o automato";
            this.btnImportAutomata.UseVisualStyleBackColor = true;
            this.btnImportAutomata.Click += new System.EventHandler(this.btnImportAutomata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnImportAutomata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.Button btnImportAutomata;
    }
}

