export const saveToken = (token) => {
    return localStorage.setItem('userToken', token);
}
export const checkToken = () => {
    return !(localStorage.getItem('userToken') === null || localStorage.getItem('userToken') === undefined);
}

export const getToken = () => {
    return localStorage.getItem('userToken');
}

export const logout = () => {
    return localStorage.removeItem('userToken');
}
