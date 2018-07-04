namespace Numerator
{
    partial class Numerator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNumer = new System.Windows.Forms.Button();
            this.editNumer = new System.Windows.Forms.Button();
            this.deleteNumer = new System.Windows.Forms.Button();
            this.yearSelectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addNumer
            // 
            this.addNumer.Location = new System.Drawing.Point(43, 75);
            this.addNumer.Name = "addNumer";
            this.addNumer.Size = new System.Drawing.Size(115, 36);
            this.addNumer.TabIndex = 0;
            this.addNumer.Text = "Dodaj nowy";
            this.addNumer.UseVisualStyleBackColor = true;
            this.addNumer.Click += new System.EventHandler(this.addNumer_Click);
            // 
            // editNumer
            // 
            this.editNumer.Location = new System.Drawing.Point(164, 75);
            this.editNumer.Name = "editNumer";
            this.editNumer.Size = new System.Drawing.Size(140, 36);
            this.editNumer.TabIndex = 1;
            this.editNumer.Text = "Edytuj istniejący";
            this.editNumer.UseVisualStyleBackColor = true;
            // 
            // deleteNumer
            // 
            this.deleteNumer.Location = new System.Drawing.Point(310, 75);
            this.deleteNumer.Name = "deleteNumer";
            this.deleteNumer.Size = new System.Drawing.Size(93, 36);
            this.deleteNumer.TabIndex = 2;
            this.deleteNumer.Text = "Usuń";
            this.deleteNumer.UseVisualStyleBackColor = true;
            // 
            // yearSelectComboBox
            // 
            this.yearSelectComboBox.FormattingEnabled = true;
            this.yearSelectComboBox.Location = new System.Drawing.Point(557, 80);
            this.yearSelectComboBox.Name = "yearSelectComboBox";
            this.yearSelectComboBox.Size = new System.Drawing.Size(201, 28);
            this.yearSelectComboBox.TabIndex = 3;
            this.yearSelectComboBox.Text = "Brak danych";
            this.yearSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.yearSelectComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rok:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(13, 117);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(745, 499);
            this.dataGrid.TabIndex = 5;
            // 
            // Numerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 628);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearSelectComboBox);
            this.Controls.Add(this.deleteNumer);
            this.Controls.Add(this.editNumer);
            this.Controls.Add(this.addNumer);
            this.Name = "Numerator";
            this.Text = "Numerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNumer;
        private System.Windows.Forms.Button editNumer;
        private System.Windows.Forms.Button deleteNumer;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox yearSelectComboBox;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

