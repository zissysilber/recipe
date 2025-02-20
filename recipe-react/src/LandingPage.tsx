import { Link } from "react-router-dom";

export default function LandingPage() {
    const backgroundImageUrl = '/images/landingPageNoText.jpg';

    return (
        <div className="landing-page p-0" style={{ backgroundImage: `url(${backgroundImageUrl})` }}>
            <div className="text-overlay">
                <div>
                    <h1 className="fw-bold shadow-text">GOOD FOOD</h1>
                    <h2 className="fw-bold shadow-text mb-5">STARTS HERE</h2>
                    <hr
                    // className="my-4 border-top border-5 border-dark mb-5" 
                    />
                    <div className="container">
                        <div className="row justify-content-center m-2">
                            <div className="col-auto">
                                <Link to="/recipes">
                                    <button type="button" className="btn btn-lg btn-light btn-outline-dark fs-4 p-3">Explore Recipes</button>
                                </Link>
                            </div>
                            <div className="col-auto">
                                <Link to="/meals">
                                    <button type="button" className="btn btn-lg btn-light btn-outline-dark fs-4 p-3">Explore Meals</button>
                                </Link>
                            </div>
                            <div className="col-auto">
                                <Link to="/cookbooks">
                                    <button type="button" className="btn btn-lg btn-light btn-outline-dark fs-4 p-3">Explore Cookbooks</button>
                                </Link>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    )
}
