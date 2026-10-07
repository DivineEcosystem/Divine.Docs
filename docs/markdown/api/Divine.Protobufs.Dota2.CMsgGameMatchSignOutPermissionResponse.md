# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse"></a> Class CMsgGameMatchSignOutPermissionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOutPermissionResponse : IMessage<CMsgGameMatchSignOutPermissionResponse>, IEquatable<CMsgGameMatchSignOutPermissionResponse>, IDeepCloneable<CMsgGameMatchSignOutPermissionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)

#### Implements

IMessage<CMsgGameMatchSignOutPermissionResponse\>, 
[IEquatable<CMsgGameMatchSignOutPermissionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOutPermissionResponse\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOutPermissionResponse\>\(CMsgGameMatchSignOutPermissionResponse, params CMsgGameMatchSignOutPermissionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse__ctor"></a> CMsgGameMatchSignOutPermissionResponse\(\)

```csharp
public CMsgGameMatchSignOutPermissionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_"></a> CMsgGameMatchSignOutPermissionResponse\(CMsgGameMatchSignOutPermissionResponse\)

```csharp
public CMsgGameMatchSignOutPermissionResponse(CMsgGameMatchSignOutPermissionResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_AbandonSignoutFieldNumber"></a> AbandonSignoutFieldNumber

```csharp
public const int AbandonSignoutFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_PermissionGrantedFieldNumber"></a> PermissionGrantedFieldNumber

```csharp
public const int PermissionGrantedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_RetryDelaySecondsFieldNumber"></a> RetryDelaySecondsFieldNumber

```csharp
public const int RetryDelaySecondsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_AbandonSignout"></a> AbandonSignout

```csharp
public bool AbandonSignout { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_HasAbandonSignout"></a> HasAbandonSignout

```csharp
public bool HasAbandonSignout { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_HasPermissionGranted"></a> HasPermissionGranted

```csharp
public bool HasPermissionGranted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_HasRetryDelaySeconds"></a> HasRetryDelaySeconds

```csharp
public bool HasRetryDelaySeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOutPermissionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_PermissionGranted"></a> PermissionGranted

```csharp
public bool PermissionGranted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_RetryDelaySeconds"></a> RetryDelaySeconds

```csharp
public uint RetryDelaySeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_ClearAbandonSignout"></a> ClearAbandonSignout\(\)

```csharp
public void ClearAbandonSignout()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_ClearPermissionGranted"></a> ClearPermissionGranted\(\)

```csharp
public void ClearPermissionGranted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_ClearRetryDelaySeconds"></a> ClearRetryDelaySeconds\(\)

```csharp
public void ClearRetryDelaySeconds()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOutPermissionResponse Clone()
```

#### Returns

 [CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_"></a> Equals\(CMsgGameMatchSignOutPermissionResponse\)

```csharp
public bool Equals(CMsgGameMatchSignOutPermissionResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_"></a> MergeFrom\(CMsgGameMatchSignOutPermissionResponse\)

```csharp
public void MergeFrom(CMsgGameMatchSignOutPermissionResponse other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionResponse](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

