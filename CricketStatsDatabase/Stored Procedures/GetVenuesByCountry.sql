CREATE PROCEDURE dbo.GetVenuesByCountry
	(
		@countryid uniqueidentifier
	)
AS
	SET NOCOUNT ON 
	SELECT (CASE  WHEN Venue.venuename <> '' THEN  Venue.venuename ELSE Venue.venuecity END) AS VenueName FROM Venue
	WHERE Venue.countryid=@countryid
	RETURN
