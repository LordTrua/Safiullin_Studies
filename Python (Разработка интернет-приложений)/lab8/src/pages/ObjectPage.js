import { Link } from "react-router-dom";
import HeaderComp from "../components/HeaderComp.js";



function ObjectPage(params) {
    const GameTypesList = params.location.data
    return (
        <div>
            <HeaderComp></HeaderComp>
            <h2>Название типа игра: {GameTypesList.NameGameTypes}</h2>
            <h4>Описание типа игр:</h4>
            <p>{GameTypesList.GameTypesDescription}</p>
            <Link to="/GameTypes"><button>Назад</button></Link>
        </div>
    );
}

export default ObjectPage;