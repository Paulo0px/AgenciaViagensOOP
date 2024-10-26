Projeto de Agência de Viagens
Este projeto é uma aplicação simples de gerenciamento de uma agência de viagens, permitindo cadastrar destinos, clientes e pacotes turísticos, além de realizar reservas e cancelamentos.

Tecnologias Utilizadas
C#
.NET (se aplicável)
Console Application
Pré-requisitos
.NET SDK (versão X.X ou superior)
Instalação
Clone o repositório

Use o comando abaixo para clonar o repositório para sua máquina local:

bash
Copiar código
git clone https://github.com/Paulo0px
Navegue até o diretório do projeto

bash
Copiar código
cd nome-do-repositorio
Restaure as dependências (se necessário)

Caso o projeto use pacotes NuGet, você pode restaurar as dependências com o seguinte comando:

bash
Copiar código
dotnet restore
Execução
Para executar o projeto, utilize o seguinte comando:

bash
Copiar código
dotnet run
Como Usar
Cadastrar um Destino

O programa irá solicitar que você insira os detalhes do destino, como nome, país, código e descrição.
Listar Destinos

Após cadastrar, você pode listar todos os destinos cadastrados na agência.
Cadastrar um Cliente

O programa solicitará os dados do cliente, incluindo nome, número de identificação e contato.
Listar Clientes

Você pode listar todos os clientes cadastrados.
Cadastrar um Pacote Turístico

Insira os detalhes do pacote, como código e descrição.
Listar Pacotes

Veja todos os pacotes turísticos disponíveis.
Reservar um Pacote

O programa permitirá que você reserve um pacote, reduzindo o número de vagas disponíveis.
Cancelar uma Reserva

Você pode cancelar uma reserva, aumentando as vagas disponíveis.