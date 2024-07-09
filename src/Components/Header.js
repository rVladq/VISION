import { Link } from "react-router-dom";

import './Header.css'

export default function Header() {

  return (
    <header className='header'>
        <Link className="route_" to='/food'>
            <p>HOME</p>
        </Link>
    </header>
  );

};
