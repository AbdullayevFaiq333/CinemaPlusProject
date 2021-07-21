import { FETCH_CONTENT,FETCH_CONTENT_SUCCESS,FETCH_CONTENT_FAIL,FETCH_LANGUAGES,FETCH_LANGUAGES_SUCCESS,FETCH_LANGUAGES_FAIL } from "../constants";
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

export const fetchContent = (languageCode = "AZ") => async (dispatch) => {
    dispatch({type: FETCH_CONTENT});

    try {
        const response = await api.get(`Content/getContentWebsite/${languageCode}`);

        dispatch({type: FETCH_CONTENT_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_CONTENT_FAIL,payload: e.message ? e.message : e});
    }
}