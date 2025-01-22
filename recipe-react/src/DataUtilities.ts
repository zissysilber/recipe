import { FieldValues } from "react-hook-form";
import { ICuisine, IRecipe, IUsers } from "./DataInterfaces";
let baseurl = import.meta.env.VITE_API_URL;

async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

async function postData<T>(url: string, form: FieldValues): Promise<{ status: number; data: T }> {
    url = baseurl + url;
    const r = await fetch(url, {
        method: "POST",
        body: JSON.stringify(form),
        headers: {
            "Content-Type": "application/json"
        },
    });
    const data = await r.json();
    return {
        status: r.status,
        data: data,
    };
}

async function deleteData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url, { method: "DELETE" });
    const data = await r.json();
    return data;
}

export async function fetchCuisine() {
    return await fetchData<ICuisine[]>("cuisine");
}

export async function fetchRecipeByCuisine(cuisineName: string) {
    const data = await fetchData<IRecipe[]>(`Recipe/GetByCuisine/${cuisineName}`);
    return data;
}

export async function fetchUsers() {
    const data = await fetchData<IUsers[]>("Recipe/users");
    return data;
}

export async function postRecipe(form: FieldValues) {
    return postData<IRecipe>("Recipe", form);
}

export async function deleteRecipe(recipeId: number) {
    return deleteData<IRecipe>(`recipe?id=${recipeId}`)
}

export const blankRecipe: IRecipe = {
    recipeId: 0,
    recipeName: "",
    cuisineId: 0,
    cuisineName: "",
    usersId: 0,
    usersName: "",
    calories: 0,
    vegan: false,
    ingredientList: [{
        ingredientName: "",
        measurementName: "",
        measurementAmt: 0
    }],
    directionList: [{
        directionSequence: 0,
        directionDesc: ""
    }],
    errorMessage: ""
}

