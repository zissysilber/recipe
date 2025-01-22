import './assets/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import { FieldValues, useForm } from "react-hook-form";
import { ICuisine, IRecipe, IUsers } from "./DataInterfaces"
import { useEffect, useState } from "react";
import { blankRecipe, deleteRecipe, fetchCuisine, fetchUsers, postRecipe } from "./DataUtilities";
import { MessageBox } from "./MessageBox";

interface Props {
    recipe: IRecipe;
    onMessageClose: () => void
}

export function RecipeEdit({ recipe, onMessageClose }: Props) {

    const { register, handleSubmit, reset } = useForm({ defaultValues: recipe });
    const [cuisine, setCuisine] = useState<ICuisine[]>([]);
    const [users, setUsers] = useState<IUsers[]>([]);
    const [errormsg, setErrorMsg] = useState("");
    const [msgClass, setMsgClass] = useState<string>("");
    const [showMessageBox, setShowMessagebox] = useState(false);


    useEffect(() => {
        const fetchdata = async () => {
            const dataCuisine = await fetchCuisine();
            setCuisine(dataCuisine);
            const dataUsers = await fetchUsers();
            setUsers(dataUsers);
            console.log('Fetched recipe:', recipe);
            reset(recipe);
        }
        fetchdata();
    }, [recipe, reset]);


    const submitForm = async (data: FieldValues) => {
        try {
            const { status, data: r } = await postRecipe(data);
            setErrorMsg(r.errorMessage);
            setMsgClass(status === 200 ? "success" : "error");
            setShowMessagebox(true);
            reset(r);
        } catch (error: any) {
            const errorMessage = error.message;
            setErrorMsg(errorMessage);
            setMsgClass("error");
            setShowMessagebox(true);
        }
    };

    const handleDelete = async () => {
        try {
            const r = await deleteRecipe(recipe.recipeId);
            if (r.errorMessage === "") {
                setErrorMsg("Recipe deleted successfully");
                setMsgClass("success");
                reset(blankRecipe);
            } else {
                setErrorMsg(r.errorMessage);
                setMsgClass("error");
            }
            setShowMessagebox(true);
        }
        catch (error: any) {
            setErrorMsg(error.message);
            setMsgClass("error");
            setShowMessagebox(true);
        }
    }

    const handleMessageBoxClose = () => {
        setShowMessagebox(false);
        onMessageClose();
    }

    return (
        <div className="container bg-light mt-4 p-4">
            {showMessageBox && (
                <div>
                    <MessageBox message={errormsg} msgClassName={msgClass} onClose={handleMessageBoxClose} />
                </div>
            )}
            <div className="row">
                <div className="col-12">
                    <form onSubmit={handleSubmit(submitForm)} className="needs-validation">
                        <div className="mb-3">
                            <input type="hidden" {...register("recipeId")} id="recipeId" className="form-control" required />

                            <label htmlFor="recipeName" className="form-label">Recipe Name:</label>
                            <input type="text" {...register("recipeName")} className="form-control" id="recipeName" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="cuisineId" id="cuisineId" className="form-label">Cuisine Name:  </label>
                            <select {...register("cuisineId")} className="form-select" id="cuisineId">
                                {cuisine.map(c => <option key={c.cuisineId} value={c.cuisineId}>{c.cuisineName}</option>)}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="usersId" className="form-label">User Name:</label>
                            <select {...register("usersId")} className="form-select" id="usersId">
                                {users.map(u => <option key={u.usersId} value={u.usersId}>{u.usersName}</option>)}
                            </select>
                        </div>

                        <div className="mb-3">
                            <label htmlFor="calories" className="form-label">Calories:</label>
                            <input type="number" {...register("calories")} className="form-control" id="calories" required />
                        </div>

                        <div className="mb-3">
                            <label htmlFor="vegan" className="form-label">Vegan:</label>
                            <input type="checkbox" {...register("vegan")} className="form-check-input" id="vegan" />
                        </div>
                        <div className="mb-3">
                            <button type="submit" className="btn btn-primary me-2">Submit</button>
                            <button type="button" id="btndelete" onClick={handleDelete} className="btn btn-danger">Delete</button>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    )
}