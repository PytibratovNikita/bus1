namespace bus1
{
    partial class Form2Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.маршрутыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bUSDataSet = new bus1.BUSDataSet();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.маршрутыTableAdapter = new bus1.BUSDataSetTableAdapters.МаршрутыTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bUSDataSet1 = new bus1.BUSDataSet1();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new bus1.BUSDataSet1TableAdapters.RouteTableAdapter();
            this.routesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bUSDataSet3 = new bus1.BUSDataSet3();
            this.bUSDataSet2 = new bus1.BUSDataSet2();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter = new bus1.BUSDataSet2TableAdapters.RoutesTableAdapter();
            this.fareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.travelTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.routesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.routesTableAdapter1 = new bus1.BUSDataSet3TableAdapters.RoutesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктназначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расстояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявпутиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьпроездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fareNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelTimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // маршрутыBindingSource1
            // 
            this.маршрутыBindingSource1.DataMember = "Маршруты";
            this.маршрутыBindingSource1.DataSource = this.bUSDataSet;
            // 
            // bUSDataSet
            // 
            this.bUSDataSet.DataSetName = "BUSDataSet";
            this.bUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.bUSDataSet;
            this.маршрутыBindingSource.CurrentChanged += new System.EventHandler(this.маршрутыBindingSource_CurrentChanged);
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bUSDataSet1
            // 
            this.bUSDataSet1.DataSetName = "BUSDataSet1";
            this.bUSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.bUSDataSet1;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // routesBindingSource2
            // 
            this.routesBindingSource2.DataMember = "Routes";
            this.routesBindingSource2.DataSource = this.bUSDataSet3;
            // 
            // bUSDataSet3
            // 
            this.bUSDataSet3.DataSetName = "BUSDataSet3";
            this.bUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUSDataSet2
            // 
            this.bUSDataSet2.DataSetName = "BUSDataSet2";
            this.bUSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "Routes";
            this.routesBindingSource.DataSource = this.bUSDataSet2;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // fareNumericUpDown
            // 
            this.fareNumericUpDown.Location = new System.Drawing.Point(292, 380);
            this.fareNumericUpDown.Name = "fareNumericUpDown";
            this.fareNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.fareNumericUpDown.TabIndex = 9;
            // 
            // travelTimeNumericUpDown
            // 
            this.travelTimeNumericUpDown.Location = new System.Drawing.Point(292, 354);
            this.travelTimeNumericUpDown.Name = "travelTimeNumericUpDown";
            this.travelTimeNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.travelTimeNumericUpDown.TabIndex = 10;
            this.travelTimeNumericUpDown.ValueChanged += new System.EventHandler(this.travelTimeNumericUpDown_ValueChanged);
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Location = new System.Drawing.Point(292, 325);
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.distanceNumericUpDown.TabIndex = 11;
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(292, 272);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(100, 20);
            this.departureTextBox.TabIndex = 12;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(292, 299);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Отправление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Место назначения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Расстояние";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Время в пути";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Плата за проезд";
            // 
            // routesBindingSource1
            // 
            this.routesBindingSource1.DataMember = "Routes";
            this.routesBindingSource1.DataSource = this.bUSDataSet2;
            // 
            // routesTableAdapter1
            // 
            this.routesTableAdapter1.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.routesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // routesBindingSource3
            // 
            this.routesBindingSource3.DataMember = "Routes";
            this.routesBindingSource3.DataSource = this.bUSDataSet3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пунктотправленияDataGridViewTextBoxColumn
            // 
            this.пунктотправленияDataGridViewTextBoxColumn.DataPropertyName = "пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.HeaderText = "пункт_отправления";
            this.пунктотправленияDataGridViewTextBoxColumn.Name = "пунктотправленияDataGridViewTextBoxColumn";
            // 
            // пунктназначенияDataGridViewTextBoxColumn
            // 
            this.пунктназначенияDataGridViewTextBoxColumn.DataPropertyName = "пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.HeaderText = "пункт_назначения";
            this.пунктназначенияDataGridViewTextBoxColumn.Name = "пунктназначенияDataGridViewTextBoxColumn";
            // 
            // расстояниеDataGridViewTextBoxColumn
            // 
            this.расстояниеDataGridViewTextBoxColumn.DataPropertyName = "расстояние";
            this.расстояниеDataGridViewTextBoxColumn.HeaderText = "расстояние";
            this.расстояниеDataGridViewTextBoxColumn.Name = "расстояниеDataGridViewTextBoxColumn";
            // 
            // времявпутиDataGridViewTextBoxColumn
            // 
            this.времявпутиDataGridViewTextBoxColumn.DataPropertyName = "время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.HeaderText = "время_в_пути";
            this.времявпутиDataGridViewTextBoxColumn.Name = "времявпутиDataGridViewTextBoxColumn";
            // 
            // стоимостьпроездаDataGridViewTextBoxColumn
            // 
            this.стоимостьпроездаDataGridViewTextBoxColumn.DataPropertyName = "стоимость_проезда";
            this.стоимостьпроездаDataGridViewTextBoxColumn.HeaderText = "стоимость_проезда";
            this.стоимостьпроездаDataGridViewTextBoxColumn.Name = "стоимостьпроездаDataGridViewTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Маршруты";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Авторизация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(this.distanceNumericUpDown);
            this.Controls.Add(this.travelTimeNumericUpDown);
            this.Controls.Add(this.fareNumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2Admin";
            this.Text = "Form2Admin";
            this.Load += new System.EventHandler(this.Form2Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fareNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelTimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BUSDataSet bUSDataSet;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private BUSDataSetTableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource маршрутыBindingSource1;
        private BUSDataSet1 bUSDataSet1;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private BUSDataSet1TableAdapters.RouteTableAdapter routeTableAdapter;
        private BUSDataSet2 bUSDataSet2;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private BUSDataSet2TableAdapters.RoutesTableAdapter routesTableAdapter;
        private System.Windows.Forms.NumericUpDown fareNumericUpDown;
        private System.Windows.Forms.NumericUpDown travelTimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource routesBindingSource1;
        private BUSDataSet3 bUSDataSet3;
        private System.Windows.Forms.BindingSource routesBindingSource2;
        private BUSDataSet3TableAdapters.RoutesTableAdapter routesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктназначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расстояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявпутиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьпроездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource routesBindingSource3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}