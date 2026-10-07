# <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData"></a> Class CMsgAddItemToSocketData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAddItemToSocketData : IMessage<CMsgAddItemToSocketData>, IEquatable<CMsgAddItemToSocketData>, IDeepCloneable<CMsgAddItemToSocketData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)

#### Implements

IMessage<CMsgAddItemToSocketData\>, 
[IEquatable<CMsgAddItemToSocketData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAddItemToSocketData\>, 
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
[EnumerableExtensions.In<CMsgAddItemToSocketData\>\(CMsgAddItemToSocketData, params CMsgAddItemToSocketData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData__ctor"></a> CMsgAddItemToSocketData\(\)

```csharp
public CMsgAddItemToSocketData()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData__ctor_Divine_Protobufs_Dota2_CMsgAddItemToSocketData_"></a> CMsgAddItemToSocketData\(CMsgAddItemToSocketData\)

```csharp
public CMsgAddItemToSocketData(CMsgAddItemToSocketData other)
```

#### Parameters

`other` [CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_GemItemIdFieldNumber"></a> GemItemIdFieldNumber

```csharp
public const int GemItemIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_SocketIndexFieldNumber"></a> SocketIndexFieldNumber

```csharp
public const int SocketIndexFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_GemItemId"></a> GemItemId

```csharp
public ulong GemItemId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_HasGemItemId"></a> HasGemItemId

```csharp
public bool HasGemItemId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_HasSocketIndex"></a> HasSocketIndex

```csharp
public bool HasSocketIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAddItemToSocketData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_SocketIndex"></a> SocketIndex

```csharp
public uint SocketIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_ClearGemItemId"></a> ClearGemItemId\(\)

```csharp
public void ClearGemItemId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_ClearSocketIndex"></a> ClearSocketIndex\(\)

```csharp
public void ClearSocketIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_Clone"></a> Clone\(\)

```csharp
public CMsgAddItemToSocketData Clone()
```

#### Returns

 [CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_Equals_Divine_Protobufs_Dota2_CMsgAddItemToSocketData_"></a> Equals\(CMsgAddItemToSocketData\)

```csharp
public bool Equals(CMsgAddItemToSocketData other)
```

#### Parameters

`other` [CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_MergeFrom_Divine_Protobufs_Dota2_CMsgAddItemToSocketData_"></a> MergeFrom\(CMsgAddItemToSocketData\)

```csharp
public void MergeFrom(CMsgAddItemToSocketData other)
```

#### Parameters

`other` [CMsgAddItemToSocketData](Divine.Protobufs.Dota2.CMsgAddItemToSocketData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAddItemToSocketData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

