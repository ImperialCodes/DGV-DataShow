namespace Ronny_Beispielaufgabe
{
    partial class ShowData
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.dgvMainData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hier werden Daten in einem Gridview dargestellt per Button";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(504, 22);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(119, 23);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Daten anzeigen";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // dgvMainData
            // 
            this.dgvMainData.AllowUserToAddRows = false;
            this.dgvMainData.AllowUserToDeleteRows = false;
            this.dgvMainData.AllowUserToOrderColumns = true;
            this.dgvMainData.AllowUserToResizeColumns = false;
            this.dgvMainData.AllowUserToResizeRows = false;
            this.dgvMainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainData.Location = new System.Drawing.Point(12, 61);
            this.dgvMainData.Name = "dgvMainData";
            this.dgvMainData.Size = new System.Drawing.Size(776, 377);
            this.dgvMainData.TabIndex = 2;
            this.dgvMainData.Visible = false;
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMainData);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.label1);
            this.Name = "ShowData";
            this.Text = "ShowData";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView dgvMainData;
    }
}

