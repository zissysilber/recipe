import { useEffect, useState } from "react"
import { ICuisine } from "./DataInterfaces"
import { fetchCuisine } from "./DataUtilities";
import CuisineButton from "./CuisineButton";

interface Props {
    onCuisineSelected: (cuisineName: string) => void
}

function Sidebar({ onCuisineSelected }: Props) {
    const [cuisineList, setCuisineList] = useState<ICuisine[]>([]);
    const [selectedCuisineName, setSelectedCuisineName] = useState("English");

    useEffect(() => {
        const fetchdata = async () => {
            const data = await fetchCuisine();
            setCuisineList(data);
            if (data.length > 0) {
                handleSelectedCuisine(data[0].cuisineName);
            }
        }
        fetchdata();
    }
        , []);

    function handleSelectedCuisine(cuisineName: string) {
        setSelectedCuisineName(cuisineName);
        onCuisineSelected(cuisineName);
    }
    return (
        <div>
            <h2> Cuisine</h2>
            <div className="flex align-items-center">
                <div className="row d-flex flex-column flex-sm-row flex-lg-column justify-content-between align-items-center">
                    {cuisineList.map(c =>
                        <div className="col-6 col-lg-6 col-sm-2 col-md-2 mb-3 d-flex  "
                            key={c.cuisineId}
                        >
                            <CuisineButton key={c.cuisineId} cuisine={c} onSelected={handleSelectedCuisine} isSelected={c.cuisineName == selectedCuisineName} />
                        </div>)}
                </div>
            </div>
        </div>
    )
}

export default Sidebar;