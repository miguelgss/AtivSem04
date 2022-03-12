CREATE DATABASE `bdservico` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

GO

USE bdservico;

GO

CREATE TABLE `limiteclientes` (
  `LimiteId` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(80) NOT NULL,
  `LimiteCredito` float NOT NULL,
  PRIMARY KEY (`LimiteId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4;

GO

INSERT into limiteclientes(nome,limiteCredito) values ('Fulano', 500);
INSERT into limiteclientes(nome,limiteCredito) values ('Sicrano', 300);
INSERT into limiteclientes(nome,limiteCredito) values ('Bernardo', 450);
INSERT into limiteclientes(nome,limiteCredito) values ('Rodrigo', 600);
INSERT into limiteclientes(nome,limiteCredito) values ('TheEndurableSmoggy', 150);
INSERT into limiteclientes(nome,limiteCredito) values ('VonSmoggy', 720);
INSERT into limiteclientes(nome,limiteCredito) values ('JadedSmoggy', 250);
INSERT into limiteclientes(nome,limiteCredito) values ('TheErraticRuddy', 1000);
INSERT into limiteclientes(nome,limiteCredito) values ('Grammona', 350);
INSERT into limiteclientes(nome,limiteCredito) values ('Usmog', 900);