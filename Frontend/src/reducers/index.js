import {
  FETCH_CONTENT_NAVBAR,
  FETCH_CONTENT_NAVBAR_SUCCESS,
  FETCH_CONTENT_NAVBAR_FAIL,
  FETCH_CONTENT_PLATINUM,
  FETCH_CONTENT_PLATINUM_SUCCESS,
  FETCH_CONTENT_PLATINUM_FAIL,
  FETCH_CONTENT_DOLBYATMOS,
  FETCH_CONTENT_DOLBYATMOS_SUCCESS,
  FETCH_CONTENT_DOLBYATMOS_FAIL,
  FETCH_CONTENT_SERVICE,
  FETCH_CONTENT_SERVICE_SUCCESS,
  FETCH_CONTENT_SERVICE_FAIL,
  FETCH_CONTENT_FOOTER,
  FETCH_CONTENT_FOOTER_SUCCESS,
  FETCH_CONTENT_FOOTER_FAIL,
  FETCH_CONTENT_SOCIALMEDIA,
  FETCH_CONTENT_SOCIALMEDIA_SUCCESS,
  FETCH_CONTENT_SOCIALMEDIA_FAIL,
  FETCH_CONTENT_ADVERTISEMENT,
  FETCH_CONTENT_ADVERTISEMENT_SUCCESS,
  FETCH_CONTENT_ADVERTISEMENT_FAIL,
  FETCH_CONTENT_SECONDFOOTER,
  FETCH_CONTENT_SECONDFOOTER_SUCCESS,
  FETCH_CONTENT_SECONDFOOTER_FAIL,
  FETCH_CONTENT_NEWS,
  FETCH_CONTENT_NEWS_SUCCESS,
  FETCH_CONTENT_NEWS_FAIL,
  FETCH_CONTENT_FAQ,
  FETCH_CONTENT_FAQ_SUCCESS,
  FETCH_CONTENT_FAQ_FAIL,
  FETCH_CONTENT_CAMPAIGNS,
  FETCH_CONTENT_CAMPAIGNS_SUCCESS,
  FETCH_CONTENT_CAMPAIGNS_FAIL,
  FETCH_CONTENT_CAMPAIGNDETAIL,
  FETCH_CONTENT_CAMPAIGNDETAIL_SUCCESS,
  FETCH_CONTENT_CAMPAIGNDETAIL_FAIL,
  FETCH_CONTENT_CONTACT,
  FETCH_CONTENT_CONTACT_SUCCESS,
  FETCH_CONTENT_CONTACT_FAIL,
  FETCH_CONTENT_TARIFF,
  FETCH_CONTENT_TARIFF_SUCCESS,
  FETCH_CONTENT_TARIFF_FAIL,
  FETCH_CONTENT_MOVIE,
  FETCH_CONTENT_MOVIE_SUCCESS,
  FETCH_CONTENT_MOVIE_FAIL,
  FETCH_CONTENT_MOVIEDETAIL,
  FETCH_CONTENT_MOVIEDETAIL_SUCCESS,
  FETCH_CONTENT_MOVIEDETAIL_FAIL,
  FETCH_CONTENT_BRANCH,
  FETCH_CONTENT_BRANCH_SUCCESS,
  FETCH_CONTENT_BRANCH_FAIL,
  FETCH_CONTENT_SESSION,
  FETCH_CONTENT_SESSION_SUCCESS,
  FETCH_CONTENT_SESSION_FAIL,
  FETCH_CONTENT_ROW,
  FETCH_CONTENT_ROW_SUCCESS,
  FETCH_CONTENT_ROW_FAIL,
  FETCH_LANGUAGES,
  FETCH_LANGUAGES_SUCCESS,
  FETCH_LANGUAGES_FAIL,
} from "../constants";

export const fetchLanguagesReducer = (
  state = { loading: true, languages: [] },
  action
) => {
  switch (action.type) {
    case FETCH_LANGUAGES:
      return {
        ...state,
        loading: true,
      };
    case FETCH_LANGUAGES_SUCCESS:
      return {
        ...state,
        languages: action.payload,
        loading: false,
      };
    case FETCH_LANGUAGES_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentNavbarReducer = (
  state = { loading: true, content: {} },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_NAVBAR:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_NAVBAR_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_NAVBAR_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentPlatinumReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_PLATINUM:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_PLATINUM_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_PLATINUM_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentDolbyAtmosReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_DOLBYATMOS:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_DOLBYATMOS_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_DOLBYATMOS_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentServiceReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_SERVICE:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_SERVICE_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_SERVICE_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentFooterReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_FOOTER:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_FOOTER_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_FOOTER_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentSocialMediaReducer = (
  state = { loading: true, socialMedia: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_SOCIALMEDIA:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_SOCIALMEDIA_SUCCESS:
      return {
        ...state,
        socialMedia: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_SOCIALMEDIA_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentAdvertisementReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_ADVERTISEMENT:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_ADVERTISEMENT_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_ADVERTISEMENT_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentSecondFooterReducer = (
  state = { loading: true, secondFooter: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_SECONDFOOTER:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_SECONDFOOTER_SUCCESS:
      return {
        ...state,
        secondFooter: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_SECONDFOOTER_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentNewsReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_NEWS:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_NEWS_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_NEWS_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentFAQReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_FAQ:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_FAQ_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_FAQ_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentCampaignsReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_CAMPAIGNS:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_CAMPAIGNS_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_CAMPAIGNS_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentCampaignDetailReducer = (
  state = { loading: true, content: {} },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_CAMPAIGNDETAIL:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_CAMPAIGNDETAIL_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_CAMPAIGNDETAIL_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentContactReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_CONTACT:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_CONTACT_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_CONTACT_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentTariffReducer = (
  state = { loading: true, content: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_TARIFF:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_TARIFF_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_TARIFF_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentMovieReducer = (
  state = { loading: true, movie: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_MOVIE:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_MOVIE_SUCCESS:
      return {
        ...state,
        movie: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_MOVIE_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentMovieWidthIdReducer = (
  state = { loading: true, movieWidthId: {} },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_MOVIE:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_MOVIE_SUCCESS:
      return {
        ...state,
        movieWidthId: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_MOVIE_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentMovieDetailReducer = (
  state = { loading: true, content: {} },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_MOVIEDETAIL:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_MOVIEDETAIL_SUCCESS:
      return {
        ...state,
        content: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_MOVIEDETAIL_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentBranchReducer = (
  state = { loading: true, branch: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_BRANCH:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_BRANCH_SUCCESS:
      return {
        ...state,
        branch: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_BRANCH_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentSessionReducer = (
  state = { loading: true, session: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_SESSION:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_SESSION_SUCCESS:
      return {
        ...state,
        session: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_SESSION_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};

export const fetchContentRowReducer = (
  state = { loading: true, row: [] },
  action
) => {
  switch (action.type) {
    case FETCH_CONTENT_ROW:
      return {
        ...state,
        loading: true,
      };
    case FETCH_CONTENT_ROW_SUCCESS:
      return {
        ...state,
        row: action.payload,
        loading: false,
      };
    case FETCH_CONTENT_ROW_FAIL:
      return {
        ...state,
        error: action.payload,
        loading: false,
      };
    default:
      return state;
  }
};
