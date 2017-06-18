//The angular.module module, extra modules are in the array

angular.module('EmailApp',
[
	'ngRoute',
	'ngSanitize'
]).config(function ($routeProvider)
	{
		'use strict';
		$routeProvider
			.when('/inbox',
			{
			  templateUrl: 'views/inbox.html',
			  controller: 'InboxCtrl',
			  controllerAs: 'inbox'
//	how do these three differentiate?
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
	}).run(function($rootScope)
		{
			$rootScope.$on('$routeChangeError', function(event, current, previous, rejection)
			{
				console.log(event, current, previous, rejection);
//	looks like this logs route errors
			});
			//^these last two are missing semicolons in the original version
		});

