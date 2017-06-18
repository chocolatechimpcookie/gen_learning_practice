'use strict';

/**
 * @ngdoc overview
 * @name routingQuizApp
 * @description
 * # routingQuizApp
 *
 * Main module of the application.
 */
angular
  .module('routingQuizApp', ['ui.router'])
  .config(['$stateProvider', '$urlRouterProvider', function($stateProvider, $urlRouterProvider)
  {
    $urlRouterProvider.otherwise('/');
    
    $stateProvider
    .state('home',
    {
      url:'/',
      templateUrl:'views/instructions.html',
    })
    .state('brick',
    {
      url:'/bricks/:color',
      templateUrl:'views/bricks.html',
      controllerProvider: function($stateParams)
      {
        var color = $stateParams.color;
        color = color[0].toUpperCase() + color.slice(1);
        var ctrlName = color + 'BricksCtrl';
        return ctrlName;
      },
      controllerAs:'brick'
    })
    //.state('redBrick',
    //{
    //  url: '/bricks/red',
    //  templateUrl: 'views/bricks.html',
    //  controller: "RedBricksCtrl as brick"
    //})
    //.state('blueBrick',
    //{
    //  url: '/bricks/blue',
    //  templateUrl: 'views/bricks.html',
    //  controller: "BlueBricksCtrl as brick"
    //})
    //.state('greenBrick',
    //{
    //  url:'/bricks/green',
    //  templateUrl: 'views/bricks.html',
    //  controller: "GreenBricksCtrl as brick"
    //})
    .state('cart',
    {
      url: '/cart',
      templateUrl:'views/cart.html',
      controller: "CartCtrl as cart"
    })
    .state('brick.cart',
    {
      url:'/cart',
      templateUrl: 'views/cart.html',
      controller: 'CartCtrl as cart'
    })
    //.state('redBrick.cart',
    //{
    //  url: '/cart',
    //  templateUrl:'views/cart.html',
    //  controller:'CartCtrl as cart'
    //})
    //.state('blueBrick.cart',
    //{ 
    //  url:'/cart',
    //  templateUrl:'views/cart.html',
    //  controller:'CartCtrl as cart'
    //})
    //.state('greenBrick.cart',
    //{
    //  url:'/cart',
    //  templateUrl:'views/cart.html',
    //  controller:'CartCtrl as cart'
    //})
    ;
  }]);



    //<div ng-include="'views/bricks.html'" ng-controller="RedBricksCtrl as brick"></div>
    //<div ng-include="'views/bricks.html'" ng-controller="BlueBricksCtrl as brick"></div>
    //<div ng-include="'views/bricks.html'" ng-controller="GreenBricksCtrl as brick"></div>
    //<div ng-include="'views/cart.html'" ng-controller="CartCtrl as cart"></div>