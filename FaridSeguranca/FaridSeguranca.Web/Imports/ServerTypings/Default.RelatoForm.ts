namespace FaridSeguranca.Default {
    export interface RelatoForm {
        TipoRelato: Serenity.StringEditor;
    }

    export class RelatoForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Relato';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RelatoForm.init)  {
                RelatoForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RelatoForm, [
                    'TipoRelato', w0
                ]);
            }
        }
    }
}

