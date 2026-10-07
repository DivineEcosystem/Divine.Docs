# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse"></a> Class CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse : IMessage<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse>, IEquatable<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\>\(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse, params CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse__ctor"></a> CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_"></a> CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectGlobalSuffixResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

