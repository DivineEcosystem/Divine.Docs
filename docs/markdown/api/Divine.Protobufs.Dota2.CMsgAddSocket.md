# <a id="Divine_Protobufs_Dota2_CMsgAddSocket"></a> Class CMsgAddSocket

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAddSocket : IMessage<CMsgAddSocket>, IEquatable<CMsgAddSocket>, IDeepCloneable<CMsgAddSocket>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)

#### Implements

IMessage<CMsgAddSocket\>, 
[IEquatable<CMsgAddSocket\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAddSocket\>, 
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
[EnumerableExtensions.In<CMsgAddSocket\>\(CMsgAddSocket, params CMsgAddSocket\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket__ctor"></a> CMsgAddSocket\(\)

```csharp
public CMsgAddSocket()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket__ctor_Divine_Protobufs_Dota2_CMsgAddSocket_"></a> CMsgAddSocket\(CMsgAddSocket\)

```csharp
public CMsgAddSocket(CMsgAddSocket other)
```

#### Parameters

`other` [CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ItemItemIdFieldNumber"></a> ItemItemIdFieldNumber

```csharp
public const int ItemItemIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ToolItemIdFieldNumber"></a> ToolItemIdFieldNumber

```csharp
public const int ToolItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_UnusualFieldNumber"></a> UnusualFieldNumber

```csharp
public const int UnusualFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_HasItemItemId"></a> HasItemItemId

```csharp
public bool HasItemItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_HasToolItemId"></a> HasToolItemId

```csharp
public bool HasToolItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_HasUnusual"></a> HasUnusual

```csharp
public bool HasUnusual { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ItemItemId"></a> ItemItemId

```csharp
public ulong ItemItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAddSocket> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ToolItemId"></a> ToolItemId

```csharp
public ulong ToolItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Unusual"></a> Unusual

```csharp
public bool Unusual { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ClearItemItemId"></a> ClearItemItemId\(\)

```csharp
public void ClearItemItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ClearToolItemId"></a> ClearToolItemId\(\)

```csharp
public void ClearToolItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ClearUnusual"></a> ClearUnusual\(\)

```csharp
public void ClearUnusual()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Clone"></a> Clone\(\)

```csharp
public CMsgAddSocket Clone()
```

#### Returns

 [CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_Equals_Divine_Protobufs_Dota2_CMsgAddSocket_"></a> Equals\(CMsgAddSocket\)

```csharp
public bool Equals(CMsgAddSocket other)
```

#### Parameters

`other` [CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_MergeFrom_Divine_Protobufs_Dota2_CMsgAddSocket_"></a> MergeFrom\(CMsgAddSocket\)

```csharp
public void MergeFrom(CMsgAddSocket other)
```

#### Parameters

`other` [CMsgAddSocket](Divine.Protobufs.Dota2.CMsgAddSocket.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAddSocket_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

