import React, {useEffect, useState} from 'react';
import classes from "./Dashboard.module.css";
import {checkToken, logout} from "../../../../helper/AuthHelper";
import getClientInfo from "../../../../services/ClientService";
import SubmitButton from "../../button/SubmitButton";

function Dashboard(){
    const [client, setClient] = useState(undefined);
    
    useEffect( () => {
        async function prepareData() {
            if (checkToken() === false){
                window.location.replace('/login')
                return
            }
            await getClientInfo()
                .then(function (response){
                    if (response.status === 200){
                        setClient(response.data);
                        console.log(client)
                    }
            })
                .then(function (error){
                    if (error.response.status === 401 || error.response.status === 403){
                        logout();
                        window.location.replace('/login')
                    }
                })
        }
        prepareData()
    }, [])
    
    const accountLogout = () => {
        logout()
        window.location.replace('/login')
    }
    
    return (
        <div className={classes.wrapper}>
            <div className={classes.category}>
                <div className={classes.item}>
                    <h2>Клиент</h2>
                    {client && (
                        <h6>{client.secondName} {client.name} {client.patronymic} {client.phoneNumber}</h6>
                    )}
                </div>
            </div>
            <div className={classes.category}>
                <div className={classes.item}>
                    <h2>Счета</h2>
                    <h6>Срочный - {client && client.expressAccount}</h6>
                    <h6>До востребования - {client && client.demandAccount}</h6>
                    <h6>Карточный - {client && client.cardAccount}</h6>
                    <SubmitButton onClick={accountLogout}>Выйти</SubmitButton>
                </div>
            </div>
        </div>
    );
};

export default Dashboard;