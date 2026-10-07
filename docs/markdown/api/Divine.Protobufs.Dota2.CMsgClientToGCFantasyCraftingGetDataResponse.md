# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse"></a> Class CMsgClientToGCFantasyCraftingGetDataResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingGetDataResponse : IMessage<CMsgClientToGCFantasyCraftingGetDataResponse>, IEquatable<CMsgClientToGCFantasyCraftingGetDataResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingGetDataResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingGetDataResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingGetDataResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingGetDataResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingGetDataResponse\>\(CMsgClientToGCFantasyCraftingGetDataResponse, params CMsgClientToGCFantasyCraftingGetDataResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse__ctor"></a> CMsgClientToGCFantasyCraftingGetDataResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingGetDataResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_"></a> CMsgClientToGCFantasyCraftingGetDataResponse\(CMsgClientToGCFantasyCraftingGetDataResponse\)

```csharp
public CMsgClientToGCFantasyCraftingGetDataResponse(CMsgClientToGCFantasyCraftingGetDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_TabletDataFieldNumber"></a> TabletDataFieldNumber

```csharp
public const int TabletDataFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingGetDataResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingGetDataResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_TabletData"></a> TabletData

```csharp
public CMsgDotaFantasyCraftingTabletData TabletData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingTabletData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingTabletData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_UserData"></a> UserData

```csharp
public CMsgDotaFantasyCraftingUserData UserData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingGetDataResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingGetDataResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingGetDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingGetDataResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingGetDataResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingGetDataResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingGetDataResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingGetDataResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

