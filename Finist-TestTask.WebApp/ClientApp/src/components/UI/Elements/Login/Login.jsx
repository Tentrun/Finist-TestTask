import React from 'react';
import classes from "./Login.module.css";
import InputField from "../../input/InputField";
import SubmitButton from "../../button/SubmitButton";

const Login = () => {
    return (
        <div className={classes.wrapper}>
            <h6>Номер телефона</h6>
            <InputField></InputField>            
            <h6>Пароль</h6>
            <InputField></InputField>
            <SubmitButton>Войти</SubmitButton>
        </div>
    );
};

export default Login;