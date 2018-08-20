namespace FaridSeguranca.Northwind {
    export enum OrderShippingState {
        NotShipped = 0,
        Shipped = 1
    }
    Serenity.Decorators.registerEnumType(OrderShippingState, 'FaridSeguranca.Northwind.OrderShippingState', 'Northwind.OrderShippingState');
}

