namespace FaridSeguranca.Default {
    export interface EmpresaForm {
        Nome: Serenity.StringEditor;
    }

    export class EmpresaForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Empresa';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!EmpresaForm.init)  {
                EmpresaForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(EmpresaForm, [
                    'Nome', w0
                ]);
            }
        }
    }
}

