// Write your Javascript code.
var maruhanModule = angular.module('maruhanModule', []);
maruhanModule
    .run(function ($rootScope, $location) {

    })
    .controller('menuController', menuController)
    .controller('diaryController', diaryController)
    .controller('footerController', footerController);


function menuController($rootScope, $scope, $http, $window, $location) {
    $scope.go = function ($event, where) {
        console.log($($event.currentTarget).hasClass("active"));
        $($event.currentTarget).addClass("active");
        console.log($($event.currentTarget).hasClass("active"));

        if (where == "Index") {
            location.href = "/";
            return;
        }
        //$window.location.href = "/" + where + "/Index/";
        $location.path("/" + where);
    }
}

function diaryController($rootScope, $scope, $window, $http) {
    $scope.goToWrite = function () {
        $window.location.href = "/Diary/Write";
    }

    $scope.DiaryList = {};
    $scope.Diary = { "Title": "", "isSecret": false, "Contents": "" };

    $scope.getDiaryList = function () {
        $http({
            method: "GET",
            url: "/Diary/GetList"
        }).then(function (res) {
            //console.log(res);
        });
    }

    $scope.WriteDiary = function () {
        $http({
            method: "POST",
            url: "/Diary/WriteDiary",
            data: JSON.stringify($scope.Diary),
            dataType: "json",
            contentType: "application/json"
        }).then(function (res) {
            console.log(res);
        });
    }

    //AcountController
    $scope.User = { "Account": "", "Password": "", "Email": "", "UserName": "" };
    $scope.Join = function () {
        $http({
            method: "POST",
            url: "/Account/Create",
            data: JSON.stringify($scope.User),
            dataType: "json",
            contentType: "application/json"
        }).then(function (res) {
            console.log(res);
        });
    }

}

function success() {
    console.log("success");
}

function error() {
    console.log("fail");
}

function footerController($rootScope, $scope) {

}