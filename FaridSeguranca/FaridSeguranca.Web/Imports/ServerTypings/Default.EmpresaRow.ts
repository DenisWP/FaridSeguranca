namespace FaridSeguranca.Default {
    export interface EmpresaRow {
        Id?: number;
        Nome?: string;
    }

    export namespace EmpresaRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nome';
        export const localTextPrefix = 'Default.Empresa';

        export declare const enum Fields {
            Id = "Id",
            Nome = "Nome"
        }
    }
}

