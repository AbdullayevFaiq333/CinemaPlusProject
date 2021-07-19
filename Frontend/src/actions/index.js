import { FETCH_CONTENT,FETCH_CONTENT_SUCCESS,FETCH_CONTENT_FAIL } from "../constants";
import api from "../api"


export const fetchContent = (code = "AZ") => async (dispatch) => {
    dispatch({type: FETCH_CONTENT});

    try {
        let response = await api.get(`Content/getContentWebsite/${code}`);

        dispatch({type: FETCH_CONTENT_SUCCESS,payload: response.data});
    } catch (e) {
        dispatch({type: FETCH_CONTENT_FAIL,payload: e ? e.message : e});
    }
}