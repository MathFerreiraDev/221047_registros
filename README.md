

<h1>DEFINIÇÃO DO USUÁRIO DEFAULT NO MySQL</h1>
-- Cidades
insert into cidades values (0, "Null", "XX");
update cidades set id = 0 where id = 1;
alter table cidades auto_increment = 1;

--Cliente
insert into clientes values (0, "Default Client", 0, "2000-01-01", 1000, "000.000.000-00", "C:\Users\Usuario\Downloads\221047_registros\221047_registros\221047_registros\Resources\generic.png", 0); 
update clientes set id = 0 where id = 1;
alter table clientes auto_increment = 1; 



1° - O que é um teste de caixa preta?
> Um teste que verifica somente o produto final do software, seu final propósito,
sem instigar o código

2° - O que é um teste de caixa branca?
> Um teste que verifica somente a lógica utilizada no código para ele cumprir seu objetivo,
sujeito a modificações

3° - O que é um teste de caixa cinza?
> Junção do teste de caixa preta e branca, onde ao mesmo tempo que eu verifico o produto final,
e em caso de erros ou alterações, analizo o código e o modifico

4° - De um exemplo de software com:
	A) Muitas Telas > Sistemas de controle de estoque
	B) Poucas telas > Sistemas de mensagens, ou chamadas
