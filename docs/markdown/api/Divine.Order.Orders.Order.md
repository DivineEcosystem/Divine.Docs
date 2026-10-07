# <a id="Divine_Order_Orders_Order"></a> Class Order

Namespace: [Divine.Order.Orders](Divine.Order.Orders.md)  
Assembly: Divine.dll  

```csharp
public sealed class Order
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Order](Divine.Order.Orders.Order.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<Order\>\(Order, params Order\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Order_Orders_Order_Ability"></a> Ability

```csharp
public Ability? Ability { get; set; }
```

#### Property Value

 [Ability](Divine.Entity.Entities.Abilities.Ability.md)?

### <a id="Divine_Order_Orders_Order_AbilityIndex"></a> AbilityIndex

```csharp
public int AbilityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Order_Orders_Order_Flags"></a> Flags

```csharp
public uint Flags { get; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Order_Orders_Order_IsAdding"></a> IsAdding

```csharp
public bool IsAdding { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_Orders_Order_IsChanged"></a> IsChanged

```csharp
public bool IsChanged { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_Orders_Order_IsQueued"></a> IsQueued

```csharp
public bool IsQueued { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_Orders_Order_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Order_Orders_Order_ItemId"></a> ItemId

```csharp
public AbilityId ItemId { get; set; }
```

#### Property Value

 [AbilityId](Divine.Entity.Entities.Abilities.Components.AbilityId.md)

### <a id="Divine_Order_Orders_Order_Position"></a> Position

```csharp
public Vector3 Position { get; set; }
```

#### Property Value

 [Vector3](https://learn.microsoft.com/dotnet/api/system.numerics.vector3)

### <a id="Divine_Order_Orders_Order_SequenceNumber"></a> SequenceNumber

```csharp
public int SequenceNumber { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Order_Orders_Order_Target"></a> Target

```csharp
public Entity? Target { get; set; }
```

#### Property Value

 [Entity](Divine.Entity.Entities.Entity.md)?

### <a id="Divine_Order_Orders_Order_TargetIndex"></a> TargetIndex

```csharp
public int TargetIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Order_Orders_Order_TargetSlot"></a> TargetSlot

```csharp
public ItemSlot TargetSlot { get; set; }
```

#### Property Value

 [ItemSlot](Divine.Entity.Entities.Abilities.Items.Components.ItemSlot.md)

### <a id="Divine_Order_Orders_Order_Type"></a> Type

```csharp
public OrderType Type { get; set; }
```

#### Property Value

 [OrderType](Divine.Order.Orders.Components.OrderType.md)

### <a id="Divine_Order_Orders_Order_Units"></a> Units

```csharp
public IEnumerable<Unit> Units { get; set; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Unit](Divine.Entity.Entities.Units.Unit.md)\>

