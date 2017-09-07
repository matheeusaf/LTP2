<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="LTP2_ProjetoWeb_001.Aluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Alunos</title>
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
                <a class="navbar-brand active " href="#">Cadastro de Alunos</a>
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
            <h3 class="text-center">Cadastro de Alunos</h3>
            <br />
            <asp:Label ID="lblSucesso" runat="server"></asp:Label>
            <table class="table table-bordered table-responsive">
                <tr>
                    <td style="text-align: right">RA do Aluno:</td>
                    <td>
                        <asp:TextBox ID="txtRA" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Nome do Aluno:</td>
                    <td>
                        <asp:TextBox ID="txtNomeAluno" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">CPF do Aluno:</td>
                    <td>
                        <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Sexo do Aluno:</td>
                    <td>
                        <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align: right">Data de Ingresso(DD/MM/AAAA):</td>
                    <td>
                        <asp:TextBox ID="txtIngresso" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:Button CssClass="btn btn-success btn-lg center-block" ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </form>
</body>
</html>
