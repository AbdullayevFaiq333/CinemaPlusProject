import Header from "./components/Header";
import Platinum from "./components/Platinum";
import DolbyAtmos from "./components/DolbyAtmos";
import Services from "./components/Services";
import Campaigns from "./components/Campaigns";
import CampaignDetail from "./components/CampaignDetail";
import Footer from "./components/Footer";
import HomePage from "./components/HomePage";
import CinemaClub from "./components/CinemaClub";
import FAQ from "./components/FAQ";
import Rules from "./components/Rules";
import Vacancies from "./components/Vacancies";
import Contacts from "./components/Contacts";
import Tariffs from "./components/Tariffs";
import AboutUs from "./components/AboutUs";
import MovieDetail from "./components/MovieDetail";
import Hall from "./components/Hall";


import {Route,Switch} from "react-router-dom";
import { Suspense, useState } from "react";
import "slick-carousel/slick/slick.css"; 
import "slick-carousel/slick/slick-theme.css";
import * as ReactBootstrap from "react-bootstrap"




function App() {
  const [lyricsItem,setLyricsItem]=useState(null);
  const [loading,setLoading]=useState(false);

  return (
    <div>
      
      <Header/>
      <Suspense >
        <Switch>
          <Route path="/" exact component={HomePage} />
          <Route path="/platinum" component={Platinum} />
          <Route path="/dolbyatmos" component={DolbyAtmos} />
          <Route path="/services" component={Services} />
          <Route path="/aboutUs" exact component={AboutUs} />
          <Route path="/campaigns" component={Campaigns} />
          <Route path="/campaign/:id" component={CampaignDetail} />
          <Route path="/cineClub" component={CinemaClub} />
          <Route path="/faq" component={FAQ} />
          <Route path="/rules" component={Rules} />
          <Route path="/vacancies" component={Vacancies} />
          <Route path="/contacts" component={Contacts} />
          <Route path="/tariffs" component={Tariffs} />
          <Route path="/hall" component={Hall} />
          
          <Route path="/movie/:id" component={MovieDetail} />
        </Switch>
      </Suspense>
      <Footer/>
      
      
    </div>
  );
}

export default App;
