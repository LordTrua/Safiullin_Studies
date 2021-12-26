import {StockCardComponent} from "../../components/stock-card/StockCardComponent.js";
import {StockPage} from "../../components/stock/StockPage.js";
import {ajax} from "../../modules/ajax.js";
import {urls} from "../../modules/urls.js";

export class MainPage {
    constructor(parent) {
        this.parent = parent;
    }

    async getData() {
        return ajax.get(urls.stocks())
    }
    get page() {
        return document.getElementById('main-page')
    }

    getHTML() {
        return (
            `
            <div id="main-page" class="d-flex flex-wrap"><div/>
        `
        )
    }
    clickCard(e) {
        const cardId = e.target.dataset.pk

        const stockPage = new StockPage(this.parent, cardId)
        stockPage.render()

    }
    async render() {
        this.parent.innerHTML = ''
        const html = this.getHTML()
        this.parent.insertAdjacentHTML('beforeend', html)

        const data = await this.getData()
        data.data.forEach((item) => {
            const stockCard = new StockCardComponent(this.page)
            stockCard.render(item, this.clickCard.bind(this))
        })
    }


}