# <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket"></a> Class CMsgAddItemToSocket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAddItemToSocket : IMessage<CMsgAddItemToSocket>, IEquatable<CMsgAddItemToSocket>, IDeepCloneable<CMsgAddItemToSocket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)

#### Implements

IMessage<CMsgAddItemToSocket\>, 
[IEquatable<CMsgAddItemToSocket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAddItemToSocket\>, 
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
[EnumerableExtensions.In<CMsgAddItemToSocket\>\(CMsgAddItemToSocket, params CMsgAddItemToSocket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket__ctor"></a> CMsgAddItemToSocket\(\)

```csharp
public CMsgAddItemToSocket()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket__ctor_Divine_Protobufs_Dota2_CMsgAddItemToSocket_"></a> CMsgAddItemToSocket\(CMsgAddItemToSocket\)

```csharp
public CMsgAddItemToSocket(CMsgAddItemToSocket other)
```

#### Parameters

`other` [CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_GemsToSocketFieldNumber"></a> GemsToSocketFieldNumber

```csharp
public const int GemsToSocketFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_ItemItemIdFieldNumber"></a> ItemItemIdFieldNumber

```csharp
public const int ItemItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_GemsToSocket"></a> GemsToSocket

```csharp
public RepeatedField<CMsgAddItemToSocketData> GemsToSocket { get; }
```

#### Property Value

 RepeatedField<[CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_HasItemItemId"></a> HasItemItemId

```csharp
public bool HasItemItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_ItemItemId"></a> ItemItemId

```csharp
public ulong ItemItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAddItemToSocket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_ClearItemItemId"></a> ClearItemItemId\(\)

```csharp
public void ClearItemItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_Clone"></a> Clone\(\)

```csharp
public CMsgAddItemToSocket Clone()
```

#### Returns

 [CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_Equals_Divine_Protobufs_Dota2_CMsgAddItemToSocket_"></a> Equals\(CMsgAddItemToSocket\)

```csharp
public bool Equals(CMsgAddItemToSocket other)
```

#### Parameters

`other` [CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_MergeFrom_Divine_Protobufs_Dota2_CMsgAddItemToSocket_"></a> MergeFrom\(CMsgAddItemToSocket\)

```csharp
public void MergeFrom(CMsgAddItemToSocket other)
```

#### Parameters

`other` [CMsgAddItemToSocket](Divine.Protobufs.Dota2.CMsgAddItemToSocket.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

