/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module("myModule", []);

myApp.controller("myController", myController);
myApp.service("Validator", Validator);
function myController($scope, Validator) {
    $scope.checkNumber = function () {
        $scope.message = Validator.checkNumber($scope.num);
    }
}
myApp.directive("teduDirective", function () {
    return {
        template: "<h1>This is my directive</h1"
    }
       
});
function Validator($window) {
    return {
        checkNumber:checkNumber
    }
    function checkNumber(number) {
        if (number % 2 == 0) {
            return 'This is even' ;
        }
        else {
            return 'This is odđ';
        }
    }
}

myController.$inject['$scope','Validator'];
