import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import './assets/css/App.css'
import Navbar from './Navbar'
import Sidebar from './Sidebar'
import MainScreen from './MainScreen'
import { useState } from 'react'
import { RecipeEdit } from './RecipeEdit';
import { blankRecipe } from './DataUtilities';
import { IRecipe } from './DataInterfaces';

function App() {
  const [selectedCuisineName, setSelectedCuisineName] = useState("");
  const [isRecipeEdit, setIsRecipeEdit] = useState(false);
  const [recipeForEdit, setRecipeForEdit] = useState(blankRecipe);

  const handleCuisineSelected = (cuisineName: string) => {
    setSelectedCuisineName(cuisineName);
    setIsRecipeEdit(false);
  }

  const handleRecipeSelectedForEdit = (recipe: IRecipe) => {
    setRecipeForEdit(recipe);
    setIsRecipeEdit(true);
  }

  const handleMessageClose = () => {
    setIsRecipeEdit(false);
  }
  return (
    <div className="container-flex">
      <div className="row">
        <div className="col-12">
          <Navbar />
        </div>
      </div>
      <div className="container m-5">
        <div className='row d-flex justify-content-between'>
          <div className="col-12 col-lg-3 justify-content-between">
            <Sidebar onCuisineSelected={handleCuisineSelected} />
          </div>
          <div className='col-12 col-lg-9'>
            {isRecipeEdit ? <RecipeEdit recipe={recipeForEdit} onMessageClose={handleMessageClose} /> :
              <MainScreen cuisineName={selectedCuisineName} onRecipeSelectedForEdit={handleRecipeSelectedForEdit} />
            }
            <div className='mt-5'>
              <button onClick={() => handleRecipeSelectedForEdit(blankRecipe)} className="btn btn-primary">Add New Recipe</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  )
}

export default App
