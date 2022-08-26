using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Entity
{
    public partial class Form1 : Form
    {
        public object BotonCrear { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiseñoInicial();
            ObtenerPersonas();
        }

        private void DiseñoInicial() 
        {
            BotoCrear.Cursor = Cursors.Hand;
            BotoCrear.BackColor = Color.Blue;
            BotoCrear.ForeColor = Color.White;
            BotoCrear.FlatStyle = FlatStyle.Flat;

            DataGridViewPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewPersona.MultiSelect = false;
            DataGridViewPersona.ReadOnly = true;
            DataGridViewPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ObtenerPersonas() 
        {

            //LIMPIAMOS EL DATAGRIDVIEW
            DataGridViewPersona.DataSource = null;
            DataGridViewPersona.Rows.Clear();
            DataGridViewPersona.Columns.Clear();

            List<persona> oListaPersona;
            using(CN_DBPRUEBAS bd = new CN_DBPRUEBAS()) 
            {
                oListaPersona = (from filas in bd.persona
                                 select filas).ToList();
            }

            DataGridViewPersona.DataSource = oListaPersona;


            //AGREGAR BOTON EDITAR
            DataGridViewButtonColumn BotonEditar = new DataGridViewButtonColumn();
            BotonEditar.HeaderText = "Editar";
            BotonEditar.Text = "Editar";
            BotonEditar.Name = "btnEditar";
            BotonEditar.FlatStyle = FlatStyle.Flat;
            BotonEditar.UseColumnTextForButtonValue = true;
            BotonEditar.CellTemplate.Style.BackColor = Color.Green;
            BotonEditar.CellTemplate.Style.ForeColor = Color.White;


            //AGREGAR BOTON ELIMINAR
            DataGridViewButtonColumn BotonEliminar = new DataGridViewButtonColumn();

            BotonEliminar.HeaderText = "Eliminar";
            BotonEliminar.Text = "Eliminar";
            BotonEliminar.Name = "btnEliminar";
            BotonEliminar.FlatStyle = FlatStyle.Flat;
            BotonEliminar.UseColumnTextForButtonValue = true;
            BotonEliminar.CellTemplate.Style.BackColor = Color.Red;
            BotonEliminar.CellTemplate.Style.ForeColor = Color.White;

            //AGREGAR LOS BOTONES
            DataGridViewPersona.Columns.Add(BotonEditar);
            DataGridViewPersona.Columns.Add(BotonEliminar);

        }

        private void BotoCrear_Click(object sender, EventArgs e)
        {
            frmPersona ofrmPersona = new frmPersona();
            ofrmPersona.ShowDialog();
            ObtenerPersonas();

        }

        private void DataGridViewPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DataGridViewPersona.Columns[e.ColumnIndex].Name == "btnEditar") 
            {
                persona personaSeleccionada = (persona)DataGridViewPersona.SelectedRows[0].DataBoundItem;
                frmPersona ofrmPersona = new frmPersona(personaSeleccionada);
                ofrmPersona.ShowDialog();
                ObtenerPersonas();
            }
            
            
            if (DataGridViewPersona.Columns[e.ColumnIndex].Name == "btnEliminar") 
            {
                persona personaSeleccionada = (persona)DataGridViewPersona.SelectedRows[0].DataBoundItem;

                using (CN_DBPRUEBAS db = new CN_DBPRUEBAS())
                {
                    persona personaEliminar = (from persona in db.persona
                                               where persona.idpersona == personaSeleccionada.idpersona
                                               select persona).FirstOrDefault();

                    db.persona.Remove(personaEliminar);
                    db.SaveChanges();
                }

                ObtenerPersonas();
            }
        }
    }
}
