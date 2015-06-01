﻿(function() {
    "use strict";
    angular.module("templateApp").controller("employeeListController", employeeListController);

    employeeListController.$inject = ['employeeResource'];

    function employeeListController(employeeResource) {
        var vm = this;

        employeeResource.query(function(data) {
            vm.employees = data;
        });
    }
}());