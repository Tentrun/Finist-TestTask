import React, {useEffect, useState} from 'react';
import classes from "./Login.module.css";
import InputField from "../../input/InputField";
import SubmitButton from "../../button/SubmitButton";
import authorize from "../../../../services/AuthService";
import {checkToken, saveToken} from "../../../../helper/AuthHelper";

function Login(){
    const [error, setError] = useState('');
    const [login, setLogin] = useState('');
    const [password, setPassword] = useState('');

    useEffect( () => {
        function authorizeCheck() {
            if (checkToken() === true){
                window.location.replace('/dashboard')
            }
        }
        authorizeCheck()
    }, [])
    
    const auth = async (e) => {
        e.preventDefault()
        if (login === '' || password === ''){
            setError('Не все поля заполнены')
            return
        }

        let loginRequest = {Login: login, Password: password};
        authorize(loginRequest)
            .then(function (response){
            if (response.status === 200){
                saveToken(response.data.token);
                window.location.replace('/dashboard')
            }
        })
            .catch(function (error){
            if (error.response.status === 401 || error.response.status === 403){
                setError('Логин или пароль введены неправильно');
            }
        })
    }


    return (
        <div className={classes.wrapper}>
            <form>
                <h6>Номер телефона</h6>
                <InputField
                    value={login}
                    onChange={e => setLogin(e.target.value)}
                    type="text"/>         
                <h6>Пароль</h6>
                <InputField 
                    value={password}
                    onChange={e => setPassword(e.target.value)}
                    type="password"/>
                <SubmitButton onClick={auth}>Войти</SubmitButton>
            </form>
            <h2 className={classes.error}>{error}</h2>
        </div>
    );
}

export default Login;