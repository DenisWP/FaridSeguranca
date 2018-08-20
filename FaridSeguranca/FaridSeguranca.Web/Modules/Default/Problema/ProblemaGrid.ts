
namespace FaridSeguranca.Default {

    @Serenity.Decorators.registerClass()
    export class ProblemaGrid extends Serenity.EntityGrid<ProblemaRow, any> {
        protected getColumnsKey() { return 'Default.Problema'; }
        protected getDialogType() { return ProblemaDialog; }
        protected getIdProperty() { return ProblemaRow.idProperty; }
        protected getLocalTextPrefix() { return ProblemaRow.localTextPrefix; }
        protected getService() { return ProblemaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}