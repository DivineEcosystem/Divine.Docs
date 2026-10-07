# <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery"></a> Class CMsgDOTAHasItemQuery

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAHasItemQuery : IMessage<CMsgDOTAHasItemQuery>, IEquatable<CMsgDOTAHasItemQuery>, IDeepCloneable<CMsgDOTAHasItemQuery>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)

#### Implements

IMessage<CMsgDOTAHasItemQuery\>, 
[IEquatable<CMsgDOTAHasItemQuery\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAHasItemQuery\>, 
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
[EnumerableExtensions.In<CMsgDOTAHasItemQuery\>\(CMsgDOTAHasItemQuery, params CMsgDOTAHasItemQuery\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery__ctor"></a> CMsgDOTAHasItemQuery\(\)

```csharp
public CMsgDOTAHasItemQuery()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery__ctor_Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_"></a> CMsgDOTAHasItemQuery\(CMsgDOTAHasItemQuery\)

```csharp
public CMsgDOTAHasItemQuery(CMsgDOTAHasItemQuery other)
```

#### Parameters

`other` [CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_ItemIdFieldNumber"></a> ItemIdFieldNumber

```csharp
public const int ItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_HasItemId"></a> HasItemId

```csharp
public bool HasItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_ItemId"></a> ItemId

```csharp
public ulong ItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAHasItemQuery> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_ClearItemId"></a> ClearItemId\(\)

```csharp
public void ClearItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAHasItemQuery Clone()
```

#### Returns

 [CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_Equals_Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_"></a> Equals\(CMsgDOTAHasItemQuery\)

```csharp
public bool Equals(CMsgDOTAHasItemQuery other)
```

#### Parameters

`other` [CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_"></a> MergeFrom\(CMsgDOTAHasItemQuery\)

```csharp
public void MergeFrom(CMsgDOTAHasItemQuery other)
```

#### Parameters

`other` [CMsgDOTAHasItemQuery](Divine.Protobufs.Dota2.CMsgDOTAHasItemQuery.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAHasItemQuery_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

