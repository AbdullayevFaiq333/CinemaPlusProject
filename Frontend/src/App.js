import Header from "./components/Header";
import Platinum from "./components/Platinum";
import DolbyAtmos from "./components/DolbyAtmos";
import Services from "./components/Services";
import Footer from "./components/Footer";
import HomePage from "./components/HomePage";
import {Route,Switch} from "react-router-dom";
import { Suspense } from "react";


function App() {
  
  return (
    <div>
      
      <Header/>
      <Suspense fallback={<div>Loading</div>}>
        <Switch>
          <Route path="/" exact component={HomePage} />
          <Route path="/platinum" component={Platinum} />
          <Route path="/dolbyatmos" component={DolbyAtmos} />
          <Route path="/services" component={Services} />
        </Switch>
      </Suspense>
      <Footer/>
      
      
    </div>
  );
}

export default App;
