import { useEffect, useState } from "react"
import RecipeCarousel from "./RecipeCarousel"
import { IRecipe } from "./DataInterfaces"
import { fetchRecipeByCuisine } from "./DataUtilities";


interface Props {
    cuisineName: string,
    onRecipeSelectedForEdit: (recipe: IRecipe) => void
}

export default function MainScreen({ cuisineName, onRecipeSelectedForEdit }: Props) {
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        if (cuisineName != '') {
            setIsLoading(true);
            const fetchdata = async () => {
                const data = await fetchRecipeByCuisine(cuisineName);
                console.log(data);
                setRecipeList(data);
                setIsLoading(false);
            };
            fetchdata();
        }
    },
        [cuisineName])

    return (
        <>
            <div className="row">
                <div className={isLoading ? "placeholder-glow" : ""}>
                    <h4 className="mt-2 bg-light col-lg-12 col-md-12 col-sm-12 p-3">
                        <span className={`${isLoading ? "placeholder" : ""} d-flex justify-content-center align-items-center`}>
                            {recipeList.length == 0 ? (<>No recipes in {cuisineName} cuisine. More great recipes coming soon!</>) : `${recipeList.length} Recipes in ${cuisineName} Cuisine`} </span>
                    </h4>
                    <div>
                        <RecipeCarousel recipeList={recipeList} isLoading={isLoading} onRecipeSelectedForEdit={onRecipeSelectedForEdit} />
                    </div>

                </div>
            </div>
        </>
    )
}