import { createStore, combineReducers, applyMiddleware } from "redux";
import {
  fetchContentNavbarReducer,
  fetchLanguagesReducer,
  fetchContentPlatinumReducer,
  fetchContentDolbyAtmosReducer,
  fetchContentServiceReducer,
  fetchContentFooterReducer,
  fetchContentSocialMediaReducer,
  fetchContentAdvertisementReducer,
  fetchContentSecondFooterReducer,
  fetchContentFAQReducer,
  fetchContentCampaignsReducer,
  fetchContentCampaignDetailReducer,
  fetchContentContactReducer,
  fetchContentMovieReducer,
  fetchContentMovieDetailReducer,
  fetchContentNewsReducer,
  fetchContentTariffReducer,
  fetchContentBranchReducer,
  fetchContentMovieWidthIdReducer,
  fetchContentSessionReducer,
  fetchContentRowReducer,
  fetchContentHallReducer,
  fetchContentSeatReducer,
} from "./reducers";
import thunk from "redux-thunk";
import { composeWithDevTools } from "redux-devtools-extension";

const reducers = combineReducers({
  contentNavbar: fetchContentNavbarReducer,
  languages: fetchLanguagesReducer,
  contentPlatinum: fetchContentPlatinumReducer,
  contentDolbyAtmos: fetchContentDolbyAtmosReducer,
  contentService: fetchContentServiceReducer,
  contentFooter: fetchContentFooterReducer,
  socialMedia: fetchContentSocialMediaReducer,
  advertisement: fetchContentAdvertisementReducer,
  contentSecondFooter: fetchContentSecondFooterReducer,
  contentNews: fetchContentNewsReducer,
  contentFAQ: fetchContentFAQReducer,
  contentCampaigns: fetchContentCampaignsReducer,
  contentCampaignDetail: fetchContentCampaignDetailReducer,
  contact: fetchContentContactReducer,
  contentMovie: fetchContentMovieReducer,
  contentMovieDetail: fetchContentMovieDetailReducer,
  tariff: fetchContentTariffReducer,
  contentBranch: fetchContentBranchReducer,
  movieWidthId: fetchContentMovieWidthIdReducer,
  contentSession: fetchContentSessionReducer,
  row: fetchContentRowReducer,
  contentHall:fetchContentHallReducer,
  seat:fetchContentSeatReducer,
  
});

const store = createStore(
  reducers,
  composeWithDevTools(applyMiddleware(thunk))
);

export default store;
