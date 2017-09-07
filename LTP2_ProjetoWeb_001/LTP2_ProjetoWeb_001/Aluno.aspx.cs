using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class Aluno : System.Web.UI.Page
    {
        conectAluno A = new conectAluno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (VisualizarAlunos.ID != 0)
                {
                    preencherFormulario();
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            A.configurarConexao();

            string test = txtSexo.Text;

            A.RA_Aluno = txtRA.Text;
            A.Nome_Aluno = txtNomeAluno.Text;
            A.CPF_Aluno = txtCPF.Text;
            A.Sexo_Aluno = txtSexo.Text;
            A.Ingresso_Aluno = txtIngresso.Text;

            if (VisualizarAlunos.ID == 0)
            {
                A.InserirAluno();
            }
            else
            {
                A.ID_Aluno = VisualizarAlunos.ID;
                A.alterarItem();
            }

            //lblSucesso.Text = "Aluno Inserido com sucesso!";
            Response.Redirect("VisualizarAlunos.aspx");

        }

        public void preencherFormulario()
        {
            int ID = VisualizarAlunos.ID;

            A.configurarConexao();
            A = A.retornarItem(ID);

            txtRA.Text = A.RA_Aluno;
            txtNomeAluno.Text = A.Nome_Aluno;
            txtCPF.Text = A.CPF_Aluno;
            txtSexo.Text = A.Sexo_Aluno;
            txtIngresso.Text = A.Ingresso_Aluno;
        }
    }
}