import { createStore, combineReducers, applyMiddleware} from "redux";
import { fetchContentReducer,fetchLanguagesReducer } from "./reducers";
import thunk from "redux-thunk";
import {composeWithDevTools} from "redux-devtools-extension";

const reducers = combineReducers({
    content: fetchContentReducer,
    languages: fetchLanguagesReducer,
})

const store = createStore(reducers,composeWithDevTools(applyMiddleware(thunk)));

export default store;