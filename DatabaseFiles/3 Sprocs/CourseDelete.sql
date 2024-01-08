create or alter proc dbo.CourseDelete(
	@CourseId int,
	@Message varchar (500) = '')

as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId, 0)

	begin try
		begin tran
			delete MealCourseRecipe
			from MealCourseRecipe mcr
			join MealCourse mc
			on mc.MealCourseId = mcr.MealCourseId
			join Course c
			on c.CourseId = mc.CourseId
			where c.CourseId = @CourseId

			delete MealCourse
			from MealCourse mc
			where mc.CourseId = @CourseId

			delete Course
			from Course
			where CourseId = @CourseId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return

end
go