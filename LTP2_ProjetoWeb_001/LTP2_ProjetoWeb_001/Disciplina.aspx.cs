using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class Disciplina : System.Web.UI.Page
    {
        conectDisciplina D = new conectDisciplina();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (VisualizarDisciplinas.ID != 0)
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            D.configurarConexao();

            string test = txtSemestre.Text;

            D.Codigo_Disciplina = txtCodigoDisciplina.Text;
            D.Nome_Disciplina = txtDisciplina.Text;
            D.Ementa_Disciplina = txtEmenta.Text;
            D.Semestre_Disciplina = txtSemestre.Text;
            D.CargaHoraria_Disciplina = txtCargaHoraria.Text;

            if (VisualizarDisciplinas.ID == 0)
            {
                D.InserirDisciplina();
            }
            else
            {
                D.ID_Disciplina = VisualizarDisciplinas.ID;
                D.alterarItem();
            }

            //lblSucesso.Text = "Disciplina Inserida com sucesso!";
            Response.Redirect("VisualizarDisciplinas.aspx");

        }

        public void preencherFormulario()
        {
            int ID = VisualizarDisciplinas.ID;

            D.configurarConexao();
            D = D.retornarItem(ID);

            txtCodigoDisciplina.Text = D.Codigo_Disciplina;
            txtDisciplina.Text = D.Codigo_Disciplina;
            txtEmenta.Text = D.Ementa_Disciplina;
            txtSemestre.Text = D.Semestre_Disciplina;
            txtCargaHoraria.Text = D.CargaHoraria_Disciplina;
        }

    }
}