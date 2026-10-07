# <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest"></a> Class CMsgClientToGCMatchesMinimalRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCMatchesMinimalRequest : IMessage<CMsgClientToGCMatchesMinimalRequest>, IEquatable<CMsgClientToGCMatchesMinimalRequest>, IDeepCloneable<CMsgClientToGCMatchesMinimalRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)

#### Implements

IMessage<CMsgClientToGCMatchesMinimalRequest\>, 
[IEquatable<CMsgClientToGCMatchesMinimalRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCMatchesMinimalRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCMatchesMinimalRequest\>\(CMsgClientToGCMatchesMinimalRequest, params CMsgClientToGCMatchesMinimalRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest__ctor"></a> CMsgClientToGCMatchesMinimalRequest\(\)

```csharp
public CMsgClientToGCMatchesMinimalRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_"></a> CMsgClientToGCMatchesMinimalRequest\(CMsgClientToGCMatchesMinimalRequest\)

```csharp
public CMsgClientToGCMatchesMinimalRequest(CMsgClientToGCMatchesMinimalRequest other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_MatchIdsFieldNumber"></a> MatchIdsFieldNumber

```csharp
public const int MatchIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_MatchIds"></a> MatchIds

```csharp
public RepeatedField<ulong> MatchIds { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCMatchesMinimalRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCMatchesMinimalRequest Clone()
```

#### Returns

 [CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_"></a> Equals\(CMsgClientToGCMatchesMinimalRequest\)

```csharp
public bool Equals(CMsgClientToGCMatchesMinimalRequest other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_"></a> MergeFrom\(CMsgClientToGCMatchesMinimalRequest\)

```csharp
public void MergeFrom(CMsgClientToGCMatchesMinimalRequest other)
```

#### Parameters

`other` [CMsgClientToGCMatchesMinimalRequest](Divine.Protobufs.Dota2.CMsgClientToGCMatchesMinimalRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCMatchesMinimalRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

