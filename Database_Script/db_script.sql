CREATE DATABASE [WebEngineering] 

go

use [WebEngineering]

go

CREATE TABLE [dbo].[Persons](
	[userID] [int] primary key,
	[FullName] [varchar](255) NULL,
	[Age] [int] NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL
)

go

insert into Persons values (1, 'AbdulMoiz', 21, 'abc', 'abc'), (2, 'AbdulMoiz', 21, 'abc', 'abc'), (3, 'AbdulMoiz', 21, 'abc', 'abc')