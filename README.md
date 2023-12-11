![TUDO PARA SUA CASA, SÓ PODE ENCONTRAR AQUI](https://github.com/Bruno-Luiz-CNR/Controle-de-Estoque-e-Venda/assets/115126390/42199bd4-21ad-4572-b2db-dc4ba30b2014)

![image](https://github.com/Bruno-Luiz-CNR/Controle-de-Estoque-e-Venda/assets/115126390/60ea2160-4a72-48cb-ac98-428441e0b3cf)

#controleestoque

O código em C# apresenta um sistema de controle de estoque e vendas com interface gráfica. Aqui está um resumo das partes mais importantes:

Conexão ao Banco de Dados:

Utiliza o SQL Server (LocalDB) para armazenar dados.
Estabelece uma conexão com o banco de dados usando a classe SqlConnection.
Inicialização e Configuração da Interface Gráfica:

Cria uma interface gráfica com abas para diferentes funcionalidades.
Define botões, campos de texto e grids para interação com o usuário.
Operações no Estoque:

Adiciona, altera, exclui e pesquisa produtos no estoque.
Utiliza comandos SQL para manipular a tabela cadaspro.
Vendas de Produtos:

Registra vendas de produtos.
Atualiza o estoque após a venda.
Calcula o valor total das vendas.
Possui opção de adicionar desconto.
Relatórios de Vendas:

Gera relatórios de vendas com base em um intervalo de datas.
Exibe o valor total das vendas no período.
Controle de Usuários:

Permite configurar permissões de usuários.
Define credenciais para limitar o acesso a certas funcionalidades.
Outras Funcionalidades:

Possui botões para abrir outras janelas, como o controle de usuários.
Observações:

O código contém boas práticas, como o uso de parâmetros em consultas SQL para evitar injeção de SQL.
Há a implementação de tratamento de eventos, como cliques em botões e seleção de células em grids.
A aplicação usa controles de formulários, tais como DataGridView, TextBox, e TabControl para uma experiência interativa.
