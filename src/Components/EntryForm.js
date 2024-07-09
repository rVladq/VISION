import './EntryForm.css'

export default function EntryForm( { data, handleInput, handleSubmit } ) {



    return (
        <div className="entryForm-wrapper">
            <h1>Input Form</h1>
            <form onSubmit={handleSubmit}>
                <div>
                    <label htmlFor="input1">Name</label>
                    <input
                        type="text"
                        id="name"
                        value={data.name}
                        onChange={handleInput}
                    />
                </div>
                <div>
                    <label htmlFor="input2">Description</label>
                    <input
                        type="text"
                        id="description"
                        value={data.description}
                        onChange={handleInput}
                        />
                </div>
                <div>
                    <label htmlFor="input3">Recipe</label>
                    <textarea
                        type="text"
                        id="recipe"
                        value={data.recipe}
                        onChange={handleInput}
                    />
                </div>
                <button type="submit">Submit</button>
            </form>
        </div>
    );
}
