# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick"></a> Class CDOTAUserMsg\_PlayerDraftPick

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_PlayerDraftPick : IMessage<CDOTAUserMsg_PlayerDraftPick>, IEquatable<CDOTAUserMsg_PlayerDraftPick>, IDeepCloneable<CDOTAUserMsg_PlayerDraftPick>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)

#### Implements

IMessage<CDOTAUserMsg\_PlayerDraftPick\>, 
[IEquatable<CDOTAUserMsg\_PlayerDraftPick\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_PlayerDraftPick\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_PlayerDraftPick\>\(CDOTAUserMsg\_PlayerDraftPick, params CDOTAUserMsg\_PlayerDraftPick\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick__ctor"></a> CDOTAUserMsg\_PlayerDraftPick\(\)

```csharp
public CDOTAUserMsg_PlayerDraftPick()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_"></a> CDOTAUserMsg\_PlayerDraftPick\(CDOTAUserMsg\_PlayerDraftPick\)

```csharp
public CDOTAUserMsg_PlayerDraftPick(CDOTAUserMsg_PlayerDraftPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_PlayerIdCaptainFieldNumber"></a> PlayerIdCaptainFieldNumber

```csharp
public const int PlayerIdCaptainFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_PlayerIdTargetFieldNumber"></a> PlayerIdTargetFieldNumber

```csharp
public const int PlayerIdTargetFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_HasPlayerIdCaptain"></a> HasPlayerIdCaptain

```csharp
public bool HasPlayerIdCaptain { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_HasPlayerIdTarget"></a> HasPlayerIdTarget

```csharp
public bool HasPlayerIdTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_PlayerDraftPick> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_PlayerIdCaptain"></a> PlayerIdCaptain

```csharp
public int PlayerIdCaptain { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_PlayerIdTarget"></a> PlayerIdTarget

```csharp
public int PlayerIdTarget { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Team"></a> Team

```csharp
public int Team { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_ClearPlayerIdCaptain"></a> ClearPlayerIdCaptain\(\)

```csharp
public void ClearPlayerIdCaptain()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_ClearPlayerIdTarget"></a> ClearPlayerIdTarget\(\)

```csharp
public void ClearPlayerIdTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_PlayerDraftPick Clone()
```

#### Returns

 [CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_"></a> Equals\(CDOTAUserMsg\_PlayerDraftPick\)

```csharp
public bool Equals(CDOTAUserMsg_PlayerDraftPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_"></a> MergeFrom\(CDOTAUserMsg\_PlayerDraftPick\)

```csharp
public void MergeFrom(CDOTAUserMsg_PlayerDraftPick other)
```

#### Parameters

`other` [CDOTAUserMsg\_PlayerDraftPick](Divine.Protobufs.Dota2.CDOTAUserMsg\_PlayerDraftPick.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_PlayerDraftPick_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

