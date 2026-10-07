# <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest"></a> Class CMsgDOTAMyTeamInfoRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAMyTeamInfoRequest : IMessage<CMsgDOTAMyTeamInfoRequest>, IEquatable<CMsgDOTAMyTeamInfoRequest>, IDeepCloneable<CMsgDOTAMyTeamInfoRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)

#### Implements

IMessage<CMsgDOTAMyTeamInfoRequest\>, 
[IEquatable<CMsgDOTAMyTeamInfoRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAMyTeamInfoRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAMyTeamInfoRequest\>\(CMsgDOTAMyTeamInfoRequest, params CMsgDOTAMyTeamInfoRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest__ctor"></a> CMsgDOTAMyTeamInfoRequest\(\)

```csharp
public CMsgDOTAMyTeamInfoRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_"></a> CMsgDOTAMyTeamInfoRequest\(CMsgDOTAMyTeamInfoRequest\)

```csharp
public CMsgDOTAMyTeamInfoRequest(CMsgDOTAMyTeamInfoRequest other)
```

#### Parameters

`other` [CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAMyTeamInfoRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAMyTeamInfoRequest Clone()
```

#### Returns

 [CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_"></a> Equals\(CMsgDOTAMyTeamInfoRequest\)

```csharp
public bool Equals(CMsgDOTAMyTeamInfoRequest other)
```

#### Parameters

`other` [CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_"></a> MergeFrom\(CMsgDOTAMyTeamInfoRequest\)

```csharp
public void MergeFrom(CMsgDOTAMyTeamInfoRequest other)
```

#### Parameters

`other` [CMsgDOTAMyTeamInfoRequest](Divine.Protobufs.Dota2.CMsgDOTAMyTeamInfoRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAMyTeamInfoRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

