import { createStore, combineReducers, applyMiddleware} from "redux";
import { fetchContentNavbarReducer,fetchLanguagesReducer,fetchContentPlatinumReducer,
         fetchContentDolbyAtmosReducer,fetchContentServiceReducer,fetchContentFooterReducer,
         fetchContentSocialMediaReducer,fetchContentAdvertisementReducer,fetchContentSecondFooterReducer,
         fetchContentNewsReducer } from "./reducers";
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
    contentSecondFooter:fetchContentSecondFooterReducer,
    contentNews:fetchContentNewsReducer,
})

const store = createStore(reducers,composeWithDevTools(applyMiddleware(thunk)));

export default store;