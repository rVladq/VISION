export default async function handleDelete( id, refresh ) {

    await fetch(`https://localhost:7260/Food/DeleteFoodItems?id=${id}`,
        {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json'
            }
        }
    );

    refresh((prev) => !prev);

}