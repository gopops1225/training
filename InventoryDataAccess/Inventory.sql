use master;
go

create database InventoryDB;
go 


use InventoryDB;
go

create schema Storage;
go

create table Storage.Inventory
(
    Id int not null identity(1,1) primary key,
    Item nvarchar,
    complete bit not null --true yields complete, false yields incomplete 

);
go
