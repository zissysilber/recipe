export interface ICuisine {
    cuisineId: number;
    cuisineName: string;
}

export interface IRecipe {
    recipeId: number,
    recipeName: string,
    cuisineId: number,
    cuisineName: string,
    calories: number,
    ingredientList: {
        ingredientName: string,
        measurementName: string,
        measurementAmt: number
    }[],
    directionList: {
        directionSequence: number,
        directionDesc: string
    }[]
}