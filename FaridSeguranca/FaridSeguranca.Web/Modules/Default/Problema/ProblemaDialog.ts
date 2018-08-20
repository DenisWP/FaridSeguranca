
namespace FaridSeguranca.Default {

    @Serenity.Decorators.registerClass()
    export class ProblemaDialog extends Serenity.EntityDialog<ProblemaRow, any> {
        protected getFormKey() { return ProblemaForm.formKey; }
        protected getIdProperty() { return ProblemaRow.idProperty; }
        protected getLocalTextPrefix() { return ProblemaRow.localTextPrefix; }
        protected getNameProperty() { return ProblemaRow.nameProperty; }
        protected getService() { return ProblemaService.baseUrl; }

        protected form = new ProblemaForm(this.idPrefix);

    }
}