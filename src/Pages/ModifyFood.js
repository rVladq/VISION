import { useEffect, useState } from 'react';
import { useNavigate, useParams } from "react-router-dom";

import putFood from '../Utils/putFood';
import fetchFood from '../Utils/getFood';

import EntryForm from '../Components/EntryForm';

export default function ModifyFood() {

    const { id } = useParams();
    const navigate = useNavigate();

    const [food, setFood] = useState({
        name: undefined,
        description: undefined,
        recipe: undefined,
    })

    useEffect(() => {
        
        (async () => {
            const _food = await fetchFood();
            const obj = _food.find((item) => {
                return item.id == id
            })
            setFood(obj);
        })();
        
    }, []);


   

    function handleInput(e) {

        const { id, value } = e.target;
        setFood((prev) => ({ ...prev, [id]: value }))

    };


    const handleSubmit = async (e) => {
        
        e.preventDefault();
        console.log(food);
        await putFood(id, food);
        navigate('/food');
        
    }

    return (
        <EntryForm data={food} handleInput={handleInput} handleSubmit={handleSubmit} />
    );

};

