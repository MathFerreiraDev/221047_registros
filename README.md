
-- Cidades
insert into cidades values (0, "Null", "XX");
update cidades set id = 0 where id = 1;
alter table cidades auto_increment = 1;

--Cliente
insert into clientes values (0, "Default Client", 0, "2000-01-01", "000.000.000-00", "C:\Users\Usuario\Downloads\221047_registros\221047_registros\221047_registros\Resources\generic.png", 0);
update clientes set id = 0 where id = 1;
alter table clientes auto_increment = 1; 
