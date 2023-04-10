import { Outlet, Link } from "react-router-dom";

const Layout = () => {
    return (
        <div>
            <header>
                <nav>
                    <ul>
                        <li>
                            <Link to="/">Calculadore</Link>
                        </li>
                        <li>
                            <Link to="/about">Sobre eu</Link>
                        </li>
                    </ul>
                </nav>
            </header>
            
            <main>
                <Outlet />
            </main>

            <footer>
                <p>&copy; { (new Date()).getFullYear() } - Jo�o Lucas</p>
            </footer>
        </div>
    );
}


export default Layout;