using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace trabajoPractico
{
    public partial class Form1 : Form
    {

        DataTable Productos = new DataTable(); 
        DataTable Rubros = new DataTable();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                producto oProducto = new producto(Convert.ToInt32(maskCodigo.Text), txtprod.Text, Convert.ToInt32(txtStockActual.Text),Convert.ToInt16(comboRubros.SelectedValue));
                BD_ABM_ALMACEN.AgregarProducto(oProducto);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato en la entrada de datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Rubros oRubro = new Rubros(txtRubros.Text);
                BD_ABM_ALMACEN.AgregarRubro(oRubro);
                Rubros = BD_ABM_ALMACEN.CargarRubros();
                if (Rubros.Columns.Count > 0)
                {
                    comboRubros.DataSource = Rubros;
                    comboRubros.ValueMember = Rubros.Columns[0].ToString();
                    comboRubros.DisplayMember = Rubros.Columns[1].ToString();
                    comboRubros.Text = "Rubros";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'guia1_labDataSet.RUBROS' Puede moverla o quitarla según sea necesario.
            this.rUBROSTableAdapter.Fill(this.guia1_labDataSet.RUBROS);
            groupBox2.Enabled = false;
            if (checkNuevoRubro.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            Rubros = BD_ABM_ALMACEN.CargarRubros();
            if (Rubros.Columns.Count > 0)
            {
                comboRubros.DataSource = Rubros;
                comboRubros.ValueMember = Rubros.Columns[0].ToString();
                comboRubros.DisplayMember = Rubros.Columns[1].ToString();
                comboRubros.Text = "";
                 
            }
        }

        private void checkNuevoRubro_Click(object sender, EventArgs e)
        {
            if (this.checkNuevoRubro.Checked == true)
            {
                groupBox2.Enabled = true;
            }
            else this.groupBox2.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fila = dataGridView2.CurrentRow.Index;
            BD_ABM_ALMACEN.BorrarRubro(Convert.ToInt16(dataGridView2[0,fila].Value));
            Rubros = BD_ABM_ALMACEN.CargarRubros();
            dataGridView2.DataSource = Rubros;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rubros = BD_ABM_ALMACEN.CargarRubros();
            dataGridView2.DataSource = Rubros;
        }

        private void comboRubros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboRubros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtInfoRubro.Text = comboRubros.SelectedValue.ToString();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                grillaProductos.DataSource = BD_ABM_ALMACEN.buscarProductosxNombre(txtBuscaNombreProd.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                int cod = Convert.ToInt32(maskCodigo.Text);
                string nom = txtprod.Text;
                int stock = Convert.ToInt32(txtStockActual.Text);
                Int16 idR = Convert.ToInt16(txtInfoRubro.Text);
                
                producto oProducto = new producto(cod, nom, stock, idR);
                BD_ABM_ALMACEN.modificarProducto(oProducto);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato en la entrada de datos");
            }
        }

        private void grillaProductos_DoubleClick(object sender, EventArgs e)
        {
          txtprod.Text =  grillaProductos.CurrentRow.Cells[1].Value.ToString();
          maskCodigo.Text = grillaProductos.CurrentRow.Cells[0].Value.ToString();
          txtStockActual.Text = grillaProductos.CurrentRow.Cells[2].Value.ToString();
          txtInfoRubro.Text = grillaProductos.CurrentRow.Cells[3].Value.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                BD_ABM_ALMACEN.BorrarProducto(Convert.ToInt32(maskCodigo.Text));
                grillaProductos.DataSource = BD_ABM_ALMACEN.buscarProductosxNombre(txtBuscaNombreProd.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de Formato en la entrada de datos");
            }
        }

     
    }
}