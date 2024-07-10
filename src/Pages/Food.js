import React, { useState, useEffect } from 'react';

import './Food.css';

import fetchFood from '../Utils/getFood';

import List from '../Components/List'


export default function Food() {

	const [isLoaded, setIsLoaded] = useState(false);
	const [food, setFood] = useState([]);

	useEffect(() => {

		(async () => {
			const fetchedFood = await fetchFood();
			setFood(fetchedFood);
			setIsLoaded(true);
		})();

	}, [isLoaded]);



	return (
    <>
		{!isLoaded ? '' : 
			<div className='main'>
				<List data={food} refresh={setIsLoaded} /> : ''
			</div>
		}
    </>
  );
}
