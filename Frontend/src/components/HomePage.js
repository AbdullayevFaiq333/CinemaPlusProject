import React from 'react';
import Advertisement from './Advertisement';
import BuyTicket from './BuyTicket';
import News from './News';
import Movies from './Movies';

const HomePage = () => {
    return (
        <div>
            <Advertisement/>
            <BuyTicket/>
            <Movies/>
            <News/>
        </div>
    )
}

export default HomePage
