# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse"></a> Class CMsgClientToGCFantasyCraftingGenerateTabletsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingGenerateTabletsResponse : IMessage<CMsgClientToGCFantasyCraftingGenerateTabletsResponse>, IEquatable<CMsgClientToGCFantasyCraftingGenerateTabletsResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTabletsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingGenerateTabletsResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingGenerateTabletsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingGenerateTabletsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingGenerateTabletsResponse\>\(CMsgClientToGCFantasyCraftingGenerateTabletsResponse, params CMsgClientToGCFantasyCraftingGenerateTabletsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse__ctor"></a> CMsgClientToGCFantasyCraftingGenerateTabletsResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTabletsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_"></a> CMsgClientToGCFantasyCraftingGenerateTabletsResponse\(CMsgClientToGCFantasyCraftingGenerateTabletsResponse\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTabletsResponse(CMsgClientToGCFantasyCraftingGenerateTabletsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingGenerateTabletsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingGenerateTabletsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_UserData"></a> UserData

```csharp
public CMsgDotaFantasyCraftingUserData UserData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingGenerateTabletsResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingGenerateTabletsResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingGenerateTabletsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingGenerateTabletsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingGenerateTabletsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGenerateTabletsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGenerateTabletsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGenerateTabletsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

