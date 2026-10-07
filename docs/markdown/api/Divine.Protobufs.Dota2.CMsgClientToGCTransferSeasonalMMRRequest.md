# <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest"></a> Class CMsgClientToGCTransferSeasonalMMRRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCTransferSeasonalMMRRequest : IMessage<CMsgClientToGCTransferSeasonalMMRRequest>, IEquatable<CMsgClientToGCTransferSeasonalMMRRequest>, IDeepCloneable<CMsgClientToGCTransferSeasonalMMRRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)

#### Implements

IMessage<CMsgClientToGCTransferSeasonalMMRRequest\>, 
[IEquatable<CMsgClientToGCTransferSeasonalMMRRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCTransferSeasonalMMRRequest\>, 
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
[EnumerableExtensions.In<CMsgClientToGCTransferSeasonalMMRRequest\>\(CMsgClientToGCTransferSeasonalMMRRequest, params CMsgClientToGCTransferSeasonalMMRRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest__ctor"></a> CMsgClientToGCTransferSeasonalMMRRequest\(\)

```csharp
public CMsgClientToGCTransferSeasonalMMRRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest__ctor_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_"></a> CMsgClientToGCTransferSeasonalMMRRequest\(CMsgClientToGCTransferSeasonalMMRRequest\)

```csharp
public CMsgClientToGCTransferSeasonalMMRRequest(CMsgClientToGCTransferSeasonalMMRRequest other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_IsPartyFieldNumber"></a> IsPartyFieldNumber

```csharp
public const int IsPartyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_HasIsParty"></a> HasIsParty

```csharp
public bool HasIsParty { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_IsParty"></a> IsParty

```csharp
public bool IsParty { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCTransferSeasonalMMRRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_ClearIsParty"></a> ClearIsParty\(\)

```csharp
public void ClearIsParty()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCTransferSeasonalMMRRequest Clone()
```

#### Returns

 [CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_Equals_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_"></a> Equals\(CMsgClientToGCTransferSeasonalMMRRequest\)

```csharp
public bool Equals(CMsgClientToGCTransferSeasonalMMRRequest other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_"></a> MergeFrom\(CMsgClientToGCTransferSeasonalMMRRequest\)

```csharp
public void MergeFrom(CMsgClientToGCTransferSeasonalMMRRequest other)
```

#### Parameters

`other` [CMsgClientToGCTransferSeasonalMMRRequest](Divine.Protobufs.Dota2.CMsgClientToGCTransferSeasonalMMRRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCTransferSeasonalMMRRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

