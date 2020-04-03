# Todo_AspNet

## ChangeLog:

### 1. V0.2
  + Adicionado opção para logar e registrar 
  + Limitado as paginas que usuario sem login pode acessar

### 1. V0.1
  + Adicionar Tarefas
  + Listar todas as tarefas criadas
  + Marcar tarefas como concluida


**Tutorial para o banco**

###### Instalar uma instacia MSSQL no Docker

###### Instalar o Docker

###### Executar no CMD os seguintes comando:

###### docker pull mcr.microsoft.com/mssql/server:2019-CU3-ubuntu-18.04 - Pega a imagem do SQL Server 2019

###### docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=SqlToDo@" -p 1433:1433 --name sqltodo -d mcr.microsoft.com/mssql/server:2019-CU3-ubuntu-18.04 - Cria a instancia do SQL Server 2019

###### depois utilize um programa para consultar o Banco de Dados (Utilizei o DBeaver) - nao necessario

###### DBeaver - 

######No DBeaver criar uma novo conexao do tipo SQL Server

###### Usuario: SA
###### Senha: senha definida na linha de comando do Docker (exemplo acima esta como SqlToDo@)
