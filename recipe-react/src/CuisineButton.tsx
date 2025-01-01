
import { ICuisine } from "./DataInterfaces";

interface Props {
    cuisine: ICuisine,
    isSelected: boolean,
    onSelected: (partyId: number) => void
}

export default function CuisineButton({ cuisine, isSelected, onSelected }: Props) {

    return (
        <div onClick={() => onSelected(cuisine.cuisineId)} className={`btn ${isSelected ? "bg-secondary" : ""}`}>
            <figure className="figure" key={cuisine.cuisineId}>
                <img src={`/public/images/Cuisine/${cuisine.cuisineName}.png`} className="figure-img img-fluid rounded" alt="..." />
                <figcaption className="figure-caption text-center">{cuisine.cuisineName}</figcaption>
            </figure>
        </div>
    )
}