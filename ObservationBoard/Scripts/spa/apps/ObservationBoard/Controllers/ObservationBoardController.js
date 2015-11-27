(function (moment) {
    "use strict";

    var app = angular.module('module');
    app.controller('controller', ['$scope', '$http', '$timeout', function ($scope, $http, $timeout) {
        $scope.data = [];

        function GetClients() {
            $http.get('api/v1/ObservationBoard').then(function (response) {
                $scope.data = response.data;
            }, function (error) {
                alert('There was an error getting the data.');
            });
        }
        GetClients();

        $scope.gridOptions = {
            data: 'data',
            enableFiltering: true,
            columnDefs: [
                {
                    field: 'Id',
                    enableFiltering: true,
                    name: 'Id',
                    //cellTemplate: '<div>{{row.entity.Id}} - {{row.entity.Name}}</div>',
                    rowHeight: 50
                }
                //,
                //{
                //    field: 'Name',
                //    name: 'Name'
                //},
                //{
                //    field: 'OpenedDT',
                //    enableFiltering: false,
                //    name: 'Opened',
                //    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                //    rowHeight: 50

                //},
            ]
        }

        //Timer
        function getTime() {
            $scope.time = moment().format("MM/DD/YYYY hh:mm:ss");
            $timeout(function () {
                getTime();
            }, 1000);
        }
        getTime();
    }]);
})(moment);