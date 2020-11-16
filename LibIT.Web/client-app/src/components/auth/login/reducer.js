import * as types from './types';
const intialState = {
    loading: false,
    errors: {}
}

export const loginReducer = (state = intialState, action) => {
    console.log("Reducer working", action);
    switch (action.type) {
        case types.LOGIN_STARTED:
            return {
                //...this.state,
                loading: true,
                errors: {}
            }
            break;
            
        case types.LOGIN_SUCCESS:
            return {
                loading: false,
                errors: {}
            }
            break;

        case types.LOGIN_FAILED:
                return {
                    loading: false,
                    errors: action.errors
                }
            break;
    
        default:
            break;
    }
    return state;
}