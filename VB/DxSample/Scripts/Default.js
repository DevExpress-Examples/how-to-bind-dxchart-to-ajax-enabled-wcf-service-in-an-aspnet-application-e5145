(function ($) {
    $(function () {
        new DxSample.DxSampleService().GetSales(function (data) {
            $('#chart-container').dxChart({
                dataSource: data,
                series: [
                {
                    argumentField: 'Day',
                    valueField: 'OrangesSold',
                    name: 'Oranges Sold',
                    type: 'bar',
                    color: '#ffa500'
                }
            ]
            });
        });
    });
})(jQuery);