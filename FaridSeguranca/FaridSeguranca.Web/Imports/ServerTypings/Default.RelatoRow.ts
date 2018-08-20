namespace FaridSeguranca.Default {
    export interface RelatoRow {
        Id?: number;
        TipoRelato?: string;
    }

    export namespace RelatoRow {
        export const idProperty = 'Id';
        export const nameProperty = 'TipoRelato';
        export const localTextPrefix = 'Default.Relato';

        export declare const enum Fields {
            Id = "Id",
            TipoRelato = "TipoRelato"
        }
    }
}

