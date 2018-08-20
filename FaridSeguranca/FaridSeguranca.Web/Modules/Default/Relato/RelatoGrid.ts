
namespace FaridSeguranca.Default {

    @Serenity.Decorators.registerClass()
    export class RelatoGrid extends Serenity.EntityGrid<RelatoRow, any> {
        protected getColumnsKey() { return 'Default.Relato'; }
        protected getDialogType() { return RelatoDialog; }
        protected getIdProperty() { return RelatoRow.idProperty; }
        protected getLocalTextPrefix() { return RelatoRow.localTextPrefix; }
        protected getService() { return RelatoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}