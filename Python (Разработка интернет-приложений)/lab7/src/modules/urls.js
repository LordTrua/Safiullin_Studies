class Urls {
    constructor() {
        this.url = 'http://localhost:65415/';
    }

    stocks() {
        return `${this.url}GameTypes/`
    }

    stock(id) {
        return `${this.url}GameTypes/${id}/`
    }
}

export const urls = new Urls()