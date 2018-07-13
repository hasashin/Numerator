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
            this.deleteNumer = new System.Windows.Forms.Button();
            this.yearSelectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.endButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNumer
            // 
            this.addNumer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNumer.Location = new System.Drawing.Point(3, 7);
            this.addNumer.Name = "addNumer";
            this.addNumer.Size = new System.Drawing.Size(115, 36);
            this.addNumer.TabIndex = 0;
            this.addNumer.Text = "Dodaj nowy";
            this.addNumer.UseVisualStyleBackColor = true;
            this.addNumer.Click += new System.EventHandler(this.addNumer_Click);
            // 
            // deleteNumer
            // 
            this.deleteNumer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteNumer.Location = new System.Drawing.Point(124, 7);
            this.deleteNumer.Name = "deleteNumer";
            this.deleteNumer.Size = new System.Drawing.Size(93, 36);
            this.deleteNumer.TabIndex = 2;
            this.deleteNumer.Text = "Usuń";
            this.deleteNumer.UseVisualStyleBackColor = true;
            this.deleteNumer.Click += new System.EventHandler(this.deleteNumer_Click);
            // 
            // yearSelectComboBox
            // 
            this.yearSelectComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.yearSelectComboBox.Location = new System.Drawing.Point(271, 11);
            this.yearSelectComboBox.Name = "yearSelectComboBox";
            this.yearSelectComboBox.Size = new System.Drawing.Size(269, 28);
            this.yearSelectComboBox.Sorted = true;
            this.yearSelectComboBox.TabIndex = 3;
            this.yearSelectComboBox.Text = "Brak danych";
            this.yearSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.yearSelectComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rok:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 60);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.Size = new System.Drawing.Size(764, 565);
            this.dataGrid.TabIndex = 5;
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.076433F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.92357F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 628);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.addNumer, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteNumer, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.yearSelectComboBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.endButton, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // endButton
            // 
            this.endButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endButton.Location = new System.Drawing.Point(638, 7);
            this.endButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(106, 36);
            this.endButton.TabIndex = 5;
            this.endButton.Text = "Zakończ";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Numerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(770, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(792, 684);
            this.Name = "Numerator";
            this.Text = "Numerator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNumer;
        private System.Windows.Forms.Button deleteNumer;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox yearSelectComboBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button endButton;
    }
}

