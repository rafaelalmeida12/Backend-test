# Projeto

Backend-test é uma **API RESTFul** utilizada como um dos critérios de avaliação para back-end developer do grupo rovema, esta é a implementação feita por Thiago Barbosa.

Desenvolvi o projeto me baseando em um curso gratuito do site balta.io tendo em vista que sempre tive curiosidade de implementar uma API RESTFul  utilizando nodejs e express. Aproveitei também para trabalhar com o banco de dados Mongo que é um banco [NoSQL](https://www.mongodb.com/nosql-explained) que também me interessava havia algum tempo. Após repetir várias vezes a criação de um projeto disponível no curso mencionado anteriormente, consegui implementar o teste sem grandes dificuldades. A maior parte do tempo foi gasta nos estudos de Docker/Docker Compose e em padronizar os commits de forma satisfatória.

# Tecnologias

 - [JavaScript](https://www.javascript.com/) - Linguagem de programação
    interpretada utilizada no desenvolvimento do aplicativo
 - [NodeJS](https://nodejs.org/en/) - Interpretador de javascript
    utilizado para rodar a aplicacao
 - [Express](https://expressjs.com/) - Framework utilizado para criar
   aplicações web utilizando JavaScript
 - [MongoDB](https://www.mongodb.com/) - Banco de dados NoSQL utilizado
   para  persistir os dados processados pela API
 - [Docker](https://www.docker.com/) - Utilizado para encapsular a
   aplicação em containers facilitando sua portabilidade/instalação
 - [Docker Compose](https://docs.docker.com/compose/) - Utilizado para
   facilitar ainda mais a instalação do aplicativo configurando um
   ambiente com a aplicação e o banco de dados devidamente configurados
 - [VisualStudio Code](https://code.visualstudio.com/) - Editor de texto
   utilizado para codificar a aplicação
 - [ERDPlus](https://erdplus.com/#/) - Aplicativo utilizado para criação
   do diagrama de entidade-relacionamento
 - [GitFlow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)
 - Padrão de branches utilizado para administrar projetos de maneira clara no git.
 - [Apiary](https://apiary.io/) - Ferramenta para design de API's.

## Como rodar
Após [instalar o docker](https://docs.docker.com/install/) e [instalar o docker-compose](https://docs.docker.com/compose/install/) basta abrir um terminal na raiz da aplicação e executar o seguinte comando:

    docker-compose up

## Apiary
Caso prefira, acesse [este link](https://backendtest2.docs.apiary.io) para:
 - Entender como funcionam as rotas da aplicação
 - Testar a aplicação (manualmente, não confundir com testes unitários)
