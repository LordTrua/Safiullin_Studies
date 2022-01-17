class Ajax {
    async get(url) {
        const response = await fetch(url, {
            method: "GET"
        });
        const responseData = await response.json();

        return {
            data: responseData
        };
    }
}

export const ajax = new Ajax();