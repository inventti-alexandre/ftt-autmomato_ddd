namespace Automato.WindowsFormsApp
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
            this.btAutomataImport = new System.Windows.Forms.Button();
            this.btWordsImport = new System.Windows.Forms.Button();
            this.btExecuteAutomata = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "ImportFileDialog";
            this.ImportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportFileDialog_FileOk);
            // 
            // btAutomataImport
            // 
            this.btAutomataImport.Location = new System.Drawing.Point(12, 115);
            this.btAutomataImport.Name = "btAutomataImport";
            this.btAutomataImport.Size = new System.Drawing.Size(260, 42);
            this.btAutomataImport.TabIndex = 0;
            this.btAutomataImport.Text = "Selecione o Automato";
            this.btAutomataImport.UseVisualStyleBackColor = true;
            this.btAutomataImport.Click += new System.EventHandler(this.btAutomataImport_Click);
            // 
            // btWordsImport
            // 
            this.btWordsImport.Location = new System.Drawing.Point(12, 162);
            this.btWordsImport.Name = "btWordsImport";
            this.btWordsImport.Size = new System.Drawing.Size(260, 42);
            this.btWordsImport.TabIndex = 1;
            this.btWordsImport.Text = "Escolha as Palavaras";
            this.btWordsImport.UseVisualStyleBackColor = true;
            this.btWordsImport.Click += new System.EventHandler(this.btWordsImport_Click);
            // 
            // btExecuteAutomata
            // 
            this.btExecuteAutomata.Location = new System.Drawing.Point(12, 207);
            this.btExecuteAutomata.Name = "btExecuteAutomata";
            this.btExecuteAutomata.Size = new System.Drawing.Size(260, 42);
            this.btExecuteAutomata.TabIndex = 2;
            this.btExecuteAutomata.Text = "Executar o Automato";
            this.btExecuteAutomata.UseVisualStyleBackColor = true;
            this.btExecuteAutomata.Click += new System.EventHandler(this.btExecuteAutomata_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "header.jpg";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 97);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btExecuteAutomata);
            this.Controls.Add(this.btWordsImport);
            this.Controls.Add(this.btAutomataImport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.Button btAutomataImport;
        private System.Windows.Forms.Button btWordsImport;
        private System.Windows.Forms.Button btExecuteAutomata;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

