import axios from "axios";

async function authorize(loginRequest){
    return await axios.post('http://localhost:5274/api/Users/login', {
        login: loginRequest.Login,
        password: loginRequest.Password
    });
}
export default authorize;