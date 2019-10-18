var app = angular.module('scotch-todo', ['ionic', 'LocalStorageModule']);
//app becomes an easy prefix


app.config(function (localStorageServiceProvider)
{
  localStorageServiceProvider
    .setPrefix('scotch-todo');
//sets prefix for local storage entities
});



//you can replace $scope with this, and not pass $scope
app.controller('main', function($scope, $ionicModal, localStorageService)
{
//store the entities name in a variable var taskData = 'task';
  $scope.tasks = [];
  $scope.task = {};
  
  $ionicModal.fromTemplateUrl('new-task-modal.html',
  {
    scope: $scope,
    animation: 'slide-in-up'
  }).then(function (modal)
  {
    $scope.newTaskModal = modal;
  });

  $scope.getTasks = function ()
  {
    if (localStorageService.get(taskData))
    {
      $scope.tasks = localStorageService.get(taskData);
    }
    else
    {
      $scope.tasks = [];
    }
    
  };
  //^fetches from local storage
  
  $scope.createTask = function ()
  {
    //creates new task
    $scope.tasks.push($scope.task);
    localStorageService.set(taskData, $scope.tasks);
    $scope.task = {};
    //close new task
    $scope.newTaskModal.hide();
    
  };
  
  $scope.removeTask = function (index)
  {
    $scope.tasks.splice(index, 1);
    localStorageService.set(taskData, $scope.tasks);
  };
  
  
  //updates task as completed
  $scope.completeTask = function (index)
  {
    if (index !== -1)
    {
      $scope.tasks[index].completed = true;
    }
    
    localStorageService.set(taskData, $scope.tasks);
  
  };
  //updates task as completed
  
  
});


