(function () {
    angular.module('app').controller('app.views.programador.index', [
        '$scope', '$http', 'DTO',
        function ($scope, $http, DTO) {
            var vm = this;

            vm.programador = {
                Id: DTO.getId(),
                Nome: '',
                Skype: '',
                Telefone: '',
                Email: '',
                Linkdin: '',
                Cidade: '',
                Estado: '',
                SalarioHora: '',
                SalarioMes: '',
                Portifolio: '',
                Linguagens: '',
                Trabalhos: '',
                GerenciadorWeb: '',
                EditorImagem: '',
                Interesse: '',
                Curso: '',
                Horas: '',
                Horario: '',
            };

            function load() {
                $http({
                    method: 'POST',
                    url: '/Programador/Get',
                    data: { id: vm.programador.Id },
                }).success(function (data) {
                    vm.programador = data;
                })
            }


            if (vm.programador.Id == "") { //Save
                vm.saveUpdate = function () {
                    var form = $('#Form').parsley();
                    if (!form.isValid())
                        return false;

                    $http({
                        method: "POST",
                        url: '/Programador/Insert',
                        data: vm.programador,
                    }).success(function (result) {
                        toastr["success"](result.Mensagem);
                        document.location = '/Home';
                    }).error(function (result) {
                        toastr["error"]("Erro ao salvar.");
                        console.log(result.Mensagem)
                    });
                }
            }
            else { //Update
                load();
                vm.saveUpdate = function () {
                    var form = $('#Form').parsley();
                    if (!form.isValid())
                        return false;

                    $http({
                        method: "POST",
                        url: '/Programador/Update',
                        data: vm.programador,
                    }).success(function (result) {
                        toastr["success"](result.Mensagem);
                        document.location = '/Home';
                    }).error(function (result) {
                        toastr["error"]("Erro ao salvar.");
                        console.log(result.Mensagem)
                    });
                }
            }

            vm.delete = function () {
                swal({
                    title: "Atenção",
                    text: "O Registro será Deletado!",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Continuar",
                    cancelButtonText: "Cancelar",
                    closeOnConfirm: false
                },
                function () {
                    $http({
                        method: "POST",
                        url: '/Programador/Delete',
                        data: vm.programador,
                    }).success(function (result) {
                        toastr["success"](result.Mensagem);
                        document.location = '/Home';
                    }).error(function (result) {
                        toastr["error"]("Erro ao deletar.");
                        console.log(result.Mensagem)
                    });
                });
            }

        }]);
})();
