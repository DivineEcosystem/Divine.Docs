# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest"></a> Class CMsgClientToGCRankRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRankRequest : IMessage<CMsgClientToGCRankRequest>, IEquatable<CMsgClientToGCRankRequest>, IDeepCloneable<CMsgClientToGCRankRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)

#### Implements

IMessage<CMsgClientToGCRankRequest\>, 
[IEquatable<CMsgClientToGCRankRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRankRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRankRequest\>\(CMsgClientToGCRankRequest, params CMsgClientToGCRankRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest__ctor"></a> CMsgClientToGCRankRequest\(\)

```csharp
public CMsgClientToGCRankRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_"></a> CMsgClientToGCRankRequest\(CMsgClientToGCRankRequest\)

```csharp
public CMsgClientToGCRankRequest(CMsgClientToGCRankRequest other)
```

#### Parameters

`other` [CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_RankTypeFieldNumber"></a> RankTypeFieldNumber

```csharp
public const int RankTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_HasRankType"></a> HasRankType

```csharp
public bool HasRankType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRankRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_RankType"></a> RankType

```csharp
public ERankType RankType { get; set; }
```

#### Property Value

 [ERankType](Divine.Protobufs.Dota2.ERankType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_ClearRankType"></a> ClearRankType\(\)

```csharp
public void ClearRankType()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRankRequest Clone()
```

#### Returns

 [CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_"></a> Equals\(CMsgClientToGCRankRequest\)

```csharp
public bool Equals(CMsgClientToGCRankRequest other)
```

#### Parameters

`other` [CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_"></a> MergeFrom\(CMsgClientToGCRankRequest\)

```csharp
public void MergeFrom(CMsgClientToGCRankRequest other)
```

#### Parameters

`other` [CMsgClientToGCRankRequest](Divine.Protobufs.Dota2.CMsgClientToGCRankRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRankRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

