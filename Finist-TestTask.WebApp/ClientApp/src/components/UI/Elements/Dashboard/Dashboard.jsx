import React from 'react';
import classes from "./Dashboard.module.css";

const Dashboard = () => {
    return (
        <div className={classes.wrapper}>
            <div className={classes.category}>
                <div className={classes.item}>
                    <h2>Клиент</h2>
                    <h6>фыофыл</h6>
                </div>
            </div>
            <div className={classes.category}>
                <div className={classes.item}>
                    <h2>Счета</h2>
                    <h6>Срочный - </h6>
                    <h6>До востребования - </h6>
                    <h6>Карточный - </h6>
                </div>
            </div>
        </div>
    );
};

export default Dashboard;