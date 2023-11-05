import axios from "axios";
import API_ADDRESSES from "../constants/endpoints";
import {getToken} from "../helper/AuthHelper";

async function getClientInfo(){
    return await axios.post(`${API_ADDRESSES.API_URL_CLIENT_GET_INFO}`, {}, {headers:{Authorization: `Bearer ${getToken()}`}});
}

export default getClientInfo;