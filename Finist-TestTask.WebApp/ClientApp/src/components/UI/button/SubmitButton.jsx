import React from 'react';
import classes from "./SubmitButtom.module.css";

const SubmitButton = ({children ,...props}) => {
    return (
        <button  {...props} className={classes.submitButton}>
            {children}
        </button>
    );
};

export default SubmitButton;