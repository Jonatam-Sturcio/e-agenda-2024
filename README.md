# e-Agenda

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Descri��o

Jos� Pedro gosta de participar em eventos, palestras e congressos de tecnologia. E depois de horas de networking � normal ele voltar para casa com v�rios cart�es com contatos de seus novos colegas. � bastante comum ele deixar estes cart�es guardados, que podem ser esquecidos no fundo de uma gaveta...

Para isto, ser� necess�rio fazer uma gest�o de contatos inteligente e JP pretende fazer isso utilizando um sistema.


## Funcionalidades

1. O cadastro do **Contato** consiste de:
	- nome
	- email
	- telefone
	- cargo
	- empresa

2. O cadastro do **Compromisso** consiste de:
	- assunto
	- data
	- hora de in�cio
	- hora de t�rmino
	- local (caso presencial)
	- link (caso remoto)
	- contato (opcional)

3. O cadastro do **Tarefa** consiste de:
	- t�tulo
	- prioridade
	- data de cria��o
	- data de conclus�o
	- itens
	- percentual conclu�do

	3.1. Item da Tarefa
	- t�tulo
	- conclu�do (status)
	- tarefa
---

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/academia-do-programador/e-agenda-2024.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd e-agenda-2024
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd eAgenda.WinApp
```

#### Execute o projeto
```
dotnet run
```
