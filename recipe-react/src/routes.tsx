import { createBrowserRouter } from "react-router-dom";
import App from "./App";
import Meals from "./Meals";
import Cookbooks from "./Cookbooks";
import Recipe from "./Recipe";
import LandingPage from "./LandingPage";

const router = createBrowserRouter([
    {
        path: "/", element: <App />, children: [
            { path: "/", element: <LandingPage /> },
            { path: "/recipes", element: <Recipe /> },
            { path: "/meals", element: <Meals /> },
            { path: "/cookbooks", element: <Cookbooks /> }
        ]
    },
])

export default router;