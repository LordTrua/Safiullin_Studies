export class StockCardComponent {
    constructor(parent) {
        this.parent = parent;
    }
    getHTML(data) {
        return (
            `
                <div class="card" style="width: 300px;">
                    
                    <div class="card-body">
                        <h5 class="card-title">${data.NameGameTypes}</h5>
                        <p class="card-text">${data.GameTypesDescription}</p>
                        <button class="btn btn-primary" id="click-card-${data.pk}" data-id="${data.pk}">Нажми на меня</button>

                    </div>
                </div>
            `
        )
    }

    addListeners(data, listener) {
        document
            .getElementById(`click-card-${data.pk}`)
            .addEventListener("click", listener)
    }

    render(data, listener) {
        const html = this.getHTML(data)
        this.parent.insertAdjacentHTML('beforeend', html)
        this.addListeners(data, listener)
    }
}