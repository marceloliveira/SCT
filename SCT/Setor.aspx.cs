using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDADES;
using DADOS;
using NEGOCIO;

namespace SCT
{
    public partial class Setor : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            SetorN.carregarSetores();
            upDateGrid();
        }
        
        private void upDateGrid()
        {
            GridView1.DataSource = SetorN.setores;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int codigoClicado = (int)GridView1.DataKeys[e.RowIndex].Value;
            deleteField(codigoClicado);
        }

        private void deleteField(int codigoClicado)
        {
            foreach (SetorE p in SetorN.setores)
            {
                if (p.codigo.Equals(codigoClicado))
                {
                    SetorN.removerSetor(codigoClicado);
                    break;
                }
            }
            upDateGrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.SelectRow(e.NewEditIndex);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            upDateGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            
        }
    }
}