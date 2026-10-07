# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest"></a> Class CMsgGameMatchSignOutPermissionRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOutPermissionRequest : IMessage<CMsgGameMatchSignOutPermissionRequest>, IEquatable<CMsgGameMatchSignOutPermissionRequest>, IDeepCloneable<CMsgGameMatchSignOutPermissionRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)

#### Implements

IMessage<CMsgGameMatchSignOutPermissionRequest\>, 
[IEquatable<CMsgGameMatchSignOutPermissionRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOutPermissionRequest\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOutPermissionRequest\>\(CMsgGameMatchSignOutPermissionRequest, params CMsgGameMatchSignOutPermissionRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest__ctor"></a> CMsgGameMatchSignOutPermissionRequest\(\)

```csharp
public CMsgGameMatchSignOutPermissionRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_"></a> CMsgGameMatchSignOutPermissionRequest\(CMsgGameMatchSignOutPermissionRequest\)

```csharp
public CMsgGameMatchSignOutPermissionRequest(CMsgGameMatchSignOutPermissionRequest other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_LocalAttemptFieldNumber"></a> LocalAttemptFieldNumber

```csharp
public const int LocalAttemptFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_SecondsWaitedFieldNumber"></a> SecondsWaitedFieldNumber

```csharp
public const int SecondsWaitedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ServerVersionFieldNumber"></a> ServerVersionFieldNumber

```csharp
public const int ServerVersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_TotalAttemptFieldNumber"></a> TotalAttemptFieldNumber

```csharp
public const int TotalAttemptFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_HasLocalAttempt"></a> HasLocalAttempt

```csharp
public bool HasLocalAttempt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_HasSecondsWaited"></a> HasSecondsWaited

```csharp
public bool HasSecondsWaited { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_HasServerVersion"></a> HasServerVersion

```csharp
public bool HasServerVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_HasTotalAttempt"></a> HasTotalAttempt

```csharp
public bool HasTotalAttempt { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_LocalAttempt"></a> LocalAttempt

```csharp
public uint LocalAttempt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOutPermissionRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_SecondsWaited"></a> SecondsWaited

```csharp
public uint SecondsWaited { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ServerVersion"></a> ServerVersion

```csharp
public uint ServerVersion { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_TotalAttempt"></a> TotalAttempt

```csharp
public uint TotalAttempt { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ClearLocalAttempt"></a> ClearLocalAttempt\(\)

```csharp
public void ClearLocalAttempt()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ClearSecondsWaited"></a> ClearSecondsWaited\(\)

```csharp
public void ClearSecondsWaited()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ClearServerVersion"></a> ClearServerVersion\(\)

```csharp
public void ClearServerVersion()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ClearTotalAttempt"></a> ClearTotalAttempt\(\)

```csharp
public void ClearTotalAttempt()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOutPermissionRequest Clone()
```

#### Returns

 [CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_"></a> Equals\(CMsgGameMatchSignOutPermissionRequest\)

```csharp
public bool Equals(CMsgGameMatchSignOutPermissionRequest other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_"></a> MergeFrom\(CMsgGameMatchSignOutPermissionRequest\)

```csharp
public void MergeFrom(CMsgGameMatchSignOutPermissionRequest other)
```

#### Parameters

`other` [CMsgGameMatchSignOutPermissionRequest](Divine.Protobufs.Dota2.CMsgGameMatchSignOutPermissionRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOutPermissionRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

