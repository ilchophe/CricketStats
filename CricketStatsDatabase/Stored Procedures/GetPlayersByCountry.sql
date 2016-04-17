CREATE PROCEDURE dbo.GetPlayersByCountry
	(
		@countryid uniqueidentifier
	)
AS
	SET NOCOUNT ON 
	SELECT Player.playername AS [Name], Player.playersurname AS Surname, 
	Country.countrydesc AS Country, Player.retired AS Retired, 
	DATEDIFF(DAY, dbo.Player.dob, GETDATE()) AS Age
	FROM Player INNER JOIN
	Country ON Player.countryid = Country.countryid
	WHERE Player.countryid=@countryid
                      
	RETURN
