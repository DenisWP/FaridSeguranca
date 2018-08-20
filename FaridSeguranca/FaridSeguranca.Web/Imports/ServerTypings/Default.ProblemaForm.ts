namespace FaridSeguranca.Default {
    export interface ProblemaForm {
        CriadoPor: Serenity.IntegerEditor;
        Relatado: Serenity.StringEditor;
        RelatoId: Serenity.IntegerEditor;
        LocalEmpresa: Serenity.IntegerEditor;
        Descricao: Serenity.StringEditor;
    }

    export class ProblemaForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Problema';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProblemaForm.init)  {
                ProblemaForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(ProblemaForm, [
                    'CriadoPor', w0,
                    'Relatado', w1,
                    'RelatoId', w0,
                    'LocalEmpresa', w0,
                    'Descricao', w1
                ]);
            }
        }
    }
}

