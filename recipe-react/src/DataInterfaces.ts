export interface ICuisine {
    cuisineId: number;
    cuisineName: string;
}

export interface IUsers {
    usersId: number;
    usersName: string;
}

export interface IRecipe {
    recipeId: number,
    recipeName: string,
    cuisineId: number,
    cuisineName: string,
    usersId: number,
    usersName: string,
    calories: number,
    vegan: boolean,
    ingredientList: {
        ingredientName: string,
        measurementName: string,
        measurementAmt: number
    }[],
    directionList: {
        directionSequence: number,
        directionDesc: string
    }[],
    errorMessage: string
}