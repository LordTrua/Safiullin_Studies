import { Link } from "react-router-dom";

function HeaderComp() {
    return (
        <div>
            <Link to='/'>Главная страница</Link>
            <hr></hr>
            <i>Группа:</i> РТ5-51Б
            <i> Студент:</i> Сафиуллин Антон Павлович
            <br></br>
            <i>Лабораторная работа:</i> №8
            <hr></hr>



        </div>
    );
}

export default HeaderComp;