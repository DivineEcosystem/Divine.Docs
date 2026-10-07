# <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest"></a> Class CMsgClientToGCTeammateStatsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCTeammateStatsRequest : IMessage<CMsgClientToGCTeammateStatsRequest>, IEquatable<CMsgClientToGCTeammateStatsRequest>, IDeepCloneable<CMsgClientToGCTeammateStatsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)

#### Implements

IMessage<CMsgClientToGCTeammateStatsRequest\>, 
[IEquatable<CMsgClientToGCTeammateStatsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCTeammateStatsRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCTeammateStatsRequest\>\(CMsgClientToGCTeammateStatsRequest, params CMsgClientToGCTeammateStatsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest__ctor"></a> CMsgClientToGCTeammateStatsRequest\(\)

```csharp
public CMsgClientToGCTeammateStatsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_"></a> CMsgClientToGCTeammateStatsRequest\(CMsgClientToGCTeammateStatsRequest\)

```csharp
public CMsgClientToGCTeammateStatsRequest(CMsgClientToGCTeammateStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCTeammateStatsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCTeammateStatsRequest Clone()
```

#### Returns

 [CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_"></a> Equals\(CMsgClientToGCTeammateStatsRequest\)

```csharp
public bool Equals(CMsgClientToGCTeammateStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_"></a> MergeFrom\(CMsgClientToGCTeammateStatsRequest\)

```csharp
public void MergeFrom(CMsgClientToGCTeammateStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCTeammateStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCTeammateStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTeammateStatsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

