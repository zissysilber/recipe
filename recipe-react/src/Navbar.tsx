import { NavLink } from "react-router-dom";

export default function NavBar() {
    return (
        <>
            <nav className="navbar navbar-expand-lg bd-navbar sticky-top bg-light w-100" data-bs-theme="light">
                <div className="container-fluid">
                    <NavLink className="navbar-brand" to="/">
                        <img src="/images/HeartyHearth.png" width="100" className="d-inline-block pe-3" alt="HeartyHearthLogo" />
                        Hearty Hearth</NavLink>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor03" aria-controls="navbarColor03" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarColor03">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <NavLink className="nav-link" to="/recipes">
                                    Recipes </NavLink>
                            </li>
                            <li className="nav-item">
                                <NavLink className="nav-link" to="/meals">Meals</NavLink>
                            </li>
                            <li className="nav-item">
                                <NavLink className="nav-link" to="/cookbooks">Cookbooks</NavLink>
                            </li>
                        </ul>

                    </div>
                </div>
            </nav>

        </>
    )
}