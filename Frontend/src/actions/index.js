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
  FETCH_CONTENT_HALL,
  FETCH_CONTENT_HALL_SUCCESS,
  FETCH_CONTENT_HALL_FAIL,
  FETCH_LANGUAGES,
  FETCH_LANGUAGES_SUCCESS,
  FETCH_LANGUAGES_FAIL,
} from "../constants";
import api from "../api";

export const fetchLanguages = () => async (dispatch) => {
  dispatch({ type: FETCH_LANGUAGES });

  try {
    const response = await api.get("Language");

    dispatch({ type: FETCH_LANGUAGES_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_LANGUAGES_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentNavbar =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_NAVBAR });

    try {
      const response = await api.get(
        `Content/getContentWebsiteNavbar/${languageCode}`
      );
      dispatch({ type: FETCH_CONTENT_NAVBAR_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_NAVBAR_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentPlatinum =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_PLATINUM });

    try {
      const response = await api.get(
        `Content/getContentWebsitePlatinium/${languageCode}`
      );

      dispatch({
        type: FETCH_CONTENT_PLATINUM_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_PLATINUM_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentDolbyAtmos =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_DOLBYATMOS });

    try {
      const response = await api.get(
        `Content/getContentWebsiteDolbyAtmos/${languageCode}`
      );

      dispatch({
        type: FETCH_CONTENT_DOLBYATMOS_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_DOLBYATMOS_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentService =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_SERVICE });

    try {
      const response = await api.get(
        `Content/getContentWebsiteService/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_SERVICE_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_SERVICE_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentFooter =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_FOOTER });

    try {
      const response = await api.get(
        `Content/getContentWebsiteFooter/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_FOOTER_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_FOOTER_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentSocialMedia = () => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_SOCIALMEDIA });

  try {
    const response = await api.get(`SocialMedia`);

    dispatch({
      type: FETCH_CONTENT_SOCIALMEDIA_SUCCESS,
      payload: response.data,
    });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_SOCIALMEDIA_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentAdvertisement = () => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_ADVERTISEMENT });

  try {
    const response = await api.get(`Advertisement`);

    dispatch({
      type: FETCH_CONTENT_ADVERTISEMENT_SUCCESS,
      payload: response.data,
    });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_ADVERTISEMENT_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentSecondFooter =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_SECONDFOOTER });

    try {
      const response = await api.get(
        `Content/getContentWebsiteSecondFooter/${languageCode}`
      );

      dispatch({
        type: FETCH_CONTENT_SECONDFOOTER_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_SECONDFOOTER_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentNews =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_NEWS });

    try {
      const response = await api.get(
        `Content/getContentWebsiteNews/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_NEWS_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_NEWS_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentFAQ =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_FAQ });

    try {
      const response = await api.get(
        `Content/getContentWebsiteFAQ/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_FAQ_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_FAQ_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentCampaigns =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_CAMPAIGNS });

    try {
      const response = await api.get(
        `Content/getContentWebsiteCampaign/${languageCode}`
      );

      dispatch({
        type: FETCH_CONTENT_CAMPAIGNS_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_CAMPAIGNS_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentCampaignDetail =
  (id, languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_CAMPAIGNDETAIL });

    try {
      const response = await api.get(
        `Content/getContentWebsiteCampaignDetail/${languageCode}/${id}`
      );

      dispatch({
        type: FETCH_CONTENT_CAMPAIGNDETAIL_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_CAMPAIGNDETAIL_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentContact = () => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_CONTACT });

  try {
    const response = await api.get(`Contact`);

    dispatch({ type: FETCH_CONTENT_CONTACT_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_CONTACT_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentTariff = () => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_TARIFF });

  try {
    const response = await api.get(`Tariff`);

    dispatch({ type: FETCH_CONTENT_TARIFF_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_TARIFF_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentMovie =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_MOVIE });

    try {
      const response = await api.get(
        `Content/getContentWebsiteMovie/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_MOVIE_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_MOVIE_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentMovieWidthId = (id) => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_MOVIE });

  try {
    const response = await api.get(
      `Content/getContentWebsiteMovieWidthId/${id}`
    );

    dispatch({ type: FETCH_CONTENT_MOVIE_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_MOVIE_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentMovieDetail =
  (id, languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_MOVIEDETAIL });

    try {
      const response = await api.get(
        `Content/getContentWebsiteMovieDetail/${languageCode}/${id}`
      );

      dispatch({
        type: FETCH_CONTENT_MOVIEDETAIL_SUCCESS,
        payload: response.data,
      });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_MOVIEDETAIL_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentBranch =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_BRANCH });

    try {
      const response = await api.get(
        `Content/getContentWebsiteBranch/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_BRANCH_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_BRANCH_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };

export const fetchContentSession = () => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_SESSION });

  try {
    const response = await api.get(`Session`);

    dispatch({ type: FETCH_CONTENT_SESSION_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_SESSION_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentRow = (id) => async (dispatch) => {
  dispatch({ type: FETCH_CONTENT_ROW });

  try {
    const response = await api.get(`Row/${id}`);

    dispatch({ type: FETCH_CONTENT_ROW_SUCCESS, payload: response.data });
  } catch (e) {
    dispatch({
      type: FETCH_CONTENT_ROW_FAIL,
      payload: e.message ? e.message : e,
    });
  }
};

export const fetchContentHall =
  (languageCode = "AZ") =>
  async (dispatch) => {
    dispatch({ type: FETCH_CONTENT_HALL });

    try {
      const response = await api.get(
        `Content/getContentWebsiteHall/${languageCode}`
      );

      dispatch({ type: FETCH_CONTENT_HALL_SUCCESS, payload: response.data });
    } catch (e) {
      dispatch({
        type: FETCH_CONTENT_HALL_FAIL,
        payload: e.message ? e.message : e,
      });
    }
  };
