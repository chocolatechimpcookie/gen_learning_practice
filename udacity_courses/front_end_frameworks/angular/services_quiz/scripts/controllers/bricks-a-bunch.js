'use strict';

/**
 * @ngdoc function
 * @name serviceQuizApp.controller:BricksABunchCtrl
 * @description
 * # BricksABunchCtrl
 * Controller of the serviceQuizApp
 */
angular.module('serviceQuizApp')
  .controller('BricksABunchCtrl', ['brickWarehouse', function (warehouse)
  {
    //What if there is more than one service, keyword passed?
    this.name = 'Bricks A Bunch';
    
    this.redBricks = warehouse.bricks.red;
    
    //why is prce here?
    this.addToCart = function(price)
    {
      warehouse.decreaseQuantity('red', price);
    };
  }]);
