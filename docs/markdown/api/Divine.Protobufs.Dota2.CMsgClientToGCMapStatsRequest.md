# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest"></a> Class CMsgClientToGCMapStatsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMapStatsRequest : IMessage<CMsgClientToGCMapStatsRequest>, IEquatable<CMsgClientToGCMapStatsRequest>, IDeepCloneable<CMsgClientToGCMapStatsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)

#### Implements

IMessage<CMsgClientToGCMapStatsRequest\>, 
[IEquatable<CMsgClientToGCMapStatsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMapStatsRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMapStatsRequest\>\(CMsgClientToGCMapStatsRequest, params CMsgClientToGCMapStatsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest__ctor"></a> CMsgClientToGCMapStatsRequest\(\)

```csharp
public CMsgClientToGCMapStatsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_"></a> CMsgClientToGCMapStatsRequest\(CMsgClientToGCMapStatsRequest\)

```csharp
public CMsgClientToGCMapStatsRequest(CMsgClientToGCMapStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMapStatsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMapStatsRequest Clone()
```

#### Returns

 [CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_"></a> Equals\(CMsgClientToGCMapStatsRequest\)

```csharp
public bool Equals(CMsgClientToGCMapStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_"></a> MergeFrom\(CMsgClientToGCMapStatsRequest\)

```csharp
public void MergeFrom(CMsgClientToGCMapStatsRequest other)
```

#### Parameters

`other` [CMsgClientToGCMapStatsRequest](Divine.Protobufs.Dota2.CMsgClientToGCMapStatsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMapStatsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

