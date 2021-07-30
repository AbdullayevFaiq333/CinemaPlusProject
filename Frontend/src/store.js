import { createStore, combineReducers, applyMiddleware} from "redux";
import { fetchContentNavbarReducer,fetchLanguagesReducer,fetchContentPlatinumReducer,
         fetchContentDolbyAtmosReducer,fetchContentServiceReducer,fetchContentFooterReducer,
         fetchContentSocialMediaReducer,fetchContentAdvertisementReducer } from "./reducers";
import thunk from "redux-thunk";
import {composeWithDevTools} from "redux-devtools-extension";

const reducers = combineReducers({
    contentNavbar: fetchContentNavbarReducer,
    languages: fetchLanguagesReducer,
    contentPlatinum: fetchContentPlatinumReducer,
    contentDolbyAtmos:fetchContentDolbyAtmosReducer,
    contentService:fetchContentServiceReducer,
    contentFooter:fetchContentFooterReducer,
    socialMedia:fetchContentSocialMediaReducer,
    advertisement:fetchContentAdvertisementReducer,
})

const store = createStore(reducers,composeWithDevTools(applyMiddleware(thunk)));

export default store;