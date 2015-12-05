(function (moment) {
    "use strict";

    var app = angular.module('module');
    app.controller('controller', ['$scope', '$http', '$timeout', function ($scope, $http, $timeout) {
        $scope.data = [];
        $scope.time = '';

        $scope.gridOptions = {
            data: 'data',
            enableFiltering: true,
            columnDefs: getColumnDefinitions(),
            onRegisterApi: function (gridApi) {
                $scope.gridApi = gridApi;
                //This must be here to wait for dom to load.
                $timeout(function () {
                    $scope.search();
                });
            }
        }

        $scope.search = function () {
            $http.get('api/v1/ObservationBoard').then(function (response) {
                $scope.data = response.data;
            }, function (error) {
                alert('There was an error getting the data.');
            });
        }

        function getColumnDefinitions() {
            return [
                {
                    field: 'Id',
                    enableFiltering: true,
                    name: 'Id',
                    //cellTemplate: '<div>{{row.entity.Id}} - {{row.entity.Name}}</div>',
                    rowHeight: 50
                },
                {
                    field: 'Client',
                    name: 'Client'
                },
                {
                    field: 'Assigned Bed',
                    name: 'AssignedBed'
                },
                {
                    field: 'OpenedTimeStamp',
                    enableFiltering: false,
                    name: 'Opened',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'DemographicTimeStamp',
                    enableFiltering: false,
                    name: 'Demographic',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'GeneralConsentTimeStamp',
                    enableFiltering: false,
                    name: 'Consent',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'PhotoTimeStamp',
                    enableFiltering: false,
                    name: 'Photo',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'CrisisScreeningTimeStamp',
                    enableFiltering: false,
                    name: 'Screening',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'AssessmentTimeStamp',
                    enableFiltering: false,
                    name: 'Assessment',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'FinancialTimeStamp',
                    enableFiltering: false,
                    name: 'Financial',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'EAndMTimeStamp',
                    enableFiltering: false,
                    name: 'E&M',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'ROSTimeStamp',
                    enableFiltering: false,
                    name: 'ROS',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'UDSTimeStamp',
                    enableFiltering: false,
                    name: 'UDS',
                    cellTemplate: '../Scripts/spa/apps/ObservationBoard/Views/CellTemplates/celltemplate.html',
                    rowHeight: 50
                },
                {
                    field: 'LastNursingAssessmentTimeStamp',
                    enableFiltering: true,
                    name: 'Last Assessment',
                    rowHeight: 50
                },
            ]
        }

        //Timer
        $scope.getTime = function () {
            $scope.time = moment().format("MM/DD/YYYY hh:mm:ss");
            $timeout(function () {
                $scope.getTime();
            }, 1000);
        }
        $scope.getTime();
    }]);
})(moment);