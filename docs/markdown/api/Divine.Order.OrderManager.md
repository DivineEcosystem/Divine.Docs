# <a id="Divine_Order_OrderManager"></a> Class OrderManager

Namespace: [Divine.Order](Divine.Order.md)  
Assembly: Divine.dll  

```csharp
public static class OrderManager
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[OrderManager](Divine.Order.OrderManager.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Properties

### <a id="Divine_Order_OrderManager_Orders"></a> Orders

```csharp
public static IEnumerable<Order> Orders { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Order](Divine.Order.Orders.Order.md)\>

## Methods

### <a id="Divine_Order_OrderManager_ClearOrders"></a> ClearOrders\(\)

```csharp
public static void ClearOrders()
```

### <a id="Divine_Order_OrderManager_CreateOrder_Divine_Order_Orders_Components_OrderType_System_Collections_Generic_IEnumerable_Divine_Entity_Entities_Units_Unit__System_Int32_System_Int32_System_Numerics_Vector3_System_Boolean_System_Boolean_System_Boolean_"></a> CreateOrder\(OrderType, IEnumerable<Unit\>, int, int, Vector3, bool, bool, bool\)

```csharp
public static bool CreateOrder(OrderType orderType, IEnumerable<Unit> units, int targetIndex, int abilityIndex, Vector3 position, bool queued, bool showEffects, bool bypassOrderAdding)
```

#### Parameters

`orderType` [OrderType](Divine.Order.Orders.Components.OrderType.md)

`units` [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

`targetIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`abilityIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`showEffects` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_OrderManager_CreateOrder_Divine_Order_Orders_Components_OrderType_Divine_Entity_Entities_Units_Unit_System_Int32_System_Int32_System_Numerics_Vector3_System_Boolean_System_Boolean_System_Boolean_"></a> CreateOrder\(OrderType, Unit, int, int, Vector3, bool, bool, bool\)

```csharp
public static bool CreateOrder(OrderType orderType, Unit unit, int targetIndex, int abilityIndex, Vector3 position, bool queued, bool showEffects, bool bypassOrderAdding)
```

#### Parameters

`orderType` [OrderType](Divine.Order.Orders.Components.OrderType.md)

`unit` [Unit](Divine.Entity.Entities.Units.Unit.md)

`targetIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`abilityIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`position` [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

`queued` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`showEffects` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`bypassOrderAdding` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_OrderManager_GetOrderBySequenceNumber_System_Int32_"></a> GetOrderBySequenceNumber\(int\)

```csharp
public static Order? GetOrderBySequenceNumber(int sequenceNumber)
```

#### Parameters

`sequenceNumber` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Order](Divine.Order.Orders.Order.md)?

### <a id="Divine_Order_OrderManager_OrderAdding"></a> OrderAdding

```csharp
public static event OrderManager.OrderAddingEventHandler OrderAdding
```

#### Event Type

 [OrderManager](Divine.Order.OrderManager.md).[OrderAddingEventHandler](Divine.Order.OrderManager.OrderAddingEventHandler.md)

### <a id="Divine_Order_OrderManager_OrderHumanizer"></a> OrderHumanizer

```csharp
public static event OrderManager.OrderHumanizerEventHandler OrderHumanizer
```

#### Event Type

 [OrderManager](Divine.Order.OrderManager.md).[OrderHumanizerEventHandler](Divine.Order.OrderManager.OrderHumanizerEventHandler.md)

### <a id="Divine_Order_OrderManager_OrderOverwatchAdding"></a> OrderOverwatchAdding

```csharp
public static event OrderManager.OrderOverwatchAddingEventHandler OrderOverwatchAdding
```

#### Event Type

 [OrderManager](Divine.Order.OrderManager.md).[OrderOverwatchAddingEventHandler](Divine.Order.OrderManager.OrderOverwatchAddingEventHandler.md)

