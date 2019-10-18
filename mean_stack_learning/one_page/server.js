//modules

var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var methodOverride = require('method-override');

//config
var db = require('./config/db');

//set port
var port = process.env.PORT || 8080;
var mongoose = require('mongoose');
//connect to mongo
//add own credentials in config/db.js and then uncomment the next line
mongoose.connect(db.url);


//get all data of body POST parameters
// parse appliction/json
app.use(bodyParser.json());


//parse app/vnd.api + json as json
app.use(bodyParser.json({ type: 'application/vnd.api+json'  }));


//parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: true}));

// override with the X-HTTP-METHOD-OVERRIDE header in the request. simulate DELETE/PUT
app.use(methodOverride('X-HTTP-Method-Override'));


//set static files location /public/img will be /img for users
app.use(express.static(__dirname + '/public'));


//routes, configure our routes
require('./app/routes')(app);

//start app, start up at 8080
//   http://localhost:8080
app.listen(port);
console.log('Magic happens on port ' + port);

//expose app
exports = module.exports = app;
