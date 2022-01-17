const getObjects = async () =>{
    return await fetch('http://localhost:52139/GameTypes/', {method: "GET"})
        .then((response) => {
            return response.json();
        }).catch(() => {
            return {resultCount: 0, results: []}
        })
}

export default getObjects