import { FETCH_CONTENT_NAVBAR,FETCH_CONTENT_NAVBAR_SUCCESS,FETCH_CONTENT_NAVBAR_FAIL,
         FETCH_CONTENT_PLATINUM,FETCH_CONTENT_PLATINUM_SUCCESS,FETCH_CONTENT_PLATINUM_FAIL,
         FETCH_CONTENT_DOLBYATMOS,FETCH_CONTENT_DOLBYATMOS_SUCCESS,FETCH_CONTENT_DOLBYATMOS_FAIL,
         FETCH_CONTENT_SERVICE,FETCH_CONTENT_SERVICE_SUCCESS,FETCH_CONTENT_SERVICE_FAIL,
         FETCH_CONTENT_FOOTER,FETCH_CONTENT_FOOTER_SUCCESS,FETCH_CONTENT_FOOTER_FAIL,
         FETCH_CONTENT_SOCIALMEDIA,FETCH_CONTENT_SOCIALMEDIA_SUCCESS,FETCH_CONTENT_SOCIALMEDIA_FAIL,
         FETCH_CONTENT_ADVERTISEMENT,FETCH_CONTENT_ADVERTISEMENT_SUCCESS,FETCH_CONTENT_ADVERTISEMENT_FAIL,
         FETCH_CONTENT_SECONDFOOTER,FETCH_CONTENT_SECONDFOOTER_SUCCESS,FETCH_CONTENT_SECONDFOOTER_FAIL,
         FETCH_CONTENT_NEWS,FETCH_CONTENT_NEWS_SUCCESS,FETCH_CONTENT_NEWS_FAIL,
         FETCH_CONTENT_FAQ,FETCH_CONTENT_FAQ_SUCCESS,FETCH_CONTENT_FAQ_FAIL,
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


export const fetchContentPlatinumReducer = (state = {loading: true,content : []},action) => {
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


export const fetchContentDolbyAtmosReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_DOLBYATMOS:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_DOLBYATMOS_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_DOLBYATMOS_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentServiceReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_SERVICE:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_SERVICE_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_SERVICE_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentFooterReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_FOOTER:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_FOOTER_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_FOOTER_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentSocialMediaReducer = (state = {loading: true,socialMedia : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_SOCIALMEDIA:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_SOCIALMEDIA_SUCCESS:
            return {
                ...state,
                socialMedia : action.payload,
                loading: false
            }
        case FETCH_CONTENT_SOCIALMEDIA_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentAdvertisementReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_ADVERTISEMENT:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_ADVERTISEMENT_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_ADVERTISEMENT_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentSecondFooterReducer = (state = {loading: true,secondFooter : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_SECONDFOOTER:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_SECONDFOOTER_SUCCESS:
            return {
                ...state,
                secondFooter : action.payload,
                loading: false
            }
        case FETCH_CONTENT_SECONDFOOTER_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentNewsReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_NEWS:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_NEWS_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_NEWS_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}


export const fetchContentFAQReducer = (state = {loading: true,content : []},action) => {
    switch (action.type) {
        case FETCH_CONTENT_FAQ:
            return {
                ...state,
                loading: true
            }
        case FETCH_CONTENT_FAQ_SUCCESS:
            return {
                ...state,
                content : action.payload,
                loading: false
            }
        case FETCH_CONTENT_FAQ_FAIL:
            return {
                ...state,
                error : action.payload,
                loading: false
            }
        default:
            return state;
    }
}