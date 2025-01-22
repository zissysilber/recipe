import { IRecipe } from "./DataInterfaces";
interface Props {
    recipeList: IRecipe[];
    isLoading: boolean;
    onRecipeSelectedForEdit: (recipe: IRecipe) => void
}

export default function RecipeCarousel({ recipeList, onRecipeSelectedForEdit }: Props) {
    if (recipeList.length === 0) {
        return (
            <div className="container" style={{ maxWidth: '80%' }}>
                <img src="/images/fourplates.jpg" alt="No recipes available" className="img-fluid" />
            </div>
        );
    }
    return (
        <>
            <div id="carouselRecipe" className="carousel slide col col-lg-12 col-md-12 col-sm-12" data-bs-ride="carousel">
                <div className="carousel-inner">
                    {recipeList.map((r, index) => {
                        const isActive = index === 0 ? 'active' : '';
                        return (
                            <div key={r.recipeId} className={`carousel-item ${isActive} bg-light p-4`}>
                                <div className="row">
                                    <div className="col-12 col-sm-5 col-md-5 d-flex flex-column mb-4">
                                        <img
                                            src={`/images/RecipeImages/recipe_${r.recipeName.toLowerCase().replace(/\s+/g, '')}.jpg`}
                                            className="d-block w-100"
                                            alt={r.recipeName}
                                            onError={(e) => (e.currentTarget.src = "/images/placeholder.jpg")}
                                        />
                                    </div>

                                    <div className="col">
                                        <div className="mb-3">
                                            <h2>{r.recipeName}</h2>
                                        </div>

                                        {r.ingredientList.length == 0 ? "Recipe coming soon..." :
                                            <div className="mb-3">
                                                <h5>Ingredients:</h5>
                                                <ul>
                                                    {r.ingredientList.map((ingredient, iindex) => (
                                                        <li key={iindex}>
                                                            {ingredient.measurementAmt} {ingredient.measurementName} {ingredient.ingredientName}
                                                        </li>
                                                    ))}
                                                </ul>
                                            </div>
                                        }
                                        {r.directionList.length == 0 ? "" :
                                            <div className="mb-3">
                                                <h5>Directions:</h5>
                                                <ol>
                                                    {r.directionList.map((direction) => (
                                                        <li key={direction.directionSequence}>{direction.directionDesc}</li>
                                                    ))}
                                                </ol>
                                            </div>
                                        }
                                        <div className="mt-4">
                                            <button onClick={() => onRecipeSelectedForEdit(r)} type="button" className="btn btn-outline-primary">Edit Recipe</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        );
                    })}
                </div>

                <button
                    className="carousel-control-prev position-absolute top-50 start-0 translate-middle-y"
                    type="button"
                    data-bs-target="#carouselRecipe"
                    data-bs-slide="prev">
                    <span className="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span className="visually-hidden">Previous</span>
                </button>
                <button
                    className="carousel-control-next position-absolute top-50 end-0 translate-middle-y"
                    type="button"
                    data-bs-target="#carouselRecipe"
                    data-bs-slide="next">
                    <span className="carousel-control-next-icon" aria-hidden="true"></span>
                    <span className="visually-hidden">Next</span>
                </button>
            </div>
        </>
    );
}