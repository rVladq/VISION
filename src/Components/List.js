import { Link } from "react-router-dom";

import Entry from "./Entry"
import EntryDescriptor from "./EntryDesciptor"

import './List.css';

export default function List( { data, refresh } ) {
    
    let entries = [];

    if(data.length != 0 ) {

        entries = data.map(element => {
            return (
                <Entry data_obj={element} refresh={refresh} />
            )
        })

    }

    return (
        <div className="list-wrapper">

            <h1 className="title">Items</h1>

            { data.length !== 0 ? <EntryDescriptor data_obj={data[0]} /> : '' }

            { data.length !== 0 ? entries : ''}
            
            <Link className="add" to={`/food/new`}>
                <div>+</div>
            </Link>

        </div>
    )

}