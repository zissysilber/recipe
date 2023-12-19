-- SM 100%
use master;
go
ALTER DATABASE HeartyHearthDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
Go

Use master
go
drop database if exists HeartyHearthDB
go
create database HeartyHearthDB
go