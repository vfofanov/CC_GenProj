export function getSettings(settings) {
    const newSettings = { content: { name: 'blocks' } };
    const children = [];
    newSettings.content.type = 8;

    const lineChart = {
        name: 'line',
        controller: 'OrdersQuery',
        type: 5,
        content: {
            name: 'line',
            type: 7,
            series:  [
                { field: 'Id', name: "Order Id", categoryField: "OrderDate" }
            ],
            chartType: 'line'
        }
    };
    children.push(lineChart);

    const pieChart = {
        name: 'pie',
        controller: 'OrdersQuery',
        type: 5,
        content: {
            name: 'pie',
            type: 7,
            series:  [
                { field: 'Id', name: "Order Id", categoryField: "OrderDate" }
            ],
            chartType: 'pie'
        }
    };
    children.push(pieChart);

    const barChart = {
        name: 'bar',
        controller: 'OrdersQuery',
        type: 5,
        content: {
            name: 'bar',
            type: 7,
            series:  [
                { field: 'Id', name: "Order Id", categoryField: "OrderDate" }
            ],
            chartType: 'bar'
        }
    };
    children.push(barChart);

    newSettings.content.children = children;
    return newSettings;
}