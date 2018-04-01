angular.module('EmailApp',
[
  'ngRoute'
]).config(function ( $routeProvider )
  {
    'use strict';
    $routeProvider
      .when('/inbox',
      {
        templateUrl: 'views/inbox.html',
        controller: 'InboxCtrl', // map js to html scope
      })
      .otherwise(
      { // default
        redirectTo: '/inbox'
      });
  });
