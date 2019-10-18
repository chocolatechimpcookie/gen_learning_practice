// app/routes.js

//grab the nerd model we just created
var Nerd = require('./models/nerd');

    module.exports = function(app)
    {
      
        //server routes, handle things like api calls  
        //authentication routes
        
        //simple api route
        app.get('/api/nerds', function(req,res)
        {
           //use mongoose to get all nerds in the database
           Nerd.find(function(err, nerds)
            {
               //if there is an error retrieving, send the error
                //nothing after res.send (err) will execute
                
                if(err)
                    res.send(err);
                    
                res.json(nerds);
            });
           
        });
        
        
        
        
        //route to hand creating goes here (app.post)
        //route to handle delete goes here (app.delete)
        
        //front end routes,
        
        //handles angular requests
        //this is our catch-all route
        app.get('*', function(req, res)
        {
           res.sendfile('./public/views/index.html');
           //load our public/index.html
        });
    };