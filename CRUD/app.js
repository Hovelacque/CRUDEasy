
var app = angular.module('app', [
    'ngAnimate',
    'ngSanitize',
    'ngCookies',
    'ngMaterial',
    'ngMessages',

    'ui.router',
    'ui.bootstrap',
    'ui.jq',

]);

app.service('DTO', [
    '$cookies',
   function ($cookies) {
       var vm = this;

       var keyId = 'id';

       vm.setId = function (id) {
           $cookies.put(keyId, id);
       };

       vm.getId = function () {
           return $cookies.get(keyId);
       };
   }
]);

app.filter('foneformat', function () {
    return function (number) {

        if (!number) { return ''; }

        number = String(number);
        
        var area = number.substring(0,2);
        var front = number.substring(2, 6);
        var end = number.substring(6, 10);

        if (front) {
            formattedNumber = ("(" + area + ") " + front);  
        }
        if (end) {
            formattedNumber += ("-" + end);
        }
        return formattedNumber;
    };
});

