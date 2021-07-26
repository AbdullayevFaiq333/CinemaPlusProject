import Header from "./components/Header";
import Platinum from "./components/Platinum";
import DolbyAtmos from "./components/DolbyAtmos";
import {Route,Switch,Link} from "react-router-dom";

function App() {
  return (
    <div>
      
      <Header />
      <Switch>
        <Route path="/platinum" component={Platinum} />
        <Route path="/dolbyatmos" component={DolbyAtmos} />
      </Switch>
      
    </div>
  );
}

export default App;
