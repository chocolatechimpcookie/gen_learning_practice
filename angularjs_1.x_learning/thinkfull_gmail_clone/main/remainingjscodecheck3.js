        <div ng-controller="InboxCtrl">
            {{ title }}
            
        </div>
		  
		  
		    var app = angular.module('app',['ngRoute']);
            function TestCtrl($scope)
            {
              $scope.title = 'Write a title here...';  
                
            }
            
            app.controller('InboxCtrl', function($scope)
            {
               //Model and view bindings, initialize view,
               //a good controller should have as little logic as possible
               //^You don't want pieces coupled
               //small helper function not needed anywhere else
               //scope is how we add properties and methods to view
               
               
               //initialize the title property to an array for view to use
               $scope.title = "This is a title";
               
               
               
            });
            
            //If you look closely, you'll notice each view has a particular Controller.
            //Later versions of Angular (we're using one of the latest) ship with a new
            //Controller syntax, the "Controller as" syntax, which instantiates the Controller
            //like an Object and binds it to the current scope under a namespace. The namespace
            //we've chosen for InboxCtrl is inbox.
            //Note: You can also declare "Controller as" in-line. It'd look like this: ng-controller="InboxCtrl as inbox".

            
            app.config(function ($routeProvider)
            {
                $routeProvider
                    .when('/inbox',
                    {
                      templateURL: 'views/inbox.html',
                      controller: 'InboxCtrl',
                      controllerAs: 'inbox'
                    })
                    .when('/inbox/email/:id',
                    {
                      templateUrl: 'views/email.html',
                      controller: 'EmailCtrl',
                      controllerAs: 'email'
                    })
                    .otherwise(
                    {
                       redirectTo: '/inbox' 
                    });
                
            });