angular.module('appRoutes', []).config(['$routeProvider', '$locationProvider', function($routeProvider, $locationProvider)
{

    $routeProvider
    
        //homepage
        .when('/',
        {
            templateUrl: 'views/home.html',
            controller: 'MainController'
        })
        
        // nerds page that will use the NerdController
        .when('/nerds',
        {
            templateUrl: 'views/nerd.html',
            controller: 'NerdController'
        });
        
        //gets #/ out of the way
        $locationProvider.html5Mode(true);
}]);