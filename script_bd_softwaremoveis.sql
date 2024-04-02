create database software_moveis;

use software_moveis;

-- Criação da tabela de Imóveis
CREATE TABLE Imoveis (
    ImovelID INT AUTO_INCREMENT PRIMARY KEY,
    TipoImovel VARCHAR(255) NOT NULL,
    Endereco VARCHAR(255) NOT NULL,
    ValorAluguel FLOAT NOT NULL
);

-- Criação da tabela de Clientes (anteriormente "Locatários")
CREATE TABLE Clientes (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Email VARCHAR(255),
    Telefone VARCHAR(20)
);

-- Criação da tabela de Aluguéis
CREATE TABLE Alugueis (
    AluguelID INT AUTO_INCREMENT PRIMARY KEY,
    ImovelID INT NOT NULL,
    ClienteID INT NOT NULL,
    ValorMensal float NOT NULL,
    FOREIGN KEY (ImovelID) REFERENCES Imoveis(ImovelID),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);


select * from Alugueis;