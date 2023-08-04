    angular.module('AttendanceModel', [])
        .controller('AttendanceController', function ($scope) {
            $scope.courseList = [];
            $scope.groupList = [];
            $scope.levelList = [];
            $scope.init = function (AttendanceDataList) {
                $scope.courseList = AttendanceDataList.CourseData;
                $scope.groupList = AttendanceDataList.GroupData;
                $scope.levelList = AttendanceDataList.LevelData;
            
            }
            $scope.onClickSaveBtn() = function () {
                var data = {
                    LevelId = $scope.LevelId,
                    CourseId = $scope.courseId,
                    GroupId = $scope.groupId
                }
                $http.post('/Attendances/getStudentData', data)
                    .then(function (response) {
                        // Handle the response from the server
                    })
                    .catch(function (error) {
                        // Handle any errors
                    });
            }
    });
