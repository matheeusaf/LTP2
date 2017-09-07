<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="LTP2_ProjetoWeb_001.Curso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Cursos</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <!-- Header -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand active " href="#">Cadastro de Cursos</a>
            </div>

            <!-- Navbar links -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li><a href="index.html">Home</a></li>
                    <li><a href="Aluno.aspx">Cadastrar Alunos</a></li>
                    <li><a href="VisualizarAlunos.aspx">Visualizar Alunos</a></li>
                    <li><a href="Disciplina.aspx">Cadastrar Disciplinas</a></li>
                    <li><a href="VisualizarDisciplinas.aspx">Visualizar Disciplinas</a></li>
                    <li><a href="Curso.aspx">Cadastrar Cursos</a></li>
                    <li><a href="VisualizarCursos.aspx">Visualizar Cursos</a></li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Form Cadastro -->
    <form id="form1" runat="server">
        <div>
            <h3 class="text-center">Cadastro de Cursos</h3>
            <br />
            <asp:Label ID="lblSucesso" runat="server"></asp:Label>
            <table class="table table-bordered table-responsive">
                <tr>
                    <td style="text-align: right">Código do Curso:</td>
                    <td>
                        <asp:TextBox ID="txtCodido" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Nome do Curso:</td>
                    <td>
                        <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Período do Curso (Diurno, Noturno):</td>
                    <td>
                        <asp:TextBox ID="txtPeriodo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Duração (em anos):</td>
                    <td>
                        <asp:TextBox ID="txtDuracao" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Conceito Enade (de 0 a 5):</td>
                    <td>
                        <asp:TextBox ID="txtEnade" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:Button CssClass="btn btn-success btn-lg center-block" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </form>
</body>
</html>
