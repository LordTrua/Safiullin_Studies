import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import HeaderComp from "../components/HeaderComp.js";
import getObjects from "../modules/GetObjects.js";


function ListPage() {

    const [GameTypesList, setGameTypesList] = useState([])
    const [GameTypesNames, setGameTypesNames] = useState([])

    const handleObjectsList = async () => {
        const Types = []
        const GameTypes = await getObjects()
        for (let gameType of GameTypes) {
            Types.push(gameType['NameGameTypes']);
        }
        setGameTypesList(GameTypes)
        setGameTypesNames(Types)
    }

    useEffect(()=>{
        handleObjectsList()
    }, [])

    return (
        <div>
            <HeaderComp></HeaderComp>
            <h2>Таблица GameTypes</h2>
            <ul>
                {GameTypesNames.map((NameGameTypes)=>{
                    return (
                        <li key={NameGameTypes}>
                            <Link to={{pathname: "/GameTypes/object", data: GameTypesList.find(obj => obj.NameGameTypes == NameGameTypes)}}>{NameGameTypes}</Link>
                        </li>
                    )
                })}
            </ul>
        </div>
    );
}

export default ListPage;