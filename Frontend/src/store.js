import { createStore, combineReducers, applyMiddleware} from "redux";
import { fetchContentNavbarReducer,fetchLanguagesReducer,fetchContentPlatinumReducer,fetchContentDolbyAtmosReducer } from "./reducers";
import thunk from "redux-thunk";
import {composeWithDevTools} from "redux-devtools-extension";

const reducers = combineReducers({
    contentNavbar: fetchContentNavbarReducer,
    languages: fetchLanguagesReducer,
    contentPlatinum: fetchContentPlatinumReducer,
    contentDolbyAtmos:fetchContentDolbyAtmosReducer,
})

const store = createStore(reducers,composeWithDevTools(applyMiddleware(thunk)));

export default store;