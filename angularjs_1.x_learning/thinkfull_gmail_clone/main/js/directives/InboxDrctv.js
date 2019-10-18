//What's the difference between a directive and controller?

angular.module('EmailApp')
   .directive('inbox', function InboxDrctv ()
   {
      'use strict';

//editor says missing semi colon
      return
       {
           restrict: 'EA',
           replace: true,
           scope: true,
           templateUrl: "js/directives/inbox.tmpl.html",
           controllerAs: 'inbox',
           
//What is being passed?
//Why does this also say controller?
           controller: function (InboxFactory)
           {
               this.messages = [];
               
               this.goToMessage = function(id)
               {
                   InboxFactory.deleteMessage(id,index);
               };
               
               this.deleteMessage = function (id, index)
               {
                   InboxFactory.deleteMessage(id, index);
               };
//Why do these end with semicolons though they are functions
//function as variable statements/expressions?
               InboxFactory.getMessages()
                  .then
                     ( angular.bind( this, function then()
                        {
                           this.messages = InboxFactory.messages;              
                        })
                     );
//strange syntax
           },
           
           link: function (scope, element, attrs, ctrl)
           {
                        /* 
              "by convention we do not $ prefix arguments to the link function
              this is to be explicit that they have a fixed order"
            */
           }
           
       }
       
   });