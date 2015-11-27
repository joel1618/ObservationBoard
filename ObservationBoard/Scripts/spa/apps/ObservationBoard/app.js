var app = angular.module('module', ['ngRoute', 'ui.grid']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '../Scripts/spa/apps/ObservationBoard/Views/ObservationBoard.html'
        })
}])