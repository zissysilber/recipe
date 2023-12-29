create or alter procedure dbo.MeasurementGet(
	@MeasurementId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)

as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @MeasurementId = isnull(@MeasurementId, 0)

	select m.MeasurementId, m.MeasurementName
	from Measurement m
	where MeasurementId = @MeasurementId
	or @All = 1
	order by m.MeasurementName

	return @return

end
go


