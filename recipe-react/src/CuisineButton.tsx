
import { ICuisine } from "./DataInterfaces";

interface Props {
    cuisine: ICuisine,
    isSelected: boolean,
    onSelected: (cuisineName: string) => void
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {

    return (
        <div onClick={() => onSelected(cuisine.cuisineName)}
            className={`btn d-flex flex-column  justify-content-center gy-1 ${isSelected ? "bg-secondary" : ""} cuisine-button`}>
            <figure className="figure d-flex flex-column  justify-content-between align-items-center" key={cuisine.cuisineId}>
                <img src={`/images/Cuisine/${cuisine.cuisineName}.png`} className="figure-img img-fluid rounded" alt={`${cuisine.cuisineName} image`} />
                <figcaption className="figure-caption text-center">{cuisine.cuisineName}</figcaption>
            </figure>
        </div>
    )
}

