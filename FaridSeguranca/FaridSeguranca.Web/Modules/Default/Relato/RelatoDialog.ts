
namespace FaridSeguranca.Default {

    @Serenity.Decorators.registerClass()
    export class RelatoDialog extends Serenity.EntityDialog<RelatoRow, any> {
        protected getFormKey() { return RelatoForm.formKey; }
        protected getIdProperty() { return RelatoRow.idProperty; }
        protected getLocalTextPrefix() { return RelatoRow.localTextPrefix; }
        protected getNameProperty() { return RelatoRow.nameProperty; }
        protected getService() { return RelatoService.baseUrl; }

        protected form = new RelatoForm(this.idPrefix);

    }
}