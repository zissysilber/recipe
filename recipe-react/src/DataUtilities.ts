import { ICuisine } from "./DataInterfaces";
const baseurl = "https://zsrecipeapi.azurewebsites.net/api/"

async function fetchData<T>(url: string): Promise<T> {
    url = baseurl + url;
    const r = await fetch(url);
    const data = await r.json();
    return data;
}

export async function fetchCuisine() {
    return await fetchData<ICuisine[]>("cuisine");
}