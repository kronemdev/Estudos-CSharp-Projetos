# 🏦 Simulador de Caixa Eletrônico em C#

Este é um projeto de **Simulador de Caixa Eletrônico** desenvolvido em console utilizando **C#** e **.NET**. O objetivo deste projeto é consolidar conceitos fundamentais de lógica de programação, como estruturas de repetição (`while`), estruturas condicionais (`if/else`), seleção de fluxo (`switch/case`) e manipulação de variáveis.

## 🚀 Funcionalidades

O simulador replica as operações básicas de uma conta bancária com um saldo inicial de R\$ 5.000,00:

* 💰 **1 - Ver Saldo:** Exibe na tela o saldo atualizado da conta.
* 💵 **2 - Depositar:** Permite somar um valor informado pelo usuário ao saldo atual.
* 💸 **3 - Sacar:** Realiza a dedução de um valor do saldo, contando com uma validação de segurança caso o usuário tente sacar mais do que possui em conta.
* 🚪 **4 - Sair:** Encerra a execução do sistema com uma mensagem de despedida.

## 🛠️ Tecnologias Utilizadas

* **C#** (.NET)
* **Visual Studio** (IDE)
* **Git & GitHub** (Controle de versão)

## 📁 Estrutura do Projeto

* `Program.cs`: Contém toda a lógica de repetição, leitura de dados do teclado e as operações do banco.
* `.gitignore`: Configuração para ignorar arquivos temporários e pastas pesadas (`bin/` e `obj/`).

## 🖥️ Como Executar o Projeto

1. Certifique-se de ter o SDK do .NET instalado na sua máquina.
2. Abra a pasta do projeto no **Visual Studio**.
3. Pressione a tecla **F5** para rodar o projeto.
4. Interaja com o menu do Caixa Eletrônico digitando os números correspondentes no console.
