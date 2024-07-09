export default async function addFood( food ) {

    await fetch(`https://localhost:7260/Food/PostFoodItems`,
        {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                name: food.name,
                description: food.description,
                recipe: food.recipe
            })
        }
    );

}