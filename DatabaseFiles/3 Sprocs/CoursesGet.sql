create or alter procedure dbo.CourseGet(
	@CourseId int = 0 output,
	@All bit  = 0,
	@Message varchar (500) = ''
	)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @CourseId = isnull(@CourseId,0)

	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @All  = 1

	return @return

end
go