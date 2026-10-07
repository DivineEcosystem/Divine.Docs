# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest"></a> Class CMsgDOTASubmitPlayerAvoidRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerAvoidRequest : IMessage<CMsgDOTASubmitPlayerAvoidRequest>, IEquatable<CMsgDOTASubmitPlayerAvoidRequest>, IDeepCloneable<CMsgDOTASubmitPlayerAvoidRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerAvoidRequest\>, 
[IEquatable<CMsgDOTASubmitPlayerAvoidRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerAvoidRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerAvoidRequest\>\(CMsgDOTASubmitPlayerAvoidRequest, params CMsgDOTASubmitPlayerAvoidRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest__ctor"></a> CMsgDOTASubmitPlayerAvoidRequest\(\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_"></a> CMsgDOTASubmitPlayerAvoidRequest\(CMsgDOTASubmitPlayerAvoidRequest\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequest(CMsgDOTASubmitPlayerAvoidRequest other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_UserNoteFieldNumber"></a> UserNoteFieldNumber

```csharp
public const int UserNoteFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_HasUserNote"></a> HasUserNote

```csharp
public bool HasUserNote { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerAvoidRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_UserNote"></a> UserNote

```csharp
public string UserNote { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_ClearUserNote"></a> ClearUserNote\(\)

```csharp
public void ClearUserNote()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerAvoidRequest Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_"></a> Equals\(CMsgDOTASubmitPlayerAvoidRequest\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerAvoidRequest other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_"></a> MergeFrom\(CMsgDOTASubmitPlayerAvoidRequest\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerAvoidRequest other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerAvoidRequest](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerAvoidRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerAvoidRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

