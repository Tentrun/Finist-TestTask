const IDENTITY_API_URL = 'http://localhost:5274/api/';
const BASE_API_URL = 'http://localhost:5231/api/';

const ENDPOINTS = {
    IDENTITY_AUTHORIZE: 'Users/Login',
    CLIENT_GET_INFO: 'Client'
};

const API_ADDRESSES = {
    API_URL_IDENTITY_AUTHORIZE: `${IDENTITY_API_URL}${ENDPOINTS.IDENTITY_AUTHORIZE}`,
    API_URL_CLIENT_GET_INFO: `${BASE_API_URL}${ENDPOINTS.CLIENT_GET_INFO}`
}

export default API_ADDRESSES;