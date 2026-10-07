# <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest"></a> Class CMsgGCMatchDetailsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMatchDetailsRequest : IMessage<CMsgGCMatchDetailsRequest>, IEquatable<CMsgGCMatchDetailsRequest>, IDeepCloneable<CMsgGCMatchDetailsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)

#### Implements

IMessage<CMsgGCMatchDetailsRequest\>, 
[IEquatable<CMsgGCMatchDetailsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMatchDetailsRequest\>, 
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
[EnumerableExtensions.In<CMsgGCMatchDetailsRequest\>\(CMsgGCMatchDetailsRequest, params CMsgGCMatchDetailsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest__ctor"></a> CMsgGCMatchDetailsRequest\(\)

```csharp
public CMsgGCMatchDetailsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest__ctor_Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_"></a> CMsgGCMatchDetailsRequest\(CMsgGCMatchDetailsRequest\)

```csharp
public CMsgGCMatchDetailsRequest(CMsgGCMatchDetailsRequest other)
```

#### Parameters

`other` [CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_MatchIdFieldNumber"></a> MatchIdFieldNumber

```csharp
public const int MatchIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_HasMatchId"></a> HasMatchId

```csharp
public bool HasMatchId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_MatchId"></a> MatchId

```csharp
public ulong MatchId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMatchDetailsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_ClearMatchId"></a> ClearMatchId\(\)

```csharp
public void ClearMatchId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCMatchDetailsRequest Clone()
```

#### Returns

 [CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_Equals_Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_"></a> Equals\(CMsgGCMatchDetailsRequest\)

```csharp
public bool Equals(CMsgGCMatchDetailsRequest other)
```

#### Parameters

`other` [CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_"></a> MergeFrom\(CMsgGCMatchDetailsRequest\)

```csharp
public void MergeFrom(CMsgGCMatchDetailsRequest other)
```

#### Parameters

`other` [CMsgGCMatchDetailsRequest](Divine.Protobufs.Dota2.CMsgGCMatchDetailsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCMatchDetailsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

