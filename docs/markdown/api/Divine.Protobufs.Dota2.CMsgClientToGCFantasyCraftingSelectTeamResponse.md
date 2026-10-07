# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse"></a> Class CMsgClientToGCFantasyCraftingSelectTeamResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingSelectTeamResponse : IMessage<CMsgClientToGCFantasyCraftingSelectTeamResponse>, IEquatable<CMsgClientToGCFantasyCraftingSelectTeamResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingSelectTeamResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingSelectTeamResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingSelectTeamResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingSelectTeamResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingSelectTeamResponse\>\(CMsgClientToGCFantasyCraftingSelectTeamResponse, params CMsgClientToGCFantasyCraftingSelectTeamResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse__ctor"></a> CMsgClientToGCFantasyCraftingSelectTeamResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeamResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_"></a> CMsgClientToGCFantasyCraftingSelectTeamResponse\(CMsgClientToGCFantasyCraftingSelectTeamResponse\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeamResponse(CMsgClientToGCFantasyCraftingSelectTeamResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingSelectTeamResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingSelectTeamResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingSelectTeamResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingSelectTeamResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingSelectTeamResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingSelectTeamResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingSelectTeamResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingSelectTeamResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingSelectTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingSelectTeamResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

