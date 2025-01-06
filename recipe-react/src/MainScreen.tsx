import { useEffect, useState } from "react"
import RecipeCarousel from "./RecipeCarousel"
import { IRecipe } from "./DataInterfaces"
import { fetchRecipeByCuisine } from "./DataUtilities";


interface Props {
    cuisineName: string
}






export default function MainScreen({ cuisineName }: Props) {
    const [recipeList, setRecipeList] = useState<IRecipe[]>([]);
    const [isLoading, setIsLoading] = useState(false);




    useEffect(() => {
        if (cuisineName != "") {
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
                    <h2 className="mt-2 bg-light col-lg-12 col-md-12 col-sm-12">
                        <span className={isLoading ? "placeholder" : ""}>{recipeList.length} Recipes in {cuisineName} Cuisine</span>
                    </h2>
                    <div>
                        <RecipeCarousel recipeList={recipeList} isLoading={isLoading} />
                    </div>
                </div>
            </div>
        </>
    )
}