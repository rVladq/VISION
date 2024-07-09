export default async () => {

    let response =  await fetch("https://localhost:7260/Food/GetFoodItems");
    return await response.json();

};
