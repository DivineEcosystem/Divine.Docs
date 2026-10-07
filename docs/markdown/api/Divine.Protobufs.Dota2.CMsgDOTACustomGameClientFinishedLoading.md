# <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading"></a> Class CMsgDOTACustomGameClientFinishedLoading

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTACustomGameClientFinishedLoading : IMessage<CMsgDOTACustomGameClientFinishedLoading>, IEquatable<CMsgDOTACustomGameClientFinishedLoading>, IDeepCloneable<CMsgDOTACustomGameClientFinishedLoading>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)

#### Implements

IMessage<CMsgDOTACustomGameClientFinishedLoading\>, 
[IEquatable<CMsgDOTACustomGameClientFinishedLoading\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTACustomGameClientFinishedLoading\>, 
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
[EnumerableExtensions.In<CMsgDOTACustomGameClientFinishedLoading\>\(CMsgDOTACustomGameClientFinishedLoading, params CMsgDOTACustomGameClientFinishedLoading\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading__ctor"></a> CMsgDOTACustomGameClientFinishedLoading\(\)

```csharp
public CMsgDOTACustomGameClientFinishedLoading()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading__ctor_Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_"></a> CMsgDOTACustomGameClientFinishedLoading\(CMsgDOTACustomGameClientFinishedLoading\)

```csharp
public CMsgDOTACustomGameClientFinishedLoading(CMsgDOTACustomGameClientFinishedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_CommentFieldNumber"></a> CommentFieldNumber

```csharp
public const int CommentFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_LoadingDurationFieldNumber"></a> LoadingDurationFieldNumber

```csharp
public const int LoadingDurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ResultCodeFieldNumber"></a> ResultCodeFieldNumber

```csharp
public const int ResultCodeFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ResultStringFieldNumber"></a> ResultStringFieldNumber

```csharp
public const int ResultStringFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_SignonStatesFieldNumber"></a> SignonStatesFieldNumber

```csharp
public const int SignonStatesFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Comment"></a> Comment

```csharp
public string Comment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasComment"></a> HasComment

```csharp
public bool HasComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasLoadingDuration"></a> HasLoadingDuration

```csharp
public bool HasLoadingDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasResultCode"></a> HasResultCode

```csharp
public bool HasResultCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasResultString"></a> HasResultString

```csharp
public bool HasResultString { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_HasSignonStates"></a> HasSignonStates

```csharp
public bool HasSignonStates { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_LoadingDuration"></a> LoadingDuration

```csharp
public uint LoadingDuration { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTACustomGameClientFinishedLoading> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ResultCode"></a> ResultCode

```csharp
public int ResultCode { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ResultString"></a> ResultString

```csharp
public string ResultString { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_SignonStates"></a> SignonStates

```csharp
public uint SignonStates { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearComment"></a> ClearComment\(\)

```csharp
public void ClearComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearLoadingDuration"></a> ClearLoadingDuration\(\)

```csharp
public void ClearLoadingDuration()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearResultCode"></a> ClearResultCode\(\)

```csharp
public void ClearResultCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearResultString"></a> ClearResultString\(\)

```csharp
public void ClearResultString()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ClearSignonStates"></a> ClearSignonStates\(\)

```csharp
public void ClearSignonStates()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Clone"></a> Clone\(\)

```csharp
public CMsgDOTACustomGameClientFinishedLoading Clone()
```

#### Returns

 [CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_Equals_Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_"></a> Equals\(CMsgDOTACustomGameClientFinishedLoading\)

```csharp
public bool Equals(CMsgDOTACustomGameClientFinishedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_"></a> MergeFrom\(CMsgDOTACustomGameClientFinishedLoading\)

```csharp
public void MergeFrom(CMsgDOTACustomGameClientFinishedLoading other)
```

#### Parameters

`other` [CMsgDOTACustomGameClientFinishedLoading](Divine.Protobufs.Dota2.CMsgDOTACustomGameClientFinishedLoading.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTACustomGameClientFinishedLoading_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

