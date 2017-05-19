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
            this.SuspendLayout();
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.FileName = "ImportFileDialog";
            this.ImportFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportFileDialog_FileOk);
            // 
            // btAutomataImport
            // 
            this.btAutomataImport.Location = new System.Drawing.Point(12, 64);
            this.btAutomataImport.Name = "btAutomataImport";
            this.btAutomataImport.Size = new System.Drawing.Size(260, 39);
            this.btAutomataImport.TabIndex = 0;
            this.btAutomataImport.Text = "Selecione o Automato";
            this.btAutomataImport.UseVisualStyleBackColor = true;
            this.btAutomataImport.Click += new System.EventHandler(this.btAutomataImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btAutomataImport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImportFileDialog;
        private System.Windows.Forms.Button btAutomataImport;
    }
}

