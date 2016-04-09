var app = angular.module("ncmaApp", ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.

    when('/viewDojos', {
        templateUrl: 'dojoView.html', controller: 'dojoController'
    }).

    otherwise({
        redirectTo: '/viewDojos'
    });

}]);
