import React, { useState } from 'react';
import { useNavigate } from "react-router-dom";

import addFood from '../Utils/postFood';

import EntryForm from '../Components/EntryForm';

export default function NewFood() {

    const navigate = useNavigate();
    const [food, setFood] = useState({
        name: undefined,
        description: undefined,
        recipe: undefined,
    })

    function handleInput(e) {

        const { id, value } = e.target;
        setFood((prev) => ({ ...prev, [id]: value }))

    };


    const handleSubmit = async (e) => {
        
        e.preventDefault();
        await addFood(food);
        navigate('/food');

    }

    return(
        <EntryForm data={food} handleInput={handleInput} handleSubmit={handleSubmit} />
    )

};

