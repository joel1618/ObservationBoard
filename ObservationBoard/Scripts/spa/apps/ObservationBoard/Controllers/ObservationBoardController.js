(function (moment) {
    "use strict";

    var app = angular.module('module');
    app.controller('controller', ['$scope', '$http', '$timeout', function ($scope, $http, $timeout) {
        $scope.clients = [
         { Id: 123456, Image: 'no.jpg', Name: 'Basil', OpenedDT: '10/10/2015 12:30 PM', Status: '', Accompanied: '', DemoDT: '', ConsentDT: '', PhotoDt: '', PhotoOnFileDT: '' },
         { Id: '123457', Image: 'no.jpg', Name: 'Travis', OpenedDT: '', Status: '', Accompanied: '10/10/2015 12:30 PM', DemoDT: '', ConsentDT: '', PhotoDt: '', PhotoOnFileDT: '' },
         { Id: '123458', Image: 'no.jpg', Name: 'James', OpenedDT: '', Status: '', Accompanied: '', DemoDT: '', ConsentDT: '10/10/2015 12:30 PM', PhotoDt: '', PhotoOnFileDT: '' },
         { Id: '123459', Image: 'no.jpg', Name: 'Joel', OpenedDT: '', Status: '', Accompanied: '', DemoDT: '', ConsentDT: '', PhotoDt: '10/10/2015 12:30 PM', PhotoOnFileDT: '' },
         { Id: '123460', Image: 'no.jpg', Name: 'Judith', OpenedDT: '', Status: '', Accompanied: '', DemoDT: '', ConsentDT: '', PhotoDt: '', PhotoOnFileDT: '10/10/2015 12:30 PM' },
         { Id: '123461', Image: 'no.jpg', Name: 'Ayaz', OpenedDT: '', Status: '', Accompanied: '', DemoDT: '', ConsentDT: '', PhotoDt: '', PhotoOnFileDT: '' }
        ];

        function getClients() {
            $http.get('http://jsonplaceholder.typicode.com/posts/1').then(function (response) {
                //$scope.clients = clients();
                $timeout(function () {
                    getClients();
                }, 10000);
            }, function (response) {
                alert('getClients failed');
                $timeout(function () {
                    getClients();
                }, 30000);
            });
        }
        getClients();

        //Timer
        function getTime() {
            $scope.time = moment().format("MM/DD/YYYY hh:mm:ss");
            $timeout(function () {
                getTime();
            }, 1000);
        }
        getTime();

        $scope.gridOptions = {
            data: $scope.clients,
            enableFiltering: true,
            columnDefs: [
                {
                    field: 'Id',
                    enableFiltering: true,
                    name: 'Id',
                    //cellTemplate: '<div>{{row.entity.Id}} - {{row.entity.Name}}</div>',
                    rowHeight: 50
                },
                {
                    field: 'Name',
                    name: 'Name'
                },
                {
                    field: 'OpenedDT',
                    enableFiltering: false,
                    name: 'Opened',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50

                },
            ]
        }
    }]);
})(moment);