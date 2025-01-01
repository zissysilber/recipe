import { useEffect, useState } from "react"
import { ICuisine } from "./DataInterfaces"
import { fetchCuisine } from "./DataUtilities";
import CuisineButton from "./CuisineButton";

function Sidebar() {
    const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisineId, setSelectedCuisineId] = useState(0);

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisine();
            setCuisineList(data);
            if (data.length > 0) {
                handleSelectedCuisine(data[0].cuisineId);
            }
        }
        fetchdata();
    }
        , []);

    function handleSelectedCuisine(cuisineId: number) {
        setSelectedCuisineId(cuisineId);
    }
    return (
        <>
            <h2>{cuisineList.map(c =>
                <CuisineButton key={c.cuisineId} cuisine={c} onSelected={handleSelectedCuisine} isSelected={c.cuisineId == selectedCuisineId} />)}</h2>
        </>
    )
}

export default Sidebar;