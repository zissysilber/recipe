create or alter procedure dbo.MeasurementUpdate(
	@MeasurementId int = 0  output,
	@MeasurementName varchar (25) = ' ',
	@Message varchar(500) = '' output)

as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId, 0)

	if @MeasurementId = 0
	begin
		insert Measurement(MeasurementName)
		values(@MeasurementName)

		select @MeasurementId = SCOPE_IDENTITY()
	end
	else
	begin
		update Measurement
		set
			MeasurementName = @MeasurementName
			where MeasurementId = @MeasurementId
		end

		return @return

end
go