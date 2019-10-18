var obj1 = {}; //new object via object literal
var arr1 = []; //new array via Array literal
var func1 = function() {}; //a new function via function literal

var obj2 = new Object(); //via object constructor
var arr2 = new Array(); //via array constructor
var func2 = new Function(); //via function constructor


//here, the third argument is the body of the function

var adder2 = new function ("num1", "num2", "return num1 + num2");

//you can dynamically create new functions via other functions

function make(adjective)
{
	return new Function('noun', "return noun[0].toUpperCase() + noun.slice(1) + ' is " + adjective + "!'");

}

var isFun = make('fun');

isFun('biking'); ///"biking is fun!", fun was already passed into Make, so biking is being passed as noun



//function numLetters("letter")
//{
//	return new Function('number', "return letter*number");	
//	
//}

//^error

//the "\" allows you to write the string across multiple lines 

function numLetters("letter")
{
	return new Function('number',
		"if (number < 0) return ''; \
		var result = ''; \
		number = Math.round(times); \
		while(times --) \
			{ result += '" + letter + "'; } \
			return result;"  
		");	
	
}

// using '\' lets you write the passing argument 
