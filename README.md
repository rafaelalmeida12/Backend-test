# Projeto

RESTFul API desenvolvida para realização do CRUD( Create, Read, Update, Delete) de Produtos e Categorias. Projeto este que foi desenvolvido na linguagem C# utilizando o Entity Framework Code First para Mapeamento Objeto Relacional juntamente com Microsoft SQL Server 2017.


# Tecnologias

**Linguagem de Programação:** C#(CSharp) [Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/)
**IDE de Desenvolvimento:** Microsoft Visual Studio Enterprise 2017 Versão 15.9.6  
**Framework de Mapeamento Objeto Relacional:** Entity Framework Versão 6.2.0 [Documentação](https://docs.microsoft.com/pt-br/ef/ef6/)
**Banco de Dados:** Microsoft SQL Server 2017
**Style Guide:** [C# Style Guide](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).

# Como Rodar

## Passo-a-Passo

#### 1- Instalar o [Visual Studio Community](https://visualstudio.microsoft.com/pt-br/downloads/?rr=https%3A%2F%2Fwww.google.com%2F)
#### 2- Instalar o [Microsoft SQL Server 2017](https://go.microsoft.com/fwlink/?linkid=853017)
#### 3- Abrir o projeto e pressionar **F5** para executá-lo.
  ###### 3.1 Algumas vezes não reconhece o Banco de Dados sendo necessário abrir o **SQL Server Object Explorer** e reconectar o banco manualemente do projeto.



## Rotas da API

#### Get    => Utilize "api/Value" para **retornar** todos os **Produtos** Cadastrados no Banco de Dados
#### Get    => Utilize "api/Value/{id:int}" para **retornar** um **Produto** específico passando como Parâmetro o **Id** desejado
#### Post   => Utilize "api/Value" para **Cadastrar** um **Novo Produto** {"Nome":Value, "Preco:"value, "Categorias:"[value]}
#### Put    => Utilize "api/Value/{id:int}" para **Atualizar** um **Produto** existente passando como parâmetro seu **Id**
#### Delete => Utilize "api/Value/{id:int}" para **Deletar** um **Produto** passando como parâmetro seu **Id**.

##### **Value** = Nome da **Classe** (Ex: Produto, Categoria)
 
 
 
 
