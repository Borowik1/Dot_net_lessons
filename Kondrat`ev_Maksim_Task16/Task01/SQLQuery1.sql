CREATE DATABASE UsersAndAwards

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	DateOfBirth DATETIME2 NOT NULL
)

CREATE TABLE Awards
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Description NVARCHAR(50)
)
use UsersAndAwards
go
CREATE TABLE Relations
(
	Id INT PRIMARY KEY IDENTITY,
	UserID INT REFERENCES Users(Id) ON DELETE CASCADE,
	AwardId INT REFERENCES Awards(Id) ON DELETE CASCADE
)

USE UsersAndAwards
GO
CREATE procedure AddAward
	@AwardName nvarchar(50),
	@AwardDesc nvarchar(50)
as
insert into Awards
values (@AwardName, @AwardDesc)

USE UsersAndAwards
GO

CREATE procedure AddUser
@FirstName nvarchar(50),
@LastName nvarchar(50),
@DateOfBirth datetime2,
@AwardsIDS AwardsIds READONLY

AS
BEGIN
	DECLARE @userId AS TABLE(id int)

	INSERT INTO Users
	OUTPUT Inserted.Id INTO @userId
	VALUES(@FirstName, @LastName, @DateOfBirth)

	INSERT INTO Relations
	SELECT [@userId].id, [@AwardsIDS].id FROM @awardsIds, @userId
END

CREATE procedure DeleteAward
	@Id int
as
delete Awards 
where Id = @Id

CREATE procedure DeleteUser
@Id int
as
delete Users where Id=@Id

CREATE PROCEDURE EditAward
	@Id int,
	@AwardName nvarchar(50),
	@AwardDesc nvarchar(50)

AS
BEGIN
UPDATE Awards
SET Name = @AwardName, Description = @AwardDesc
WHERE Id = @Id
END

CREATE procedure EditUser
@Id int,
@FirstName nvarchar(50),
@LastName nvarchar(50),
@DateOfBirth datetime2,
@AwardsIds AwardsIds READONLY

AS
BEGIN
	DECLARE @userId AS TABLE(id int)
	INSERT @userId VALUES (@Id)

	UPDATE Users
	SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth
	WHERE Id = @Id

	DELETE Relations
	WHERE UserId = @Id

	INSERT INTO Relations
	SELECT [@userId].id, [@AwardsIDS].id FROM @awardsIds, @userId
END
