namespace trabajoPractico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRubros = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.maskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInfoRubro = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkNuevoRubro = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRubros = new System.Windows.Forms.ComboBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscaNombreProd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.guia1_labDataSet = new trabajoPractico.Guia1_labDataSet();
            this.rUBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rUBROSTableAdapter = new trabajoPractico.Guia1_labDataSetTableAdapters.RUBROSTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guia1_labDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtRubros);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(24, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta  y Baja de rubros";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtRubros
            // 
            this.txtRubros.Location = new System.Drawing.Point(20, 24);
            this.txtRubros.Name = "txtRubros";
            this.txtRubros.Size = new System.Drawing.Size(116, 20);
            this.txtRubros.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.button7);
            this.Grupo1.Controls.Add(this.maskCodigo);
            this.Grupo1.Controls.Add(this.txtStockActual);
            this.Grupo1.Controls.Add(this.label6);
            this.Grupo1.Controls.Add(this.txtInfoRubro);
            this.Grupo1.Controls.Add(this.button5);
            this.Grupo1.Controls.Add(this.checkNuevoRubro);
            this.Grupo1.Controls.Add(this.label4);
            this.Grupo1.Controls.Add(this.label3);
            this.Grupo1.Controls.Add(this.label2);
            this.Grupo1.Controls.Add(this.label1);
            this.Grupo1.Controls.Add(this.comboRubros);
            this.Grupo1.Controls.Add(this.txtprod);
            this.Grupo1.Controls.Add(this.button1);
            this.Grupo1.Location = new System.Drawing.Point(24, 28);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(394, 255);
            this.Grupo1.TabIndex = 2;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Producto";
            // 
            // maskCodigo
            // 
            this.maskCodigo.Location = new System.Drawing.Point(211, 57);
            this.maskCodigo.Mask = "0000";
            this.maskCodigo.Name = "maskCodigo";
            this.maskCodigo.Size = new System.Drawing.Size(33, 20);
            this.maskCodigo.TabIndex = 2;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(176, 170);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(68, 20);
            this.txtStockActual.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nro. Rubro";
            // 
            // txtInfoRubro
            // 
            this.txtInfoRubro.Location = new System.Drawing.Point(177, 132);
            this.txtInfoRubro.Name = "txtInfoRubro";
            this.txtInfoRubro.Size = new System.Drawing.Size(67, 20);
            this.txtInfoRubro.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 27);
            this.button5.TabIndex = 7;
            this.button5.Text = "Modificar Producto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkNuevoRubro
            // 
            this.checkNuevoRubro.AutoSize = true;
            this.checkNuevoRubro.Location = new System.Drawing.Point(282, 100);
            this.checkNuevoRubro.Name = "checkNuevoRubro";
            this.checkNuevoRubro.Size = new System.Drawing.Size(90, 17);
            this.checkNuevoRubro.TabIndex = 8;
            this.checkNuevoRubro.Text = "Nuevo Rubro";
            this.checkNuevoRubro.UseVisualStyleBackColor = true;
            this.checkNuevoRubro.Click += new System.EventHandler(this.checkNuevoRubro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rubro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // comboRubros
            // 
            this.comboRubros.FormattingEnabled = true;
            this.comboRubros.Location = new System.Drawing.Point(96, 95);
            this.comboRubros.Name = "comboRubros";
            this.comboRubros.Size = new System.Drawing.Size(148, 21);
            this.comboRubros.TabIndex = 3;
            this.comboRubros.SelectionChangeCommitted += new System.EventHandler(this.comboRubros_SelectionChangeCommitted);
            this.comboRubros.SelectedIndexChanged += new System.EventHandler(this.comboRubros_SelectedIndexChanged);
            // 
            // txtprod
            // 
            this.txtprod.Location = new System.Drawing.Point(96, 19);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(148, 20);
            this.txtprod.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cargar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(432, 33);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.Size = new System.Drawing.Size(406, 250);
            this.grillaProductos.TabIndex = 4;
            this.grillaProductos.DoubleClick += new System.EventHandler(this.grillaProductos_DoubleClick);
            // 
            // txtBuscaNombreProd
            // 
            this.txtBuscaNombreProd.Location = new System.Drawing.Point(215, 24);
            this.txtBuscaNombreProd.Name = "txtBuscaNombreProd";
            this.txtBuscaNombreProd.Size = new System.Drawing.Size(176, 20);
            this.txtBuscaNombreProd.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Buscar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtBuscaNombreProd);
            this.groupBox3.Location = new System.Drawing.Point(429, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de Productos";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(9, 52);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(54, 33);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ingrese código o porción del nombre";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 376);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(251, 111);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // guia1_labDataSet
            // 
            this.guia1_labDataSet.DataSetName = "Guia1_labDataSet";
            this.guia1_labDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rUBROSBindingSource
            // 
            this.rUBROSBindingSource.DataMember = "RUBROS";
            this.rUBROSBindingSource.DataSource = this.guia1_labDataSet;
            // 
            // rUBROSTableAdapter
            // 
            this.rUBROSTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(296, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ver Rubros";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(259, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 27);
            this.button7.TabIndex = 13;
            this.button7.Text = "Borrar Producto";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 521);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Grupo1);
            this.Name = "Form1";
            this.Text = "ABM de Productos y Rubros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guia1_labDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rUBROSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRubros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.CheckBox checkNuevoRubro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRubros;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.TextBox txtBuscaNombreProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Guia1_labDataSet guia1_labDataSet;
        private System.Windows.Forms.BindingSource rUBROSBindingSource;
        private trabajoPractico.Guia1_labDataSetTableAdapters.RUBROSTableAdapter rUBROSTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInfoRubro;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.MaskedTextBox maskCodigo;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button7;

    }
}

