import { FETCH_CONTENT_NAVBAR,FETCH_CONTENT_NAVBAR_SUCCESS,FETCH_CONTENT_NAVBAR_FAIL,
         FETCH_CONTENT_PLATINUM,FETCH_CONTENT_PLATINUM_SUCCESS,FETCH_CONTENT_PLATINUM_FAIL,
         FETCH_CONTENT_DOLBYATMOS,FETCH_CONTENT_DOLBYATMOS_SUCCESS,FETCH_CONTENT_DOLBYATMOS_FAIL,
         FETCH_LANGUAGES,FETCH_LANGUAGES_SUCCESS,FETCH_LANGUAGES_FAIL } from "../constants";
import api from "../api"

export const fetchLanguages = () => async (dispatch) => {
    dispatch({type: FETCH_LANGUAGES});

    try {
        const response = await api.get("Language");
        
        dispatch({type: FETCH_LANGUAGES_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_LANGUAGES_FAIL,payload: e.message ? e.message : e});
    }
}

export const fetchContentNavbar = (languageCode = "AZ") => async (dispatch) => {
    dispatch({type: FETCH_CONTENT_NAVBAR});

    try {
        const response = await api.get(`Content/getContentWebsiteNavbar/${languageCode}`);
        dispatch({type: FETCH_CONTENT_NAVBAR_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_CONTENT_NAVBAR_FAIL,payload: e.message ? e.message : e});
    }
}


export const fetchContentPlatinum = (languageCode = "AZ") => async (dispatch) => {
    dispatch({type: FETCH_CONTENT_PLATINUM});

    try {
        const response = await api.get(`Content/getContentWebsitePlatinum/${languageCode}`);

        dispatch({type: FETCH_CONTENT_PLATINUM_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_CONTENT_PLATINUM_FAIL,payload: e.message ? e.message : e});
    }
}


export const fetchContentDolbyAtmos = (languageCode = "AZ") => async (dispatch) => {
    dispatch({type: FETCH_CONTENT_DOLBYATMOS});

    try {
        const response = await api.get(`Content/getContentWebsiteDolbyAtmos/${languageCode}`);

        dispatch({type: FETCH_CONTENT_DOLBYATMOS_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_CONTENT_DOLBYATMOS_FAIL,payload: e.message ? e.message : e});
    }
}