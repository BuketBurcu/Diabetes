(function () {
    'use strict';

    angular
        .module('app')
        .controller('DiabetesController', DiabetesController);

    DiabetesController.$inject = ['$location'];

    function DiabetesController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'DiabetesController';

        activate();

        function activate() { }
    }
})();
