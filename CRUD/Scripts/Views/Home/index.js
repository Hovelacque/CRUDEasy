(function () {
    angular.module('app').controller('app.views.home.index', [
        '$scope', '$http', 'DTO',
        function ($scope, $http, DTO) {
            var vm = this;

            vm.programadores = [];
            vm.filtrado = [];

            function load() {
                $http({
                    method: "POST",
                    url: '/Programador/GetAll',
                    data: '',
                }).success(function (result) {
                    vm.programadores = result;
                }).error(function () {
                    sweetAlert("Erro ao Carregar :(", "Erro durante Get na Base", "error");
                });
            };
            load();

            vm.filtro = function (item) {
                if (vm.pesquisa == undefined || vm.pesquisa == null)
                    return true;

                if (vm.pesquisa == "") {
                    vm.pesquisa = undefined;
                    load();
                    return true;
                }

                if (item.id == vm.pesquisa ||
                    item.Nome.toLowerCase().indexOf(vm.pesquisa.toLowerCase()) != -1)
                    return true;

                return false;
            };

            vm.new = function () {
                DTO.setId("");
                document.location = '/Programador/Index';
            };

            vm.select = function (id) {
                DTO.setId(id);
                document.location = '/Programador/Index';
            }


        }]);
})();
