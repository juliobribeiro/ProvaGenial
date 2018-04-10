'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.loginData = {
        userName: "julio",
        password: "julio1234"
    };

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            $location.path('/contatos');
        },
         function (err) {
             $scope.message = "Ocorreu algum erro ao autenticar.";
         });
    };

}]);