import './assets/css/bootstrap.min.css'
import './assets/css/App.css'
import Navbar from './Navbar'
import Sidebar from './Sidebar'

function App() {
  return (

    <div className="container-flex">
      <div className="row">
        <div className="col-12">
          <Navbar />
        </div>
        <div className="col-3">
          <Sidebar />
        </div>

      </div>
    </div>

  )
}

export default App
