(function () {
    var ctrl = function($scope) {
        $scope.app = {
            title: "Doggie Day Care"
        };
    };

    angular.module('app').controller('appCtrl', ['$scope', ctrl]);
})();