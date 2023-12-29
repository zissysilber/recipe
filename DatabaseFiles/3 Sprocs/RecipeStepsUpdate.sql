create or alter procedure dbo.RecipeDirectionUpdate(
	@RecipeDirectionId int  output,
	@RecipeId int ,
	@DirectionSequence int ,
	@DirectionDesc varchar (200),
	@All bit = 0
)
as
begin

	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId, 0), @RecipeId = isnull(@RecipeId, 0)

	if @RecipeDirectionId = 0
	begin
		insert RecipeDirection (RecipeId, DirectionSequence, DirectionDesc)
		values (@RecipeId, @DirectionSequence, @DirectionDesc )

		select @RecipeDirectionId = SCOPE_IDENTITY()
	end
	
	else
	begin
		update RecipeDirection
		set
			RecipeId = @RecipeId, 
			DirectionSequence = @DirectionSequence, 
			DirectionDesc = @DirectionDesc
			where RecipeDirectionId = @RecipeDirectionId
	end

	return @return
end