export default async function putFood( id, food ) {

    await fetch(`https://localhost:7260/Food/PutFoodItems?id=${id}`,
        {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(food)
        }
    );

}