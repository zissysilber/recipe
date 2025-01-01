export default function NavBar() {
    return (
        <>
            <nav className="navbar  navbar-expand-lg bd-navbar sticky-top bg-light w-100" data-bs-theme="light">
                <div className="container-fluid">
                    <a className="navbar-brand" href="#">
                        <img src="/public/images/HeartyHearth.png" width="100" className="d-inline-block pe-3" />
                        Hearty Hearth</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor03" aria-controls="navbarColor03" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarColor03">
                        <ul className="navbar-nav me-auto">
                            <li className="nav-item">
                                <a className="nav-link active" href="#">Recipes
                                    <span className="visually-hidden">(current)</span>
                                </a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Meals</a>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">Cookbooks</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
        </>
    )
}