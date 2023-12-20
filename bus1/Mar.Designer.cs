namespace bus1
{
    partial class Mar
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
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bUSDataSet3 = new bus1.BUSDataSet3();
            this.routesTableAdapter = new bus1.BUSDataSet3TableAdapters.RoutesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.стоимостьпроездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявпутиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктназначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.returnButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.bUSDataSet3;
            // 
            // bUSDataSet3
            // 
            this.bUSDataSet3.DataSetName = "BUSDataSet3";
            this.bUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Маршруты";
            // 
            // стоимостьпроездаDataGridViewTextBoxColumn
            // 
            this.стоимостьпроездаDataGridViewTextBoxColumn.DataPropertyName = "стоимость_проезда";
            this.стоимостьпроездаDataGridViewTextBoxColumn.HeaderText = "стоимость_проезда";
            this.стоимостьпроездаDataGridViewTextBoxColumn.Name = "стоимостьпроездаDataGridViewTextBoxColumn";
            // 
            // времявпутиDataGridViewTextBoxColumn
            // 
            this.времявпутиDataGridViewTextBoxColumn.DataPropertyName = "время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.HeaderText = "время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.Name = "времявпутиDataGridViewTextBoxColumn";
            // 
            // расстояниеDataGridViewTextBoxColumn
            // 
            this.расстояниеDataGridViewTextBoxColumn.DataPropertyName = "расстояние";
            this.расстояниеDataGridViewTextBoxColumn.HeaderText = "расстояние";
            this.расстояниеDataGridViewTextBoxColumn.Name = "расстояниеDataGridViewTextBoxColumn";
            // 
            // пунктназначенияDataGridViewTextBoxColumn
            // 
            this.пунктназначенияDataGridViewTextBoxColumn.DataPropertyName = "пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.HeaderText = "пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.Name = "пунктназначенияDataGridViewTextBoxColumn";
            // 
            // пунктотправленияDataGridViewTextBoxColumn
            // 
            this.пунктотправленияDataGridViewTextBoxColumn.DataPropertyName = "пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.HeaderText = "пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.Name = "пунктотправленияDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.пунктотправленияDataGridViewTextBoxColumn,
            this.пунктназначенияDataGridViewTextBoxColumn,
            this.расстояниеDataGridViewTextBoxColumn,
            this.времявпутиDataGridViewTextBoxColumn,
            this.стоимостьпроездаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // returnButton2
            // 
            this.returnButton2.Location = new System.Drawing.Point(16, 415);
            this.returnButton2.Name = "returnButton2";
            this.returnButton2.Size = new System.Drawing.Size(75, 23);
            this.returnButton2.TabIndex = 5;
            this.returnButton2.Text = "Вернуться";
            this.returnButton2.UseVisualStyleBackColor = true;
            this.returnButton2.Click += new System.EventHandler(this.returnButton2_Click);
            // 
            // Mar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mar";
            this.Text = "Mar";
            this.Load += new System.EventHandler(this.Mar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BUSDataSet3 bUSDataSet3;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private BUSDataSet3TableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьпроездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявпутиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктназначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button returnButton2;
    }
}