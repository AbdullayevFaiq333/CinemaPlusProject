import React from 'react';
import Advertisement from './Advertisement';
import News from './News';
import Movies from './Movies';

const HomePage = () => {
    return (
        <div>
            <Advertisement/>
            <Movies/>
            <News/>
        </div>
    )
}

export default HomePage
