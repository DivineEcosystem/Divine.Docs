# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse"></a> Class CMsgClientToGCFantasyCraftingSelectPlayerResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingSelectPlayerResponse : IMessage<CMsgClientToGCFantasyCraftingSelectPlayerResponse>, IEquatable<CMsgClientToGCFantasyCraftingSelectPlayerResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingSelectPlayerResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingSelectPlayerResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingSelectPlayerResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingSelectPlayerResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingSelectPlayerResponse\>\(CMsgClientToGCFantasyCraftingSelectPlayerResponse, params CMsgClientToGCFantasyCraftingSelectPlayerResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse__ctor"></a> CMsgClientToGCFantasyCraftingSelectPlayerResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectPlayerResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_"></a> CMsgClientToGCFantasyCraftingSelectPlayerResponse\(CMsgClientToGCFantasyCraftingSelectPlayerResponse\)

```csharp
public CMsgClientToGCFantasyCraftingSelectPlayerResponse(CMsgClientToGCFantasyCraftingSelectPlayerResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingSelectPlayerResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingSelectPlayerResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectPlayerResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingSelectPlayerResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingSelectPlayerResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingSelectPlayerResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingSelectPlayerResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectPlayerResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectPlayerResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectPlayerResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

