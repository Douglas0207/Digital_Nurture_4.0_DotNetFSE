import React from 'react';
import styles from "../Styles/CohortDetails.module.css";

const CohortDetails = ({title, startDate, status, coach, trainer}) => {
    const headingStyle = {
        color: status === 'Ongoing' ? 'green' : 'blue'
    };
    return (
        <div className={styles.box}>
            <h3 style={headingStyle}>{title}</h3>
            <dl>
                <dt>Started On</dt>
                <dd>{startDate}</dd>
                <dt>Current Status</dt>
                <dd>{status}</dd>
                <dt>Coach</dt>
                <dd>{coach}</dd>
                <dt>Trainer</dt>
                <dd>{trainer}</dd>
            </dl>
        </div>
    );
};

export default CohortDetails;