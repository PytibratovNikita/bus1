namespace bus1
{
    partial class Prom
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bUSDataSet3 = new bus1.BUSDataSet3();
            this.intermediatepointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intermediate_pointsTableAdapter = new bus1.BUSDataSet3TableAdapters.Intermediate_pointsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idмаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепунктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниеотпунктаотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnButton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediatepointsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Промежуточные точки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idмаршрутаDataGridViewTextBoxColumn,
            this.названиепунктаDataGridViewTextBoxColumn,
            this.расстояниеотпунктаотправленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.intermediatepointsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // bUSDataSet3
            // 
            this.bUSDataSet3.DataSetName = "BUSDataSet3";
            this.bUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // intermediatepointsBindingSource
            // 
            this.intermediatepointsBindingSource.DataMember = "Intermediate_points";
            this.intermediatepointsBindingSource.DataSource = this.bUSDataSet3;
            // 
            // intermediate_pointsTableAdapter
            // 
            this.intermediate_pointsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idмаршрутаDataGridViewTextBoxColumn
            // 
            this.idмаршрутаDataGridViewTextBoxColumn.DataPropertyName = "id_маршрута";
            this.idмаршрутаDataGridViewTextBoxColumn.HeaderText = "id_маршрута";
            this.idмаршрутаDataGridViewTextBoxColumn.Name = "idмаршрутаDataGridViewTextBoxColumn";
            // 
            // названиепунктаDataGridViewTextBoxColumn
            // 
            this.названиепунктаDataGridViewTextBoxColumn.DataPropertyName = "название_пункта";
            this.названиепунктаDataGridViewTextBoxColumn.HeaderText = "название_пункта";
            this.названиепунктаDataGridViewTextBoxColumn.Name = "названиепунктаDataGridViewTextBoxColumn";
            // 
            // расстояниеотпунктаотправленияDataGridViewTextBoxColumn
            // 
            this.расстояниеотпунктаотправленияDataGridViewTextBoxColumn.DataPropertyName = "расстояние_от_пункта_отправления";
            this.расстояниеотпунктаотправленияDataGridViewTextBoxColumn.HeaderText = "расстояние_от_пункта_отправления";
            this.расстояниеотпунктаотправленияDataGridViewTextBoxColumn.Name = "расстояниеотпунктаотправленияDataGridViewTextBoxColumn";
            // 
            // returnButton3
            // 
            this.returnButton3.Location = new System.Drawing.Point(16, 415);
            this.returnButton3.Name = "returnButton3";
            this.returnButton3.Size = new System.Drawing.Size(75, 23);
            this.returnButton3.TabIndex = 7;
            this.returnButton3.Text = "Вернуться";
            this.returnButton3.UseVisualStyleBackColor = true;
            this.returnButton3.Click += new System.EventHandler(this.returnButton3_Click);
            // 
            // Prom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Prom";
            this.Text = "Prom";
            this.Load += new System.EventHandler(this.Prom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediatepointsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BUSDataSet3 bUSDataSet3;
        private System.Windows.Forms.BindingSource intermediatepointsBindingSource;
        private BUSDataSet3TableAdapters.Intermediate_pointsTableAdapter intermediate_pointsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idмаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепунктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниеотпунктаотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button returnButton3;
    }
}