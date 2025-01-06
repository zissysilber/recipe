
import { ICuisine } from "./DataInterfaces";

interface Props {
    cuisine: ICuisine,
    isSelected: boolean,
    onSelected: (cuisineName: string) => void
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {

    return (
        <div onClick={() => onSelected(cuisine.cuisineName)}
            className={`btn d-flex flex-column align-items-center justify-content-between gy-1 ${isSelected ? "bg-secondary" : ""} cuisine-button`}>
            <figure className="figure d-flex flex-column align-items-center justify-content-between" key={cuisine.cuisineId}>
                <img src={`/public/images/Cuisine/${cuisine.cuisineName}.png`} className="figure-img img-fluid rounded" alt="..." />
                <figcaption className="figure-caption text-center">{cuisine.cuisineName}</figcaption>
            </figure>
        </div>
    )
}