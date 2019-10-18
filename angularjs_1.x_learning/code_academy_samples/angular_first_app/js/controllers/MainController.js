app.controller('MainController', ['$scope', function($scope)
{
 $scope.title = 'We all love peanut butter'; 
 $scope.promo = "Damn son where'd you get this ";
 $scope.products = 
[ 
  { 
    name: 'The Book of Trees', 
    price: 19, 
    pubdate: new Date('2014', '03', '08'), 
    cover: 'img/the-book-of-trees.jpg',
    likes:0,
    dislikes:0
  }, 
  { 
    name: 'Program or be Programmed', 
    price: 8, 
    pubdate: new Date('2013', '08', '01'), 
    cover: 'img/program-or-be-programmed.jpg',
    likes:0,
    dislikes:0

  },
  {
    name:"Hatchet",
    price:3,
    pubdate: new Date("1922", "2", "03"),
    cover: "https://sharpread.files.wordpress.com/2011/06/99034_hatchet_gary_paulsen2.jpg",
    likes:0,
    dislikes:0
  },
  {
    name:"Hatchet",
    price:3,
    pubdate: new Date("1922", "2", "03"),
    cover: "https://sharpread.files.wordpress.com/2011/06/99034_hatchet_gary_paulsen2.jpg",
    likes:0,
    dislikes:0

  }
];
  $scope.plusOne =
    function(index)
  {
    $scope.products[index].likes += 1;
  };
  $scope.minusOne = 
    function(index)
  {
    $scope.products[index].dislikes +=1;
  };
}]);
