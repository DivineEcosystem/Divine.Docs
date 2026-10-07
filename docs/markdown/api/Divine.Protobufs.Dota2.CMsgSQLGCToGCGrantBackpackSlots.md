# <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots"></a> Class CMsgSQLGCToGCGrantBackpackSlots

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSQLGCToGCGrantBackpackSlots : IMessage<CMsgSQLGCToGCGrantBackpackSlots>, IEquatable<CMsgSQLGCToGCGrantBackpackSlots>, IDeepCloneable<CMsgSQLGCToGCGrantBackpackSlots>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)

#### Implements

IMessage<CMsgSQLGCToGCGrantBackpackSlots\>, 
[IEquatable<CMsgSQLGCToGCGrantBackpackSlots\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSQLGCToGCGrantBackpackSlots\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgSQLGCToGCGrantBackpackSlots\>\(CMsgSQLGCToGCGrantBackpackSlots, params CMsgSQLGCToGCGrantBackpackSlots\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots__ctor"></a> CMsgSQLGCToGCGrantBackpackSlots\(\)

```csharp
public CMsgSQLGCToGCGrantBackpackSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots__ctor_Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_"></a> CMsgSQLGCToGCGrantBackpackSlots\(CMsgSQLGCToGCGrantBackpackSlots\)

```csharp
public CMsgSQLGCToGCGrantBackpackSlots(CMsgSQLGCToGCGrantBackpackSlots other)
```

#### Parameters

`other` [CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_AddSlotsFieldNumber"></a> AddSlotsFieldNumber

```csharp
public const int AddSlotsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_AddSlots"></a> AddSlots

```csharp
public uint AddSlots { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_HasAddSlots"></a> HasAddSlots

```csharp
public bool HasAddSlots { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSQLGCToGCGrantBackpackSlots> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_ClearAddSlots"></a> ClearAddSlots\(\)

```csharp
public void ClearAddSlots()
```

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_Clone"></a> Clone\(\)

```csharp
public CMsgSQLGCToGCGrantBackpackSlots Clone()
```

#### Returns

 [CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_Equals_Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_"></a> Equals\(CMsgSQLGCToGCGrantBackpackSlots\)

```csharp
public bool Equals(CMsgSQLGCToGCGrantBackpackSlots other)
```

#### Parameters

`other` [CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_MergeFrom_Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_"></a> MergeFrom\(CMsgSQLGCToGCGrantBackpackSlots\)

```csharp
public void MergeFrom(CMsgSQLGCToGCGrantBackpackSlots other)
```

#### Parameters

`other` [CMsgSQLGCToGCGrantBackpackSlots](Divine.Protobufs.Dota2.CMsgSQLGCToGCGrantBackpackSlots.md)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSQLGCToGCGrantBackpackSlots_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

