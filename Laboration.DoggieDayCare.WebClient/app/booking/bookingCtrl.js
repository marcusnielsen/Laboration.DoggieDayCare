(function () {
    var ctrl = function ($scope, $http) {
        $scope.template = {
            addBookingTemplateUrl: 'app/booking/addBooking.html',
            endBookingTemplateUrl: 'app/booking/endBooking.html'
        };

        $scope.result = { addResult: "", endResult: "" };

        $scope.addBookingData = {
            "DogBreedName": "Beast",
            "OwnerCivicRegistrationNumber": "8012121234",
            "DogRegistrationNumber": "1234567890",
            "CheckIn": new Date().toISOString(),
            "CheckInFoodWeight": "1.5"
        };

        $scope.endBookingData = {
            "Id": "",
            "CheckOut": new Date().toISOString(),
            "CheckOutFoodWeight": "0.5"
        };

        $scope.addBooking = function () {
            $http.post("http://localhost:49640/api/Booking", $scope.addBookingData, {}).then(function(result) {
                $scope.result.addResult = result.data;

                $scope.endBookingData.Id = result.data;
            });
        };

        $scope.endBooking = function () {
            $http.put("http://localhost:49640/api/Booking", $scope.endBookingData, {}).then(function (result) {
                $scope.result.endResult = result.data;
            });
        };
    };
    
    angular.module('app').controller('bookingCtrl', ['$scope', '$http', ctrl]);
})();