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
    public partial class frmPersona : Form
    {
        persona oPersonaEditar = null;
        public frmPersona(persona oPersonaRecibida = null)
        {
            InitializeComponent();

            if (oPersonaRecibida != null) 
            {
                oPersonaEditar = oPersonaRecibida;

                textoNombres.Text = oPersonaRecibida.nombres;
                textoTelefono.Text = oPersonaRecibida.telefono;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oPersonaEditar != null) 
            {
                using (CN_DBPRUEBAS bd = new CN_DBPRUEBAS()) 
                {
                    persona oPersonaParaEditar = (from seleccionado in bd.persona
                                                  where seleccionado.idpersona == oPersonaEditar.idpersona
                                                  select seleccionado
                                                  ).FirstOrDefault();

                    oPersonaParaEditar.nombres = textoNombres.Text;
                    oPersonaParaEditar.telefono = textoTelefono.Text;
                    bd.SaveChanges();
                }            
            }
            else 
            {
                using (CN_DBPRUEBAS bd = new CN_DBPRUEBAS())
                {
                    bd.persona.Add(new persona()
                    {
                        nombres = textoNombres.Text,
                        telefono = textoTelefono.Text
                    });

                    bd.SaveChanges();
                }
            }
            bd.SaveChanges();
            this.Close();
        }
    }
}
