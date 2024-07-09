import { Link } from "react-router-dom";

import Entry from "./Entry"
import EntryDescriptor from "./EntryDesciptor"

import './List.css';

export default function List( { data, refresh } ) {

    const entries = data.map(element => {
        return (
            <Entry data_obj={element} refresh={refresh} />
        )
    })

    return (
    <div className="list-wrapper">
        <h1 className="title">Items</h1>
        <EntryDescriptor data_obj={data[0]} />
        { entries }
        <Link className="route_" to={`/food/new`}>
            <div className="add">+</div>
        </Link>
    </div>
    )

}