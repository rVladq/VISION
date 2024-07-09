import { Link } from "react-router-dom";

import deleteFood from '../Utils/deleteFood';
import './Entry.css';

export default function Entry( { data_obj, refresh } ) {

    let entry = Object.keys(data_obj).map((key) => {
        return(
            <p className={`entry ${key}`}>{ data_obj[key] }</p>
        );
    });



    return (
    <div className="entry-wrapper">
        { entry }
        <Link to={`/food/${data_obj.id}`}>
            <div className='button edit_button'>EDIT</div>
        </Link>
        <div className='button delete_button' onClick={ () => deleteFood(data_obj.id, refresh) }>DELETE</div>
    </div>
    )

}
