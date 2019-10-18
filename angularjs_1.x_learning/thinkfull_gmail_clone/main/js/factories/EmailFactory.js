
//*what exactly is this doing and how is this connected
//*must handle the model and send it somewhere? look at get message
//Q is a promise
//*and deferrment and what does that have to do with get

angular.module('EmailApp')
    .factory('EmailFactory', function EmailFactory ($q, $http, $routeParams)
    {
//Is the Q the rootscope?        
        
        'use strict';
        var exports = {};
        
        exports.reply = function (message)
        {
            if (message)
            {
              alert('Reply content: ' + message);
            }
        };
        
        exports.getMessage = function (params)
        {
            if (params.id)
            
            {
                var deferred = $q.defer();
                $http.get('json/message/' + params.id + '.json')
                    .success(function (data)
                    {
                        deferred.resolve(data);
                    })
                    .error(function (data)
                    {
                        deferred.reject(data);
                    });
                return deferred.promise;                
            }
        };
        
        return exports;
    });