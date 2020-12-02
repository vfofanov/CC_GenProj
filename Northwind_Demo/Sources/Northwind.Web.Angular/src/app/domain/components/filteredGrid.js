import template from './filteredGrid.html'
import './filteredGrid.scss'
import angular from 'angular'

class FilteredGridController {
    constructor($scope, $element, $timeout, testDynamicColumnsActionService) {
        'ngInject'
        this.testDynamicColumnsActionService = testDynamicColumnsActionService;
        this.filter = {};
        $scope.$watch('$ctrl.filter', () => {
            this.updateGrid();
        }, true);
        this.$element = $element;
        this.$timeout = $timeout;
    }
    $onInit() {
        this.periodOptions = {
            dataSource: {
                data: [1, 2, 3, 4]
            }
        }
    }

    updateGrid() {
        if (this.filter.startDate && this.filter.endDate/* && this.filter.periodQuantity*/) {
            this.testDynamicColumnsActionService.getTestData(this.filter.startDate.toISOString(),
                this.filter.endDate.toISOString(), 1)
                .then(res => res.data.Data)
                .then(({ Columns, Rows }) => {
                    const columns = [];
                    const fields = {};
                    Columns.forEach((c, i) => {
                        columns.push({
                            title: c.Name,
                            field: `field${i}`
                        });
                        fields[`field${i}`] = { type: 'string' };
                    });
                    this.gridOptions = {
                        columns: columns,
                        dataSource: {
                            data: Rows.map(r => {
                                const entity = {};
                                for (let i = 0; i < r.length; i++) {
                                    entity[`field${i}`] = r[i];
                                }
                                return entity;
                            })
                        }
                    };
                    this.$timeout(() => {
                        const grid = this.$element.find('.grid').data('kendoGrid');
                        grid.dataSource.read();
                        grid.refresh();
                    }, 100);
                });
        }
    }
}

export default {
    template,
    controller: FilteredGridController
}