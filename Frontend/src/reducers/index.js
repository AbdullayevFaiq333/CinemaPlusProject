import { FETCH_CONTENT_NAVBAR,FETCH_CONTENT_NAVBAR_SUCCESS,FETCH_CONTENT_NAVBAR_FAIL,
         FETCH_CONTENT_PLATINUM,FETCH_CONTENT_PLATINUM_SUCCESS,FETCH_CONTENT_PLATINUM_FAIL,
         FETCH_LANGUAGES,FETCH_LANGUAGES_SUCCESS,FETCH_LANGUAGES_FAIL } from "../constants";

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

export const fetchContentNavbarReducer = (state = {loading: true,content : {}},action) => {
    switch (action.type) {
        case FETCH_CONTENT_NAVBAR:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_NAVBAR_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_NAVBAR_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentPlatinumReducer = (state = {loading: true,content : {}},action) => {
    switch (action.type) {
        case FETCH_CONTENT_PLATINUM:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_PLATINUM_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_PLATINUM_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}