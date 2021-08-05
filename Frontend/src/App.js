import Header from "./components/Header";
import Platinum from "./components/Platinum";
import DolbyAtmos from "./components/DolbyAtmos";
import Services from "./components/Services";
import Campaigns from "./components/Campaigns";
import Footer from "./components/Footer";
import HomePage from "./components/HomePage";
import CinemaClub from "./components/CinemaClub";
import FAQ from "./components/FAQ";
import Rules from "./components/Rules";

import {Route,Switch} from "react-router-dom";
import { Suspense } from "react";
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";


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
          <Route path="/campaigns" component={Campaigns} />
          <Route path="/cineClub" component={CinemaClub} />
          <Route path="/faq" component={FAQ} />
          <Route path="/rules" component={Rules} />
        </Switch>
      </Suspense>
      <Footer/>
      
      
    </div>
  );
}

export default App;
