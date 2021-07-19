import { FETCH_CONTENT,FETCH_CONTENT_SUCCESS,FETCH_CONTENT_FAIL } from "../constants";

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