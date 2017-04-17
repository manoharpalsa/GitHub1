1) Run below script on sql server query editor

CREATE DATABASE [Test] ON  PRIMARY 
( NAME = N'Test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Test.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Test_log.ldf' , SIZE = 63488KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

USE [Test]


CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[Email] [varchar](250) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[IsActive] [bit] NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




2) Change contactconnectionstring connection string in web.config file where you ran above script


3) Run the appalciation, Navigate to https://localhost:/api/contacts/

you should see below json data
 

[{"Id":1,"FirstName":"John","LastName":"Wright","Email":"john.wright@gmail.com","PhoneNumber":"123-234-1234","IsActive":true},{"Id":2,"FirstName":"Don","LastName":"Miller","Email":"don.miller@gmail.com","PhoneNumber":"342-234-1256","IsActive":true}]


4) you should also be able to create/edit/delete contact.