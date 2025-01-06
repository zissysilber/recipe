import './assets/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import './assets/css/App.css'
import Navbar from './Navbar'
import Sidebar from './Sidebar'
import MainScreen from './MainScreen'
import { useState } from 'react'

function App() {
  const [selectedCuisineName, setSelectedCuisineName] = useState("");
  const handleCuisineSelected = (cuisineName: string) => {
    setSelectedCuisineName(cuisineName);
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
            <MainScreen cuisineName={selectedCuisineName} />
          </div>
        </div>

      </div>
    </div>

  )
}

export default App
