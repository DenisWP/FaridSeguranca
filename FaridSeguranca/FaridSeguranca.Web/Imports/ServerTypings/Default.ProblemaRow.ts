namespace FaridSeguranca.Default {
    export interface ProblemaRow {
        ProblemaId?: number;
        CriadoPor?: number;
        Relatado?: string;
        RelatoId?: number;
        LocalEmpresa?: number;
        Descricao?: string;
        CriadoPorUsername?: string;
        CriadoPorDisplayName?: string;
        CriadoPorEmail?: string;
        CriadoPorSource?: string;
        CriadoPorPasswordHash?: string;
        CriadoPorPasswordSalt?: string;
        CriadoPorLastDirectoryUpdate?: string;
        CriadoPorUserImage?: string;
        CriadoPorInsertDate?: string;
        CriadoPorInsertUserId?: number;
        CriadoPorUpdateDate?: string;
        CriadoPorUpdateUserId?: number;
        CriadoPorIsActive?: number;
        RelatoTipoRelato?: string;
        LocalEmpresaNome?: string;
    }

    export namespace ProblemaRow {
        export const idProperty = 'ProblemaId';
        export const nameProperty = 'Relatado';
        export const localTextPrefix = 'Default.Problema';

        export declare const enum Fields {
            ProblemaId = "ProblemaId",
            CriadoPor = "CriadoPor",
            Relatado = "Relatado",
            RelatoId = "RelatoId",
            LocalEmpresa = "LocalEmpresa",
            Descricao = "Descricao",
            CriadoPorUsername = "CriadoPorUsername",
            CriadoPorDisplayName = "CriadoPorDisplayName",
            CriadoPorEmail = "CriadoPorEmail",
            CriadoPorSource = "CriadoPorSource",
            CriadoPorPasswordHash = "CriadoPorPasswordHash",
            CriadoPorPasswordSalt = "CriadoPorPasswordSalt",
            CriadoPorLastDirectoryUpdate = "CriadoPorLastDirectoryUpdate",
            CriadoPorUserImage = "CriadoPorUserImage",
            CriadoPorInsertDate = "CriadoPorInsertDate",
            CriadoPorInsertUserId = "CriadoPorInsertUserId",
            CriadoPorUpdateDate = "CriadoPorUpdateDate",
            CriadoPorUpdateUserId = "CriadoPorUpdateUserId",
            CriadoPorIsActive = "CriadoPorIsActive",
            RelatoTipoRelato = "RelatoTipoRelato",
            LocalEmpresaNome = "LocalEmpresaNome"
        }
    }
}

