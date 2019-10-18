angular.module('todoApp', [])
  .controller('TodoListController', function()
    {
        //keeps mention $scope, I know what scope is, but what is $scope?
        //view is the HTML
        //model is data available for the current view
        //controller is the JS function that works with the data
        //scope is the model. A javascript object with properties
        //and methods which are avilable for both the view and controller
        //http://www.w3schools.com/angular/angular_scopes.asp
        
        //default todos
        //model in simple JObject
        var todoList = this;
        todoList.todos =
        [
            {text:'learn angular', done:true},
            {text:'build an angular app', done:false}
        ];
     
        //adds item to list
        //ng submit invokes this
        todoList.addTodo = function()
        {
            todoList.todos.push({text:todoList.todoText, done:false});
            todoList.todoText = '';
        };
     
        //counts remaining
        todoList.remaining = function()
        {
            var count = 0;
            angular.forEach(todoList.todos, function(todo)
            {
                count += todo.done ? 0 : 1;
            });
            return count;
        };
     
     
        //deletes old
        todoList.archive = function()
        {
            var oldTodos = todoList.todos;
            todoList.todos = [];
            angular.forEach(oldTodos, function(todo)
            {
                if (!todo.done) todoList.todos.push(todo);
            });
        };
    });