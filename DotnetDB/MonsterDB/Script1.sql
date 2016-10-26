create schema Monster;
go

create table Monster.Monster
(
    MonsterId int not null identity(1,1),
    TitleId int null,
    Name nvarchar(250) not null,
    TypeId int not null,
    GenderId int null,
    PicturePath nvarchar(max) null,
    Actve bit not null 

);
go

create table Monster.MonsterType
(
    MonsterTypeId int not null identity(1,1) primary key,
    TypeName nvarchar(250) not null,
    Active bit not null
);
go

create table Monster.Gender
(
    GenderId int not null identity(1,1) primary key,
    GenderName nvarchar(250) not null,
    Active bit not null
);
go

create table Monster.Title
(
    TitleId int not null identity(1,1) primary key,
    TitleName nvarchar(250) not null,
    Active bit not null
);
go

alter table Monster.Monster
    add constraint pk_monster_monsterid primary key clustered (MonsterId);
go 

alter table Monster.Monster
    add constraint fk_monster_genderid foreign key (GenderId) references Monster.Gender (GenderId);
go 

alter table Monster.Monster
    add constraint fk_monster_titleid foreign key (TitleId) references Monster.Title (TitleId);
go

alter table Monster.Monster
    add constraint fk_monster_typeid foreign key (TypeId) references Monster.MonsterType (MonsterTypeId);
 go

