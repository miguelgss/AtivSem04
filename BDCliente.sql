USE bdservico;

CREATE TABLE `vendasclientes`(
	`VendaId` int(11) NOT NULL AUTO_INCREMENT,
    `DataVenda` date NOT NULL,
    `Venda` float NOT NULL,
    `LimiteId` int(11),
	PRIMARY KEY (`VendaId`),
    FOREIGN KEY (`LimiteId`) REFERENCES limiteclientes(`LimiteId`)
);