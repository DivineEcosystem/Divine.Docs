# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse"></a> Class CMsgClientToGCFantasyCraftingRerollOptionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingRerollOptionsResponse : IMessage<CMsgClientToGCFantasyCraftingRerollOptionsResponse>, IEquatable<CMsgClientToGCFantasyCraftingRerollOptionsResponse>, IDeepCloneable<CMsgClientToGCFantasyCraftingRerollOptionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingRerollOptionsResponse\>, 
[IEquatable<CMsgClientToGCFantasyCraftingRerollOptionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingRerollOptionsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingRerollOptionsResponse\>\(CMsgClientToGCFantasyCraftingRerollOptionsResponse, params CMsgClientToGCFantasyCraftingRerollOptionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse__ctor"></a> CMsgClientToGCFantasyCraftingRerollOptionsResponse\(\)

```csharp
public CMsgClientToGCFantasyCraftingRerollOptionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_"></a> CMsgClientToGCFantasyCraftingRerollOptionsResponse\(CMsgClientToGCFantasyCraftingRerollOptionsResponse\)

```csharp
public CMsgClientToGCFantasyCraftingRerollOptionsResponse(CMsgClientToGCFantasyCraftingRerollOptionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_ResponseFieldNumber"></a> ResponseFieldNumber

```csharp
public const int ResponseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_UserDataFieldNumber"></a> UserDataFieldNumber

```csharp
public const int UserDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_HasResponse"></a> HasResponse

```csharp
public bool HasResponse { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingRerollOptionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Response"></a> Response

```csharp
public CMsgClientToGCFantasyCraftingRerollOptionsResponse.Types.EResponse Response { get; set; }
```

#### Property Value

 [CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.Types.EResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_UserData"></a> UserData

```csharp
public CMsgDotaFantasyCraftingUserData UserData { get; set; }
```

#### Property Value

 [CMsgDotaFantasyCraftingUserData](Divine.Protobufs.Dota2.CMsgDotaFantasyCraftingUserData.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_ClearResponse"></a> ClearResponse\(\)

```csharp
public void ClearResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingRerollOptionsResponse Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_"></a> Equals\(CMsgClientToGCFantasyCraftingRerollOptionsResponse\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingRerollOptionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_"></a> MergeFrom\(CMsgClientToGCFantasyCraftingRerollOptionsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingRerollOptionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingRerollOptionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingRerollOptionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingRerollOptionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

