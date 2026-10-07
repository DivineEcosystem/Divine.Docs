# <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError"></a> Class CMsgClientToGCOverwatchReplayError

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCOverwatchReplayError : IMessage<CMsgClientToGCOverwatchReplayError>, IEquatable<CMsgClientToGCOverwatchReplayError>, IDeepCloneable<CMsgClientToGCOverwatchReplayError>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)

#### Implements

IMessage<CMsgClientToGCOverwatchReplayError\>, 
[IEquatable<CMsgClientToGCOverwatchReplayError\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCOverwatchReplayError\>, 
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
[EnumerableExtensions.In<CMsgClientToGCOverwatchReplayError\>\(CMsgClientToGCOverwatchReplayError, params CMsgClientToGCOverwatchReplayError\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError__ctor"></a> CMsgClientToGCOverwatchReplayError\(\)

```csharp
public CMsgClientToGCOverwatchReplayError()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError__ctor_Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_"></a> CMsgClientToGCOverwatchReplayError\(CMsgClientToGCOverwatchReplayError\)

```csharp
public CMsgClientToGCOverwatchReplayError(CMsgClientToGCOverwatchReplayError other)
```

#### Parameters

`other` [CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_OverwatchReplayIdFieldNumber"></a> OverwatchReplayIdFieldNumber

```csharp
public const int OverwatchReplayIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_HasOverwatchReplayId"></a> HasOverwatchReplayId

```csharp
public bool HasOverwatchReplayId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_OverwatchReplayId"></a> OverwatchReplayId

```csharp
public ulong OverwatchReplayId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCOverwatchReplayError> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_ClearOverwatchReplayId"></a> ClearOverwatchReplayId\(\)

```csharp
public void ClearOverwatchReplayId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCOverwatchReplayError Clone()
```

#### Returns

 [CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_Equals_Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_"></a> Equals\(CMsgClientToGCOverwatchReplayError\)

```csharp
public bool Equals(CMsgClientToGCOverwatchReplayError other)
```

#### Parameters

`other` [CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_"></a> MergeFrom\(CMsgClientToGCOverwatchReplayError\)

```csharp
public void MergeFrom(CMsgClientToGCOverwatchReplayError other)
```

#### Parameters

`other` [CMsgClientToGCOverwatchReplayError](Divine.Protobufs.Dota2.CMsgClientToGCOverwatchReplayError.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCOverwatchReplayError_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

