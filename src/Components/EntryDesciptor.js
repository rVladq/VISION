import './EntryDescriptor.css';

export default function Entry( { data_obj } ) {

    let entry = Object.keys(data_obj).map((key) => {
        return(
            <p className={`entry ${key}`}>{ key }</p>
        );
    });



    return (
    <div className="entry-wrapper entrydescriptor-wrapper">
        { entry }
        <div className='button edit_button descr_edit_button'>  </div>
        <div className='button delete_button descr_delete_button'>  </div>
    </div>
    )

}
