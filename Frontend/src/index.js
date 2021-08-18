import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router } from 'react-router-dom';
import "./scss/index.scss";
import "bootstrap/dist/css/bootstrap.min.css";
import SimpleReactLightbox from 'simple-react-lightbox';
import { Provider } from 'react-redux';
import App from './App';
import store from "./store"

ReactDOM.render(
  <React.StrictMode>
    <SimpleReactLightbox>
    <Router>
    <Provider store={store}>
      <App />
    </Provider>
    </Router>
    </SimpleReactLightbox>
  </React.StrictMode>,
  document.getElementById('root')
);


