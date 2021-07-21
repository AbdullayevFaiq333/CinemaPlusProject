import { FETCH_CONTENT,FETCH_CONTENT_SUCCESS,FETCH_CONTENT_FAIL,FETCH_LANGUAGES,FETCH_LANGUAGES_SUCCESS,FETCH_LANGUAGES_FAIL } from "../constants";

export const fetchLanguagesReducer = (state = {loading: true,languages: []},action) => {
    switch (action.type) {
        case FETCH_LANGUAGES:
            return {
                ...state,
                loading: true
            }
        case FETCH_LANGUAGES_SUCCESS:
            return {
                ...state,
                languages: action.payload,
                loading: false
            }
        case FETCH_LANGUAGES_FAIL:
            return {
                ...state,
                error: action.payload,
                loading: false
            }
        default:
            return state;
    }
}

export const fetchContentReducer = (state = {loading: true,content : {}},action) => {
    switch (action.type) {
        case FETCH_CONTENT:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}